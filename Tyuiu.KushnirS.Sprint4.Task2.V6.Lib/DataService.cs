using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KushnirS.Sprint4.Task2.V6.Lib
{
    public class DataService : ISprint4Task2V6
    {
        public int Calculate(int[] array)
        {
            int pro = 1;
            foreach (int i in array)
            {
                if (i % 2 == 0)
                {
                    pro = pro * i;
                }
            }
            return pro;
        }
    }
}
