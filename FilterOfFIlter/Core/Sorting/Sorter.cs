using System;
using System.Collections.Generic;
using System.Text;

namespace FilterOfFIlter
{
    public class Sorter : ISorter
    {
        private readonly ISortingAfterString _sortingAfter; 
        private readonly ISortingBeforeString _sortingBefore;
        public Sorter(ISortingAfterString sortingAfter, ISortingBeforeString sortingBefore)
        {
            _sortingAfter = sortingAfter;
            _sortingBefore = sortingBefore;
        }
        public void SortingAfterAndBefore(ref List<string> list)
        {
            _sortingAfter.NumberSortingAfterString(ref list);
            _sortingBefore.NumberSortingBeforeString(ref list);
        }
    }
}
