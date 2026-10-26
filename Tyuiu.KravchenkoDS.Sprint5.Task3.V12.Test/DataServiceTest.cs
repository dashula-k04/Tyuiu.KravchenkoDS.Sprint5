using System.IO;

using Tyuiu.KravchenkoDS.Sprint5.Task3.V12.Lib;

namespace Tyuiu.KravchenkoDS.Sprint5.Task3.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
