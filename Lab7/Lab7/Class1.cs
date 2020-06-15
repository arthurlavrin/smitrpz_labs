using System;
using System.Drawing;

namespace Lab7
{
    public class PiMonteCarlo
    {
        public const int circle_Radius = 1;
        PointF Origin = new PointF(0,0);

        public double Calculate(double totalPointsCount)
        {
            long circlePointsCount = 0;
            for (int i = 0; i < totalPointsCount; i++)
            {
                double x= new Random().NextDouble()*circle_Radius;
                double y= new Random().NextDouble()*circle_Radius;
                if (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(circle_Radius, 2))
                {
                    circlePointsCount++;
                }
            }

            return (4 * circlePointsCount) / totalPointsCount;
        }

    }
}
