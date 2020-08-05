using System;
using System.Collections.Generic;
using System.Reflection;
using project_euler.Problems;
using project_euler.Helpers;

namespace project_euler {
    class Program {
        static void Main(string[] args) {

            var listHelper = new ListHelper();
            var timeHelper = new TimeHelper();
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

                    timeHelper.TimeToSolve(start);
                } 
                else {
                    switch (input) {
                        case "pf":
                            var helper = new PrimeHelper();
                            helper.WritePrimeFactorisation();
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
    }
}
