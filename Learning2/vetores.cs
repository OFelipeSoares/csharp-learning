using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class unario
    {
        public static void Main()
        {
            int[] myInts = { 5, 10, 15 };
            bool[] myBools = new boll[2][];

            myBools[0] = new bool[2];
            myBools[1] = new bool[1];

            double[,] myDoubles = new double[2, 2];
            string[] myString = new string[3];

            Console.WriteLine("myInts: {0}, myInts[1]: {1}, myInts[2]: {2}", myInts[0], myInts[1], myInts[2]);

            myBools[0][0] = true;
            myBools[0][1] = false;
            myBools[1][0] = true;

            Console.WriteLine("myBools[0][0]: {0}, myBools[1][0]: {1},", myBools[0][0], myBools[1][0]);

            myDoubles[0, 0] = 3.147;
            myDoubles[0, 1] = 7.157;
            myDoubles[1, 1] = 2.117;
            myDoubles[1, 0] = 56.00138917;

            Console.WriteLine("myDubles[0, 0]: {0}, myDubles[1, 0]: {1}", myDoubles[0, 0], myDoubles[1, 0]);

            myString[0] = "Joe";
            myString[1] = "Matt";
            myString[2] = "Robert";

            Console.WriteLine("myString[0]: {0}, myString[1]: {1}, myString[2]: {2}", myString[0], myString[1], myString[2]);


        }
    }
}