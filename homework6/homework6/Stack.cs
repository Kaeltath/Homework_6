using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    class MyStack: Buffer
    {
        private int index;
        private int[] stack;

        public MyStack()
        {
            index = 0;
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
            stack[index] = topush;
            index++;
        }

        public int Pop()
        {
            index--;
            return stack[index];

        }

        public override bool IsFull()
        {
            if (index == stack.Length)
            {
                return true;
            }
            return false;

        }

        public override bool IsEmpty()
        {
            if (index == 0)
            {
                return true;
            }
            return false;
        }

        public int Peek()
        {
            return stack[index - 1];
        }
    }
}
