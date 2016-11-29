using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    class InsertionSorter: Sorter
    {
        public int[] sortArray;

        public InsertionSorter(int[] sortArray)  : base(sortArray)
        {
            this.sortArray = sortArray;
        } 

        public void Sort()
        {
            for (int i = 1; i < sortArray.Length; i++)
            {

                int j = i;
                while (j > 0 && sortArray[j] < sortArray[j - 1])
                {
                    Swap(j, j - 1);
                    j--;
                }

            }
        }
        
    }
}
