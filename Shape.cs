using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Shape
    {
        public virtual void CalculatedArea(float pi, float radius)
        {
            float AreaOfCircle = pi * (radius * radius); 
            Console.WriteLine(AreaOfCircle);
        }
    }
    public class Circle : Shape 
    {
        public override void CalculatedArea(float pi,float radius)
        {
           float AreaofCircle = pi * (radius*radius);
            Console.WriteLine(AreaofCircle);
        }
    }
}
