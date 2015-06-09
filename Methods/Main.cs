using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Methods.Bubble;
using Methods.Quick;

namespace Methods
{
    public class Main
    {  
        public void Run()
        {
            //RunBubbleSort();  
            RunQuickSort();         
        }

        private void RunBubbleSort()
        {
            Bubble.Bubble b = new Bubble.Bubble();
            b.Run(true);

            b = new Bubble.Bubble();
            b.Run(false);
        }           
        private void RunQuickSort()
        {
            Quick.Quick q = new Quick.Quick();
            q.Run(true);
        }          
    }
}
