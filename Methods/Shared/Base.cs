using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Shared
{
    public class Base
    {
        protected IList<int> numbersToSort = null;
        
        protected void DisplayNumbersToSort()
        {            
            foreach(int number in numbersToSort)
                Console.WriteLine(number.ToString());

            Console.WriteLine("");
        }
        
        protected IList<int> PopulateNumbersDescending()
        {
            IList<int> numbersToSort = new List<int>();

            numbersToSort.Add(10);
            numbersToSort.Add(9);
            numbersToSort.Add(8);
            numbersToSort.Add(7);
            numbersToSort.Add(6);
            numbersToSort.Add(5);
            numbersToSort.Add(4);
            numbersToSort.Add(3);
            numbersToSort.Add(2);
            numbersToSort.Add(1);

            return numbersToSort;
        }
        
        protected IList<int> PopulateNumbersRandom()
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
