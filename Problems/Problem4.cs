using System;
using System.Collections.Generic;
using System.Linq;
using project_euler.Helpers;

namespace project_euler.Problems {
    public class Problem4 : ISolveable {

        public void Solve () {

            int i = 1;
            int j = 1;
            List<Problem4Info> info = new List<Problem4Info> ();

            while (i <= 1000) {
                while (j <= 1000) {
                    int product = i * j;
                    if (NumberIsPalindrom (product)) {
                        info.Add (new Problem4Info { I = i, J = j, Product = product });
                    }
                    j++;
                }
                j = 1;
                i++;
            }

            Problem4Info result = new Problem4Info () { Product = 0 };
            foreach (var item in info) {
                if (item.Product > result.Product) {
                    result = item;
                }
            }

            Console.WriteLine ($"Problem 4: {result.Product} = {result.I} * {result.J}");
        }

        public bool NumberIsPalindrom (int input) {
            string word = input.ToString ();
            char[] charArray = word.ToCharArray ();
            Array.Reverse (charArray);
            string reverse = new string (charArray);

            return word == reverse ? true : false;
        }

        public class Problem4Info {
            public int I { get; set; }
            public int J { get; set; }
            public int Product { get; set; }
        }
    }
}