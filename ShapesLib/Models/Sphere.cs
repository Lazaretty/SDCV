using System;

namespace ShapesLib.Models
{
    public class Sphere : IShape
    {
        public double mesaure { get; set; }
        public double radius;
        public string mesaureName { get; set; }
        public Sphere(double Radius)
        {
            radius = Radius;
            mesaure = Radius;
        }
        public Sphere(double Radius, string MeasureName)
        {
            radius = Radius;
            mesaureName = MeasureName;
            if (mesaureName == "V")
            {
                CountVolume();
            }
            else
            {
                if (mesaureName == "SA")
                {
                    CountSurfaceArea();
                }
                else
                    mesaure = 0;
            }
        }
        public void CountVolume()
        {
            mesaure = 4 / 3 * Math.PI * radius * radius * radius;
            mesaureName = "V";
        }
        public void CountSurfaceArea()
        {
            mesaure = 4 * Math.PI * radius * radius;
            mesaureName = "SA";
        }
    }
}
