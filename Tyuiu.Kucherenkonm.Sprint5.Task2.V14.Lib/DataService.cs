using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.Kucherenkonm.Sprint5.Task2.V14.Lib
{
    public class DataService : ISprint5Task2V14
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutputFileTask2.txt" });
            int rows = matrix.GetLength(0) ;
            int cols = matrix.GetLength(1);
            FileInfo fileinfo = new FileInfo(path);
            bool filexists = fileinfo.Exists;
            if (filexists)
            {
                File.Delete(path);
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if(matrix[i, j] >= 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {

                    if (j != cols - 1)
                    {
                        str = str + matrix[i, j] + ";";
                    }
                    else
                    {
                        str = str + matrix[i, j];
                    }
                }



                    if (i != rows - 1)
                    {
                        File.AppendAllText(path, str + Environment.NewLine);
                    }
                    else
                    {
                        File.AppendAllText(path, str);
                    }

                    str = "";
                }
            return path;
        }
    }
}
