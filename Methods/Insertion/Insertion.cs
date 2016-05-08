using Methods.Shared;
using System;
using System.Collections.Generic;

namespace Methods.Insertion
{
    public class Insertion : Base
    {
        public Insertion()
        {
            //numbersToSort = PopulateNumbersRandom();
            numbersToSort = PopulateNumberListB();
    }

        public void Run(bool increasing)
        {
            Console.WriteLine("Starting Insertion Example");

            DisplayNumbersToSort();

            RunInsertion(true);

            DisplayNumbersToSort();

            Console.WriteLine("Insertion Example Completed!");
        }

        //Good Source in conceptually explaining an insertion sort - https://www.youtube.com/watch?v=baV_W4-x5Wg
        private void RunInsertion(bool increasingOrder)
        {          
            for (int ctr = 0; ctr < numbersToSort.Count; ctr++)
            {     
                //handle first two elements
                if (ctr == 0 && numbersToSort[ctr] > numbersToSort[ctr + 1])
                {
                    int tmp = numbersToSort[ctr];
                    numbersToSort[ctr] = numbersToSort[ctr + 1];
                    numbersToSort[ctr + 1] = tmp;
                    ctr = 1; 
                }

                //then, work each next val backwards through array
                else
                {
                    int indexFlip = -1;  //non-reachable index

                    //find the 'insert' point that our next value fits in
                    for (int subCtr = ctr; subCtr > 0; subCtr--)
                    {
                        if ((subCtr - 1) < 0)
                            break;

                        if (numbersToSort[ctr] < numbersToSort[subCtr-1])
                        {
                            indexFlip = subCtr - 1;
                        }
                    }

                    //if we have a flix index, move values up and insert new value
                    if (indexFlip > -1)
                    {
                        int compareVal = numbersToSort[ctr];
                        int flipCtr = ctr;

                        while(flipCtr > indexFlip)
                        {
                            numbersToSort[flipCtr] = numbersToSort[flipCtr - 1];

                            flipCtr--;
                        }

                        numbersToSort[indexFlip] = compareVal;
                    }
                }
            }
        }
    }
}
