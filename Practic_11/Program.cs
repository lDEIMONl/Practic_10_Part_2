using System;

namespace Practic_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Заполенение массива случаными числами
            int[,] array = new int[10, 10];
            Random random = new Random();
            Console.WriteLine("Начальный массив");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 10);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            //Сортировка массива по столбцам
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(1); k++)
                    {
                        if (array[j, i] >= array[k, i])
                        {
                            continue;
                        }
                        int temp = array[j, i];
                        array[j, i] = array[k, i];
                        array[k, i] = temp;
                    }
                }
                
            }

            //Вывод отсортированного массива
            Console.WriteLine("\nОтсортированный массив по столбцам");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
