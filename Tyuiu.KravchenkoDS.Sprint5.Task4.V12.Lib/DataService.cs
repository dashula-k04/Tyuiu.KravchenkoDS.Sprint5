using System.IO;


using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.KravchenkoDS.Sprint5.Task4.V12.Lib
{
    public class DataService : ISprint5Task4V12
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = Convert.ToDouble(strX.Replace('.', ','));
            double res = Math.Round(Math.Cos(Math.Pow(x, 3)) + x / 2,3);
            return res;
        }
    }
}
