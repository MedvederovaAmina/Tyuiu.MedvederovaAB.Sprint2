﻿using Tyuiu.MedvederovaAB.Sprint2.Task2.V16.Lib;

namespace Tyuiu.MedvederovaAB.Sprint2.Task2.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2  |  Выполнила: Медведерова А. Б.  |  ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор if.                                                      *");
            Console.WriteLine("* Задание: #2                                                             *");
            Console.WriteLine("* Вариант: #16                                                            *");
            Console.WriteLine("* Выполнила: Медведерова Амина Борисовна | ПКТб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры и   *");
            Console.WriteLine("* вычисляет находится ли точка с координатами x,y в заштрихованной области *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Введите значение переменной x : " );
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите значение переменной y : " );
            int y = Convert.ToInt32(Console.ReadLine());    
            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);
      
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (res)
            {
                Console.WriteLine("Точка находится вне заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            Console.ReadKey();
        }
    }
}
