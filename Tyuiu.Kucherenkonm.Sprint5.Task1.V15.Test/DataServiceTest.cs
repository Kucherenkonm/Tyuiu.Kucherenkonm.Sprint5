using Tyuiu.Kucherenkonm.Sprint5.Task1.V15.Lib;
namespace Tyuiu.Kucherenkonm.Sprint5.Task1.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"C:\Users\stysh\AppData\Local\Temp\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
