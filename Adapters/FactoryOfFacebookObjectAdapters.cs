namespace Adapters
{
    using System;
    using FacebookWrapper.ObjectModel;

    public static class FactoryOfFacebookObjectAdapters
    {
        public static AdapterFacebookObject Create(FacebookObject i_FacebookObj)
        {
            AdapterFacebookObject adapter = null;

            if (i_FacebookObj.GetType() == typeof(Post))
            {
                adapter = new AdapterFacebookPost(i_FacebookObj);
            }
            else if (i_FacebookObj.GetType() == typeof(User))
            {
                adapter = new AdapterFacebookUser(i_FacebookObj);
            }
            else if (i_FacebookObj.GetType() == typeof(Album))
            {
                adapter = new AdapterFacebookAlbum(i_FacebookObj);
            }
            else if (i_FacebookObj.GetType() == typeof(Page))
            {
                adapter = new AdapterFacebookPage(i_FacebookObj);
            }
            else if (i_FacebookObj.GetType() == typeof(Event))
            {
                adapter = new AdapterFacebookEvent(i_FacebookObj);
            }
            else if (i_FacebookObj.GetType() == typeof(Checkin))
            {
                adapter = new AdapterFacebookCheckIn(i_FacebookObj);
            }
            else
            {
                throw new Exception("Illegal type of adapter.");
            }

            return adapter;
        }
    }
}
