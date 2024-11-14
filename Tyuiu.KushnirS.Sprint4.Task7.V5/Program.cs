using Tyuiu.KushnirS.Sprint4.Task7.V5.Lib;
namespace Tyuiu.KushnirS.Sprint4.Task7.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string v = "695324951753684";
            int n = 5, m = 3;
           
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр.                                      *");
            Console.WriteLine("* Преобразуйте ее в матрицу 5 на 3 и подсчитайте сумму нечетных чисел.    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* 695324951753684                                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Произведение четных элементов массива равно " + ds.Calculate(n, m, v));
            Console.ReadLine();
        }
    }
}
