using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwayGameOfLife
{
    public interface ILifeBehaviour
    {
        bool CellShouldLive(bool livingCell, int neighbourCount);
    }
}
