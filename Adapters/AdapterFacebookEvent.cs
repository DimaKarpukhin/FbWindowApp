namespace Adapters
{
    using FacebookWrapper.ObjectModel;

    public class AdapterFacebookEvent : AdapterFacebookObject
    {
        public AdapterFacebookEvent(FacebookObject i_FacebookObject) : base(i_FacebookObject)
        {
        }

        public Event Event => m_FacebookObject as Event;

        public override FacebookObject FacebookObject => Event;

        public override string DisplayName => Event.Name;
    }
}
