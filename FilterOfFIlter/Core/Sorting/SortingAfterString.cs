using System;
using System.Collections.Generic;
using System.Text;

namespace FilterOfFIlter
{

    public class SortingAfterString : ISortingAfterString
    {
        private readonly IComparer<string> _comparerAfterString;
        public SortingAfterString(IComparer<string> comparerAfterString)
        {
            _comparerAfterString = comparerAfterString;
        }

        public void NumberSortingAfterString(ref List<string> list)
        {
            list.Sort(_comparerAfterString);
        }
    }
}
