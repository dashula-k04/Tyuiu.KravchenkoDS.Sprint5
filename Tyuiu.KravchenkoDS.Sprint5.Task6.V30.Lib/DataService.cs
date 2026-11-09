using System.ComponentModel.Design;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KravchenkoDS.Sprint5.Task6.V30.Lib
{
    public class DataService : ISprint5Task6V30
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int length = 0;
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == ' ')
                        {
                            if (length == 8)
                            {
                                count++;
                            }
                            length = 0;

                        }
                        else
                        {
                            length++;
                        }

                    }
                    if (length == 8)
                    {
                        count++;

                    }
                }
         
            }
            return count;
        }
    }
}
