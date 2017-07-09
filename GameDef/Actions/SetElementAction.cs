using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeCentral.GameDef.Actions
{
    /// <summary>
    /// This action sets an element's state.
    /// </summary>
    public class SetElementAction : IAction
    {
        /// <summary>
        /// The id of the hub where the element can be found.
        /// </summary>
        public string HubId { get; set; }

        /// <summary>
        /// The id of the element.
        /// </summary>
        public string ElementId { get; set; }

        /// <summary>
        /// The state to set the element to.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The amount of milliseconds after the condition is met that this action should trigger.
        /// </summary>
        public int Delay { get; set; }
        public bool Repeat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int RepeatCount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// Triggers the set element action by sending a message to the related hub and element, 
        /// instructing the element to set its state.
        /// </summary>
        public void Trigger()
        {
            throw new NotImplementedException();
        }
    }
}
