using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
    internal abstract class Sokszog
    {
        private double a;

        public Sokszog(double a)
        {
            this.a = a;
        }

        public virtual double A { get => this.a; set => this.a = value; }

        public abstract double Kerulet { get; }
        public abstract double Terulet { get; }

        public override string ToString()
        {
            return String.Format("K = {0,-10:0.000} T = {1,-10:0.000}",
                this.Kerulet, this.Terulet);
        }
    }
}
