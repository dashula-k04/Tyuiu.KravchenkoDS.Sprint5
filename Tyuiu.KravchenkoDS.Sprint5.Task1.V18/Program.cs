using Tyuiu.KravchenkoDS.Sprint5.Task1.V18.Lib;


namespace Tyuiu.KravchenkoDS.Sprint5.Task1.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Кравченко Д. С. | ИСТНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Класс File. Запись набора данных в текстовый файл                       *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнила: Кравченко Дарья Сергеевна | ИСТНб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция на заданном диапазоне [-5, 5] с шагом 1.Произвести проверку*");
            Console.WriteLine("*деления на ноль.При делении на 0 вернуть значение 0.Результат сохранить  *");
            Console.WriteLine("* в текстовый файл OutPutFileTask1.txt,вывести на консоль таблицу." +
                "Округлить значение до двух                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            string[] lines = File.ReadAllLines(res);
            int x = startValue;

            Console.WriteLine("+--------+------------+");
            Console.WriteLine("|   x    |    F(x)    |");
            Console.WriteLine("+--------+------------+");
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine("| {0,6} | {1,10} |", x, lines[i]);
                x++;
            }
            Console.WriteLine("+--------+------------+");

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
