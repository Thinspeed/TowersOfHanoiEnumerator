using System;
using System.Collections.Generic;
using System.Text;

namespace TowersOfHanoiEnumerator
{
    public class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            foreach (var (from, to) in HanoiTowers.GetMoves(number))
            {
                Console.WriteLine($"{from} {to}");
            }
        }
    }
}
