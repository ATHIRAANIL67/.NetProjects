namespace FlowerPetal
{
    internal class Flower
    {
        private string _flowers;
        public string Flowers
        {
            get { return _flowers; }
            set { _flowers = value; }
        }
        private int _petal;
        public int Petal
        {
            get { return _petal; }
            set { _petal = value; }
        }
        public Flower()
        {}
        public Flower(string flower, int petal)
        {
            _flowers = flower;
            _petal = petal;
        }
    }
}

