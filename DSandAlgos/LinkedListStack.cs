using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlogrithms
{
    public class StackNode
    {
        public int value;
        public StackNode next;

        public StackNode(int v)
        {
            value = v;

            next = null;
        }
    }
    public class LinkedListStack
    {
        StackNode top;

        LinkedListStack()
        {
            this.top = null;
        }


        public void Push(int value)
        {
            StackNode newNode = new StackNode(value);

            if(top == null)
            {
                newNode.next = null;
                
            }
            else
            {
                newNode.next = top;
               
            }
            top = newNode;
        }
        public  void pop()
        {
            if(top== null)
            {
                Console.WriteLine("Stack undrflow.deletion not possible");
                return;
            }
            Console.WriteLine(top.value);
            top = top.next; //it is not next - it points to the down node/stack
        }
    }


    public class LinkedListQueue
    {
        StackNode front;
        StackNode Rear;

        LinkedListQueue()
        {
            this.front = this.Rear = null;
        }
        public void Enqueue(int v)
        {
            StackNode newNode = new StackNode(v);

            if (this.Rear == null)
            {
                this.front = this.Rear = newNode;
            }
            else
            {
                this.Rear.next = newNode;  //assign to the current rear node
                this.Rear = newNode;   //then change the rear node to new one
            }

        }

        public void Dequeue()
        {
            if(this.front == null)
            {
                return; //we cant delete any 
            }

            StackNode temp = this.front;
            this.front = this.front.next;
            
            //


        }

    }

    

   
}
