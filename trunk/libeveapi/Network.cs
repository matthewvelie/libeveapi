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
            WebClient wc = new WebClient();
            wc.Headers.Add("user-agent", "libEveApi/1");
            Stream s = wc.OpenRead(url);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(s);
            return xmlDoc;
        }

        public static Image GetImage(string url)
        {
            WebClient wc = new WebClient();
            wc.Headers.Add("user-agent", "libEveApi/1");
            Stream s = wc.OpenRead(url);
            return Image.FromStream(s, true, true);
        }
    }
}
