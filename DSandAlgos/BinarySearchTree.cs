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
        public Node root;
        public Node parent;
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
            while (cur.left != null)
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
            while (cur.right != null)
            {
                cur = cur.right;

            }
            return cur.data;
        }
        public Node FindMinNode(Node root)
        {
            if (root == null)
            {
                return root;
            }
            Node cur = root;
            
            while (cur.left != null)
            {
                parent = cur;
                cur = cur.left;

            }
            return cur;
        }


        //Without recursion - refer book with recursion
        public Node DeleteNode(Node root,int value)
        {
            
            if (root == null)
            {
                return root;
            }
            parent = root;
            var isleft = true;
            //find the node which we have to delete.
            while (root.data != value)
            {
                parent = root;
                if (root.data > value)
                {
                    
                    root = root.left;
                }
                else if (root.data < value)
                {
                    isleft = false;
                    root = root.right;
                }
            }
            //after this while block - root will be node which we need to delete.
           
            //node leaf node
            if (root.left == null && root.right == null)
            {
                if (isleft) { parent.left = null; }
                else { parent.right = null; }
                root = null;
                return parent;
            }
            else if (root.left == null)
            {
                if (isleft)
                {
                    parent.left = root.right;
                    //root = null;
                }
                parent.right = root.right;
                root = null;
            }
            else if (root.right == null)
            {
                if (isleft)
                {
                    parent.left = root.left;
                    //root = null;
                }
                parent.right = root.left;
                root = null;
            }

            //When root has both nodes -

            var minNode = FindMinNode(root.right);

            //replace root with Min

            root.data = minNode.data;

            //
            if (isleft)
            {
                parent.left = null;
            }
            else
            {
                parent.right = null;
            }







            return parent;

        }

    }
}
