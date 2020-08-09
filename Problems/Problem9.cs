using System;

namespace project_euler.Problems {
    public class Problem9 : ISolveable {

        public void Solve () {

            int a, b, c, i, j ,k;
            a = b = c = i = j = k = 0;

            bool ansFound = false;

            while (!ansFound) {
                while (i < 1000) {
                    while (j < 1000) {
                        while (k < 1000) {
                            if (this.IsPythagoreanTriplet (i, j, k)) {
                                if (this.SumTo1000 (i, j, k)) {
                                    a = i;
                                    b = j;
                                    c = k;
                                    ansFound = true;
                                }
                            }
                            k++;
                        }
                        k = 1;
                        j++;
                    }
                    j = 1;
                    i++;
                }
            }

            int product = a * b * c;

            Console.WriteLine ($"Problem 9: {product} = {a}*{b}*{c} [where {a}+{b}+{c}=1000]");
        }

        private bool SumTo1000 (int i, int j, int k) {
            return i + j + k == 1000 ? true : false;
        }

        private bool IsPythagoreanTriplet (int i, int j, int k) {
            if (i < j) {
                if (j < k) {
                    return i * i + j * j == k * k ? true : false;
                } else {
                    return false;
                }
            } else {
                return false;
            }
        }
    }

}