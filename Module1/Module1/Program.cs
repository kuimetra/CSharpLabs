using System.Collections.Generic;
using System.Linq;
using System.IO;
using System;

namespace Module1
{
    internal interface ISalary
    {
        float GetSalary();
    }

    internal class Student : IComparable, ISalary
    {
        private readonly string _name;
        private readonly float _averageMark;

        public Student()
        {
            _name = "unknown";
            _averageMark = (float) 0.0;
        }

        public Student(string name, float averagePoint)
        {
            _name = name;
            _averageMark = averagePoint;
        }

        public override string ToString()
        {
            return $"{_name} {_averageMark} (${GetSalary()})";
        }

        public float GetSalary()
        {
            return _averageMark > 4.5 ? 1300 : 0;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            ISalary o = obj switch
            {
                Teacher teacher => teacher,
                Student student => student,
                _ => null
            };
            return GetSalary().CompareTo(o.GetSalary());
        }
    }

    internal class Teacher : IComparable, ISalary
    {
        private readonly string _name;
        private readonly string _post;

        public Teacher()
        {
            _name = "unknown";
            _post = "unknown";
        }

        public Teacher(string name, string post)
        {
            _name = name;
            _post = post.ToLower();
        }

        public override string ToString()
        {
            return $"{_name} {_post} (${GetSalary()})";
        }

        public float GetSalary()
        {
            return _post switch
            {
                "assistant" => 9750,
                "docent" => 11250,
                "professor" => 15350,
                _ => 0
            };
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            ISalary o = obj switch
            {
                Teacher teacher => teacher,
                Student student => student,
                _ => null
            };
            return GetSalary().CompareTo(o.GetSalary());
        }
    }


    internal static class Program
    {
        private static void Main()
        {
            var studentsAndTeachers = new List<ISalary>();
            try
            {
                Console.Write("File name: ");
                var fileName = Console.ReadLine();
                var file = new StreamReader(fileName ?? string.Empty);
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    var info = line.Split(',');
                    var flag = info[0].ToUpper();
                    switch (flag)
                    {
                        case "S":
                            studentsAndTeachers.Add(new Student(info[1], float.Parse(info[2])));
                            break;
                        case "T":
                            studentsAndTeachers.Add(new Teacher(info[1], info[2]));
                            break;
                        default:
                            throw new FormatException("Wrong flag.");
                    }
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

            Console.WriteLine("Enter:\n(1) - see list;\n(2) - sort salaries;" +
                              "\n(3) - teachers with an income of more than $10,000;\n(0) - exit.");
            while (true)
            {
                Console.Write("\n----> ");
                var option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        return;
                    case 1:
                    {
                        var ind = 1;
                        Console.Write("(1) - only students\n(2) - only teachers\n(3) - mixed\n--> ");
                        var choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                foreach (var person in studentsAndTeachers.OfType<Student>())
                                {
                                    Console.WriteLine($"{ind}) {person}");
                                    ind++;
                                }

                                break;
                            case 2:
                                foreach (var person in studentsAndTeachers.OfType<Teacher>())
                                {
                                    Console.WriteLine($"{ind}) {person}");
                                    ind++;
                                }

                                break;
                            case 3:
                                foreach (var person in studentsAndTeachers)
                                {
                                    Console.WriteLine($"{ind}) {person}");
                                    ind++;
                                }

                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine($"There is no option {choice}.");
                                Console.ResetColor();
                                break;
                        }

                        break;
                    }
                    case 2:
                    {
                        Console.Write("(1) - in ascending order\n(2) - in descending order\n--> ");
                        var order = int.Parse(Console.ReadLine());
                        switch (order)
                        {
                            case 1:
                                studentsAndTeachers.Sort();
                                break;
                            case 2:
                                studentsAndTeachers.Sort();
                                studentsAndTeachers.Reverse();
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Incorrect input. Nothing changed.");
                                Console.ResetColor();
                                break;
                        }

                        foreach (var person in studentsAndTeachers) Console.WriteLine(person);
                        break;
                    }
                    case 3:
                    {
                        foreach (var person in studentsAndTeachers)
                            if (person is Teacher teacher && teacher.GetSalary() > 10000)
                                Console.WriteLine(person);
                        break;
                    }
                    default:
                    {
                        Console.Write("No such option. Try again or exit.");
                        break;
                    }
                }
            }
        }
    }
}