namespace ShapesLib.Models
{
    public class Square : IShape
    {
        public double mesaure { get; set; }
        public string mesaureName { get; set; }
        public double sideLenght { get; set; }

        public Square(double SideLenght)
        {
            sideLenght = SideLenght;
            mesaure = SideLenght;
        }

        public Square(double SideLenght, string MeasureName)
        {
            sideLenght = SideLenght;
            mesaureName = MeasureName;
            if (mesaureName == "P")
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

        public void CountPerimetr()
        {
            mesaure = sideLenght * 4;
            mesaureName = "P";
        }

        public void CountArea()
        {
            mesaure = sideLenght * sideLenght;
            mesaureName = "S";
        }
    }
}
