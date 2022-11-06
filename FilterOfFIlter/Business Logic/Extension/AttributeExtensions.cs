using FilterOfFIlter.Business_Logic.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilterOfFIlter
{
    public static class AttributeExtensions
    {
        public static List<string> GetNamesList<T>(this IList<T> filterItems,string propertyName)
        {
            List<string> Names = new List<string> { };

            foreach (var item in filterItems)
            {
                Names.Add(item.GetValueFromProperty(propertyName).ToString());
            }
            return Names;
        }

        public static List<T> FindByName<T>(this IList<T> Items, string value, string propertyName)
        {
            return Items.ToList().FindAll(x => x.GetValueFromProperty(propertyName).ToString().ToLower().Replace(" ", "") == value.ToLower().Replace(" ", ""));
        }

        public static bool ExistsName<T>(this List<T> List, string value, string propertyName)
        {
            return List.Exists(o => o.GetValueFromProperty(propertyName).ToString().ToLower().Replace(" ", "") == value.ToLower().Replace(" ", ""));
        }
    }
}
