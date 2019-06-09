namespace Adapters
{
    using FacebookWrapper.ObjectModel;

    public class AdapterFacebookPage : AdapterFacebookObject
    {
        public AdapterFacebookPage(FacebookObject i_FacebookObject) : base(i_FacebookObject)
        {
        }

        public Page Page => m_FacebookObject as Page;

        public override FacebookObject FacebookObject => Page;

        public override string DisplayName => Page.Name;
    }
}
