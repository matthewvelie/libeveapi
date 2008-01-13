using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Xml;

namespace libeveapi
{
    public class Network
    {
        public static XmlDocument GetXml(string url)
        {
            WebClient wc = new WebClient();
            Stream s = wc.OpenRead(url);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(s);
            return xmlDoc;
        }
    }
}
