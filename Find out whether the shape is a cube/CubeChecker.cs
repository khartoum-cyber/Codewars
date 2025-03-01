using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_out_whether_the_shape_is_a_cube
{
    internal class CubeChecker
    {
        public bool IsCube(double volume, double side)
        {
            return side > 0 && volume > 0 &&  volume == Math.Pow(side, 3.0f);
        }
    }
}
