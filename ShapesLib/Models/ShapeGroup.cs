using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.NetworkInformation;

namespace ShapesLib.Models
{
    public class ShapeGroup : IShape
    {
        private double Mesaure;
        public double mesaure {
            get
            {
                if (shapes.Count == 0)
                {
                    return 0;
                }
                else
                    return Mesaure;
            }
            set { Mesaure = value; }
        }
        public List<IShape> shapes { get; set; }
        protected string operatoSign { get; set; }
        public ShapeGroup(string OperatotorSign)
        {
            if (OperatotorSign == "+")
            {
                mesaure = 0;
            }

            if (OperatotorSign == "*")
            {
                mesaure = 1.0;
            }

            operatoSign = OperatotorSign;
            shapes = new List<IShape>();

        }
        public void AddToGroup(IShape shape)
        {
            shapes.Add(shape);
            ChangeMesure(shape);
        }
        private void ChangeMesure(IShape shape)
        {
            if (operatoSign == "+")
            {
                mesaure += shape.mesaure;
            }
            else
            {
                if (operatoSign == "*")
                {
                    mesaure *= shape.mesaure;
                }
            }
        }
        private void MakeIndent(int spaceCount)
        {
            for (int i = 0; i < spaceCount; i++)
            {
                Console.Write(" ");
            }
        }
        public void About(int spaceCount = 0)
        {
            //GetMesaure();
            MakeIndent(spaceCount);
            Console.WriteLine("Messaure is {0}", mesaure);
            MakeIndent(spaceCount);
            Console.WriteLine("Operator is {0}", operatoSign);
            MakeIndent(spaceCount);
            Console.WriteLine("Amount of objects in group is {0}\n", shapes.Count);
            foreach (IShape shape in shapes)
            {
                if (shape is ShapeGroup shapeGroup)
                {
                    MakeIndent(spaceCount);
                    Console.WriteLine("{0}", shapeGroup.GetType());
                    shapeGroup.About(spaceCount+4);
                }
                else
                {
                    MakeIndent(spaceCount);
                    Console.WriteLine("{0}, mesaure = {1}\n",shape.GetType(),shape.mesaure);
                }
            }
        }
    }
}
