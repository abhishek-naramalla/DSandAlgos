using System;

namespace DSandAlgos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var bst = new BinarySearchTree();
            bst.Insert(2);
            bst.Insert(1);
          
            bst.Insert(3);



            Console.WriteLine("Hello World!");

            Console.WriteLine(bst.FindMin(bst.root));

            Console.WriteLine("end..");

            Console.ReadLine();

            

        

        }
    }
}
