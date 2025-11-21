using Tyuiu.Kucherenkonm.Sprint5.Task2.V14.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        int[,] mtrx = new int[3, 3] { { -3, -6, -3 },
                                        { 6, 8, 3 },
                                        { -6, -5, 5 } };
        int rows = mtrx.GetUpperBound(0) + 1;
        int columns = mtrx.Length / rows;
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнила: Кучеренко Н. М. | ИИПб - 25 - 1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #14                                                             *");
        Console.WriteLine("* Выполнила: Кучеренко Надежда Михайловна | ИИПб - 25 - 1                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*          Массив заполнен элементами. Заменить положительные             *");
        Console.WriteLine("*             элементы массива на 1, отрицательные на 0.                  *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Массив: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{mtrx[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.SaveToFileTextData(mtrx);
        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}