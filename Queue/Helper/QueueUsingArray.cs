using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Helper
{
    internal class QueueUsingArray
    {
        internal int Size { get; private set; }
        internal int Rear { get; set; }
        internal int Front { get; set; }
        internal int[] Item { get; set; }

        public QueueUsingArray(int size)
        {
            Size = size;
            Rear = -1;
            Front = -1;
            Item = new int[size];
        }

        internal void Enqueue(int num)
        {
            if(Rear == Size - 1)
            {
                Console.WriteLine("Queue is full.");
                return;
            }
            Item[++Rear] = num;
        }

        internal int Dequeue()
        {
            if(Rear == Front)
            {
                return -1;
            }

            return Item[++Front];
        }

        internal void Display()
        {
            for(int i = Front + 1; i <= Rear; i++)
            {
                Console.WriteLine(Item[i]);
            }
        }
    }
}
