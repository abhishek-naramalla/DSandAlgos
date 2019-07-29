using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataStructuresAndAlogrithms
{
    class Program
    {
        static void Main(string[] args)
        {
            DataStructuresAndAlogrithms.LinkedList lnkList = new LinkedList();
            //lnkList.CreateCycle();
           // lnkList.isLinkedListCycle(lnkList);

           var obj = new Arrays();
            var bin = new BinarySerachTree();

            //var binNbr = bin.binaryconversion(2);

            var revInt = bin.ReverseInteger(123);

            Console.ReadLine();

           // var isAna = obj.isAnagram("abhi", "ibha");

           // var isSum = obj.TwoIntegersSumToTarget(new int[] { 2, 3, 4, 4, 5, 6, 1 }, 3);
            //  var reversedString = obj.stringReverse("abhi");
            //var isPolin= obj.isPolindrome("boob");

            //var rev = obj.ReverseString("abhi shek");

            //obj.CharaterCountInString("abhisheknaramalla");

            // var nodupes = obj.RemoveDuplicates("abhishek");

            //var s= obj.findallsubstring("abhi");

            //var b = obj.FindPrime(17);

            //obj.SumOfDigits(151);
            //int[] a = new int[]{ 34, 3, 23, 54, };
            // obj.FindSecondLargeInArray(new int[] { 4,7,1,9 });

            //obj.MultiToSingle(new int[,] { { 2, 3, 3 }, { 3, 5, 4 } });



            // LinkedList l1 = new LinkedList();
            // //l1.Add(new Node("1"));  
            // l1.Add(new Node(2));
            // l1.Add(new Node(3));
            // l1.Add(new Node(4));
            // l1.Add(new Node(5));
            // l1.Add(new Node(8));
            // l1.Add(new Node(100));
            // l1.Add(new Node(120));


            // LinkedList l2 = new LinkedList();
            // l2.Add(new Node(10));
            // l2.Add(new Node(30));
            // l2.Add(new Node(34));
            // LinkedList list = new LinkedList();
            // list.MergeSortedList(l1., l2.Head);
            //// list.PrintNodes();
            // Console.ReadLine();
        }
    }
}
