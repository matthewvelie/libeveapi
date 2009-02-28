using System.Net;

namespace libeveapi
{
    ///<summary>
    /// Maintains a list of network settings relevant for retrieving API details.
    ///</summary>
    internal class ApiNetworkSettings : IApiNetworkSettings
    {
        private readonly string libEveApiAgent = "libEveApi/" +
                                                 System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

        public string FullUserAgentName
        {
            get
            {
                if( string.IsNullOrEmpty( UserAgent ) )
                {
                    return libEveApiAgent;
                }
                
                return string.Format( "{0}({1})", libEveApiAgent, UserAgent );
            }
        }

        public string UserAgent { get; set; }

        public IWebProxy Proxy { get; set; }

        public void SetProxySettings( string host, int port, string userName, string password )
        {
            Proxy = new WebProxy( host, port );

            if( !string.IsNullOrEmpty( userName ) )
            {
                Proxy.Credentials = new NetworkCredential( userName, password );
            }
        }
    }
}