using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Equidistance
    {
        public class EuclideanDistance
        {
            public EuclideanDistance()
            {
            }

            public float CalculateDistance(Point2D point1, Point2D point2)
            {
                float valueOfX = point2.x - point1.x;

                float valueOfY = point2.y - point1.y;

                return (float)Math.Sqrt((valueOfX * valueOfY) + (valueOfY * valueOfY));
            }
        }
    }
}
