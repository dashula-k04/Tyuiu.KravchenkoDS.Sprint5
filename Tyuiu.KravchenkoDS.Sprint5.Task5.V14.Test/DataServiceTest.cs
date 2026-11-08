using System.IO;


using Tyuiu.KravchenkoDS.Sprint5.Task5.V14.Lib;


namespace Tyuiu.KravchenkoDS.Sprint5.Task5.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V14.txt");
            File.WriteAllText(path, "17.57 0 -2.02 10 0 2.1 2 7.97 -8.36 12.22 12 17.91 9.43 19.01 -6.82 -4.78 -1 1 0 -8");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);

        }
    }
}
