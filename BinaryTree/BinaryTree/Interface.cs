using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryTree
{
    class Interface
    {
           
        public static List<int> Input(string prompt,string words)
        {
            List<int> valList = new List<int>();
            string input;
            int num;
            bool exit = false;
            bool validInput;

            Console.WriteLine(prompt);
            Console.WriteLine();
            Console.WriteLine(words);
            Console.WriteLine("Wenn Sie fertig sind dann geben sie ende ein.\n");

            do
            {
                if (valList.Count != 0)
                {
                    Console.WriteLine("Liste:");
                    foreach (var item in valList) Console.WriteLine("= {0}", item);
                }
                Console.WriteLine();

                do
                {
                    validInput = true;

                    Console.Write(": ");
                    input = Console.ReadLine();

                    if (input != "ende")
                    {
                        validInput = Int32.TryParse(input, out num);
                        if (validInput) valList.Add(num);
                    }
                    else
                    {
                        exit = true;
                    }

                } while (!validInput);
                Console.WriteLine();
                Console.Clear();

            } while (!exit);

            return valList;
        }

        public static void PrintPath(List<string> pathList, List<int> inputList)
        {
            int pathLength;
            pathLength = pathList.Count();

            for(int i = 0; i < pathLength; i++)
            {
                if(pathList[i] != "Wert wurde nicht gefunden") pathList.Add(MakeReverse(pathList[i]));
                pathList.Add(pathList[i]);
            }
            pathList.RemoveRange(0, pathLength);

            
            if(pathLength != 0)
            {
                if(pathList[0] != "")
                {
                    Console.WriteLine("Position der Werte:\n");

                    for (int i = 0; i < pathList.Count(); i++)
                    {
                        Console.WriteLine("{0}. Wert ({1}): {2}", i + 1, inputList[i],pathList[i]);
                    }
                }
            }
        }

        static string MakeReverse(string word)
        {
            string reverseword = "";

            for(int i = word.Length - 1; i >= 1; i--)
            {
                reverseword += word[i];    
            }

            return reverseword;
        }        
        
    }
}
