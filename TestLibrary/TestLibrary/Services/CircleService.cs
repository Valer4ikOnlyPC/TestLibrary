using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLibrary.Interface;

namespace TestLibrary.Services
{
    public class CircleService : IFigure
    {
        private readonly double Pi = 3.14;
        public async Task<double> GetArea(List<double> sides)
        {
            return Pi * Math.Pow(sides[0], 2);
        }
    }
}
