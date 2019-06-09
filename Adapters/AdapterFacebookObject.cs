namespace Adapters
{
    using FacebookWrapper.ObjectModel;

    public abstract class AdapterFacebookObject
    {
        public abstract string DisplayName { get; }

        public abstract FacebookObject FacebookObject { get; }

        protected FacebookObject m_FacebookObject;
        
        protected AdapterFacebookObject(FacebookObject i_FacebookObject)
        {
            m_FacebookObject = i_FacebookObject;
        }
    }
}
