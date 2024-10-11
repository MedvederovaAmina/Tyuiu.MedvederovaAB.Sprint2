using Tyuiu.MedvederovaAB.Sprint2.Task1.V25.Lib;

namespace Tyuiu.MedvederovaAB.Sprint2.Task1.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 247;
            int b = 155;
            int c = 325;
            int d = 857;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations( a, b, c, d);
            Console.Title = "Спринт #2  |  Выполнила: Медведерова А. Б.  |  ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции.                                              *");
            Console.WriteLine("* Задание: #1                                                             *");
            Console.WriteLine("* Вариант: #25                                                            *");
            Console.WriteLine("* Выполнила: Медведерова Амина Борисовна | ПКТб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и арифметических выражений,    *");
            Console.WriteLine("* которая вернет логическую последовательность (массив).                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" a = " + a);
            Console.WriteLine(" b = " + b);
            Console.WriteLine(" c = " + c);
            Console.WriteLine(" d  = " + d);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 6; i++)
            { 
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
