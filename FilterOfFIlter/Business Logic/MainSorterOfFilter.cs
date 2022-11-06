using SevenSpikes.Nop.Plugins.AjaxFilters.Models.AttributeFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FilterOfFIlter
{
    public class MainSorterOfFilter
    {
        private readonly ISorter _sorter;
        public MainSorterOfFilter()
        {
            _sorter = new Sorter(new SortingAfterString(new ComparerAfterString()),
                                 new SortingBeforeString(new ComparerBeforeString()));
        }

        public IList<AttributeFilterItem> SortingAscending(IList<AttributeFilterItem> attrFilterItems)
        {
            if (attrFilterItems.IsNull())
                return new List<AttributeFilterItem>();

            List<string> Names =  attrFilterItems.GetNamesList();

            _sorter.SortingAfterAndBefore(ref Names);

            return new SortingAscending().FilterSorterToAscending(attrFilterItems, Names);
        }

        public  IList<AttributeFilterItem> RemoveDuplicateItems(IList<AttributeFilterItem> attrFilterItems)
        {
            if (attrFilterItems.IsNull())
                return new List<AttributeFilterItem>();

            return new RemoveDuplicateItems().RemoveDuplicateItemsOfList(attrFilterItems);
        }

        public  IList<AttributeFilterItem> CorrectFormatOfItems(IList<AttributeFilterItem> attrFilterItems)
        {
            if (attrFilterItems.IsNull())
                return new List<AttributeFilterItem>();

            return new CorrectFormatOfItems().CorrectFormatOfItemsOfList(attrFilterItems);
        }

    }
}
