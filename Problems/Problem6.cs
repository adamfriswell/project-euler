using System;
using System.Collections.Generic;
using project_euler.Helpers;

namespace project_euler.Problems {
    public class Problem6 : ISolveable {

        public void Solve () {

            List<int> numbers = new List<int> { };
            int count = 1;
            while (count <= 100) {
                numbers.Add (count);
                count++;
            }

            long sumOfSquares = 0;
            long squareOfSum = 0;
            foreach (var n in numbers) {
                sumOfSquares += (n * n);
                squareOfSum += n;
            }

            squareOfSum = squareOfSum * squareOfSum;

            long difference = squareOfSum - sumOfSquares;

            Console.WriteLine ($"Problem 6: {difference}");
        }
    }
}