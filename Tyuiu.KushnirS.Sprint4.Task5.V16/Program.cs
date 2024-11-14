using Tyuiu.KushnirS.Sprint4.Task5.V16.Lib;
namespace Tyuiu.KushnirS.Sprint4.Task5.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

           
            Console.WriteLine("* УСЛОВИЕ:" + String.Concat(Enumerable.Repeat(" ", 64)) + "*");
            Console.WriteLine("* Написать програму, которая заменяет положительные элементы массива на 1 *");
            Console.WriteLine("* и печатает массив на экран.                                             *");
            Console.WriteLine("*" + String.Concat(Enumerable.Repeat(" ", 73)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:" + String.Concat(Enumerable.Repeat(" ", 56)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

            Console.WriteLine("Введите количевство строк матрицы: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количевство столбцов матрицы: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = rnd.Next(-6, 3);
                }
            }

            Console.WriteLine("\nМатрица:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine($"* Результат:{String.Concat(Enumerable.Repeat(" ", 62))}*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

            for (int i = 0; i < ds.Calculate(matrix).GetLength(0); i++)
            {
                for (int j = 0; j < ds.Calculate(matrix).GetLength(1); j++)
                {
                    Console.Write($"{ds.Calculate(matrix)[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
