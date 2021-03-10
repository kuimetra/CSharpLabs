// Відомі бали, набрані кожним з n спортсменів-п’ятиборців у кожному з п’яти видів спорту. 
// Визначити прізвище переможця змагань.

using System.Linq;
using System;

namespace ClassTask3
{
    public class Athlete
    {
        private readonly int[] _points;
        public string Surname { get; }

        public Athlete()
        {
            Surname = "unknown";
            _points = new int[5];
        }

        public Athlete(string surname, int[] points)
        {
            Surname = surname;
            _points = points;
        }

        public int GetPointsSum()
        {
            return _points.Sum();
        }

        public override string ToString()
        {
            return $"{Surname}: {string.Join(", ", _points)} ({GetPointsSum()})";
        }
    }

    internal static class Program
    {
        private static void Main()
        {
            Console.Write("Enter the amount of athletes: ");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter surname and points:");
            var listOfAthletes = new Athlete[n];
            for (var i = 0; i < n; i++)
            {
                Console.Write($"{i + 1})");
                var surnameAndPoints = Console.ReadLine().Split();
                var (surname, points) = (surnameAndPoints[0],
                    surnameAndPoints[1].Split(',').Select(int.Parse).ToArray());
                listOfAthletes[i] = new Athlete(surname, points);
            }

            Console.WriteLine("\nList of athletes:\nSurname: Points (Total)");
            foreach (var athlete in listOfAthletes) Console.WriteLine(athlete);

            var winners = listOfAthletes.Where(y => y.GetPointsSum() ==
                                                    listOfAthletes.Max(z => z.GetPointsSum()));
            Console.WriteLine("\nWinner/s: {0}", string.Join(", ",
                winners.Select(o => o.Surname.ToString())));
        }
    }
}