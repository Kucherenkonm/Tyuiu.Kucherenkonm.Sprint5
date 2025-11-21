using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.Kucherenkonm.Sprint5.Task3.V14.Lib
{
    public class DataService : ISprint5Task3V14
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutputFileTask3.bin" });
            double y = 4 * Math.Pow(x, 3) / (Math.Pow(x, 3) - 1);
            y = Math.Round(y, 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            return path;
        }
    }
}
