using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilterOfFIlter
{
    public class SortingAscending
    {
        public IList<T> FilterSorterToAscending<T>(IList<T> attrFilterItems,List<string> Names,string propertyName)
        {
            List<T> returnAttrFilterItems = new List<T>();
            for (int i = 0; i < Names.Count; i++)
            {
                var items = attrFilterItems.FindByName(Names[i], propertyName);
                if (!returnAttrFilterItems.ExistsName(Names[i],propertyName))
                     returnAttrFilterItems.AddRange(items);
            }
            return returnAttrFilterItems;
        }

    }
}
