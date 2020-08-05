using System;
using System.Collections.Generic;
using project_euler.Helpers;

namespace project_euler.Problems {
    public class Problem5 {

        public void Solve() {

            bool solved = false;
            long ans = 2520; //can start here as given in question

            while (!solved) {
                if (ans % 1 == 0 && ans % 2 == 0 && ans % 3 == 0 && ans % 4 == 0 && ans % 5 == 0 &&
                    ans % 6 == 0 && ans % 7 == 0 && ans % 8 == 0 && ans % 9 == 0 && ans % 10 == 0 && 
                    ans % 11 == 0 && ans % 12 == 0 && ans % 13 == 0 && ans % 14 == 0 && ans % 15 == 0 &&
                    ans % 16 == 0 && ans % 17 == 0 && ans % 18 == 0 && ans % 19 == 0 && ans % 20 == 0) {
                        solved = true;
                }
                else{
                    ans+=2; //can ignore all odd numbers as not divisible by 2
                }
            }

            Console.WriteLine("Problem 5: " + ans);
        }
    }
}