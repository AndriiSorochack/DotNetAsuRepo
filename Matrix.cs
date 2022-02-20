using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_14
{
    internal class Matrix
    { 
        private int[,] _matrix;
        private bool _isMatrixInitialized; //по дефолту false

        // замість private set можещ заюзати init
        public int Size { get; private set; }

        public Matrix(int size)
        {
            Size = size;
            _matrix = new int[size, size];
        }

        public void InitializeMatrix()
        {
            Console.WriteLine("Entering values of matrix:");

            for (int i = 0; i < Size; i++)
            {
                //Ініціалізуються рядки
                bool isConsoleArrayCoorrect = false;

                while (!isConsoleArrayCoorrect)
                {
                    string valuesFromConsole = Console.ReadLine();

                    // .Split(" ") також повертає масив
                    string[] separatedValues = valuesFromConsole.Split(" ");

                    if (separatedValues.Length != Size)
                    {
                        Console.WriteLine("Incorect amount of values!");
                        continue;
                    }

                    for (int j = 0; j < Size; j++)
                    {
                        //Parse - один зі способів взяти значення зі строки
                        //TryParse поверне false якщо конвертнути значенння не вдалось, а саме значення запишеться в out int integerValue
                        //за допомогою out ти можеш зробити так, щоб функція повертала багато результатів, не лише через out, а ще через out
                        //від недавно ти можеш в самому out ініціалізувати зміну, головне вписати там її тип даних

                        bool result = int.TryParse(separatedValues[j], out int integerValue);

                        if (result == false)
                        {
                            Console.WriteLine("Incorect data is entered!");
                            isConsoleArrayCoorrect = false;
                            break;
                        }

                        _matrix[i, j] = integerValue;
                        isConsoleArrayCoorrect = true;
                    }

                    if (!isConsoleArrayCoorrect)
                    {
                        i--;
                        break;
                    }
                }
            }

            _isMatrixInitialized = true;
        }

        public void PrintMatrix()
        {
            Console.WriteLine("\n Matrix:");

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    // це називається string interpolation
                    Console.Write($"{_matrix[i, j]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public int? GetTraceOfMatrix()
        {
            if (!_isMatrixInitialized)
            {
                Console.WriteLine("Matrix is not initialized!");
                return null;
            }

            int traceOfMatrix = 0;

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (i == j)
                    {
                        traceOfMatrix += _matrix[i, j];
                    }
                }
            }

            return traceOfMatrix;
        }

        public int? GetSumOfElementsAboveMainDiagonal()
        {
            if (!_isMatrixInitialized)
            {
                Console.WriteLine("Matrix is not initialized!");
                return null;
            }

            int sum = 0;

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (i < j)
                    {
                        sum += _matrix[i, j];
                    }
                }
            }

            return sum;
        }

        //? для того, щоб інт міг зберігати null - загугли nullable types
        public int? GetSumOfElementsBeloveMainDiagonal()
        {
            if (!_isMatrixInitialized)
            {
                Console.WriteLine("Matrix is not initialized!");
                return null;
            }

            int sum = 0;

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (i > j)
                    {
                        sum += _matrix[i, j];
                    }
                }
            }

            return sum;
        }

        ~Matrix()
        {

        }
    }

}
