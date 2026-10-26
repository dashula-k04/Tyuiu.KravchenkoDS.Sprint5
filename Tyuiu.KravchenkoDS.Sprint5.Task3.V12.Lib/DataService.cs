using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KravchenkoDS.Sprint5.Task3.V12.Lib
{
    public class DataService : ISprint5Task3V12
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutputFileTask3.bin"); 
           
            double wait = Math.Pow(x, 3) / (2 * Math.Pow(x + 5, 2));        
            wait = Math.Round(wait, 3);       
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(wait);
            }

            return path;
        }
    }
}
