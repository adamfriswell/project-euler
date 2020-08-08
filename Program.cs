using System;
using System.Collections.Generic;
using System.Reflection;
using project_euler.Helpers;
using project_euler.Problems;

namespace project_euler {
    class Program {
        static void Main (string[] args) {

            var listHelper = new ListHelper ();
            var timeHelper = new TimeHelper ();
            var primeHelper = new PrimeHelper ();

            bool exit = false;

            while (!exit) {
                Console.Write ("Menu: ");
                string input = Console.ReadLine ().ToLower ();

                DateTime start = DateTime.Now;
                List<long> problemsDone = new List<long> () { 1, 2, 3, 4, 5, 6, 7, 8};

                bool isNumeric = int.TryParse (input, out int problemNumber);

                if (isNumeric && problemsDone.Contains (problemNumber)) {
                    InvokeProblemSolveMethod (problemNumber);
                    timeHelper.TimeToSolve (start);
                } else {
                    switch (input) {
                        case "pf":
                            primeHelper.WritePrimeFactorisation ();
                            break;
                        case "pal":
                            var p4 = new Problem4 ();
                            Console.Write ("Type any number to see if its a palindrom: ");
                            int i = Int32.Parse (Console.ReadLine ());
                            Console.WriteLine (p4.NumberIsPalindrom (i));
                            break;
                        case "po":
                            Console.Write ("Type any number to see the primes up to this ordinal: ");
                            long j = Int64.Parse (Console.ReadLine ());
                            Console.WriteLine (listHelper.ListItems(primeHelper.PrimesUpToOrdinal(j)));
                            break;
                        case "e":
                            exit = true;
                            Console.WriteLine ("Exitting");
                            break;
                        case "help":
                            Console.WriteLine ("Options: Problem <n> = <n>, Prime Factorisation = pf, Is number palindrom = pal, Exit =e");
                            Console.WriteLine ($"Problems Completed: {listHelper.ListItems (problemsDone)}");
                            break;
                        default:
                            Console.WriteLine ("Not a valid option, write 'help' to see available options");
                            break;
                    }
                }
                Console.WriteLine ("---------------");
            }
        }

        private static void InvokeProblemSolveMethod (int problemNumber) {
            Type problemClassType = Type.GetType ("project_euler.Problems.Problem" + problemNumber);
            object instance = Activator.CreateInstance (problemClassType);
            MethodInfo solveMethod = problemClassType.GetMethod ("Solve");
            solveMethod.Invoke (instance, null);
        }
    }
}