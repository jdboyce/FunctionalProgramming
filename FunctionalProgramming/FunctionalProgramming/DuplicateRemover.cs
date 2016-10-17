
using System;
using System.Collections.Generic;
using System.Linq;


namespace FunctionalProgramming
{
    class DuplicateRemover
    {
        List<string> nameList;
        List<string> distinctList;

        public DuplicateRemover()
        {
            nameList = new List<string>();
            distinctList = new List<string>();
        }


        public void RunDemo()
        {
            nameList.AddRange(new string[] {"Adam", "Billy", "Billy", "Billy", "Charles", "Deborah", "Emily", "Adam", "Emily", "Emily"});
            Console.WriteLine("\nHere is the list of names before duplicates are removed:\n");
            nameList.ForEach(Console.WriteLine);
            Console.WriteLine("\n\nHere is the list of names after duplicates are removed using the \"Distinct\" extension method:\n");
            RemoveDuplicates(nameList).ForEach(Console.WriteLine);
        }


        public List<string> RemoveDuplicates(List<string> passedList)
        {
            distinctList.AddRange(passedList.Distinct());
            return distinctList;
        }
    }
}
