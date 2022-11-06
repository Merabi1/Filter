using System;
using System.Collections.Generic;
using System.Text;

namespace FilterOfFIlter
{
    public class SortingBeforeString : ISortingBeforeString
    {
        private readonly IComparer<string> _comparerBeforeString;

        public SortingBeforeString(IComparer<string> comparerBeforeString)
        {
            _comparerBeforeString = comparerBeforeString;
        }

        public void NumberSortingBeforeString(ref List<string> list)
        {
            list.Sort(_comparerBeforeString);
        }
    }
}
