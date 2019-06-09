namespace Adapters
{
    using FacebookWrapper.ObjectModel;
    public class AdapterFacebookPost : AdapterFacebookObject
    {
        public AdapterFacebookPost(FacebookObject i_FacebookObject) : base(i_FacebookObject) { }

        public Post Post => m_FacebookObject as Post;

        public override FacebookObject FacebookObject => Post;

        public override string DisplayName => findDisplayName();

        private string findDisplayName()
        {
            string displayName;

            if (Post.Message != null)
            {
                displayName = Post.Message;
            }
            else if (Post.Name != null)
            {
                displayName = Post.Name;
            }
            else if (Post.Caption != null)
            {
                displayName = Post.Caption;
            }
            else
            {
                displayName = Post.Type.ToString();
            }

            return displayName;
        }
    }
}
