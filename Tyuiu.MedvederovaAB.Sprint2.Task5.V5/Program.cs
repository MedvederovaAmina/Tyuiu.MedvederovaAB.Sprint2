using System.ComponentModel.Design;
using Tyuiu.MedvederovaAB.Sprint2.Task5.V5.Lib;

DataService ds = new DataService();
Console.Title = "Спринт #2  |  Выполнила: Медведерова А. Б.  |  ПКТб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Оператор switch.                                                  *");
Console.WriteLine("* Задание: #5                                                             *");
Console.WriteLine("* Вариант: #5                                                             *");
Console.WriteLine("* Выполнила: Медведерова Амина Борисовна | ПКТб-24-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет требуемое значение и возвращает   *");
Console.WriteLine("* результат.                                                              *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(" Введите номер карты: ");
int numCard = Convert.ToInt32(Console.ReadLine());
string res;
if ((numCard < 6) || (numCard > 14))
{
    res = " Введено неверное значение! ";
}
else
{
    res = " Эта карта: " + ds.FindCardValue(numCard);
}
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(res);
Console.ReadKey();
