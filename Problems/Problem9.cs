using System;

namespace project_euler.Problems {
    public class Problem9 : ISolveable {

        public void Solve () {

            int i = 0, j = 0, k = 0;

            bool ansFound = false;
            string result = "Not found";

            while (!ansFound) {
                while (i < 1000) {
                    while (j < 1000) {
                        while (k < 1000) {
                            if (i + j + k == 1000) {
                                if (this.IsPythagoreanTriplet (i, j, k)) {
                                    result = $"Problem 9: {i * j * k} = {i}*{j}*{k} [where {i}+{j}+{k}=1000]";
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

            Console.WriteLine (result);
        }

        private bool IsPythagoreanTriplet (int i, int j, int k) {
            if (i < j && j < k) {
                return i * i + j * j == k * k;
            }
            return false;
        }
    }
}