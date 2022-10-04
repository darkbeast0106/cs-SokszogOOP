using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
    internal class Sokszog
    {
        private double a;

        public Sokszog(double a)
        {
            this.a = a;
        }

        public double A { get => this.a; set => this.a = value; }


    }
}
