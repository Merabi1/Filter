using SevenSpikes.Nop.Plugins.AjaxFilters.Models.AttributeFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilterOfFIlter
{
    public static class AttributeExtensions
    {
        public static List<string> GetNamesList(this IList<AttributeFilterItem> attrFilterItems)
        {
            List<string> Names = new List<string> { };

            foreach (var item in attrFilterItems)
            {
                Names.Add(item.Name);
            }
            return Names;
        }

        public static List<AttributeFilterItem> FindByName(this IList<AttributeFilterItem> Items, string Name)
        {
            return Items.ToList().FindAll(x => x.Name.ToLower().Replace(" ", "") == Name.ToLower().Replace(" ", ""));
        }

        public static bool ExistsName(this List<AttributeFilterItem> List, string Name)
        {
            return List.Exists(o => o.Name.ToLower().Replace(" ", "") == Name.ToLower().Replace(" ", ""));
        }
    }
}
