using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KushnirS.Sprint4.Task7.V5.Lib
{
    public class DataService : ISprint4Task7V22
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int mul = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[m * i + j].ToString());
                    Console.WriteLine(m * i + j);
                    if (matrix[i, j] % 2 == 0) mul *= matrix[i, j];
                }
            }
            return mul;
        }
    }
}
