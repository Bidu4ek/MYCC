using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYCC
{
    class Circle
    {
        /* protected double R;
         public Circle(double e)
         {
             R = e;
         }
         public virtual double S()       //вычисление площади окружности
         {

             return R * R * Math.PI;

         }
         public double L()               //вычисление длины окружности
         {
             return R * (2 * Math.PI);
         }*/
        double R;
        double L;
        double S;
        
        public double Radius { get => R; set => R = value; }
        public double Len { get => L; set => L = value; }
        public double Sq { get => S; set => S = value; }

        public Circle()
        {

        }
        public Circle(double Radius)
        {
            this.Radius = Radius;
            this.Len = Radius*2*Math.PI;
            this.Sq = Radius*Radius*Math.PI;
        }
    }
}
