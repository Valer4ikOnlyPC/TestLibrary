using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary.Interface
{
    public interface IFigure
    {
        Task<double> GetArea(List<double> sides);
    }
}
