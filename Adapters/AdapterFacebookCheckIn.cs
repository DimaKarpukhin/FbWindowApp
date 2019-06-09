namespace Adapters
{
    using FacebookWrapper.ObjectModel;

    public class AdapterFacebookCheckIn : AdapterFacebookObject
    {
        public AdapterFacebookCheckIn(FacebookObject i_FacebookObject) : base(i_FacebookObject)
        {
        }

        public Checkin Checkin => m_FacebookObject as Checkin;

        public override FacebookObject FacebookObject => Checkin;

        public override string DisplayName => Checkin.Place.Name;
    }
}
