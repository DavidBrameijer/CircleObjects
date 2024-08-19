using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjects
{
    internal class Returns
    {
        public static string ReturnValues(Circle circle)
        {
            return $"Diameter is {circle.CalculateDiameter()}, Circumferrence is {circle.CalculateCircumference()} Area is {circle.CalculateArea()}";
        }
    }
}
