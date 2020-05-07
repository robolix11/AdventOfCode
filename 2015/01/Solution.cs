using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace AdventOfCode._2015._01
{
    public class Solution
    {
        private const char CHAR_LEVEL_INCREASE = '(';
        private const char CHAR_LEVEL_DECREASE = ')';

        private static string getInput()
        {
            return File.ReadAllText("..\\..\\..\\2015\\01\\Input.txt");
        }

        private static int analyseChar(char input)
        {
            switch (input)
            {
                case CHAR_LEVEL_INCREASE:
                    return 1;
                case CHAR_LEVEL_DECREASE:
                    return -1;
                default:
                    //How da f did i end up here??
                    return 0;
            }
        }

        public static void Part1()
        {
            string inputString = "";
            int floorLevel = 0;

            inputString = getInput();

            Console.WriteLine("Begin Task 2015.01 - Part 1");

            foreach(char currentChar in inputString)
            {
                floorLevel += analyseChar(currentChar);
            }

            Console.WriteLine($"Solution Part 1: {floorLevel}");
        }

        public static void Part2()
        {
            const int ENTER_BASEMENT_LEVEL = -1;

            string inputString = "";
            int floorLevel = 0;
            int charPos = 0;

            inputString = getInput();

            Console.WriteLine("Begin Task 2015.01 - Part 2");

            foreach (char currentChar in inputString)
            {
                charPos++;
                floorLevel += analyseChar(currentChar);
                if(floorLevel == ENTER_BASEMENT_LEVEL)
                {
                    break;
                }
            }

            Console.WriteLine($"Solution Part 2: {charPos}");
        }
    }
}
