namespace Ex1
{
    public class Szescian
    {

        private double _krawedz;

        public double Krawedz { 
            get
            {
                return _krawedz;
            } 
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value");
                }

                _krawedz = value;
            }
        }


        public double ObliczObjetosc()
        {
            return Math.Pow(Krawedz, 3);
        }

        public Szescian(double krawedz)
        {
            Krawedz = krawedz;
        }
    }
}
