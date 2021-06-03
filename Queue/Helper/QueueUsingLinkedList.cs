using Queue.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Helper
{
    internal class QueueUsingLinkedList
    {
        internal Node Front { get; set; }
        internal Node Rear { get; set; }

        internal void Enqueue(int num)
        {
            Node node = new Node(num);

            if(node == null)
            {
                Console.WriteLine("Queue is null.");
            }
            else
            {
                if(Front == null)
                {
                    Rear = Front = node;
                }
                else
                {
                    Rear.Next = node;
                    Rear = Rear.Next;
                }
            }  
        }

        internal int Dequeue()
        {
            if (Front == null)
            {
                return -1;
            }
            else
            {
                if(Front.Next == null)
                {
                    Rear = Front.Next;
                }

                Node tempNode = Front;
                Front = Front.Next;
                return tempNode.Data;
            }
        }

        internal void Display()
        {
            Node tempNode = Front;

            while(tempNode != null)
            {
                Console.WriteLine(tempNode.Data);
                tempNode = tempNode.Next;
            }
        }
    }
}
