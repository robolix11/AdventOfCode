using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace AdventOfCode._2015._02
{
    public class Solution
    {
        const char DIMENSION_SEPERATOR_CHAR = 'x';

        private static string getInput()
        {
            return File.ReadAllText("..\\..\\..\\2015\\02\\Input.txt");
        }

        private static int[] getTwoLowestOfThree(int[] threeNums)
        {
            int[] returnArray = new int[2];

            if (threeNums[0] < threeNums[1] || threeNums[0] < threeNums[2])
            {
                returnArray[0] = threeNums[0];
                returnArray[1] = threeNums[1] < threeNums[2] ? threeNums[1] : threeNums[2];
            }
            else
            {
                returnArray[0] = threeNums[1];
                returnArray[1] = threeNums[2];
            }

            return returnArray;
        }

        public static void Part1()
        {
            string[] packetLines = getInput().Split(Environment.NewLine);
            int packetAreaNeeded = 0;

            Console.WriteLine("Begin Task 2015.02 - Part 1");

            foreach (string packet in packetLines)
            {
                string[] packetDimensions = packet.Split(DIMENSION_SEPERATOR_CHAR);

                int width = Int32.Parse(packetDimensions[0]);
                int height = Int32.Parse(packetDimensions[1]);
                int length = Int32.Parse(packetDimensions[2]);

                int packetArea = 2 * width * height + 2 * width * length + 2 * height * length;
                packetAreaNeeded += packetArea;

                int[] twoShortestSides = getTwoLowestOfThree(new int[] { width, height, length });
                packetArea = twoShortestSides[0] * twoShortestSides[1];

                packetAreaNeeded += packetArea;
            }

            Console.WriteLine($"Solution Part 1: {packetAreaNeeded}");
        }

        public static void Part2()
        {
            string[] packetLines = getInput().Split(Environment.NewLine);
            int ribbonLengthNeeded = 0;

            Console.WriteLine("Begin Task 2015.02 - Part 2");

            foreach (string packet in packetLines)
            {
                string[] packetDimensions = packet.Split(DIMENSION_SEPERATOR_CHAR);

                int width = Int32.Parse(packetDimensions[0]);
                int height = Int32.Parse(packetDimensions[1]);
                int length = Int32.Parse(packetDimensions[2]);

                int ribbonLength = width * height * length;
                ribbonLengthNeeded += ribbonLength;

                int[] twoShortestSides = getTwoLowestOfThree(new int[] { width, height, length });
                ribbonLength = 2*twoShortestSides[0] + 2*twoShortestSides[1];

                ribbonLengthNeeded += ribbonLength;
            }

            Console.WriteLine($"Solution Part 2: {ribbonLengthNeeded}");
        }
    }
}
