using System;
using System.Collections.Generic;
using System.Linq;

namespace project_euler.Helpers {
    public class PrimeHelper {

        public bool IsPrime (long input) {
            for (int i = 2; i < input; i++) {
                if (input % i == 0) {
                    return false;
                }
            }
            return true;
        }

        public List<long> PrimeFactors (long input) {

            var primeFactors = new List<long> () { };

            for (long i = 3; i <= input; i += 2) { //skip even numbers
                if (input % i == 0) { //is a divisor
                    if (IsPrime (i)) { //is prime          
                        primeFactors.Add (i); //then will be a prime factor, so add to list
                    }
                }
            }

            return primeFactors;
        }

        public List<long> PrimeFactorsFromFactorisation (long input) {
            return this.PrimeFactorisation (input).Distinct ().ToList ();
        }

        public List<long> PrimeFactorisation (long input) {
            List<long> primeFactorisation = new List<long> () { };
            double result = input;
            int count = 2;
            double test = 0;

            while (result != 1) {
                test = result / count;

                if (test % 1 == 0) { //if whole number
                    primeFactorisation.Add (count);
                    result = test;
                } else {
                    count++;
                }
            }

            return primeFactorisation;
        }

        public void WritePrimeFactorisation () {

            Console.Write ("Type any number:  ");
            long input = Int64.Parse (Console.ReadLine ());

            DateTime start = DateTime.Now;
            var pf = PrimeFactorisation (input);

            var listHelper = new ListHelper ();
            Console.WriteLine ("Prime factorisation of " + input + " is: " + listHelper.ListItems (pf));

            var timeHelper = new TimeHelper ();
            timeHelper.TimeToSolve (start);
        }

    }
}