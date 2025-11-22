using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.Kucherenkonm.Sprint5.Task4.V24.Lib
{
    public class DataService : ISprint5Task4V24
    {
        public double LoadFromDataFile(string path)
        {
            NumberFormatInfo info = new NumberFormatInfo()
            {
                NumberDecimalSeparator = "."
            };
            string strX = File.ReadAllText(path);
            double x = double.Parse(strX,info);
            double res = Math.Round((Math.Pow(x, -2) + 2) * Math.Sin(x), 3);
            return res;
        }
    }
}
