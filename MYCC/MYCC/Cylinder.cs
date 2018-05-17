using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYCC
{
    class Cylinder : Circle
    {
       
        double H;
        double R;
        double V;
        double Sqc;

        public double RadiusH { get => R; set => R = value; }
        public double Hei { get => H; set => H = value; }
        public double Va { get => V; set => V = value; }
        public double SqC { get => Sqc; set => Sqc = value; }

        public Cylinder()
        {

        }
        public Cylinder(double RadiusH,double Hei)
        {
            this.RadiusH = RadiusH;
            this.Hei = Hei;
            this.Va = Hei * RadiusH * RadiusH * Math.PI;
            this.SqC = 2 * Math.PI * RadiusH * (Hei + RadiusH);
    }
    }
}
