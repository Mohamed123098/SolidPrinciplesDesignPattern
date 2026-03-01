using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenForExtensionClosedForModification
{
    internal class BubbleSort<T> : ISortingStrategy<T>
    {
        public void Sorting(List<T> list)
        {
            list.Sort();
            Console.WriteLine("Bubble... sorting");
            Console.Write("[");
            foreach (var item in list)
            {
                Console.Write($"{item },");
            }
            Console.Write("\b]\n");
        }
    }
}
