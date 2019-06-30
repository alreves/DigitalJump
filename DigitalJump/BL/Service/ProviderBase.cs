namespace DigitalJump.BL.Service
{
    public abstract class ProviderBase
    {
        protected DataProvider Provider
        {
            get; set;
        }

        public ProviderBase()
        {
            Provider = new DataProvider();
        }

        //protected Call
    }
}
