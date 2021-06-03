using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Helper
{
    internal class CircularQueueUsingArray
    {
        internal int Size { get; private set; }
        internal int Rear { get; set; }
        internal int Front { get; set; }
        internal int[] Item { get; set; }

        public CircularQueueUsingArray(int size)
        {
            Size = size;
            Rear = 0;
            Front = 0;
            Item = new int[size];
        }

        internal void Enqueue(int num)
        {
            if ((Rear + 1) % Size == Front)
            {
                Console.WriteLine("Queue is full.");
                return;
            }

            Rear = (Rear + 1) % Size;
            Item[Rear] = num;
        }

        internal int Dequeue()
        {
            if (Front == Rear)
            {
                return -1;
            }

            Front = (Front + 1) % Size;
            return Item[Front];
        }

        internal void Display()
        {
            int x = Front + 1;

            while(x != ((Rear+1) % Size))
            {
                Console.WriteLine(Item[x]);
                x = (x+1) % Size;
            }
        }
    }
}
