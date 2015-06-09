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
        int upVal = 0;
        int downVal = 0;

        public Quick()
        {
            //TODO - works with descending, but not random...fix
            //numbersToSort = PopulateNumbersDescending();
            numbersToSort = PopulateNumbersRandom();
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
            QuickSort();
        }

        private void QuickSort()
        {
            while(upIndex <= downIndex)
            {
                bool upFnd = false;
                bool downFnd = false;

                while(!upFnd || !downFnd)
                {
                    upVal = numbersToSort[upIndex];
                    downVal = numbersToSort[downIndex];

                    if (upVal > pivotVal)
                        upFnd = true;
                    else
                        upIndex++;

                    if (downVal <= pivotVal)
                        downFnd = true;
                    else
                        downIndex--;

                    if (upFnd && downFnd)
                    {
                        numbersToSort[upIndex] = downVal;
                        numbersToSort[downIndex] = upVal;
                        break;
                    }
                    else
                    {
                        if (downIndex <= 0)
                            break;

                        if (upIndex >= (numbersToSort.Count()-1))
                            break;
                    
                        if (upIndex > downIndex)
                            break;
                    }
                }
                
                DisplayNumbersToSort();
            }
        }

        private void SetInitialValues()
        {
            int maxIndex = numbersToSort.Count();
            pivotIndex = maxIndex/2;
            pivotVal = numbersToSort[pivotIndex];
            upIndex = 0;
            downIndex = maxIndex-1;
        }
    }
}
