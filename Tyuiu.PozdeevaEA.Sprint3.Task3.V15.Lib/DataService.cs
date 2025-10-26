using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PozdeevaEA.Sprint3.Task3.V15.Lib
{
    public class DataService : ISprint3Task3V15
    {
        public int GetMinCharCount(string value, char item)
        {
            int countM = 0;
            int minCount = value.Length;
            foreach (char m in value)
            {
                if (m == 'm')
                {
                    countM++;
                }
                else
                {
                    if (countM >= 2 && countM < minCount)
                    {
                        minCount = countM;
                    }
                    countM = 0;
                }
            }
            
            return minCount;
        }
    }
}
