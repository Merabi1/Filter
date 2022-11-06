using FilterOfFIlter.Business_Logic.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilterOfFIlter
{
    public class CorrectFormatOfItems
    {
        public List<T> CorrectFormatOfItemsOfList<T>(IList<T> items,string propertyName)
        {
            /*            var count = items.Count;
                        for (int i = 0; i < count; i++)
                        {
                            var name = items[i].GetValueFromProperty(propertyName).ToString();

                            int index = name.Replace(" ", "").ToLower().IndexOf("სმ/cm");
                            if (index != -1)
                            {
                                items[i].Name = name.Replace(" ", "").ToLower().Insert(index, " ");
                                items.Insert(i, items[i]);
                                items.Remove(items[i]);
                            }
                        }
                        return items.ToList();*/
            return items.ToList();
        }
    }
}
