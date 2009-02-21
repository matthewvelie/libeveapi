using System;
using System.Drawing;
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
}