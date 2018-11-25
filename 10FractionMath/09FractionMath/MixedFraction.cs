using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvdFractionMath
{
    class MixedFraction : Fraction
    {
        private int whole;//, numerator, denominator;
        public MixedFraction() : base()
        {
            whole = 0;
        }
        public MixedFraction(int whl, int nume, int denom) : base(nume, denom)
        {
            whole = whl;
            numerator = nume;
            denominator = denom;
            //
            int sign = 1;
            if (whole < 0)
            {
                sign *= -1;
                whole *= -1;
               // whole = Math.Abs(whole);
            }
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
            //Convert mixed to improper fraction
            numerator += whole * denominator;
            numerator *= sign;
            Reduce();
        }
        public void ToMixedFraction(Fraction frac)
        {
            int sign = 1;
            
            whole = frac.Numerator / frac.Denominator;
            if (whole < 0) sign *= -1;
            numerator = frac.Numerator % frac.Denominator;
            numerator *= sign;
            denominator = frac.Denominator;
        }
        public string GetMixedWhole()
        {
            return Convert.ToString(whole);
        }
        public string GetMixedDenominator()
        {
            return Convert.ToString(denominator);
        }
        public string GetMixedNumerator()
        {
            return Convert.ToString(numerator);
        }
    }
}
