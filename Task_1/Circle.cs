using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    static class Circle
    {
        static public double GetCircleLength(double r)
        {
            return 2 * Math.PI * r;
        }
        static public double GetCircleSquare(double r)
        {
            return r * r * Math.PI;
        }
        static public string GetCircleDot(double x, double y, double r)
        {
            double triangle = Math.Sqrt(x * x + y * y);
                if (triangle <= r)
                return "Точка в круге";
                else 
                return "Точка вне круга";
        }
    }
}
