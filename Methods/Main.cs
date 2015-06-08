using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Methods.Bubble;

namespace Methods
{
    public class Main
    {  
        public void Run()
        {
            RunBubbleSort();         
        }

        private void RunBubbleSort()
        {
            IList<int> numbersToSort = PopulateNumbers();
            Bubble.Bubble b = new Bubble.Bubble(numbersToSort);
            b.Run(true);

            b = new Bubble.Bubble(numbersToSort);
            b.Run(false);
        }   
        
        private IList<int> PopulateNumbers()
        {
            IList<int> numbersToSort = new List<int>();

            numbersToSort.Add(10);
            numbersToSort.Add(1);
            numbersToSort.Add(8);
            numbersToSort.Add(6);
            numbersToSort.Add(4);
            numbersToSort.Add(2);
            numbersToSort.Add(3);
            numbersToSort.Add(5);
            numbersToSort.Add(7);
            numbersToSort.Add(9);

            return numbersToSort;
        }
    }
}
