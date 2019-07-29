using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlogrithms
{
    public class BinarySerachTree
    {
        public class Node
        {
            public int data;
            public Node Left;
            public Node Right;           

        }

        public Node root;
        public BinarySerachTree()
        {
            root = null;
        }

        public void Insert(int i)
        {
            Node newnode = new Node();
            newnode.data = i;
            if (root == null)
            {
                root = newnode;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (i < current.data)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newnode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newnode;
                            break;
                        }
                    }
                }
            }
        }


        public int BinarySearch(int[] inputArray,int key,int min,int max)
        {
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if(key == inputArray[mid])
                {
                    return ++mid;
                }
                else if(key<inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            throw new Exception("Not Found");

        }
        public double CalculatePower(double @base,int exponent)
        {
            if (exponent < 0)
            {
                throw new Exception("can't be negative");
            }
            else if (exponent == 1)
            {
                return @base;
            }
            else if (exponent == 0)
            {
                return 1;
            }
            else
            {
                return @base * CalculatePower(@base, exponent - 1);
            }


            return 0;
        }


        public int binaryconversion(int num)
        {
            int bin;
            if (num != 0)
            {
                bin = (num % 2) + 10 * binaryconversion(num / 2);
                Console.Write(bin);
                return 0;
            }
            else
            {
                return 0;
            }

        }

        public int ReverseInteger(int Number)
        {
            int Reverse = 0;
            while (Number > 0)
            {
                int remainder = Number % 10;
                Reverse = (Reverse * 10) + remainder;
                Number = Number / 10;
            }
            return Reverse;
        }


        //Private method, with args: root node, node to be deleted
        private Node DeleteN(Node root, Node deleteNode)
        {
            if (root == null)
            {
                return root;
            }
            if (deleteNode.data < root.data)
            {
                root.Left = DeleteN(root.Left, deleteNode);
            }
            if (deleteNode.data > root.data)
            {
                root.Right = DeleteN(root.Right, deleteNode);
            }
            if (deleteNode.data == root.data)
            {
                //No child nodes
                if (root.Left == null && root.Right == null)
                {
                    root = null;
                    return root;
                }
                //No left child - DONT WORK
                else if (root.Left == null)
                {
                    Node temp = root;
                    root = root.Right;
                    temp = null;
                }
                //No right child
                else if (root.Right == null)
                {
                    Node temp = root;
                    root = root.Left;
                    temp = null;
                }
                //Has both child nodes
                else
                {
                    Node min = FindMin2(root.Right);
                    root.data = min.data;
                    root.Right = DeleteN(root.Right, min);
                }
            }
            return root;
        }
        public Node FindMin2(Node root)
        {
            return root;

        }
        //Public method with arg: int value of node to be deleted
        public void DeleteNode(int x)
        {
            Node deleteNode = new Node();
            deleteNode.data = x;
            DeleteN(root, deleteNode);
        }
    }
}
