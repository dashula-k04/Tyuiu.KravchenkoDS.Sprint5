using System.IO;


using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.KravchenkoDS.Sprint5.Task7.V16.Lib
{
    public class DataService : ISprint5Task7V16
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V16.txt");
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string strLine = "";
                    string word = "";

                    for (int i = 0; i < line.Length; i++)
                    {
                        char c = line[i];
                        if (c != ' ')
                        {
                            word += c;
                        }
                        else
                        {
                            if (word.Length == 2)
                            {
                                strLine += "XY";
                            }
                            else
                            {
                                strLine += word;
                            }
                            strLine += " "; 
                            word = "";      
                        }
                    }
                    if (word.Length > 0)
                    {
                        if (word.Length == 2)
                        {
                            strLine += "XY";
                        }
                        else
                        {
                            strLine += word;
                        }
                    }
                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                }
            }

            return pathSaveFile;
        }
    }


}

 

