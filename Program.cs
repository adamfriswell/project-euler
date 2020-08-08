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
            var helper = new PrimeHelper();

            bool exit = false;

            while (!exit) {
                Console.Write("Menu: ");
                string input = Console.ReadLine().ToLower();

                DateTime start = DateTime.Now;
                List<long> problemsDone = new List<long>() { 1, 2,3, 5, 6 };

                bool isNumeric = int.TryParse(input, out int problemNumber);

                if (isNumeric && problemsDone.Contains(problemNumber)) {
                    InvokeProblemSolveMethod(problemNumber);
                    timeHelper.TimeToSolve(start);
                } 
                else {
                    switch (input) {
                        case "pf":
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

        private static void InvokeProblemSolveMethod(int problemNumber) {
            Type problemClassType = Type.GetType("project_euler.Problems.Problem" + problemNumber);
            object instance = Activator.CreateInstance(problemClassType);
            MethodInfo solveMethod = problemClassType.GetMethod("Solve");
            solveMethod.Invoke(instance, null);
        }
    }
}
