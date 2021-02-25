using System;
using System.Globalization;

namespace Frachion
{
    public class Frachion
    {
        public Frachion(int n = 0, int d = 0)
        {
            numerator = n;
            denomianator = d;
            if (!(denomianator == 0 && numerator == 0))
            {
                roun();
            }
        }

        public static Frachion operator +(Frachion f1, Frachion f2)
        {
            Frachion f = new Frachion(); 
            f.denomianator = f1.denomianator * f2.denomianator;
            f.numerator = f1.numerator * f2.denomianator + f2.numerator * f1.denomianator;
            return f;
        }

        public static Frachion operator -(Frachion f1, Frachion f2)
        {
            Frachion f = new Frachion();
            f.denomianator = f1.denomianator * f2.denomianator;
            f.numerator = f1.numerator * f2.denomianator - f2.numerator * f2.denomianator;
            return f;
        }

        public static Frachion operator *(Frachion f1, Frachion f2)
        {
            Frachion f = new Frachion();
            f.denomianator = f1.denomianator * f2.denomianator;
            f.numerator = f1.numerator * f2.numerator ;
            return f;
        }
        public static Frachion operator /(Frachion f1, Frachion f2)
        {
            Frachion f = new Frachion();
            f.denomianator = f1.denomianator * f2.numerator;
            f.numerator = f2.denomianator * f1.numerator ;
            return f;
        }

        public static Frachion operator -(Frachion f1)
        {
            Frachion f = new Frachion();
            f.numerator = - f1.numerator;
            return f;
        }

        public static bool operator <(Frachion f1, Frachion f2)
        {
            return (((f1.numerator * f2.denomianator) - (f2.numerator * f1.denomianator ))< 0);
        }


        public static bool operator ==(Frachion f1, Frachion f2) 
        {
            return (((f1.numerator * f2.denomianator) - (f2.numerator * f1.denomianator)) == 0);
        }

        public static bool operator >(Frachion f1, Frachion f2)
        {
            return ((!(f1==f2))&&(!(f1<f2)));
        }

        public static bool operator !=(Frachion f1, Frachion f2)
        {
            return (!(f1==f2));
        }

        public static bool operator >=(Frachion f1, Frachion f2)
        {
            return ((f1==f2)||(f1>f2));
        }

        public static bool operator <=(Frachion f1, Frachion f2)
        {
            return ((f1 == f2) || (f1 < f2));
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                throw new NullReferenceException();
            if (!(obj is Frachion))
                throw new ArgumentException("Argument should be Frachion type");
            return (numerator == (obj as Frachion).numerator);
        }

        public override int GetHashCode()
        {
            return numerator.GetHashCode();
        }

        public int numerator
        {
            get;
            set;
        }
        public int denomianator
        {
            get;
            set;
        }
        private void roun ()
        {
            if(denomianator==0)
            {
                throw new ArgumentException("деление на 0");
            }
            if (numerator == 0)
            {
                denomianator = 1;
            }
            if(denomianator <0)
            {
                numerator = -numerator;
                denomianator = -denomianator;
            }
            if (numerator != 0)
            {
                int m = Math.Abs(numerator),
                  n = Math.Abs(denomianator),
                  ost = m % n;
                while (ost != 0)
                {
                    m = n; n = ost;
                    ost = m % n;
                }
                int nod = n;
                if (nod != 1)
                {
                    numerator /= nod;
                    denomianator /= nod;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Frachion a = new Frachion(3 , 8);
            Frachion c = new Frachion(24 , 3);
            Frachion b = new Frachion();
            b = a + c;
            
            Console.WriteLine("числитель: {0}", b.numerator);
            Console.WriteLine("знаменатель: {0}", b.denomianator);
            if (a < c)
            {
                Console.WriteLine("+");
            };
        }
    }





}
