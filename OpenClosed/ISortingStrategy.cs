using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenForExtensionClosedForModification
{
    internal interface ISortingStrategy<T>
    {
        void Sorting(List<T> list);
    }
}
