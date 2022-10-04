using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
    internal class Teglalap : Sokszog
    {
        private double b;

        public Teglalap(double a, double b) : base(a)
        {
            this.b = b;
        }

        public double B { get => b; set => b = value; }

        public double Kerulet
        {
            get
            {
                return 2 * (this.A + this.b);
            }
        }

        public double Terulet
        {
            get
            {
                return this.A * this.B;
            }
        }

        public override string ToString()
        {
            return String.Format("Téglalap: a = {0,-10:0.000} b = {1,-10:0.000}" +
                " K = {2,-10:0.000} T = {3,-10:0.000}",
                this.A, this.B, this.Kerulet, this.Terulet);
        }
    }
}
