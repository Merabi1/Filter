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

        public IList<T> SortingAscending<T>(IList<T> objects,string propertyName)
        {
            if (objects.IsNull())
                return new List<T>();

            List<string> names =  objects.GetNamesList(propertyName);

            _sorter.SortingAfterAndBefore(ref names);

            return new SortingAscending().FilterSorterToAscending(objects, names, propertyName);
        }

        public  IList<T> RemoveDuplicateItems<T>(IList<T> objects,string propertyName)
        {
            if (objects.IsNull())
                return new List<T>();

            return new RemoveDuplicateItems().RemoveDuplicateItemsOfList(objects,propertyName);
        }

        public  IList<T> CorrectFormatOfItems<T>(IList<T> attrFilterItems, string propertyName)
        {
            if (attrFilterItems.IsNull())
                return new List<T>();

            return new CorrectFormatOfItems().CorrectFormatOfItemsOfList(attrFilterItems,propertyName);
        }

    }
}
