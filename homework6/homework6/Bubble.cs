using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    internal class BubbleSorter: Sorter
    {
        private int[] sortArray;

        public BubbleSorter(int[] sortArray): base(sortArray)
        {
            this.sortArray = sortArray;
        }


        public void Sort()
        {
            bool swap = true;
            int i = 0;
            while (swap && i < sortArray.Length)
            {
                for (int j = 0; j < sortArray.Length - i - 1; j++)
                {
                    if (sortArray[j] > sortArray[j + 1])
                    {
                        Swap(j, j + 1);
                        swap = true;
                        continue;
                    }
                    swap = false;


                }
                i++;
            }
        }
        
    }
}