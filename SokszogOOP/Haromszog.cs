using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
    internal class Haromszog : Sokszog
    {
        private double b;
        private double c;
        private static Random rnd = new Random();

        public Haromszog() : base(VeletlenOldalGeneralas())
        {
            this.b = VeletlenOldalGeneralas();
            this.c = VeletlenOldalGeneralas();
            while (!Szerkesztheto)
            {
                base.A = VeletlenOldalGeneralas();
                this.b = VeletlenOldalGeneralas();
                this.c = VeletlenOldalGeneralas();
            }
        }

        private static double VeletlenOldalGeneralas()
        {
            return rnd.NextDouble() * 200;
        }

        public Haromszog(double a, double b, double c) : base(a)
        {
            this.b = b;
            this.c = c;
            if (!this.Szerkesztheto)
            {
                throw new ArgumentException("A háromszög nem szerkeszthető");
            }
        }

        public double B { get => this.b; 
            set
            {
                this.b = value;
                if (!this.Szerkesztheto)
                {
                    throw new ArgumentException("A háromszög nem szerkeszthető", nameof(value));
                }
            }
        }
        public double C { get => this.c;
            set
            {
                this.c = value;
                if (!this.Szerkesztheto)
                {
                    throw new ArgumentException("A háromszög nem szerkeszthető", nameof(value));
                }
            }
        }

        public override double A
        {
            set
            {
                base.A = value;
                if (!this.Szerkesztheto)
                {
                    throw new ArgumentException("A háromszög nem szerkeszthető", nameof(value));
                }
            }
        }

        private bool Szerkesztheto
        {
            get
            {
                return (this.A + this.B) > this.C &&
                        (this.A + this.C) > this.B &&
                        (this.B + this.C) > this.A;
            }
        }

        public override double Kerulet
        {
            get
            {
                return this.A + this.B + this.C;
            }
        }

        private double S
        {
            get
            {
                return this.Kerulet / 2;
            }
        }

        public override double Terulet
        {
            get
            {
                return Math.Sqrt(this.S * (this.S - this.A) *
                    (this.S - this.B) * (this.S - this.C));
            }
        }

        public override string ToString()
        {
            return String.Format("Háromszög: a = {0,-10:0.000} b = {1,-10:0.000}" +
                "c = {2,-10:0.000} {3}",
                this.A, this.B, this.C, base.ToString());
        }
    }
}
