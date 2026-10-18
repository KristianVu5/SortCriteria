using System;
using System.Collections.Generic;
using System.Text;

namespace SortCriteria
{
    internal class Class1
    {
        public enum SortCriteria
        {
            ByName,
            ByType,
            BySize,
            ByDate,
        }


        static void Main()
        {
            Console.WriteLine("Please enter the kriteria");
            string input = Console.ReadLine();
            SortCriteria criteria;

            try
            {
                criteria = (SortCriteria)System.Enum.Parse(typeof(SortCriteria), input, true);
            }
            catch
            {
                Console.WriteLine("You must type in a valid criteria");
                string k = Console.ReadLine();
                return;
            }

            Sort(criteria);
            Console.ReadLine();

        }


        public static void Sort(SortCriteria criteria)
        {
            switch (criteria)
            {
                case SortCriteria.ByName:
                    Console.WriteLine("Files/Folders sorted by name");
                    break;
                case SortCriteria.ByType:
                    Console.WriteLine("Files/Folders sorted by type");
                    break;
                case SortCriteria.BySize:
                    Console.WriteLine("Files/Folders sorted by size");
                    break;
                case SortCriteria.ByDate:
                    Console.WriteLine("Files/Folders sorted by date");
                    break;
            }
        }
    }
}
