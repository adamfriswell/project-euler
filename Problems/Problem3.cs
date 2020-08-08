using System;
using System.Collections.Generic;
using System.Linq;
using project_euler.Helpers;

namespace project_euler.Problems {
    public class Problem3 : ISolveable {

        public void Solve () {

            var helper = new PrimeHelper ();
            long input = 600851475143;

            List<long> primeFactorisation = helper.PrimeFactorisation (input);

            Console.WriteLine ($"Problem 3: {primeFactorisation.Max ()}");
        }
    }
}