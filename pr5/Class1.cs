using System;

namespace TriangleApp
{
    public class Triangle
    {
        //стороны треугольника
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        //вычисление периметра
        public double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }

        // Перегруженный метод для установки сторон
        public void SetParams(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        // Перегруженный метод увеличения треугольника в 2 раза
        public void SetParams(double dvax)
        {
            SideA *= dvax;
            SideB *= dvax;
            SideC *= dvax;
        }
    }
}