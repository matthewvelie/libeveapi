using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Xml;

namespace libeveapi
{
    ///<summary>
    ///</summary>
    public interface IApiDataRetriever
    {
        ///<summary>
        /// Retrieves an XmlDocument from the given url.
        /// pre-condition: the given url is not null.
        /// pre-condition: the given url's length is not 0.
        /// post-condition: either an XmlDocument instance or null is returned.
        ///</summary>
        XmlDocument GetXml(Uri url);
        ///<summary>
        /// Retrieves an image from the given url.
        /// pre-condition: the given url is not null.
        /// pre-condition: the given url's length is not 0.
        /// post-condition: either an Image instance or null is returned.
        ///</summary>
        Image GetImage(Uri url);
    }

    ///<summary>
    ///</summary>
    internal class ApiDataRetriever : IApiDataRetriever
    {
        public XmlDocument GetXml( Uri url )
        {
            return GetObject( url, new StreamToXmlDocumentConverter() );
        }

        public Image GetImage( Uri url )
        {
            return GetObject( url, new StreamToImageConverter() );
        }

        private static T GetObject<T>( Uri url, IStreamConverter<T> converter ) where T : class
        {
            Debug.Assert( url != null );
            Debug.Assert( url.ToString().Length > 0 );
            Debug.Assert( converter != null );

            return OpenUrl( url, converter );
        }

        /// <summary>
        /// This function takes in a url and will return a stream of data from that url
        /// Also takes into account the user-agent settings and any proxy settings
        /// </summary>
        /// <param name="url">The url of the image file to retrieve</param>
        /// <param name="converter"></param>
        /// <returns>A stream of data</returns>
        private static T OpenUrl<T>(Uri url, IStreamConverter<T> converter ) where T : class
        {
            Debug.Assert( url != null );
            Debug.Assert( url.ToString().Length > 0 );
            Debug.Assert( converter != null );

            WebClient wc = new WebClient();
            wc.Headers.Add("user-agent", Network.eveNetworkClientSettings.userAgent);
            if (Network.eveNetworkClientSettings.proxy != null)
            {
                // TODO Replace this...
                wc.Proxy = Network.eveNetworkClientSettings.proxy;
            }

            try
            {
                using( Stream stream = wc.OpenRead( url ) )
                {
                    return converter.Convert( stream );
                }
            }
            catch( WebException )
            {
                return null;
            }
        }
    }

    internal interface IStreamConverter<T>
    {
        T Convert( Stream stream );
    }

    internal class StreamToImageConverter : IStreamConverter<Image>
    {
        public Image Convert( Stream stream )
        {
            try
            {
                return Image.FromStream( stream, true, true );
            }
            catch( ArgumentException )
            {
                return null;
            }
        }
    }

    internal class StreamToXmlDocumentConverter : IStreamConverter<XmlDocument>
    {
        public XmlDocument Convert( Stream stream )
        {
            XmlDocument document = new XmlDocument();;

            try
            {
                document.Load( stream );
                return document;
            }
            catch( XmlException )
            {
                return null;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Network
    {
        /// <summary>
        /// This function takes in a url, and will download the data from that
        /// URL and create an xml document from it
        /// </summary>
        /// <param name="url">The url of the XML file to retrieve</param>
        /// <returns></returns>
        public static XmlDocument GetXml(string url)
        {
            Stream s = openUrl(url);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(s);
            return xmlDoc;
        }

        /// <summary>
        /// This function takes in a url of an image and then returns the image
        /// </summary>
        /// <param name="url">The url of the image file to retrieve</param>
        /// <returns>An image object containing the image from the url</returns>
        public static Image GetImage(string url)
        {
            Stream s = openUrl(url);
            return Image.FromStream(s, true, true);
        }

        /// <summary>
        /// This function takes in a url and will return a stream of data from that url
        /// Also takes into account the user-agent settings and any proxy settings
        /// </summary>
        /// <param name="url">The url of the image file to retrieve</param>
        /// <returns>A stream of data</returns>
        private static Stream openUrl(string url)
        {
            WebClient wc = new WebClient();
            wc.Headers.Add("user-agent", Network.eveNetworkClientSettings.userAgent);
            if (Network.eveNetworkClientSettings.proxy != null)
            {
                wc.Proxy = Network.eveNetworkClientSettings.proxy;
            }
            return wc.OpenRead(url);
        }

        /// <summary>
        /// All advanced network settings go here
        /// </summary>
        public class eveNetworkClientSettings
        {
            /// <summary>
            /// The default proxy is null, meaning no proxy in use
            /// </summary>
            public static WebProxy proxy = null;

            /// <summary>
            /// The base userAgent string to be used by the program
            /// </summary>
            public static string userAgent = "libEveApi/1";
        }
    }
}
