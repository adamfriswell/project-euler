using System;
using project_euler.Helpers;

namespace project_euler.Problems {
    public class Problem7 : ISolveable {

        public void Solve () {

            var ph = new PrimeHelper();
            long result = ph.PrimesAtOrdinal(10001);

            Console.WriteLine ($"Problem 7: {result}");
        }
    }
}