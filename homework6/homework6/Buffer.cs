using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    class Buffer
    {
        private int[] queue;
        protected int counter;

        public Buffer()
        {
            queue = new int[5];
        }

         public virtual bool IsFull()
        {
            if (counter > queue.Length)
            {
                return true;
            }

            return false;

        }

        public virtual bool IsEmpty()
        {
            if (counter == 0)
            {
                return true;
            }

            return false;

        }
    }
}
