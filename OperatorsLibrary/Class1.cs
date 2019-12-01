using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsLibrary
{
    public class Fraction
    {
        protected long Numerator;
        protected long Denominator;

        public Fraction(long numerator, long denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public Fraction(long numerator)
        {
            Numerator = numerator;
            Denominator = 1;
        }

        public Fraction(double number)
        {
            int Denominator = 1;
            while(number % 1 != 0)
            {
                number *= 10;
                Denominator *= 10;
            }
      
            Numerator = (long)number;
        }

        public static long MaxDiv(Fraction fraction)
        {
            long a = fraction.Numerator;
            long b = fraction.Denominator;
            while (a != b)
            {
                if(a>b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }

        public void Simplify()
        {
            long maxDiv = MaxDiv(this);
            Numerator /= maxDiv;
            Denominator /= maxDiv;
        }

        public static Fraction operator +(Fraction a)
        {
            return a;
        }

        public static Fraction operator -(Fraction a)
        {
            return new Fraction(-a.Numerator, a.Denominator);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            Fraction result = new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
            result.Simplify();
            return result;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public static Fraction operator !(Fraction a)
        {
            Fraction result = new Fraction(a.Denominator, a.Numerator);
            result.Fix();
            return result;
        }

        public void Fix()
        {
            if((Denominator<0 && Numerator < 0 )||(Denominator<0 && Numerator > 0))
            {
                Numerator = -Numerator;
                Denominator = -Denominator;
            }
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            Fraction result = a * !b;
            result.Simplify();
            return result;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            Fraction result = new Fraction(a.Numerator*b.Denominator + b.Numerator*a.Denominator, a.Denominator*b.Denominator);
            result.Simplify();
            return result;
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            Fraction result = new Fraction(a.Numerator * b.Denominator - b.Numerator * a.Denominator, a.Denominator * b.Denominator);
            result.Simplify();
            return result;
        }

        public static Fraction operator +(Fraction a, long b)
        {
            return a + new Fraction(b);
        }

        public static Fraction operator +(long a, Fraction b)
        {
            return b + new Fraction(a);
        }

        public static Fraction operator -(Fraction a, long b)
        {
            return a - new Fraction(b);
        }

        public static Fraction operator -(long a, Fraction b)
        {
            return b - new Fraction(a);
        }

        public static Fraction operator *(Fraction a, long b)
        {
            return a * new Fraction(b);
        }

        public static Fraction operator *(long a, Fraction b)
        {
            return b * new Fraction(a);
        }

        public static Fraction operator /(Fraction a, long b)
        {
            return a / new Fraction(b);
        }

        public static Fraction operator /(long a, Fraction b)
        {
            return b / new Fraction(a);
        }

        public static implicit operator double(Fraction a)
        {
            return (double)a.Numerator / a.Denominator;
        }

        public static bool operator >(Fraction a, Fraction b)
        {
            return (double)a > (double)b;
        }

        public static bool operator <(Fraction a, Fraction b)
        {
            return (double)a < (double)b;
        }

        public static bool operator ==(Fraction a, Fraction b)
        {
            return (double)a == (double)b;
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            return (double)a != (double)b;
        }

    }
}
