using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MedvederovaAB.Sprint2.Task7.V13.Lib
{
    public class DataService : ISprint2Task7V13
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((y <= 1) && (x - y <= 1) && (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1))
            {
                res = true;
            }
            else
            {
                 res = false;
            }
            return res;
        }
    }
}
