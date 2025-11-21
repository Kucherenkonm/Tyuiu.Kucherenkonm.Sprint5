using Tyuiu.Kucherenkonm.Sprint5.Task0.V29.Lib;
namespace Tyuiu.Kucherenkonm.Sprint5.Task0.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\stysh\source\repos\Tyuiu.Kucherenkonm.Sprint5\Tyuiu.Kucherenkonm.Sprint5.Task0.V29\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
