using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Methods.Shared;

namespace Methods.Quick
{
    //http://www.c-program-example.com/2011/10/c-program-to-implement-quick-sort.html
    public class Quick : Base
    {
        int pivotIndex = 0;
        int pivotVal = 0;
        int upIndex = 0;
        int downIndex = 0;

        public Quick()
        {
            numbersToSort = PopulateNumbers();
        }

        public void Run(bool increasing)
        {
            Console.WriteLine("Starting Quick Example");

            DisplayNumbersToSort();

            RunQuick(increasing);
            
            DisplayNumbersToSort();

            Console.WriteLine("Quick Example Completed!");
        }

        private void RunQuick(bool increasing)
        {
            SetInitialValues();
            SetPartition();
        }

        private void SetPartition()
        {
            while(upIndex <= downIndex)
            {
                int tmpVal = 0;

                if (numbersToSort[upIndex] > pivotVal)
                {
                    tmpVal = numbersToSort[upIndex] ;
                    numbersToSort[upIndex] = numbersToSort[downIndex];
                    numbersToSort[downIndex] = tmpVal;
                }
                else
                    upIndex++;

                if (numbersToSort[downIndex] < pivotVal)
                {
                    tmpVal = numbersToSort[upIndex] ;
                    numbersToSort[upIndex] = numbersToSort[downIndex];
                    numbersToSort[downIndex] = tmpVal;
                }
                else
                    downIndex--;

                this.DisplayNumbersToSort();

                upIndex++;
                downIndex++;
            }
        }

        private void SetInitialValues()
        {
            int maxIndex = numbersToSort.Count()-1;
            pivotIndex = maxIndex/2;
            upIndex = 0;
            downIndex = maxIndex;
        }
    }
}
