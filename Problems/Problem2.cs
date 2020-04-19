using System;
namespace project_euler.Problems {
    public class Problem2 {

        public void Solve() {

            int fib1 = 1;
            int fib2 = 1;
            int nextNum = fib1 + fib2;
            int sum = 0;

            while(nextNum<4000000){
                if(nextNum%2==0){
                    sum += nextNum;
                }
                    fib1 = fib2;
                    fib2 = nextNum;
                    nextNum = fib1 + fib2;
                
            }

            Console.WriteLine("Problem 2: " + sum);
        }

    }
}