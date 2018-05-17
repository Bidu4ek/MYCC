using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYCC
{
    class CylinderDB
    {
        List<Cylinder> RH;
        public CylinderDB()
        {
           
            DCy = new List<Cylinder>();
        }
        internal List<Cylinder> DCy { get => RH; set => RH = value; }
    }
}
