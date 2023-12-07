using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Rectangle
    {
        private float length;
        private float width;
        public Rectangle(float length, float width)
        {
            this.length = length;
            this.width = width;
        }
        public void CalculatedArea()
        {
            float Area = length * width;
            Console.WriteLine(Area);
        }
    }
}

  
