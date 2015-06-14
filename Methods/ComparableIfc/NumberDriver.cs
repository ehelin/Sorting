using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.ComparableIfc
{
    public class NumberDriver
    {
        public void Run()
        {
            RunComparableIfc();
        }

        private void RunComparableIfc()
        {
            List<Number> numbers = PopulateNumbers();

            Console.WriteLine("Starting ComparableIfc Example");

            Display(numbers);

            numbers.Sort();
            
            Display(numbers);

            Console.WriteLine("ComparableIfc Example Completed!");
        }

        private List<Number> PopulateNumbers()
        {            
            List<Number> numbers = new List<Number>();
            
            Console.WriteLine("Populating numbers...");

            numbers.Add(new Number(9));
            numbers.Add(new Number(2));
            numbers.Add(new Number(100));
            numbers.Add(new Number(8));
            numbers.Add(new Number(7));
            numbers.Add(new Number(5));
            numbers.Add(new Number(1));
            numbers.Add(new Number(10));

            return numbers;
        }

        private void Display(IList<Number> numbers)
        {
           foreach(Number number in numbers)
               Console.WriteLine(number.Value);
        }
    }
}
