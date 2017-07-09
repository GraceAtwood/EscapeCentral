using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentScheduler;

namespace EscapeCentral.Utilities
{
    /// <summary>
    /// Provides methods to assist with scheduling delayed execution methods.
    /// </summary>
    public static class SchedulingUtilty
    {
        private static Registry Registry { get; set; } = new Registry();

        static SchedulingUtilty()
        {
            JobManager.Initialize(Registry);
        }

        /// <summary>
        /// Schedules an action for execution.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="schedule"></param>
        public static Schedule ScheduleJob(Action action)
        {
            return Registry.Schedule(action);
        }

    }
}
