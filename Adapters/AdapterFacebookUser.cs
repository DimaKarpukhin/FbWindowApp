namespace Adapters
{
    using FacebookWrapper.ObjectModel;

    public class AdapterFacebookUser : AdapterFacebookObject
    {
        public AdapterFacebookUser(FacebookObject i_FacebookObject) : base(i_FacebookObject)
        {
        }

        public User User => m_FacebookObject as User;

        public override FacebookObject FacebookObject => User;

        public override string DisplayName => User.Name;
    }
}
