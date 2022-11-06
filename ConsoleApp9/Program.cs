using FilterOfFIlter;
using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp9
{
    internal class Program
    {
        class absurduli
        {

            public string Name { get; set; }

        }
        static void Main(string[] args)
        {

            List<absurduli> absurdulis = new List<absurduli>()
            {
              new absurduli(){ Name = "A" },
              new absurduli(){ Name = "D" },
              new absurduli(){ Name = "B" },
              new absurduli(){ Name = "S" },
              new absurduli(){ Name = "E" },
              new absurduli(){ Name = "Q" }

            };

            MainSorterOfFilter main = new MainSorterOfFilter();

            var attributeFilter = main.SortingAscending(absurdulis, "Name");
            attributeFilter = main.RemoveDuplicateItems(attributeFilter, "Name");
            attributeFilter = main.CorrectFormatOfItems(attributeFilter, "Name");


            foreach (var item in attributeFilter)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
