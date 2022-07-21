using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionSimpleMath
{
    class Fraction
    {
        private double numerator { get; set; }
        private double demoninator { get; set; }

        public double Numerator
        {
            get { return numerator; }
            set { numerator = value;}
        }
        public double Demoninator
        {
            get { return demoninator; }
            set { demoninator = value; }
        }

        public Fraction(double Numerator,double Demoninator)
        {
            this.numerator = Numerator;
            this.demoninator = Demoninator;
        }
        public Fraction()
        {
            this.numerator = 0;
            this.demoninator = 1;
        }

        public static double GreatestCommonDivisor(double a, double b)
        {
            double temp;
            if (b > a)
            {   // Dùng để chuyển b thành a
                temp = b;
                b = a;
                a = temp;
            }     // sau khối lệnh, ta có a >= b

            double i = b;  // i chạy từ b
            while (i >= 1)
            {
                if (a % i == 0 && b % i == 0)  // nếu a và b cùng chia hết cho i
                    break;          // thoát vòng lặp
                i--;
            }
            return i;
        }
        public void ReduceFraction()
        {
            double tmp = GreatestCommonDivisor(this.numerator, this.demoninator);
            this.numerator = this.numerator / tmp;
            this.demoninator = this.demoninator / tmp;
        }
        
        //method call by instance
        public Fraction SumFraction( Fraction b)
        {
            if(this.demoninator == b.demoninator)
            {
                double num = this.numerator + b.numerator;
                Fraction c = new Fraction(num, this.demoninator);
                c.ReduceFraction();
                return c;
            }
            else
            {
                //reduce fraction to a common denominator
                double Cd = this.demoninator * b.demoninator;//common denominator
                double numA = this.numerator * b.demoninator;
                double numB = b.numerator * this.demoninator;

                Fraction c = new Fraction((numA + numB), Cd);
                c.ReduceFraction();
                return c;

            }
        }

        public Fraction SubtractionFraction(Fraction b)
        {
            if (this.demoninator == b.demoninator)
            {
                double num = this.numerator - b.numerator;
                Fraction c = new Fraction(num, this.demoninator);
                c.ReduceFraction();
                return c;
            }
            else
            {
                //reduce fraction to a common denominator
                double Cd = this.demoninator * b.demoninator;//common denominator
                double numA = this.numerator * b.demoninator;
                double numB = b.numerator * this.demoninator;

                Fraction c = new Fraction((numA - numB), Cd);
                c.ReduceFraction();
                return c;

            }
        }
        public Fraction MultiplicationFraction(Fraction b)
        {
                Fraction c = new Fraction(this.numerator* b.numerator,this.demoninator*b.demoninator);
                c.ReduceFraction();
                return c;
        }
        public Fraction DivisionFraction(Fraction b)
        {
            Fraction c = new Fraction(this.numerator * b.demoninator, this.demoninator * b.Numerator);
            c.ReduceFraction();
            return c;
        }



      
       

    }
}
