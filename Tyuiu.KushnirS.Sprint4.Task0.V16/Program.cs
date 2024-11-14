using Tyuiu.KushnirS.Sprint4.Task0.V16.Lib;
namespace Tyuiu.KushnirS.Sprint4.Task0.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("* УСЛОВИЕ:                                                      *");
            Console.WriteLine("* Написать программу, которая считает произведение четных       *");
            Console.WriteLine("* элементов массива.                                            *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("*****************************************************************");

            DataService ds = new DataService();

            int[] array = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("Результат:" + ds.GetMultEvenArrEl(array));

            Console.ReadKey();
        }
    }
}
