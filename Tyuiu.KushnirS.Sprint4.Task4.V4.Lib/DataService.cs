using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KushnirS.Sprint4.Task4.V4.Lib
{
    public class DataService : ISprint4Task4V4
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 0; i <= 5 - 1; i++)
            {
                for (int j = 0; j <= 5 - 1; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }
            return matrix;
        }
    }
}
