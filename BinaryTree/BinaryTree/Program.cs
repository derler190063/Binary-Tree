using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Menu()
        {
            string input;
            bool validInput = false;
            int num;

            Console.WriteLine("Was wollen Sie tun? Geben Sie jeweils die Zahl ein.\n");
            Console.WriteLine("1. Einen Baum erstellen und nach Werten suchen");
            Console.WriteLine("2. Unseren Beispiel Baum erstellen und nach Werten suchen\n");

            do
            {
                Console.Write(": ");
                input = Console.ReadLine();
                validInput = Int32.TryParse(input, out num);

                if (!(validInput && num >= 1 && num <= 2)) validInput = false;
                Console.WriteLine();

            } while (!validInput);

            Console.Clear();            
            if (num == 1) MakeTree();
            if (num == 2) ExampleTree();

        }
        
        static void MakeTree()
        {
            List<int> inputList = new List<int>();
            List<string> pathList = new List<string>();

            BTree myTree = new BTree();
            inputList = Interface.Input("Input", "Geben Sie Zahlen ein die Sie zum Binary Tree hinzufügen wollen");

            foreach (var item in inputList) myTree.Insert(item);

            //Wert Finden
            inputList = Interface.Input("Werte Finden", "Geben Sie Zahlen ein die Sie im Binary Tree suchen wollen");
            foreach (var item in inputList)
            {
                myTree.Find(item);
                if (BTree.foundValue == true) pathList.Add(BTree.path);
                else pathList.Add("Wert wurde nicht gefunden");

                BTree.path = "";
            }

            Interface.PrintList(pathList, inputList);
        }

        static void ExampleTree()
        {
            List<int> inputList = new List<int>();
            List<string> pathList = new List<string>();

            BTree myTree = new BTree();

            inputList.Add(10);
            inputList.Add(5);
            inputList.Add(2);
            inputList.Add(3);
            inputList.Add(8);
            inputList.Add(6);
            inputList.Add(9);
            inputList.Add(18);
            inputList.Add(17);
            inputList.Add(23);
            inputList.Add(40);

            Console.WriteLine();

            Interface.PrintList(inputList);
            foreach (var item in inputList) myTree.Insert(item);
         
            foreach (var item in inputList)
            {
                myTree.Find(item);
                if (BTree.foundValue == true) pathList.Add(BTree.path);
                BTree.path = "";
            }

            Interface.PrintList(pathList, inputList);
        }

        static void Main(string[] args)
        {
            Menu();   
        }
    }
}
