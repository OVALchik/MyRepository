namespace OOPlaba2
{
    public struct Size
    {
        public double Length { get; private set; }
        public double Width { get; private set; }
        public double Hight { get; private set; }
        public double Weigth { get; private set; }

        public Size(double length, double width, double hight, double weight)
        {
            Length = length;
            Width = width;
            Hight = hight;
            Weigth = weight;
        }
    }

}
