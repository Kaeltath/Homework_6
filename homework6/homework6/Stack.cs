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
        public void Push(int topush)
        {
            if (IsFull())
            {
                Console.WriteLine("stack overflow");
                Console.ReadKey();
                Environment.Exit(0);
            }
            itemsList[counter] = topush;
            counter++;
        }

        public int Pop()
        {
            counter--;
            return itemsList[counter];

        }
        
        public int Peek()
        {
            return itemsList[counter - 1];
        }

        public override bool IsFull()
        {
            if (counter == itemsList.Length)
            {
                return true;
            }
            return false;

        }
    }
}
