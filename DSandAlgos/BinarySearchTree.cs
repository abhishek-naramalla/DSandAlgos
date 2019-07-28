using System;
namespace DSandAlgos
{
    public class BinarySearchTree
    {

        public class Node {
           public int data;
           public Node left;
           public Node right;
            public Node(int i)
            {
                data = i;
            }
        }
        Node root;
        public BinarySearchTree()
        {
            root = null;

        }

        public void Insert(int value)
        {
            var newNode = new Node(value);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (value < current.data)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newNode; //since current is null - use parent
                            break;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode; //since current is null - use parent
                            break;
                        }
                    }
                }
            }

        }


        public int FindMin(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            Node cur = root;
            while (cur != null)
            {
                cur = cur.left;
                
            }
            return cur.data;
        }
        public int FindMax(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            Node cur = root;
            while (cur != null)
            {
                cur = cur.right;

            }
            return cur.data;
        }


    }
}
