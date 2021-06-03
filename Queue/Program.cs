using Queue.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueUsingLinkedList queueUsingLinkedList = new QueueUsingLinkedList();

            while (true)
            {
                Console.WriteLine
                    ("Please select an option" +
                        Environment.NewLine + "1. Enqueue" +
                        Environment.NewLine + "2. Dequeue" +
                        Environment.NewLine + "3. Display Queue" +
                        Environment.NewLine + "0. Exit"
                    );

                if (!int.TryParse(Console.ReadLine(), out int i))
                {
                    Console.WriteLine(Environment.NewLine + "Input format is not valid. Please try again." + Environment.NewLine);

                }

                if (i == 0)
                {
                    Environment.Exit(0);
                }
                else if (i == 1)
                {
                    Console.WriteLine("Enter the number");
                    int num = Convert.ToInt32(Console.ReadLine());
                    queueUsingLinkedList.Enqueue(num);
                }
                else if (i == 2)
                {
                    Console.WriteLine(queueUsingLinkedList.Dequeue());
                }
                else if (i == 3)
                {
                    queueUsingLinkedList.Display();
                }
                else
                {
                    Console.WriteLine("Please select a valid option.");
                }
            }
        }
    }
}
