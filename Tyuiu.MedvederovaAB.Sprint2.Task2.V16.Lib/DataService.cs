﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MedvederovaAB.Sprint2.Task2.V16.Lib
{
    public class DataService : ISprint2Task2V16
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if ((x <= 3) && (x >= 5) && (y <= 3) && (y >= 7))
            {
                res = false;
            }
            else 
            {
                res = true;
            }
            if ((x >= 6) && (x <= 7) && (y >= 5) && (y <= 11))
            {
                res = false;
            }
            else
            {
                res = true;
            }
            if ((x >= 8) && (x <= 9) && (y >= 6) && (y >= 6) && (y <= 8))
            {
                res = false;
            }
            else
            {
                res = true;
            }
            if ((x >= 10) && (x <= 12) && (y >= 7) && (y <= 7))
            {
                res = false;
            }
            else 
            {
                res = true;
            }
            if ((x >= 13) && (x <= 14) && (y >= 3) && (y <= 10))
            {
                res = false;
            }
            else
            {
                res = true;
            }
            if ((x >= 3) && (x <= 5) && (y >= 11) && (y <= 11))
            {
                res = false;
            }
            else
            {
                res = true;
            }
            if ((x >= 3) && (x <= 3) && (y >= 11) && (y <= 13))
            {
                res = false;
            }
            else 
            {
                res = true;
            }
            if ((x >= 7) && (x <= 10) && (y >= 12) && (y <= 12))
            {
                res = false;
            }
            else
            {
                res = true;
            }
            if ((x >= 10) && (x <= 12) && (y >= 13) && (y <= 13))
            {
                res = false;
            }
            else
            {
                res = true ;
            }
            return res;
        }
    }
}
