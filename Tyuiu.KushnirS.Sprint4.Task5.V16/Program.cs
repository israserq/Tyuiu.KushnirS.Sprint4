using Tyuiu.KushnirS.Sprint4.Task5.V16.Lib;
namespace Tyuiu.KushnirS.Sprint4.Task5.V16
{

        internal class Program
        {
            static void Main(string[] args)
            {
                Random rnd = new Random();

                DataService ds = new DataService();

                Console.Title = "Спринт #4 | Выполнил: Гурзан.В.М  | СМАРТБ-24-1";
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* Спринт #4                                                               *");
                Console.WriteLine("* Тема: Одномерные массивы. Ввод с клавиатуры                             *");
                Console.WriteLine("* Задание #2                                                              *");
                Console.WriteLine("* Вариант #6                                                              *");
                Console.WriteLine("* Выполнил: Гурзан Владислав Михайлович |  СМАРТБ-24-1                    *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* УСЛОВИЕ:                                                                *");
                Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
                Console.WriteLine("* случайными значениями в диапазоне от -6 до 3. Заменить положительные    *");
                Console.WriteLine("* элементы на 1.                                                          *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
                Console.WriteLine("***************************************************************************");

                Console.Write("Введите количество строк в массиве: ");
                int rows = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите количество столбцов в массиве: ");
                int colums = Convert.ToInt32(Console.ReadLine());

                int[,] mtrx = new int[rows, colums];

                Console.WriteLine("***************************************************************************");

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < colums; j++)
                    {
                        mtrx[i, j] = rnd.Next(-6, 3);
                    }
                }

                Console.WriteLine("\nМассив:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < colums; j++)
                    {
                        Console.Write($"{mtrx[i, j]} \t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
                Console.WriteLine("***************************************************************************");
                int[,] res = ds.Calculate(mtrx);

                Console.WriteLine("\nИтоговый массив:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < colums; j++)
                    {
                        Console.Write($"{mtrx[i, j]} \t" + res);
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }
    }
