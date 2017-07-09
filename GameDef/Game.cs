using EscapeCentral.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeCentral.GameDef
{
    /// <summary>
    /// Contains all of the conditions, actions and hubs for a specific game.
    /// </summary>
    public class Game
    {

        /// <summary>
        /// The id of this game.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The conditions to be used in this game.
        /// </summary>
        public List<Condition> Conditions { get; set; }

        /// <summary>
        /// The hubs in this game.
        /// </summary>
        public List<Hub> Hubs { get; set; }

        public Game()
        {
        }

        private void EvaluateConditions()
        {
            foreach (var condition in Conditions)
            {
                if (!condition.ConditionMet)
                {
                    var hub = Hubs.FirstOrDefault(x => x.Id == condition.HubId);

                    if (hub != null)
                    {
                        var element = hub.Elements.First(x => x.Id == condition.ElementId);

                        if (element != null)
                        {
                            if (element.State == condition.State)
                            {
                                condition.TriggerActions();
                                condition.ConditionMet = true;
                            }
                        }
                    }
                }
            }
        }


    }
}
