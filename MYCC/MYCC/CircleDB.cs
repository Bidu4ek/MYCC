using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYCC
{
    class CircleDB
    {
        List<Circle> Rad;
       

        public CircleDB()
        {
            DCi = new List<Circle>();
        
        }
        internal List<Circle> DCi { get => Rad; set => Rad = value; }
       
    }
}
