using System.Collections.Generic;
using System.Linq;
using System;

namespace InterfacesTask5
{
    internal interface INorm
    {
        float GetNorm();
    }

    internal class ComplexNumber : INorm
    {
        private readonly float _aReal;
        private readonly float _bImaginary;

        public ComplexNumber()
        {
            _aReal = 0;
            _bImaginary = 0;
        }

        public ComplexNumber(float a, float b)
        {
            _aReal = a;
            _bImaginary = b;
        }

        public float GetNorm()
        {
            return (float) (Math.Pow(_aReal, 2) + Math.Pow(_bImaginary, 2));
        }

        public override string ToString()
        {
            return $"Complex number: {_aReal} + {_bImaginary}J";
        }
    }

    internal class Vector : INorm
    {
        private readonly float[] _arr;

        public Vector()
        {
            _arr = new float[] {0};
        }

        public Vector(float[] arr)
        {
            _arr = arr;
        }

        public float GetNorm()
        {
            return _arr.Select(Math.Abs).Max();
        }

        public override string ToString()
        {
            return "Vector: [" + string.Join(", ", _arr) + ']';
        }
    }

    internal class Matrix : INorm
    {
        private readonly int _size;
        private float[,] Mat { get; set; }

        public Matrix()
        {
            _size = 0;
            Mat = new float[_size, _size];
        }

        public Matrix(int size)
        {
            _size = size;
        }

        public void FillMatrix()
        {
            var matrix = new float[_size, _size];
            var listOfRows = new string[_size];
            for (var i = 0; i < _size; i++)
            {
                listOfRows[i] = Console.ReadLine();
                if (listOfRows[i].Split().Length != _size)
                    throw new IndexOutOfRangeException("Invalid amount of matrix row elements.");
                for (var j = 0; j < _size; j++) matrix[i, j] = float.Parse(listOfRows[i].Split()[j]);
            }

            Mat = matrix;
        }

        public float GetNorm()
        {
            List<float> rowSum = new List<float>();

            for (int i = 0; i < _size; ++i)
            {
                float sum = 0;
                for (int j = 0; j < _size; ++j)
                {
                    sum += Math.Abs(Mat[i, j]);
                }

                rowSum.Add(sum);
            }

            if (_size != 0)
                return rowSum.Max();
            return 0;
        }

        public override string ToString()
        {
            return "Matrix: [" + string.Join(", ", Mat.OfType<float>()
                .Select((value, index) => new {value, index})
                .GroupBy(x => x.index / Mat.GetLength(1), x => x.value,
                    (_, floats) => $"[{string.Join(",", floats)}]")) + ']';
        }
    }


    internal static class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter:\nCN - to input complex number;\nV - vector;\nM - matrix;" +
                              "\nQ - quit and see results.");
            var iNorms = new List<INorm>();
            bool done = false;
            var index = 1;
            while (!done)
            {
                Console.Write($"\n[{index}] -> ");
                var flag = Console.ReadLine();
                switch (flag.ToUpper())
                {
                    case "Q":
                        done = true;
                        break;
                    case "CN":
                        Console.Write("Enter a and b: ");
                        var aAndB = Console.ReadLine().Split().Select(float.Parse).ToArray();
                        iNorms.Add(new ComplexNumber(aAndB[0], aAndB[1]));
                        break;
                    case "V":
                        Console.Write("Enter array elements: ");
                        var vector = Console.ReadLine().Split(',').Select(float.Parse).ToArray();
                        iNorms.Add(new Vector(vector));
                        break;
                    case "M":
                        Console.Write("Enter square matrix size: ");
                        var matrixSize = int.Parse(Console.ReadLine());
                        var matrixElement = new Matrix(matrixSize);
                        iNorms.Add(matrixElement);
                        matrixElement.FillMatrix();
                        break;
                    default:
                        Console.Write("Try again.");
                        index--;
                        break;
                }

                index++;
            }

            if (iNorms.Count > 0)
            {
                Console.WriteLine("\nNorms:");
                var ind = 1;
                foreach (var element in iNorms)
                {
                    Console.WriteLine($"[{ind}] {element.GetNorm()}");
                    ind++;
                }

                var minNormElement = iNorms.First(y => y.GetNorm() == iNorms.Min(z => z.GetNorm()));
                var minNorm = iNorms.First(y => y.GetNorm() == iNorms.Min(z => z.GetNorm()));
                Console.WriteLine("\nMin norm = {0} ({1});", minNorm.GetNorm().ToString(), minNormElement);

                var maxNormElement = iNorms.First(y => y.GetNorm() == iNorms.Max(z => z.GetNorm()));
                var maxNorm = iNorms.First(y => y.GetNorm() == iNorms.Max(z => z.GetNorm()));
                Console.WriteLine("Max norm = {0} ({1}).", maxNorm.GetNorm().ToString(), maxNormElement);
            }
            else
            {
                Console.WriteLine("\nArray is empty. Impossible to find the max and min norm.");
            }
        }
    }
}