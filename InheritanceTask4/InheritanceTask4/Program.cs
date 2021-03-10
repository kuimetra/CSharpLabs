// Базовий клас: Продукт; похідні класи: Їжа, Напій. На основі базового класу (який містить 2 поля) створити два
// похідні класи (у кожному по 2 поля). Для кожного з похідних класів визначити два конструктори (за замовчуванням і
// з параметрами), додати по одному власному методу до кожного класу. Створити масив з об’єктів обох похідних класів;
// впорядкувати його за значенням першого поля базового класу

using System;
using System.IO;

namespace InheritanceTask4
{
    internal class Product : IComparable
    {
        protected readonly string Brand;
        protected readonly string ProductName;

        public Product()
        {
            Brand = "unknown";
            ProductName = "unknown";
        }

        public Product(string brand, string productName)
        {
            Brand = brand;
            ProductName = productName;
        }

        public override string ToString()
        {
            return $"{Brand} {ProductName}";
        }

        public int CompareTo(object o)
        {
            return o is Product p ? Brand.CompareTo(p.Brand) : throw new Exception("Incomparable objects");
        }
    }

    internal class Food : Product
    {
        private readonly string _nutritionalValue;
        private readonly string _countryOfOrigin;

        public Food() : this("unknown", "unknown", "unknown", "unknown")
        {
        }

        public Food(string brand, string productName, string nutritionalValue, string countryOfOrigin) :
            base(brand, productName)
        {
            _nutritionalValue = nutritionalValue;
            _countryOfOrigin = countryOfOrigin;
        }

        public override string ToString()
        {
            return $"{Brand} {ProductName} {_nutritionalValue} {_countryOfOrigin}";
        }

        public float GetCalories()
        {
            var (protein, fats, carbs) = (float.Parse(_nutritionalValue.Split('/')[0]),
                float.Parse(_nutritionalValue.Split('/')[1]),
                float.Parse(_nutritionalValue.Split('/')[2]));
            return fats * 9 + (protein + carbs) * 4;
        }
    }

    internal class Beverage : Product
    {
        private readonly float _alcoholPercentage;
        private readonly float _size;

        public Beverage() : this("unknown", "unknown", 0, 0)
        {
        }

        public Beverage(string brand, string productName, float alcoholPercentage, float size) : base(brand,
            productName)
        {
            _alcoholPercentage = alcoholPercentage;
            _size = size;
        }

        public override string ToString()
        {
            return $"{Brand} {ProductName} {_alcoholPercentage}%alc./vol. {_size}ml";
        }

        public bool ContainsAlcohol()
        {
            return _alcoholPercentage > 0;
        }
    }

    internal static class Program
    {
        private static void Main()
        {
            Console.Write("File name: ");
            var fileName = Console.ReadLine();
            var fileLines = File.ReadAllLines($"{fileName}.txt");
            var size = int.Parse(fileLines[0]);
            var products = new Product[size];
            var i = 0;
            foreach (var line in fileLines[1..])
            {
                var info = line.Split(',');
                var flag = info[0].ToUpper();
                products[i] = flag switch
                {
                    "P" => new Product(info[1], info[2]),
                    "F" => new Food(info[1], info[2], info[3], info[4]),
                    "B" => new Beverage(info[1], info[2], float.Parse(info[3]), float.Parse(info[4])),
                    _ => throw new Exception("Wrong flag.")
                };
                i++;
            }

            Console.WriteLine(
                "Enter:\n(1) - see product list\n(2) - sort by company name\n(3) - calculate food calories" +
                "\n(4) - list of non-alcoholic beverages\n(5) - list of alcoholic beverages\n(0) - exit");
            while (true)
            {
                Console.Write("\n--> ");
                var option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        return;
                    case 1:
                        foreach (var product in products) Console.WriteLine(product);
                        break;
                    case 2:
                        Console.Write("(1) - A-Z\n(2) - Z-A\n--> ");
                        var order = int.Parse(Console.ReadLine());
                        switch (order)
                        {
                            case 1:
                                Array.Sort(products);
                                break;
                            case 2:
                                Array.Sort(products);
                                Array.Reverse(products);
                                break;
                            default:
                                Console.WriteLine("Incorrect input. Nothing changed.");
                                break;
                        }

                        foreach (var product in products) Console.WriteLine(product);
                        break;
                    case 3:
                        foreach (var product in products)
                            if (product is Food food)
                                Console.WriteLine($"{food} ({food.GetCalories()}kcal)");
                        break;
                    case 4:
                        foreach (var product in products)
                            if (product is Beverage beverage && !beverage.ContainsAlcohol())
                                Console.WriteLine(beverage);
                        break;
                    case 5:
                        foreach (var product in products)
                            if (product is Beverage beverage && beverage.ContainsAlcohol())
                                Console.WriteLine(beverage);
                        break;
                    default:
                        Console.WriteLine("No such option. Try again or exit.");
                        break;
                }
            }
        }
    }
}