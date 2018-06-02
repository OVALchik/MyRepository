namespace OOPlaba2
{
    public abstract class Production
    {       
        public string NameProduction { get; private set; }
        public Size SizeProduction { get; private set; }
        public int CountProduction { get; private set; }
        public decimal PriceProduction { get; private set; }

        protected Production(string name, Size size, int count, decimal price)
        {
            NameProduction = name;
            SizeProduction = size;
            CountProduction = count;
            PriceProduction = price;
        }

        public abstract void ShowInfoProduction();

    }
}
