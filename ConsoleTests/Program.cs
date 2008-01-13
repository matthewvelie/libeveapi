using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

using libeveapi;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = Network.GetXml("http://localhost/eveapi/StarbaseDetail.xml");
            XmlNodeList nodeList = xmlDoc.SelectNodes("//rowset[@name='fuel']/row");
            Console.WriteLine(nodeList.Count);
        }
    }
}
