using System.IO;
using Tyuiu.Kucherenkonm.Sprint5.Task5.V8.Lib;
namespace Tyuiu.Kucherenkonm.Sprint5.Task5.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V8.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
