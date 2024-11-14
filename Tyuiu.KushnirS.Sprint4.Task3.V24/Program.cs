using Tyuiu.KushnirS.Sprint4.Task3.V24.Lib;
namespace Tyuiu.KushnirS.Sprint4.Task3.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*  Дан двумерный целочисленный массив 5 на 5 элементов, заполненный       *");
            Console.WriteLine("*  статическими значениями в диапазоне от 1 до 8. Найдите минимальный     *");
            Console.WriteLine("*  элемент во втором столбце массива.                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int[,] numsArray = new int[5, 5] { { 3, 6, 1, 7, 3 }, { 2, 3, 7, 1, 1 },
                { 1, 2, 5, 5, 1 }, { 7, 6, 7, 6, 2 }, { 7, 6, 4, 5, 8 } };

            Console.WriteLine("Массив: ");
            for (int i = 0; i < numsArray.GetLength(0); i++)
            {
                for (int j = 0; j < numsArray.GetLength(1); j++)
                {
                    Console.Write($"{numsArray[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Минимальный элемент во втором столбце массива = {ds.Calculate(numsArray)}");
            Console.ReadKey();
        }
    }
}
