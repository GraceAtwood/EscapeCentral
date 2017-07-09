using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeCentral.GameDef
{
    /// <summary>
    /// A sensor or actor element on a hub.
    /// </summary>
    public class Element
    {

        /// <summary>
        /// The Id of this element.  Can be a random string or integers.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The state of this element.  This can either by set by the application and alerted to the hub or the other way around.
        /// </summary>
        [JsonIgnore]
        public string State { get; set; }

    }
}
