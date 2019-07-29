using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlogrithms
{

    //https://www.c-sharpcorner.com/article/linked-list-implementation-in-c-sharp/
    public class Node
    {
       public int data;
       public Node next;
        //Constructor Initialise
        //public Node(int value)
        //{
        //    data = value;
        //    next = null;
        //}
    }

    public class DNode
    {
        public int data;
        public DNode prev;
        public DNode next;

        //Constructor Initialise
        public DNode(int d)
        {
            data = d;
            prev = null;
            next = null;
        }
    }
    public class LinkedList
    {

        Node head = new Node { data = 1 };

        Node midde = new Node { data = 2 };

        Node tail = new Node();
        Node current = new Node();
        


        int count = 0;

        public void Add(Node newNode)
        {
            if (head == null)
            {
                head = newNode;
                current = head;
            }
            else
            {
                current.next = newNode;
                current  =current.next;
            }
        }

        //This creates a cycle by setting the last node's next property equal to the head
        public void CreateCycle()
        {
            Node cur = head;
            while (cur.next != null)
                cur = cur.next;
            cur.next = head;
        }

        public void AddFirst(Node newNode)
        {
            Node temp = head;

            head = newNode;

            head.next = temp;

            count++;  //declare to zero - 

            if (count == 1)
            {
                tail = head;
            }
           

           
        }

        public void InsertAtEnd(Node newNode)
        {
            LinkedList lnkList = new LinkedList();
            if(lnkList.head.next == null) //if there is no node
            {
                lnkList.head = newNode;
                return;
            }

            //Node temp = tail;

            //tail = newNode;

            //temp.next = tail;


            Node lastNode = GetLastNode(lnkList);
            lastNode.next = newNode;

        }
        public void InsertAfterGivenNode(Node givenNode ,int data)
        {
            Node newNode = new Node()
            {  data = data   };

            if(givenNode == null)
            {
                //it cant be null
                return;
            }

                  

            newNode.next = givenNode.next;
            givenNode.next = newNode;



        }
        
        public void DeleteNodebyKey(LinkedList lnkList,int data)
        {
            Node tmp = lnkList.head;
            Node prev = null;
            if (tmp == null)
            {
                return;
            }
            if(tmp!=null && tmp.data == data)
            {
                lnkList.head = tmp.next;
            }
            while (tmp != null && tmp.data != data)
            {
                prev = tmp;
                tmp = tmp.next;
            }
            prev.next = tmp.next;
        }


        public Node GetLastNode(LinkedList lnkList)
        {
            Node temp = lnkList.head;
            while (temp.next != null)
            {
                temp = temp.next; 
            }
            return temp;
        }


        public bool isLinkedListCycle(LinkedList lnkedList)
        {

            Node lag = head;
            Node lead = head.next;
            HashSet<Node> hsSet = new HashSet<Node>();

            while (lead.next != null)
            {
                if (hsSet.Contains(lead))
                {
                    return true;
                }
                else
                {
                    if(lead.next == null)
                    {
                        return false;
                    }
                    hsSet.Add(lead);
                    lead = lead.next;
                }
            }

            return false;
        }


        public void MergeSortedList(Node first, Node second)
        {
            // We would be always adding nodes from the second list to the first one  
            // If second node head data is more than first one exchange it  
            if (Convert.ToInt32(first.next.data.ToString())
                    > Convert.ToInt32(second.data.ToString()))
            {
                Node t = first;
                first = second;
                second = t;
            }
            head = first; //Assign head to first node  
                          //We need to assign head to first because first will continuosly be changing and so we want to store the beginning of list in head.  
            while ((first.next != null) && (second != null))
            {
                if (Convert.ToInt32(first.next.data.ToString())
                    < Convert.ToInt32(second.data.ToString()))
                {
                    first = first.next; //Iterate over the first node  
                }
                else
                {
                    Node n = first.next;
                    Node t = second.next;
                    first.next = second;
                    second.next = n;
                    first = first.next;
                    second = t;
                }
            }
            if (first.next == null) // Means there are still some elements in second  
                first.next = second;
        }



    }



    public class DoubleLinkedList
    {
        DNode head = new DNode(1);
        


        public void InsertFront(DoubleLinkedList dblLnkeList,int data)
        {
            DNode newNode = new DNode(data);


            newNode.next = dblLnkeList.head;
            newNode.prev = null;

            if (dblLnkeList.head != null)
            {
                dblLnkeList.head.prev = newNode;
            }

            dblLnkeList.head = newNode;  //declareing head




        }
    }


}
