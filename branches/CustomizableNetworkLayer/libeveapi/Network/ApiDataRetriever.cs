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
    internal class ApiDataRetriever : IApiDataRetriever
    {
        private readonly IApiNetworkSettings networkSettings;

        public ApiDataRetriever( IApiNetworkSettings networkSettings )
        {
            if( networkSettings == null )
            {
                networkSettings = new ApiNetworkSettings();
            }

            this.networkSettings = networkSettings;
        }

        public XmlDocument GetXml( Uri url )
        {
            return GetObject( url, new StreamToXmlDocumentConverter() );
        }

        public Image GetImage( Uri url )
        {
            return GetObject( url, new StreamToImageConverter() );
        }

        private T GetObject<T>( Uri url, IStreamConverter<T> converter ) where T : class
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
        private T OpenUrl<T>(Uri url, IStreamConverter<T> converter ) where T : class
        {
            Debug.Assert( url != null );
            Debug.Assert( url.ToString().Length > 0 );
            Debug.Assert( converter != null );

            WebClient wc = new WebClient();
            wc.Headers.Add( "user-agent", networkSettings.FullUserAgentName );
            if (networkSettings.Proxy != null)
            {
                wc.Proxy = networkSettings.Proxy;
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
}