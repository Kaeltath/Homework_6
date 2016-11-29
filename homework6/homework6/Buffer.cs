using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    class Buffer
    {
        protected int[] itemsList;
        protected int counter;

        public Buffer()
        {
            itemsList = new int[5];
        }

         public virtual bool IsFull()
        {
            if (counter > itemsList.Length)
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
