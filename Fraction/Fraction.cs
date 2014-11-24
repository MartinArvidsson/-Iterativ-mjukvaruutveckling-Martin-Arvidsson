using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Fraction
    {
        private int numerator;
        private int denumerator;
        public int getNumerator
        {
            get
            {
                return numerator;
            }
            set
            {
                numerator = value;
            }
        }
        public int getDenominator
        {
            get
            {
                return denumerator;
            }
            set
            {
                if(value == 0)
                {
                    throw new ArgumentException("Nämnaren får inte vara noll.");
                }
                denumerator = value;
            }
        }
        public Fraction (int _numerator, int _denominator)
        {
            getNumerator = _numerator;
            getDenominator = _denominator;
        }
        public Fraction add(Fraction a) // Metod för +
        {
            int newNumber = (this.getNumerator * a.getDenominator) + (a.getNumerator * this.getDenominator);
            int newDenomiator = (this.getDenominator * a.getDenominator);
            Fraction addResults = new Fraction(newNumber, newDenomiator);
            return addResults;
        }
        public Fraction multiply(Fraction a) //Metod för *
        {
            int newNumber2 = a.getNumerator * this.getNumerator;
            int newDenomiator2 = a.getDenominator * this.getDenominator;
            Fraction multiplyResults = new Fraction(newNumber2, newDenomiator2);
            return multiplyResults;
        }
        public bool isEqualTo(Fraction a) //Metod för =
        {
            if ((decimal)a.getNumerator / (decimal)a.getDenominator == (decimal)this.getNumerator / (decimal)this.getDenominator)
            {
                return true;
            }
            else
            return false;
        }
        public override string ToString()
        {
            return string.Format("{0}/{1}", getNumerator, getDenominator);
        }
    }
}
