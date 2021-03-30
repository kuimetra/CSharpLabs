// У класі: оголосити один делегат; створити змінну делегата; методи для реєстрації і видалення делегата. У програмі:
// написати 2 функції, на які посилатиметься делегат; проілюструвати використання делегата на прикладі цих функцій.
// Модифікувати програму, щоб введення даних відбувалося з текстового файлу. Дописати обробку хоча б двох виняткових
// ситуацій.

using System.Collections.Generic;
using System.Linq;
using System.IO;
using System;

namespace DelegatesTask6
{
    public class Athlete
    {
        public readonly string Surname;
        public readonly int[] Points;

        public Athlete(string surname, int[] points)
        {
            Surname = surname;
            Points = points;
        }

        public int GetPointsSum()
        {
            return Points.Sum();
        }

        public override string ToString()
        {
            return $"{Surname}: {string.Join(", ", Points)}";
        }

        public delegate void Handler(string message);

        private Handler _del;

        public void DelegateRegister(Handler del)
        {
            _del += del;
            _del.Invoke("Delegate registered.");
        }

        public void DelegateUnregister(Handler del)
        {
            try
            {
                _del -= del;
                _del.Invoke("Delegate unregistered.");
            }
            catch (NullReferenceException e)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
        }
    }

    internal static class Program
    {
        private static void Main()
        {
            var listOfAthletes = new List<Athlete>();
            try
            {
                Console.Write("File name: ");
                var fileName = Console.ReadLine();
                var file = new StreamReader(fileName);
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    var (surname, points) = (line.Split()[0],
                        line.Split()[1].Split(',').Select(int.Parse).ToArray());
                    listOfAthletes.Add(new Athlete(surname, points));
                }

                file.Close();
            }
            catch (IOException e)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("The file could not be read: " + e.Message);
                Console.ResetColor();
                return;
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(e.Message);
                Console.ResetColor();
                return;
            }

            Console.WriteLine("Enter:\n(1) - list of athletes;\n(2) - register/unregister;\n(3) - admitted athletes;" +
                              "\n(4) - winner;\n(0) - exit.");
            var isRequiredAmountSettled = false;
            var setRequiredSumOfPoints = 0;
            var done = false;
            while (!done)
            {
                Console.Write("\n----> ");
                var option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                    {
                        done = true;
                        break;
                    }
                    case 1:
                    {
                        Console.WriteLine("List of athletes:\n№) Surname: Points");
                        var ind = 1;
                        foreach (var athlete in listOfAthletes)
                        {
                            Console.WriteLine($"{ind}) {athlete}");
                            ind++;
                        }

                        break;
                    }
                    case 2:
                    {
                        Console.Write("1 - register a delegate;\n2 - unregister.\n--> ");
                        var choice = int.Parse(Console.ReadLine());
                        int? ind = null;
                        if (choice == 1 || choice == 2)
                        {
                            Console.Write("Enter the serial number of the athlete in the list: ");
                            ind = int.Parse(Console.ReadLine());
                        }

                        Athlete athlete = null;
                        try
                        {
                            if (ind != null)
                                athlete = listOfAthletes[(int) (ind - 1)];
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"{ind} is out of range (1, {listOfAthletes.Count}).");
                            Console.ResetColor();
                        }

                        switch (choice)
                        {
                            case 1:
                                athlete?.DelegateRegister(RegisterMessage);
                                break;
                            case 2:
                                athlete?.DelegateUnregister(RegisterMessage);
                                break;
                            default:
                                Console.WriteLine($"There is no option {choice}.");
                                break;
                        }

                        break;
                    }
                    case 3:
                    {
                        if (!isRequiredAmountSettled)
                        {
                            Console.Write("Enter the required amount of points for admission: ");
                            setRequiredSumOfPoints = int.Parse(Console.ReadLine());
                        }

                        var requiredSumOfPoints = setRequiredSumOfPoints;

                        Console.Write("Enter the serial number of the athlete in the list: ");
                        var ind = int.Parse(Console.ReadLine());
                        try
                        {
                            var admission = listOfAthletes[ind - 1].GetPointsSum() < requiredSumOfPoints
                                ? (Athlete.Handler) Decline
                                : Accept;
                            admission(listOfAthletes[ind - 1].Surname);
                            isRequiredAmountSettled = true;
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"{ind} is out of range (1, {listOfAthletes.Count}).");
                            Console.ResetColor();
                        }

                        break;
                    }
                    case 4:
                    {
                        var winners =
                            listOfAthletes.First(y =>
                                y.GetPointsSum() == listOfAthletes.Max(z => z.GetPointsSum()));
                        Console.WriteLine($"The winner is {winners.Surname}.");

                        break;
                    }
                    default:
                    {
                        Console.Write("Try again.");
                        break;
                    }
                }
            }
        }

        private static void Decline(string surname)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{surname} cannot take part in the next competitions.");
            Console.ResetColor();
        }

        private static void Accept(string surname)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{surname} is admitted to the next competitions.");
            Console.ResetColor();
        }

        private static void RegisterMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}