using System.Net;

namespace libeveapi
{
    public class ApiNetworkSettings : IApiNetworkSettings
    {
        private readonly string libEveApiAgent = "libEveApi/" +
                                                 System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
        private readonly IWebProxy proxy;
        private readonly string userAgent;

        public ApiNetworkSettings( IWebProxy proxy, string userAgent )
        {
            this.proxy = proxy;
            this.userAgent = userAgent;
        }

        public string UserAgent
        {
            get
            {
                if( string.IsNullOrEmpty( userAgent ) )
                {
                    return libEveApiAgent;
                }
                
                return string.Format( "{0}({1})", libEveApiAgent, userAgent );
            }
        }

        public IWebProxy Proxy
        {
            get
            {
                return proxy;
            }
        }
    }
}