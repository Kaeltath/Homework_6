using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    class MyQueue: Buffer
    {
        private int tail, head;
        
        public MyQueue()
        {
            tail = 0;
            head = 0;
         }


        public void Enqueue(int z)
        {
            counter++;
            if (IsFull())
            {
                Console.WriteLine(" item overlaped...");
                Console.ReadLine();
                Environment.Exit(0);
            }
            if (tail < itemsList.Length - 1)
            {
                itemsList[tail] = z;
                tail++;

            }
            else
            {
                itemsList[tail] = z;
                tail = 0;
            }

        }

        public int Dequeue()
        {
            int value;
            if (head < itemsList.Length - 1)
            {
                value = itemsList[head];
                head++;
                counter--;
                return value;
            }

            value = itemsList[head];
            head = 0;
            counter--;
            return value;

        }
    }
}
