using System;
using System.Collections.Generic;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int answer = 0;
            List<int> inputNumbers = new List<int>();
           
            foreach (var Line in System.IO.File.ReadLines("Input.txt"))
            {
                inputNumbers.Add(int.Parse(Line));
            }

            //Part 1
            for (int i = 0; i < inputNumbers.Count; i++)
            {
                for (int j = 0; j < inputNumbers.Count; j++)
                {
                    if (inputNumbers[i] + inputNumbers[j] == 2020)
                    {
                        num1 = inputNumbers[i];
                        num2 = inputNumbers[j];
                    }
                }
            }

           //Part 2 
           /*
            for (int i = 0; i < inputNumbers.Count; i++)
            {
                for (int j = 0; j < inputNumbers.Count; j++)
                {
                    for (int k = 0; k < inputNumbers.Count; k++)
                    {
                        if ((inputNumbers[i] + inputNumbers[j] + inputNumbers[k]) == 2020)
                        {
                            num1 = inputNumbers[i];
                            num2 = inputNumbers[j];
                            num3 = inputNumbers[k];
                        }
                    }
                }
            }
           */


            Console.WriteLine(inputNumbers);
            Console.WriteLine(num2);
            Console.WriteLine(num3);

            answer = num1 * num2 * num3;
            Console.WriteLine(answer);  
            Console.ReadLine();
        }
    }
}
