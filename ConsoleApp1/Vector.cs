using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vector
    {

        public double Lenght(double x, double y)
        {

            double lenght = Math.Sqrt(x * x + y * y);

            return lenght;
        }

        public double Scale(int x1, int x2, int y1, int y2)
        {

            double scale = x1 * x2 + y1 * y2;

            return scale;
        }



    }
}
