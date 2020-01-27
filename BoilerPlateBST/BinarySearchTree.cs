using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoilerPlateBST
{
    class BinarySearchTree
    {
        public class Node
        {
            public int data;
            public Node left;
            public Node right;

            public void DisplayNode()
            {
                Console.Write(data + " ");
            }
        }

        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }
    }
}
