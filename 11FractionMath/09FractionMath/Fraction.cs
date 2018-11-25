//Fractionmath
//Author : Nate Christensen
//Date : 10/23/2018
//Fraction.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvdFractionMath
{
    class Fraction
    {
        protected int numerator, denominator;
        /**
         * This is the default constructor
         */
        public Fraction()
        {
            numerator = 0;
            denominator = 1;
        }
        public Fraction(int num, int denom)
        {
            numerator = num;
            denominator = denom;
            Reduce();
        }
        protected void Reduce()
        {
                int sign = 1;
                if (numerator < 0)
                {
                    sign *= -1;
                    numerator *= -1;
                }
                if (denominator < 0)
                {
                    sign *= -1;
                    denominator *= -1;
                }
                for (int i = numerator; i > 1; i--)
                {
                    if (numerator % i == 0 && denominator % i == 0)
                    {
                        //If true the biggest number that is evenly 
                        //divisible from numerator and denominator
                        numerator /= i;
                        denominator /= i;
                        break;
                    }
                }
                numerator *= sign;
        }

        public static Fraction operator + (Fraction frac1, Fraction frac2)
        {
            //Top       (n1*d2)+(n2*d1)=n3
            //Bottom        d1*d2=d3
            //Result    n3/d3

            Fraction result = new Fraction();
            result.numerator = (frac1.numerator * frac2.denominator)
                + (frac2.numerator * frac1.denominator);
            result.denominator = frac1.denominator * frac2.denominator;
            result.Reduce();
            return result;
        }
        public static Fraction operator - (Fraction frac1, Fraction frac2)
        {
            //Top       (n1*d2)-(n2*d1)=n3
            //Bottom        d1*d2=d3
            Fraction result = new Fraction();
            result.numerator = (frac1.numerator * frac2.denominator)
                - (frac2.numerator * frac1.denominator);
            result.denominator = frac1.denominator * frac2.denominator;
            result.Reduce();
            return result;
        }
        public static Fraction operator * (Fraction frac1, Fraction frac2)
        {
            //Top n1*n2=n3
            //Bot d1*d2=d3

            Fraction result = new Fraction();
            result.numerator = frac1.numerator * frac2.numerator;
            result.denominator = frac1.denominator * frac2.denominator;
            result.Reduce();
            return result;
        }
        public static Fraction operator / (Fraction frac1, Fraction frac2)
        {
            //top n1*d2=n3
            //bot d1*n2=d3
            Fraction result = new Fraction();
            result.numerator = frac1.numerator * frac2.denominator;
            result.denominator = frac1.denominator * frac2.numerator;
            result.Reduce();
            return result;
        }
        public Fraction Add(Fraction frac1, Fraction frac2)
        {
            this.numerator = (frac1.numerator * frac2.denominator)
                + (frac2.numerator * frac1.denominator);
            this.denominator = frac1.denominator * frac2.denominator;
            this.Reduce();
            return this;
        }
        public string GetDenominator()
        {
            return Convert.ToString(denominator);
        }
        public string GetNumerator()
        {
            return Convert.ToString(numerator);
        }
        public int Numerator { get { return numerator; } }
        public int Denominator { get { return denominator; } }

        public string GetValue()
        {
            string output = $"{numerator} / {denominator}";
            return output;
        }
    }
    
}
