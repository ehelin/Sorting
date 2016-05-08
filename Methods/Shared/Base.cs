using System;
using System.Collections.Generic;

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

        protected IList<int> PopulateNumberListA()
        {
            IList<int> numbersToSort = new List<int>();

            numbersToSort.Add(55);
            numbersToSort.Add(2);
            numbersToSort.Add(9);
            numbersToSort.Add(34);
            numbersToSort.Add(99);
            numbersToSort.Add(1);
            numbersToSort.Add(67);
            numbersToSort.Add(44);

            return numbersToSort;
        }
    
        protected IList<int> PopulateNumberListB()
        {
            IList<int> numbersToSort = new List<int>();

            numbersToSort.Add(55);
            numbersToSort.Add(2);
            numbersToSort.Add(9);
            numbersToSort.Add(34);
            numbersToSort.Add(99);
            numbersToSort.Add(1);
            numbersToSort.Add(67);
            numbersToSort.Add(44);
            numbersToSort.Add(55);
            numbersToSort.Add(21);
            numbersToSort.Add(908);
            numbersToSort.Add(324);
            numbersToSort.Add(4);
            numbersToSort.Add(11);
            numbersToSort.Add(69357);
            numbersToSort.Add(5);
            numbersToSort.Add(0);
            numbersToSort.Add(62);
            numbersToSort.Add(94);
            numbersToSort.Add(31);
            numbersToSort.Add(99);
            numbersToSort.Add(14);
            numbersToSort.Add(72);
            numbersToSort.Add(7);

            return numbersToSort;
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
