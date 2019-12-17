using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyominoes
{
    class Board
    {
        int Size { get; set; }

        private List<Polyominoe> Polyominoes;

        public Board(int nrRowsAndCols)
        {
            Size = nrRowsAndCols;
        }

        public void Populate(List<Polyominoe> polyominoes)
        {
            Polyominoes = polyominoes;
        }




    }
}
