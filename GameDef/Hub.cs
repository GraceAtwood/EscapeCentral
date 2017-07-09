using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace EscapeCentral.GameDef
{
    /// <summary>
    /// A hub is a single raspberry pi, Arduino, or other controller.
    /// </summary>
    public class Hub
    {
        /// <summary>
        /// The IP address of this hub on the network.
        /// </summary>
        [JsonIgnore]
        public IPAddress IPAddress { get; set; }

        /// <summary>
        /// The id of this hub.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The elements attached to this hub.
        /// </summary>
        public List<Element> Elements { get; set; }

        [JsonIgnore]
        public bool IsRegistered { get; set; }

        /// <summary>
        /// Sends a generic message to the hub.  
        /// </summary>
        /// <param name="message"></param>
        public void SendMessage()
        {
            //TODO send message
        }
    }
}
