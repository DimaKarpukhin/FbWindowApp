namespace Adapters
{
    using FacebookWrapper.ObjectModel;

    public class AdapterFacebookAlbum : AdapterFacebookObject
    {
        public AdapterFacebookAlbum(FacebookObject i_FacebookObject) : base(i_FacebookObject)
        {
        }

        public Album Album => m_FacebookObject as Album;

        public override FacebookObject FacebookObject => Album;

        public override string DisplayName => Album.Name;
    }
}
