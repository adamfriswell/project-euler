using System;
using project_euler.Problems;
using project_euler.Helpers;

namespace project_euler {
    class Program {
        static void Main(string[] args) {

            bool exit = false;

            while (!exit) {
                Console.Write("Menu: ");
                string input = Console.ReadLine().ToLower();

                DateTime start = DateTime.Now;

                switch (input) {
                    case "1":
                        var p1 = new Problem1();
                        p1.Solve();
                        TimeToSolve(start);
                        break;
                    case "2":
                        var p2 = new Problem2();
                        p2.Solve();
                        TimeToSolve(start);
                        break;
                    // case "3":
                    //     var p3 = new Problem3();
                    //     p3.Solve();
                    //     break;
                    case "5":
                        var p5 = new Problem5();
                        p5.Solve();
                        TimeToSolve(start);
                        break;
                    case "pf":
                        var helper = new Helper();
                        helper.WritePrimeFactorisation();
                        TimeToSolve(start);
                        break;
                    case "e":
                        exit = true;
                        Console.WriteLine("Exitting");
                        break;
                    case "help":
                        Console.WriteLine("Options: Problem 1 = 1, Problem 2 = 2, Prime Factorisation = pf, Exit =e");
                        break;
                    default:
                        Console.WriteLine("Not a valid option, write 'help' to see available options");
                        break;
                }
                Console.WriteLine("---------------");
            }
        }

        private static void TimeToSolve(DateTime start) {
            DateTime finish = DateTime.Now;
            double duration = (finish - start). TotalMilliseconds;
            Console.WriteLine($"Took {duration.ToString()} milliseconds to solve");
        }
    }
}
