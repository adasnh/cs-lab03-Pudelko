using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PudelkoLib
{
    public sealed class Pudelko
    {
        private double a, b, c;
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        private UnitOfMeasure Unit { get; set; }
        public double Pole 
        {
            get
            {
                return Math.Round(2 * (A * C + A * B + B * C), 6);
            }
        }
        
        public double Objetosc
        {
            get
            {
                return Math.Round((A * B * C), 9);
            }
        }
        
        public Pudelko(double a, double b, double c, UnitOfMeasure unit = UnitOfMeasure.meter)
        {
            Unit = unit;
            A = ToMeters(a, unit);
            B = ToMeters(b, unit);
            C = ToMeters(c, unit);
            if (A <= 0 | A > 10 | B <= 0 | B > 10 | C <= 0 | C > 10)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public Pudelko(double a, double b, UnitOfMeasure unit = UnitOfMeasure.meter)
        {
            Unit = unit;
            A = ToMeters(a, unit);
            B = ToMeters(b, unit);
            if (A <= 0 | A > 10 | B <= 0 | B > 10)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public Pudelko(double a = 0.1, UnitOfMeasure unit = UnitOfMeasure.meter)
        {
            A =ToMeters(a, unit);
            if (A <= 0 | A > 10)
            {
                throw new ArgumentOutOfRangeException();
            }

        }
        private double ToMeters(double number, UnitOfMeasure unit)
        {
            if(unit == UnitOfMeasure.centimeter)
            {
                return number / 100;
            }
            else if (unit == UnitOfMeasure.milimeter)
            {
                return number / 1000;
            }
            else
            {
                return number;
            }
        }

    }
}
