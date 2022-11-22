using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = Convert.ToDouble(Console.ReadLine());
            double length = Circle.GetCircleLength(r);
            double square = Circle.GetCircleSquare(r);
            Console.WriteLine($"{length} \n{square}");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            string dot = Circle.GetCircleDot(r, x, y);
            Console.WriteLine($"{dot}");
            Console.ReadKey();
        }
    }
}
