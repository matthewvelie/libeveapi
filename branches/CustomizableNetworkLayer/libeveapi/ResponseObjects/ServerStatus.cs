using System;
using System.Collections.Generic;
using System.Text;

namespace libeveapi
{
    /// <summary>
    /// Tranquility Status
    /// </summary>
    public class ServerStatus : ApiResponse
    {
        private bool serverOpen;
        private int onlinePlayers;

        /// <summary>
        /// Server Status
        /// </summary>
        public bool ServerOpen
        {
            get { return serverOpen; }
            set { serverOpen = value; }
        }

        /// <summary>
        /// Number of players online
        /// </summary>
        public int OnlinePlayers
        {
            get { return onlinePlayers; }
            set { onlinePlayers = value; }
        }
    }
}
