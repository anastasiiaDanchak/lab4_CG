using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_CG
{
    public class HSB_color
    {
        public double a;
        private double H { get; set; }
        private double S { get; set; }
        private double B { get; set; }
        public HSB_color(double h, double s, double b)
        {
            this.H = h;
            this.S = s;
            this.B = b;
        }
        public double Get_H()
        { return this.H; }
        public double Get_S()
        { return this.S; }
        public double Get_B()
        { return this.B; }
        public void Set_B(double b)
        { this.B = b; }
    }


}
