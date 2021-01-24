using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwayGameOfLife
{
    class HighLife : ConwayGameOfLife
    {
        protected override bool CellShouldLive(bool livingCell, int neighbourCount)
        {
            // with 3 or 6 neighbours cell will live
            if (!livingCell &&  (neighbourCount == 3 || neighbourCount == 6))
                return true;

            // live cell with 2 or 3 neighbours stays alive
            if (livingCell && (neighbourCount == 2 || neighbourCount == 3))
                return true;

            // dead cell
            return false;
        }
    }
}
