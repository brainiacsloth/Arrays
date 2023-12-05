using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(String[] args)
        {
            int[] luckyNumber = { 4, 5, 8, 9, 0 };

            Console.WriteLine(luckyNumber[0]);

            string[] friends = new string[5];

            friends[0] = "Jim";
            friends[1] = "John";
            friends[2] = "Peter";
            Console.WriteLine(friends[2]);
        }

    }
}
