using System;
namespace DSandAlgos
{
    public class BST_TreeTraversal
    {
        public class Node
        {
            public int data;
            public Node left;
            public Node right;
            public Node(int i)
            {
                data = i;
            }
        }
        public void PreOrder(Node item)
        {
            Console.WriteLine(item.data);
            PreOrder(item.left);
            PreOrder(item.right);
        }
        public void InOrder(Node item)
        {

            InOrder(item.left);
            Console.WriteLine(item.data);
            InOrder(item.right);
        }
        public void PostOrder(Node item)
        {

            PostOrder(item.left);
            PostOrder(item.right);
            Console.WriteLine(item.data);
        }
    }
}
