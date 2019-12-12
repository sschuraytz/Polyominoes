using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyominoes
{
    class Board
    {
        public Squarie[,] squaries { get; set; }

        public Board(int nrRows, int nrCols)
        {
            squaries = new Squarie[nrRows, nrCols];
        }


    }
}
