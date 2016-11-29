using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    class MyStack: Buffer
    {
        //private int counter;
        private int[] stack;

        
        public MyStack()
        {
            Counter = 0;
            stack = new int[5];
        }

        public int Counter {get;set;}

        public void Push(int topush)
        {
            if (IsFull())
            {
                Console.WriteLine("stack overflow");
                Console.ReadKey();
                Environment.Exit(0);
            }
            stack[Counter] = topush;
            Counter++;
        }

        public int Pop()
        {
            Counter--;
            return stack[Counter];

        }

        public override bool IsFull()
        {
            if (Counter == stack.Length)
            {
                return true;
            }
            return false;

        }

        public override bool IsEmpty()
        {
            if (Counter == 0)
            {
                return true;
            }
            return false;
        }

        public int Peek()
        {
            return stack[Counter - 1];
        }
    }
}
