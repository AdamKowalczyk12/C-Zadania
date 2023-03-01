using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal struct Ulamek
    {
        public int Licznik { get; set; }
        public int Mianownik { get; set; }


        public Ulamek(int licznik, int mianownik)
        {
            if(mianownik == 0)
            {
                throw new ArgumentException("Mianownik nie może mieć wartość 0");
            }

            Licznik = licznik;
            Mianownik = mianownik;
        }

        public override string ToString()
        {
            return $"{Licznik}/{Mianownik}";
        }

        public static Ulamek operator +(Ulamek a) => a;
        public static Ulamek operator -(Ulamek a) => new Ulamek(-a.Licznik, a.Mianownik);

        public static Ulamek operator +(Ulamek a, Ulamek b)
        {
            return new Ulamek(a.Licznik * b.Mianownik + b.Licznik * a.Mianownik, a.Mianownik * b.Mianownik);
        }

        public static Ulamek operator -(Ulamek a, Ulamek b)
        {
            return a + (-b);
        }

        public static Ulamek operator *(Ulamek a, Ulamek b)
            => new Ulamek(a.Licznik * b.Licznik, a.Mianownik * b.Mianownik);

        public static Ulamek operator *(Ulamek a, int b)
                    => new Ulamek(a.Licznik * b, a.Mianownik * b);

        public static Ulamek operator /(Ulamek a, Ulamek b)
        {
            if (b.Licznik == 0)
            {
                throw new DivideByZeroException();
            }
            return new Ulamek(a.Licznik * b.Mianownik, a.Mianownik * b.Licznik);
        }
    }
}
