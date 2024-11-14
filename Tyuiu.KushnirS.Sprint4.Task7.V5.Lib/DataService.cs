using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KushnirS.Sprint4.Task7.V5.Lib
{
    public class DataService : ISprint4Task7V5
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] ints = new int[n, m]; int res = 0;
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    ints[i, j] = int.Parse(value.Substring(i * m + j, 1));
                    if (ints[i, j] % 2 == 0) { res++; }
                }
            }
            return res;
        }
    }
}
