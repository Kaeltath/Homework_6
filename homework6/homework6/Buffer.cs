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
        private int counter;

        public Buffer ()
        {
            queue= new int[0];
            counter = 0;
        }
        
        public virtual bool IsFull()
        {
            if (counter > queue.Length - 1)
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
