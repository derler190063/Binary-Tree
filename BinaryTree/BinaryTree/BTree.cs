using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BTree
    {
        public Node root;

        public void Insert(int val)
        {
            if (root != null)
            {
                root.Insert(val);
            }
            else
            {
                root = new Node(val);
            }
        }

        public void Find(int val)
        {
            if (root != null) root.Find(val);
            else Console.WriteLine("Value not found tree");
        }
    }

    class Node
    {
        private int value;

        public Node childLeftNode;
        public Node childRightNode;

        public static string path = "";

        public Node(int val)
        {
            value = val;
        }

        public void Insert(int val)
        {
            if (val >= value)
            {
                if (childRightNode == null)
                {
                    childRightNode = new Node(val);
                }
                else
                {
                    childRightNode.Insert(val);
                }
            }
            else
            {
                if (childLeftNode == null)
                {
                    childLeftNode = new Node(val);
                }
                else
                {
                    childLeftNode.Insert(val);
                }
            }
        }

        public void Find(int val)
        {

            if (value == val)
            {
                Console.WriteLine("Found");
                Console.WriteLine(value);
            }
            else
            {
                if (val < value && CheckNull(childLeftNode)) { childLeftNode.Find(val); path += "L,"; }
                if (val > value && CheckNull(childRightNode)) { childRightNode.Find(val); path += "R,"; }
            }

        }

        static bool CheckNull(Node var)
        {
            if (var == null) { Console.WriteLine("Value not Found"); return false; }
            else return true;

        }
    }
}
