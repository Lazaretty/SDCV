using System;

namespace ShapesLib.Models
{
    public class Circle : IShape
    {
        public double mesaure { get; set; }
        public double radius;
        public string mesaureName { get; set; }
        public Circle(double Radius)
        {
            radius = Radius;
            mesaure = Radius;
        }

        public Circle(double Radius, string MesaureName)
        {
            radius = Radius;
            mesaureName = MesaureName;
            if (mesaureName == "C")
            {
                CountPerimetr();
            }
            else
            {
                if (mesaureName == "S")
                {
                    CountArea();
                }
                else
                    mesaure = 0;
            }
        }

        public void CountArea()
        {
            mesaure = Math.PI * radius * radius;
            mesaureName = "P";
        }

        public void CountPerimetr()
        {
            mesaure = 2 * Math.PI * radius;
            mesaureName = "S";
        }
    }
}
