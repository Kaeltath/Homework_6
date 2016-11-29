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
        
        public Buffer()
        {
            queue = new int[5];
        }

        public virtual int Counter { set ; get; }


        public virtual bool IsFull()
        {
            if (Counter > queue.Length)
            {
                return true;
            }

            return false;

        }

        public virtual bool IsEmpty()
        {
            if (Counter == 0)
            {
                return true;
            }

            return false;

        }
    }
}
