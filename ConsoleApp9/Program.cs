using FilterOfFIlter;
using SevenSpikes.Nop.Plugins.AjaxFilters.Models.AttributeFilter;
using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IList<AttributeFilterItem> attributeFilterItems = new List<AttributeFilterItem>() {
                new AttributeFilterItem() { Name = "25"},
                new AttributeFilterItem() { Name = "STANDART1" },
                new AttributeFilterItem() { Name = "160x123CM/CM"},
                new AttributeFilterItem() { Name = "160x123CM/CM"},
                new AttributeFilterItem() { Name = "160X123CM/CM"},
                new AttributeFilterItem() { Name = "160X123CM/CM"},
                new AttributeFilterItem() { Name = "160X123CM/CM"},
                new AttributeFilterItem() { Name = "160X123CM/CM"},
                new AttributeFilterItem() { Name = "160X123CM/CM"},
                new AttributeFilterItem() { Name = "160x 123 cm/CM"},
                new AttributeFilterItem() { Name = "50x123 CM/CM" },
                new AttributeFilterItem() { Name = "50X80 CM/CM" },
                new AttributeFilterItem() { Name = "60X90CM+40X60 CM/CM" },
                new AttributeFilterItem() { Name = "50 X 70 CM/CM" },
                new AttributeFilterItem() { Name = "30X45 CM/CM" },
                new AttributeFilterItem() { Name = "70X140 CM/CM" },
                new AttributeFilterItem() { Name = "175X65X65 CM/CM+9X65X65 CM/CM" },
                new AttributeFilterItem() { Name = "17.5X6.5X6.5 CM/CM+9X6.5X6.5 CM/CM+1" },
                new AttributeFilterItem() { Name = "NEWBORN" },
                new AttributeFilterItem() { Name = "ONE SIZE" },
            };
            attributeFilterItems = null;

            MainSorterOfFilter main = new MainSorterOfFilter();
            
            var attributeFilter = main.SortingAscending(attributeFilterItems);
            attributeFilter = main.RemoveDuplicateItems(attributeFilter);
            attributeFilter = main.CorrectFormatOfItems(attributeFilter);


            foreach (var item in attributeFilter)
            {
             Console.WriteLine(item.Name);
            }
        }
    }
}
