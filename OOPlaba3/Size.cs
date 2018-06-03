using System;

namespace OOPlaba2
{
    public struct Size
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Hight { get; set; }
        public double Weigth { get; set; }

        public Size(double length, double width, double hight, double weight)
        {
            if (length <= 0 || width <= 0 || hight <= 0 || weight <= 0)
                throw new ArgumentException("Габариты продукции введены неверно");

            Length = length;
            Width = width;
            Hight = hight;
            Weigth = weight;
        }

        public void ShowSize()
        {
            Console.WriteLine($"Габариты:{Length}x{Width}x{Hight}(m) Вес:{Weigth}(kg)");
        }
    }

}