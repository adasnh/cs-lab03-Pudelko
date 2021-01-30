using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PudelkoLib
{
    public sealed class Pudelko : IComparable<Pudelko>, IEnumerable<Pudelko>, IEquatable<Pudelko>
    {
        private readonly double a, b, c;
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
        public override string ToString()
        {
            return this.ToString("m");
        }
        public string ToString(string format)
        {
            return this.ToString(format, null);
        }
         public string ToString(string format, IFormatProvider formatProvider)
        {
            if(format == "mm")
            {
                return $"{a} mm × {b} mm × {c} mm";
            }
            if(format == "cm")
            {
                return $"{a / 10} mm × {b / 10} mm × {c / 10} mm";
            }
            if(format == "m")
            {
                return $"{a / 1000} mm × {b / 1000} mm × {c / 1000} mm";
            }
            else
            {
                throw new FormatException();
            }
        }
        public override bool Equals(object obj)
        {
            if (obj is Pudelko)
            {
                return Equals((Pudelko) obj);
            }

            return base.Equals(obj);
        }
        public bool Equals(Pudelko pudelko)
        {
            return (Pole == pudelko.Pole && Objetosc == pudelko.Objetosc);
        }

        public override int GetHashCode()
        {
            return A.GetHashCode() + B.GetHashCode() + C.GetHashCode() + unit.GetHashCode();
        }
         public int CompareTo(Pudelko other) {
            double objetoscP1 = Objetosc, objetoscP2 = other.Objetosc;
            if(objetoscP1 == objetoscP2) {
                double poleP1 = Pole, poleP2 = other.Pole;
                if(Pole == poleP2) {
                    double sumP1 = A + B + C, sumP2 = other.A + other.B + other.C;
                    if(sumP1 == sumP2) {
                        return 0;
                    }
                    return sumP1 < sumP2 ? 1 : -1;
                }
                return (poleP1 < poleP2) ? 1 : -1;
            }

            return (objetoscP1 < objetoscP2) ? 1 : -1;
            throw new NotImplementedException();
        }

    }
}
