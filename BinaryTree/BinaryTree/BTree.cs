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
        public static string path = "";
        public static bool foundValue;

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
            foundValue = true;

            if (root != null) root.Find(val);
            else 
            {
                foundValue = false;
                Console.WriteLine("Wert wurde nicht gefunden ({0})", val); 
                path = ""; 
            }
        }
    }

    class Node
    {
        private int value;

        public Node childLeftNode;
        public Node childRightNode;
       

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
         
            if(value != val)
            {
                if (val < value && CheckNull(childLeftNode,val)) { childLeftNode.Find(val); BTree.path += ",L"; }
                if (val > value && CheckNull(childRightNode,val)) { childRightNode.Find(val); BTree.path += ",R"; }
            }
        }

        static bool CheckNull(Node var, int val)
        {
            if (var == null) 
            {
                BTree.foundValue = false;
                Console.WriteLine("Wert wurde nicht gefunden ({0})",val); 
                BTree.path = ""; 
                return false; 
            }
            else return true;

        }
    }
}
