using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLibrary.Interface;

namespace TestLibrary.Services
{
    public class TriangleService : IFigure
    {
        public async Task<double> GetArea(List<double> sides)
        {
            var p = (sides[0] + sides[1] + sides[2]) / 2;
            return Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]));
        }
        public async Task<bool> IsRectangular(List<double> sides)
        {
            if ((sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2]) 
                || (sides[0] * sides[0] + sides[2] * sides[2] == sides[1] * sides[1]) 
                || (sides[2] * sides[2] + sides[1] * sides[1] == sides[0] * sides[0])) return true;
            return false;
        }
    }
}
