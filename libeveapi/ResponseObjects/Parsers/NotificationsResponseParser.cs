using System; 
using System.Collections.Generic; 
using System.Globalization; 
using System.Xml; 
  
 namespace libeveapi.ResponseObjects.Parsers 
 { 
     ///<summary> 
     /// A parser which converts a given <see cref="XmlDocument"/> to a <see cref="Notifications"/>. 
     ///</summary> 
     internal class NotificationsResponseParser : IApiResponseParser<Notifications> 
     { 
         ///<summary> 
         /// XML Document Parser
         ///</summary> 
         /// <param name="xmlDocument">XML Document to parse</param> 
         /// <returns>Object containing data from the parsed XML Doc</returns> 
         public Notifications Parse(XmlDocument xmlDocument) 
         { 
             this.CheckVersion(xmlDocument);
             Notifications notifications = new Notifications(); 
             notifications.ParseCommonElements(xmlDocument); 
  
             List<Notifications.NotificationItem> notificationsList = new List<Notifications.NotificationItem>(); 
             foreach (XmlNode node in xmlDocument.SelectNodes("//rowset[@name='notifications']/row")) 
             { 
				notificationsList.Add(ParseRow(node)); 
             } 
             notifications.NotificationItems = notificationsList.ToArray(); 

             return notifications; 
         } 
  
         /// <summary> 
         /// Create a notificationItems by parsing a single row 
         /// </summary> 
         /// <param name="notificationItemRow">XmlNode containing the Notification data</param> 
         /// <returns>A Notification</returns> 
         private static Notifications.NotificationItem ParseRow(XmlNode notificationItemRow) 
         { 
			Notifications.NotificationItem notificationItem =
                new Notifications.NotificationItem(
                    Convert.ToInt32(notificationItemRow.Attributes["notificationID"].InnerText, CultureInfo.InvariantCulture),
                    Convert.ToInt32(notificationItemRow.Attributes["typeID"].InnerText, CultureInfo.InvariantCulture),
                    Convert.ToInt32(notificationItemRow.Attributes["senderID"].InnerText, CultureInfo.InvariantCulture),
                    Convert.ToDateTime(notificationItemRow.Attributes["sentDate"].InnerText, CultureInfo.InvariantCulture),
                    Convert.ToBoolean(notificationItemRow.Attributes["read"].InnerText, CultureInfo.InvariantCulture));

            return notificationItem; 
         } 
         
        ///<summary> 
        /// Check if the version of the object matches the EveApi response version 
        ///</summary> 
        /// <param name="xmlDocument">XML Document to parse</param> 
        public void CheckVersion(XmlDocument xmlDocument)
        {
            if (Notifications.VersionCheck)
            {
                string version = xmlDocument.SelectSingleNode("//eveapi").Attributes["version"].InnerText;
                if (version.CompareTo(Notifications.API_VERSION) != 0)
                {
                    throw new ApiVersionException(version, Notifications.API_VERSION);
                }
            }
        }
     } 
 } 
 