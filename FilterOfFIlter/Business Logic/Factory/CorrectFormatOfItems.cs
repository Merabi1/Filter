using SevenSpikes.Nop.Plugins.AjaxFilters.Models.AttributeFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilterOfFIlter
{
    public class CorrectFormatOfItems
    {
        public List<AttributeFilterItem> CorrectFormatOfItemsOfList(IList<AttributeFilterItem> attributeFilterItems)
        {
            var count = attributeFilterItems.Count;
            for (int i = 0; i < count; i++)
            {
                var name = attributeFilterItems[i].Name;

                int index = name.Replace(" ", "").ToLower().IndexOf("სმ/cm");
                if (index != -1)
                {
                    attributeFilterItems[i].Name = name.Replace(" ", "").ToLower().Insert(index, " ");
                    attributeFilterItems.Insert(i, attributeFilterItems[i]);
                    attributeFilterItems.Remove(attributeFilterItems[i]);
                }
            }
            return attributeFilterItems.ToList();
        }
    }
}
