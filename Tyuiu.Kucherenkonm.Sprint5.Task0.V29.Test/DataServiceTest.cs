using Tyuiu.Kucherenkonm.Sprint5.Task0.V29.Lib;
namespace Tyuiu.Kucherenkonm.Sprint5.Task0.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\stysh\AppData\Local\Temp\OutputFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
