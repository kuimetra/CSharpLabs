// Задано 2 стрічки, у яких слова відокремлені комами, а в кінці крапка. 
// Утворити нову стрічку зі слів обох стрічок, впорядкованих за зростанням довжини.

using System;

namespace StringTask2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter first string: ");
            var firstString = Console.ReadLine()?.TrimEnd('.');
            Console.Write("Enter second string: ");
            var secondString = Console.ReadLine()?.TrimEnd('.');

            var substrings = (firstString + ',' + secondString).Split(',');

            Array.Sort(substrings, (a, b) => a.Length.CompareTo(b.Length));
            var sortedString = string.Join(',', substrings) + '.';

            Console.WriteLine($"\nSorted string: {sortedString}");
        }
    }
}