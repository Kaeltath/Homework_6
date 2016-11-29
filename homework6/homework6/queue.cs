using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    class MyQueue: Buffer
    {


       private int[] queue;
       private int tail, head;


        public MyQueue()
        {
            queue = new int[5];
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
            if (tail < queue.Length - 1)
            {
                queue[tail] = z;
                tail++;

            }
            else
            {
                queue[tail] = z;
                tail = 0;
            }

        }

        public int Dequeue()
        {
            int value;
            if (head < queue.Length - 1)
            {
                value = queue[head];
                head++;
                counter--;
                return value;
            }

            value = queue[head];
            head = 0;
            counter--;
            return value;

        }
    }
}
