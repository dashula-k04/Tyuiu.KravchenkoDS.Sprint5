using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KravchenkoDS.Sprint5.Task5.V14.Lib
{
    public class DataService : ISprint5Task5V14
    {
        public double LoadFromDataFile(string path)
        {
            double max = -1000000;
            string str = File.ReadAllText(path);
            string[] nums = str.Split(' ');

            for (int i = 0; i < nums.Length; i++)
            {
                string temp = nums[i].Replace('.', ',');

                if (double.TryParse(temp, out double num))
                {
                    if (num % 1 == 0 && num % 3 == 0)
                    {
                        if (num > max)
                        {
                            max = num;
                        }
                    }
                }
            }
            double fact = 1;
            int n = Convert.ToInt32(max);

            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }

            return Math.Round(fact, 3);
        }


    }
}


            
       
        

    

    

