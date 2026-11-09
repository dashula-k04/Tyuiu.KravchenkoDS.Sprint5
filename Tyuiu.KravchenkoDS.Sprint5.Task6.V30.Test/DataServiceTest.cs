using System.IO;
using Tyuiu.KravchenkoDS.Sprint5.Task6.V30.Lib;

namespace Tyuiu.KravchenkoDS.Sprint5.Task6.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V30.txt");
            File.WriteAllText(path, "быстрота скорость страсть программирование и это не все так просто");
            DataService ds = new DataService();
            int res = ds.LoadFromDataFile(path);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V30.txt");
            File.WriteAllText(path, "быстрота скорость страсть программирование и это не все так просто");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }






    }


}
