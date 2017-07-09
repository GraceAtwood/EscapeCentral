using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeCentral.GameDef.Actions
{
    /// <summary>
    /// The interface from which all actions are built.
    /// </summary>
    public interface IAction
    {
        /// <summary>
        /// The amount of millisecond delay after which this action should happen when its condition is met.
        /// <para/>
        /// If there is a repeat, then each iteration of the repeat will also use this amount of pause.
        /// </summary>
        int Delay { get; set; }

        bool Repeat { get; set; }

        int RepeatCount { get; set; }

        /// <summary>
        /// Triggers the action.
        /// </summary>
        void Trigger();
    }
}
