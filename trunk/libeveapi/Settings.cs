using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using EVEMon.Common;
using System.Security.Cryptography;

namespace EVEMon.Common
{
    [XmlRoot("logindata2")]
    public class Settings
    {
        private static Object mutexLock = new Object();
        private static Settings m_instance = null;

        #region Settings Form - Network Tab

        private bool m_useCustomProxySettings = false;
        public bool UseCustomProxySettings
        {
            get { return m_useCustomProxySettings; }
            set
            {
                lock (mutexLock)
                {
                    m_useCustomProxySettings = value;
                }
            }
        }

        private ProxySetting m_httpProxy = new ProxySetting();
        public ProxySetting HttpProxy
        {
            get { return m_httpProxy; }
            set
            {
                lock (mutexLock)
                {
                    m_httpProxy = value;
                }
            }
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Helper method to return current settings instance. If no instance exists, one is loaded
        /// </summary>
        /// <returns>A Settings object for the currently loaded instance</returns>
        public static Settings GetInstance()
        {
            lock (mutexLock)
            {
                if (m_instance == null)
                    m_instance = new Settings();
                return m_instance;
            }
        }

        #endregion
    }

    [XmlRoot("proxySetting")]
    public class ProxySetting : ICloneable
    {
        private string m_host = String.Empty;

        public string Host
        {
            get { return m_host; }
            set { m_host = value; }
        }

        private int m_port;

        public int Port
        {
            get { return m_port; }
            set { m_port = value; }
        }

        private ProxyAuthType m_authType = ProxyAuthType.None;

        public ProxyAuthType AuthType
        {
            get { return m_authType; }
            set { m_authType = value; }
        }

        private string m_username = String.Empty;

        public string Username
        {
            get { return m_username; }
            set { m_username = value; }
        }

        private string m_password = String.Empty;

        public string Password
        {
            get { return m_password; }
            set { m_password = value; }
        }

        #region ICloneable Members

        public ProxySetting Clone()
        {
            return (ProxySetting)((ICloneable)this).Clone();
        }

        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion
    }

    public enum ProxyAuthType
    {
        None,
        SystemDefault,
        Specified
    }
}
