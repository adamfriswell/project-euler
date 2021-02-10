using System;
using System.Collections.Generic;

namespace project_euler.Helpers {
    public class TimeHelper {
        public void TimeToSolve (DateTime start) {
            double duration = (DateTime.Now - start).TotalMilliseconds;
            Console.WriteLine ($"Took {duration.ToString()} milliseconds to solve");
        }
    }
}