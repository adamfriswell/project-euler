using System;
using project_euler.Problems;
namespace project_euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project Euler:");

            var p1 = new Problem1();
            p1.Solve();

            var p2 = new Problem2();
            p2.Solve();

        }
    }
}
