using System;

namespace AreaClassLibrary
{
    public static class Circle
    {
        public static double AreaCircle(this double radius)
        {
            try
            {
                if (radius > 0)
                {
                    double result = Math.Round(Math.PI * radius * radius, 2);
                    return result;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }
    }
}
