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
       private int tail, head, counter;


        public MyQueue()
        {
            queue = new int[5];
            tail = 0;
            head = 0;
            counter = 0;
        }

        override public int Counter
        {
            get { return counter; }
            set { counter = value; }
            
        }

        public void Enqueue(int z)
        {
            Counter++;
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
                Counter--;
                return value;
            }

            value = queue[head];
            head = 0;
            Counter--;
            return value;

        }
    }
}
