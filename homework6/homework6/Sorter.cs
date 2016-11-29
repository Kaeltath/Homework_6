using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    class Sorter
    {
        
        private int[] sortArray;

        public Sorter()
        {
            sortArray = new int[3];
        }

        public Sorter(int[] sortArray)
        {
            this.sortArray = sortArray;
        }

        protected void Swap(int a, int b)
        {
            int temp = 0;
            temp = sortArray[a];
            sortArray[a] = sortArray[b];
            sortArray[b] = temp;
        }

        public void Print()
        {
            foreach (int i in sortArray)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
