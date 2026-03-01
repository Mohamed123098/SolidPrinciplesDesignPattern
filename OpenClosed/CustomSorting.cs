using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenForExtensionClosedForModification
{
    internal class CustomSorting : ISortingStrategy<int>
    {
        public void Sorting(List<int> list)
        {
            list.Sort();
            list.Reverse();
            Console.WriteLine("Custom....sorting");
            Console.Write("[");
            foreach (var item in list)
            {
                Console.Write($"{item},");
            }
            Console.Write("\b]\n");
        }
    }
}
