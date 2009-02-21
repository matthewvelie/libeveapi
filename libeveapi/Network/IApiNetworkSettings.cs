using System.Net;

namespace libeveapi
{
    ///<summary>
    ///</summary>
    public interface IApiNetworkSettings
    {
        ///<summary>
        /// The name by which the application identifies itself to the remote server.
        ///</summary>
        string UserAgent { get; }
        ///<summary>
        /// The proxy information to use whilst connecting to the remote server.
        ///</summary>
        IWebProxy Proxy { get; }
    }
}