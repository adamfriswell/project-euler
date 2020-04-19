using System;
using System.Collections.Generic;

namespace project_euler.Problems {
    public class Problem3 {

        public void Solve() {

            long input = 600851475143;
            long largestFactor = 0;
            var primeFactors = new List<long>() { };

            for (long i = 3; i <= input; i+=2) { //skip even numbers
                if (input % i == 0) { //is a divisor
                    if (IsPrime(i)) { //is prime          
                        //primeFactors.Add(i); //then will be a prime factor, so add to list
                        largestFactor = i; //in order so will be current largest factor
                    }
                }
            }

            // Console.Write("Prime Factors are: ");
            // foreach (var item in primeFactors) {
            //     Console.Write(item + ", ");
            // }

            Console.WriteLine("Problem 3: " + largestFactor);
        }

        private bool IsPrime(long input) {
            for (int i = 2; i < input; i++) {
                if (input % i == 0) {
                    return false;
                }
            }
            return true;
        }

    }
}