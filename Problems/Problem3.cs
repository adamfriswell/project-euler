using System;
using System.Collections.Generic;
using project_euler.Helpers;

namespace project_euler.Problems {
    public class Problem3 : ISolveable {

        public void Solve() {
            
            var helper = new PrimeHelper();
            long input = 600851475143;
            long largestFactor = 0;

            for (long i = 3; i <= input; i+=2) { //skip even numbers
                if (input % i == 0) { //is a divisor
                    if (helper.IsPrime(i)) { //is prime          
                        largestFactor = i; //in order so will be current largest factor
                    }
                }
            }

            Console.WriteLine("Problem 3: " + largestFactor);
        }
    }
}