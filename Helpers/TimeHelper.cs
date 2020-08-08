using System;
using System.Collections.Generic;

namespace project_euler.Helpers {
    public class TimeHelper {
        public void TimeToSolve (DateTime start) {
            DateTime finish = DateTime.Now;
            double duration = (finish - start).TotalMilliseconds;
            Console.WriteLine ($"Took {duration.ToString()} milliseconds to solve");
        }
    }
}