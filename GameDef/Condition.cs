using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EscapeCentral.GameDef
{
    /// <summary>
    /// A game condition.  
    /// </summary>
    public class Condition
    {
        /// <summary>
        /// THe id of the hub referenced in this condition.
        /// </summary>
        public string HubId { get; set; }

        /// <summary>
        /// The id of the element on the hub.
        /// </summary>
        public string ElementId { get; set; }

        /// <summary>
        /// This condition will fire when this state is met.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Indicates that the condition has been met and its actions have begun.  It should not be evaluated again.
        /// </summary>
        [JsonIgnore]
        public bool ConditionMet { get; set; }

        /// <summary>
        /// The actions to take when this condition is met.
        /// </summary>
        public List<Actions.IAction> Actions { get; set; }

        public void TriggerActions()
        {
            foreach (var action in Actions)
            {
                action.Trigger();
            }
        }
    }
}
