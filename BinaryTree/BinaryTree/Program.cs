using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = new List<int>();
            List<string> pathList = new List<string>();

            BTree myTree = new BTree();
            inputList = Interface.Input("Input");

            foreach (var item in inputList) myTree.Insert(item);

            //Wert Finden
            inputList = Interface.Input("Werte Finden");
            foreach (var item in inputList)
            {
                myTree.Find(item);
                pathList.Add(BTree.path);
                BTree.path = "";
            }

            Interface.PrintPath(pathList,inputList);
        }
    }
}
