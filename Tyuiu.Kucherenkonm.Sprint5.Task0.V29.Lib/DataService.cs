using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.Kucherenkonm.Sprint5.Task0.V29.Lib
{
    public class DataService : ISprint5Task0V29
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutputFileTask0.txt" });
            double y = 6.1 * Math.Pow(x,3) + 0.23 * Math.Pow(x,2) + 1.04 * x;
            y = Math.Round(y,3);
            File.WriteAllText(path,Convert.ToString(y));
            return path;
        }
    }
}
