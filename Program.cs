using System;
using System.Collections.Generic;
using System.Reflection;
using project_euler.Problems;
using project_euler.Helpers;

namespace project_euler {
    class Program {
        static void Main(string[] args) {

            var listHelper = new ListHelper();
            bool exit = false;

            while (!exit) {
                Console.Write("Menu: ");
                string input = Console.ReadLine().ToLower();

                DateTime start = DateTime.Now;
                List<int> problemsDone = new List<int>() { 1, 2, 5 };

                bool isNumeric = int.TryParse(input, out int n);

                if (isNumeric && problemsDone.Contains(n)) {
                    Type problemClassType = Type.GetType("project_euler.Problems.Problem" + n);
                    object instance = Activator.CreateInstance(problemClassType);
                    MethodInfo solveMethod = problemClassType.GetMethod("Solve");
                    solveMethod.Invoke(instance, null);

                    TimeToSolve(start);
                } 
                else {
                    switch (input) {
                        case "pf":
                            var helper = new PrimeHelper();
                            var pfStart = helper.WritePrimeFactorisation();
                            TimeToSolve(pfStart);
                            break;
                        case "e":
                            exit = true;
                            Console.WriteLine("Exitting");
                            break;
                        case "help":
                            Console.WriteLine("Options: Problem <n> = <n>, Prime Factorisation = pf, Exit =e");
                            Console.WriteLine("Problems Completed: " + listHelper.ListItems(problemsDone));
                            break;
                        default:
                            Console.WriteLine("Not a valid option, write 'help' to see available options");
                            break;
                    }
                }
                Console.WriteLine("---------------");
            }
        }

        private static void TimeToSolve(DateTime start) {
            DateTime finish = DateTime.Now;
            double duration = (finish - start).TotalMilliseconds;
            Console.WriteLine($"Took {duration.ToString()} milliseconds to solve");
        }
    }
}
