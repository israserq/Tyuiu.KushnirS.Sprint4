using Tyuiu.KushnirS.Sprint4.Task7.V5.Lib;
namespace Tyuiu.KushnirS.Sprint4.Task7.V5
{
    public class Class1
    {
        public static void Main()
        {
            DataService ds = new DataService();
            int result;

            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие: Дана строка из одноразрядных цифр.                             *\n" +
                              "* Преобразуйте ее в матрицу 3 на 3 и подсчитайте количество четных чисел. *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.Write("* Строка = ");
            string input = Console.ReadLine();
            Console.WriteLine("Массив:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(input.Substring(j * 3 + i, 1) + "; ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");

            { 
                result = ds.Calculate(3, 3, input);
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"*  = {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
