namespace AppLogic
{
    using System.Linq;
    using System.Collections.Generic;
    using FacebookWrapper;
    using FacebookWrapper.ObjectModel;
    using ChuckNorris;
    using Adapters;
    using Singletons;
    
    // this delegate allows the user to have an information about the duration of expected long functions
    public delegate void ProcessPercentageEventHandler(object sender, EventArgsProcessPercentage e);

    public class AppSevices
    {
        private LoginResult m_LoginResult;

        private User m_LoggedInUser;

        private AppSevices()
        {
        }

        public static AppSevices Instance
        {
            get
            {
                return Singleton<AppSevices>.Instance;
            }
        }

        public LoginResult LoginResult
        {
            get
            {
                return m_LoginResult;
            }
        }

        public User LoggedInUser
        {
            get
            {
                return m_LoggedInUser;
            }
        }

        public static bool FetchZodiacSign(User i_User, out string o_ZodiacResult)
        {
            bool isZodiacCalculationSucceed = true;

            if (!string.IsNullOrEmpty(i_User.Birthday))
            {
                o_ZodiacResult = Zodiac.CalculateSign(i_User.Birthday);
            }
            else
            {
                o_ZodiacResult = string.Empty;
                isZodiacCalculationSucceed = false;
            }

            return isZodiacCalculationSucceed;
        }

        public static bool FetchChuckNorrisJoke(out string o_Joke)
        {
            bool isJokeFetchSuccessfully = true;

            o_Joke = ChuckNorrisLogic.GenerateChuckNorrisJoke();
            if (string.IsNullOrEmpty(o_Joke))
            {
                isJokeFetchSuccessfully = false;
            }

            return isJokeFetchSuccessfully;
        }

        public bool LoginAndInit()
        {
            bool isLoginSucceed;

            m_LoginResult = FacebookService.Login(
                "249580098894680",
                "public_profile",
                "user_birthday",
                "user_posts",
                "user_friends",
                "user_photos",
                "user_likes",
                "user_events");
               // "publish_actions"); // => no permission
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                isLoginSucceed = true;
            }
            else
            {
                isLoginSucceed = false;
            }

            return isLoginSucceed;
        }

        public void ConnectUserToFacebook(string i_AccessToken)
        {
            m_LoginResult = FacebookService.Connect(i_AccessToken);
            if (IsUserLoggedIn())
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
            }
        }

        public void LogoutUserFromFacebook()
        {
            FacebookService.Logout(null);
        }

        public bool IsUserLoggedIn()
        {
            return m_LoginResult != null;
        }

        public void SetAmountToFetch(int i_Amount)
        {
            FacebookService.s_CollectionLimit = i_Amount;
        }

        public string FetchProfilePicture()
        {
            return m_LoggedInUser.PictureNormalURL;
        }

        public List<AdapterFacebookObject> FetchPosts()
        {
            return fetchItems(m_LoggedInUser.Posts);
        }

        public List<AdapterFacebookObject> FetchFriends()
        {
            return fetchItems(m_LoggedInUser.Friends);
        }

        public List<AdapterFacebookObject> FetchAlbums()
        {
            return fetchItems(m_LoggedInUser.Albums);
        }

        public List<AdapterFacebookObject> FetchPages()
        {
            return fetchItems(m_LoggedInUser.LikedPages);
        }

        public List<AdapterFacebookObject> FetchEvents()
        {
            return fetchItems(m_LoggedInUser.Events);
        }

        public List<AdapterFacebookObject> FetchCheckins()
        {
            return fetchItems(m_LoggedInUser.Checkins);
        }

        public string PostStatus(string i_NewStatus, string i_PictureURL = null, User i_TaggedFriend = null)
        {
            Status postedStatus;

            if (i_TaggedFriend == null)
            {
                postedStatus = m_LoggedInUser.PostStatus(i_NewStatus, null, i_PictureURL);
            }
            else
            {
                postedStatus = m_LoggedInUser.PostStatus(i_NewStatus, null, i_PictureURL, i_TaggedFriend.Id, i_PictureURL);
            }

            return postedStatus.Id;
        }

        public event ProcessPercentageEventHandler TaggedFriendsProcessPercentageUpdated;

        public TaggedFriends CalculateLikesPerEachTaggedFriend()
        {
            Dictionary<string, TaggedFriend> friends = new Dictionary<string, TaggedFriend>();
            EventArgsProcessPercentage args = new EventArgsProcessPercentage();
            float count = 0;

            foreach (Photo photo in m_LoggedInUser.PhotosTaggedIn)
            {
                if (photo.From != null)
                {
                    if (photo.From.Id == m_LoggedInUser.Id)
                    {
                        foreach (PhotoTag tag in photo.Tags)
                        {
                            if (tag.User.Id != string.Empty)
                            {
                                if (friends.ContainsKey(tag.User.Id))
                                {
                                    friends[tag.User.Id].Likes += photo.LikedBy.Count;
                                    friends[tag.User.Id].Photos.Add(photo);
                                }
                                else if (tag.User.Id != m_LoggedInUser.Id)
                                {
                                    friends.Add(tag.User.Id, new TaggedFriend { User = tag.User, Likes = photo.LikedBy.Count });
                                    friends[tag.User.Id].Photos.Add(photo);
                                }
                            }
                        }
                    }
                }

                if(TaggedFriendsProcessPercentageUpdated != null)
                {
                    count++;
                    args.Percentage = (int)(count / m_LoggedInUser.PhotosTaggedIn.Count * 100);
                    TaggedFriendsProcessPercentageUpdated(this, args);
                }
            }

            return new TaggedFriends(friends.Values.ToList());
        }

        private List<AdapterFacebookObject> fetchItems<T>(FacebookObjectCollection<T> i_Collection)
        {
            List<AdapterFacebookObject> listOfItems = new List<AdapterFacebookObject>();

            foreach (T item in i_Collection)
            {
                listOfItems.Add(FactoryOfFacebookObjectAdapters.Create(item as FacebookObject));
            }

            return listOfItems;
        }
    }
}
