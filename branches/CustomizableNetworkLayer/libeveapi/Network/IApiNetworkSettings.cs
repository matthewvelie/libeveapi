using System.Net;

namespace libeveapi
{
    ///<summary>
    ///</summary>
    public interface IApiNetworkSettings
    {
        ///<summary>
        /// The full name by which the application identifies itself to the remote server.
        ///</summary>
        string FullUserAgentName { get; }
        ///<summary>
        /// The proxy information to use whilst connecting to the remote server.
        ///</summary>
        IWebProxy Proxy { get; set; }

        /// <summary>
        /// The name of the application which is using the EveApi.
        /// </summary>
        string UserAgent { get; set; }

        ///<summary>
        /// Sets the details required for connections that use a proxy.
        ///</summary>
        void SetProxySettings( string host, int port, string userName, string password );
    }
}