using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeCentral.GameDef.Actions
{
    /// <summary>
    /// An action that plays a sound.
    /// </summary>
    public class PlaySoundAction : IAction
    {
        /// <summary>
        /// The amount of time in milliseconds after the condition is met that the sound should play.
        /// </summary>
        public int Delay { get; set; }

        /// <summary>
        /// The location of this sound file.
        /// </summary>
        public string FileLocation { get; set; }

        /// <summary>
        /// Instructs the sound to play on a loop.
        /// </summary>
        public bool Repeat { get; set; }

        /// <summary>
        /// Instructs the sound to repeat a number of times.  No effect is Repeat = false.
        /// </summary>
        public int RepeatCount { get; set; }

        /// <summary>
        /// Triggers the sound to start playing.
        /// </summary>
        public void Trigger()
        {
            System.Media.SystemSounds.Beep.Play();
        }
    }
}
