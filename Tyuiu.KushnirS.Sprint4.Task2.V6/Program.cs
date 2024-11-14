using Tyuiu.KushnirS.Sprint4.Task2.V6.Lib;
namespace Tyuiu.KushnirS.Sprint4.Task2.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 15 элементов                     *");
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 2 до 8               *");
            Console.WriteLine("* подсчитать произведение нечетных элементов random массива.              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");


            DataService ds = new DataService();
            Random rnd = new Random();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите количество элементов в массиве");
            int len = Convert.ToInt32(Console.ReadLine());


            int[] numsArray = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                numsArray[i] = rnd.Next(2, 8);
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine(numsArray[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Произведение нечётных элементов массива: ");
            Console.WriteLine(ds.Calculate(numsArray));

            Console.ReadKey();
        }
    }
}
