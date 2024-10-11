using Tyuiu.MedvederovaAB.Sprint2.Task3.V4.Lib;

namespace Tyuiu.MedvederovaAB.Sprint2.Task3.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2  |  Выполнила: Медведерова А. Б.  |  ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if - else.                                    *");
            Console.WriteLine("* Задание: #3                                                             *");
            Console.WriteLine("* Вариант: #4                                                             *");
            Console.WriteLine("* Выполнила: Медведерова Амина Борисовна | ПКТб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляетзначение функции y , где           *");
            Console.WriteLine("* пользователь вводит значение переменной x с клавиатуры.                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Введите значение переменной x : ");
            double x = Convert.ToInt32(Console.ReadLine());
            double res = ds.Calculate(x);
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Значение функции = " + res);
            
            Console.ReadKey();
        }
    }
}
