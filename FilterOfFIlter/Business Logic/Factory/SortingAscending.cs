using SevenSpikes.Nop.Plugins.AjaxFilters.Models.AttributeFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilterOfFIlter
{
    public class SortingAscending
    {
        public IList<AttributeFilterItem> FilterSorterToAscending(IList<AttributeFilterItem> attrFilterItems,List<string> Names)
        {
            List<AttributeFilterItem> returnAttrFilterItems = new List<AttributeFilterItem>();
            for (int i = 0; i < Names.Count; i++)
            {
                var items = attrFilterItems.FindByName(Names[i]);
                if (!returnAttrFilterItems.ExistsName(Names[i]))
                     returnAttrFilterItems.AddRange(items);
            }
            return returnAttrFilterItems;
        }

    }
}
