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
            Length = length;
            Width = width;
            Hight = hight;
            Weigth = weight;
        }
    }

}
