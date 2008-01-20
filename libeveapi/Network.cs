using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Xml;

namespace libeveapi
{
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


        public class eveNetworkClientSettings
        {
            public static WebProxy proxy = null;
            public static string userAgent = "libEveApi/1";
        }
    }
}
