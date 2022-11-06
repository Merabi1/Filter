using SevenSpikes.Nop.Plugins.AjaxFilters.Models.AttributeFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilterOfFIlter
{
    public class RemoveDuplicateItems
    {
        public List<AttributeFilterItem> RemoveDuplicateItemsOfList(IList<AttributeFilterItem> Items)
        {
            var SavedItems = new List<AttributeFilterItem>();

            foreach (var item in Items)
            {
                var attrs = Items.FindByName(item.Name);

                AttributeFilterItem attr = null;

                if (SavedItems.ExistsName(item.Name))
                    continue;

                ChangeProductsAttrLocation(attrs, ref attr);

                SavedItems.Add(attr);
            }

            return SavedItems;
        }

        private void ChangeProductsAttrLocation(List<AttributeFilterItem> attrs, ref AttributeFilterItem attr)
        {
            for (int i = 0; i < attrs.Count; i++)
                if (i == 0)
                    attr = attrs[i];
                else
                    foreach (var productNumber in attrs[i].ProductVariantAttributeIds)
                        attr.ProductVariantAttributeIds.Add(productNumber);
        }
    }
}
