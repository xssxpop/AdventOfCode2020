using System;
using System.Collections.Generic;
using System.Linq;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>();
            string[] inputParts;
            List<string> passes = new List<string>();
            List<string> conditions = new List<string>();
            int validPasses1 = 0;
            int validPasses2 = 0;

            //Add each line of input to list of strings.
            foreach (var Line in System.IO.File.ReadLines("TextFile1.txt"))
            {
                input.Add(Line);
            }



            foreach (var str in input)
            {

                //Split up string into parts so we can work with it.
                inputParts = str.Split(" ");
                string range = inputParts[0];
                int pos1 = int.Parse(range.Split("-")[0]) -1;
                int pos2 = int.Parse(range.Split("-")[1]) -1;
                int min = int.Parse(range.Split("-")[0]) - 1;
                int max = int.Parse(range.Split("-")[1]) - 1;


                string letter = inputParts[1].Split(":")[0];
                string passcode = inputParts[2];
                int count = 0;



                //Part 1
                
                if (passcode.Contains(letter))
                {
                     count = 0;

                    foreach (char c in passcode)
                    {
                        if (c == char.Parse(letter))
                        {
                            count++;
                        }
                    }

                    if (count >= min && count <= max)
                    {
                        validPasses1++;
                    }
                }

                




                //Part 2.
                // Check if the positions contain the letter.
                if (passcode[pos1] == char.Parse(letter) ^ passcode[pos2] == char.Parse(letter))
                {
                    validPasses2++;
                }           

            }

            Console.WriteLine(validPasses1);
            Console.WriteLine(validPasses2);
            Console.ReadLine();
        }
    }
}
