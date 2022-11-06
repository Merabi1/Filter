using FilterOfFIlter.Business_Logic.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilterOfFIlter
{
    public class RemoveDuplicateItems
    {
        public List<T> RemoveDuplicateItemsOfList<T>(IList<T> objects,string propertyName)
        {
            var SavedItems = new List<T>();

            foreach (var item in objects)
            {
                var getValueFromProp = item.GetValueFromProperty(propertyName).ToString();

                var items = objects.FindByName(getValueFromProp, propertyName);

                T @object = default;

                if (SavedItems.ExistsName(getValueFromProp, propertyName))
                    continue;

                //ChangeProductsAttrLocation(items, ref @object);

                SavedItems.Add(@object);
            }

            return SavedItems;
        }

     /*   private void ChangeProductsAttrLocation<T>(List<T> objects, ref T attr)
        {
            for (int i = 0; i < objects.Count; i++)
                if (i == 0)
                    attr = objects[i];
                else
                    foreach (var productNumber in objects[i].ProductVariantAttributeIds)
                        attr.ProductVariantAttributeIds.Add(productNumber);
        }*/
    }
}
