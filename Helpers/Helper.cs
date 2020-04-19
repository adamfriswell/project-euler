using System;
using System.Collections.Generic;

namespace project_euler.Helpers {
    public class Helper {

        public bool IsPrime(long input) {
            for (int i = 2; i < input; i++) {
                if (input % i == 0) {
                    return false;
                }
            }
            return true;
        }

        public List<long> PrimeFactors(long input){
            
            var primeFactors = new List<long>() { };

            for (long i = 3; i <= input; i+=2) { //skip even numbers
                if (input % i == 0) { //is a divisor
                    if (IsPrime(i)) { //is prime          
                        primeFactors.Add(i); //then will be a prime factor, so add to list
                    }
                }
            }

            return primeFactors;
        }

    }
}