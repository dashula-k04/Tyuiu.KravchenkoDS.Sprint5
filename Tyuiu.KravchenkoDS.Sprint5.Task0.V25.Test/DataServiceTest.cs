using System.IO;


using Tyuiu.KravchenkoDS.Sprint5.Task0.V25.Lib;


namespace Tyuiu.KravchenkoDS.Sprint5.Task0.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            FileInfo fileInfo = new FileInfo(path);

            DataService ds = new DataService();
            ds.SaveToFileTextData(3); 

            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
