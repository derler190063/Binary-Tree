using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryTree
{
    class Interface
    {
           
        public static List<int> Input(string prompt)
        {
            List<int> valList = new List<int>();
            string input;
            int num;
            bool exit = false;
            bool validInput;

            Console.WriteLine("Geben Sie Inputs ein die Sie zum Binary Tree hinzufügen wollen.");
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

        public static void PrintPath(List<string> pathList)
        {
            foreach (var item in pathList)
            {
                item.Remove(item.Length - 1, 1);
            }

            Console.WriteLine("Position der Werte:\n");

            for (int i = 0; i < pathList.Count(); i++)
            {
                Console.WriteLine("{0}. Wert: {1}", i + 1, pathList[i]);
            }
        }
        
    }
}
