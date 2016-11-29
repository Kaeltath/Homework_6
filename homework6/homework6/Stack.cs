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
        private int[] stack;

        
        public MyStack()
        {
            stack = new int[5];
        }

        
        public void Push(int topush)
        {
            if (IsFull())
            {
                Console.WriteLine("stack overflow");
                Console.ReadKey();
                Environment.Exit(0);
            }
            stack[counter] = topush;
            counter++;
        }

        public int Pop()
        {
            counter--;
            return stack[counter];

        }
        
        public int Peek()
        {
            return stack[counter - 1];
        }

        public override bool IsFull()
        {
            if (counter == stack.Length)
            {
                return true;
            }
            return false;

        }
    }
}
