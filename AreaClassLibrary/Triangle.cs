using System;

namespace AreaClassLibrary
{
    public static class Triangle
    {
        // calculates the area of a triangle
        public static double AreaTriangle(this double[] sides)
        { 
            var a = sides[0];
            var b = sides[1];
            var c = sides[2];

            if ((a > 0 && b > 0 && c > 0))
            {
                double p = (a + b + c) / 2;
                double result = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);
                return result;
            }
            else
            {
                return 0;
            }
        }

        // finds a right triangle
        public static bool isRightTringle(this double[] sides)
        {
            var a = sides[0];
            var b = sides[1];
            var c = sides[2];

            bool isRight = false;

            if (((a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == a * a + b * b)) 
                    && (a > 0 && b > 0 && c > 0))
                isRight = true;

            return isRight;
        }
    }
}
