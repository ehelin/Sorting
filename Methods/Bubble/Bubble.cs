using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Bubble
{
    public class Bubble
    {
        private IList<int> numbersToSort = null;

        public Bubble(IList<int> pNumbersToSort)
        {
            numbersToSort = pNumbersToSort;
        }

        //This sort method compares each number next to the other and if it is greater (or less),
        //then swaps positions...essentially 'bubbling' up to the top or bottom of the list of numbers.
        public void Run(bool increasing)
        {
            Console.WriteLine("Starting Bubble Example");

            DisplayNumbersToSort();

            RunBubble(increasing);
            
            DisplayNumbersToSort();

            Console.WriteLine("Bubble Example Completed!");
        }

        private void SetMsgStart(bool increasing, string action)
        {
            if (increasing)
                Console.WriteLine("Bubble Increasing Sort " + action);
            else
                Console.WriteLine("Bubble Decreasing Sort " + action);
        }

        private void RunBubble(bool increasing)
        {
            int runCtr = 0;
            int ctr = 0;
            int outerCtr = 0;
            
            SetMsgStart(increasing, "Starting");

            while(outerCtr <= numbersToSort.Count())
            {
                ctr = 0;

                while(ctr <= numbersToSort.Count())
                {
                    Console.WriteLine("Run " + runCtr.ToString());

                    if ((ctr + 1) >= numbersToSort.Count())
                        break;

                    int curVal = numbersToSort[ctr];
                    int nextVal = numbersToSort[ctr + 1];
                    
                    Swap(increasing, curVal, nextVal, ctr);
                    DisplayNumbersToSort();

                    runCtr++;
                    ctr++;
                }

                outerCtr++;
            }
            
            SetMsgStart(increasing, "Complete");
        }

        private void Swap(bool increasing, int curVal, int nextVal, int ctr)
        {            
            if (increasing)
            {
                if (curVal > nextVal)
                {
                    numbersToSort[ctr] = nextVal;
                    numbersToSort[ctr + 1] = curVal;
                }
            }
            else
            {
                if (curVal < nextVal)
                {
                    numbersToSort[ctr] = nextVal;
                    numbersToSort[ctr + 1] = curVal;
                }
            }
        }

        private void DisplayNumbersToSort()
        {            
            foreach(int number in numbersToSort)
                Console.WriteLine(number.ToString());

            Console.WriteLine("");
        }
    }
}
