using System.IO;

using Tyuiu.KravchenkoDS.Sprint5.Task4.V12.Lib;


namespace Tyuiu.KravchenkoDS.Sprint5.Task4.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V12.txt");
            File.WriteAllText(path, "2.89");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);

        }
    }
}
