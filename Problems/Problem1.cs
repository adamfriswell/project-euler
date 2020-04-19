using System;
namespace project_euler.Problems {
    public class Problem1 {

        public void Solve() {

            int sum = 0;

            for (int i = 0; i < 1000; i++) {
                if (i % 3 == 0 || i % 5 == 0) {
                    sum += i;
                }
            }

            Console.WriteLine("Problem 1: " + sum);
        }

    }
}