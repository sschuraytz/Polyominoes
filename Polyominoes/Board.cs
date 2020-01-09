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
        private Dictionary<Squarie, Squarie> rotateMap;
        private List<Polyominoe> Polyominoes;
        readonly bool[,] Occupied;
        readonly Squarie[,] SquarieArray;
        private readonly int max = 4;

        public Board(int nrRowsAndCols)
        {
            Size = nrRowsAndCols;
            SquarieArray = new Squarie[Size, Size];
            Occupied = new bool[Size, Size];
        }

        public void Populate(List<Polyominoe> polyominoes)
        {
            Polyominoes = polyominoes;
        }

        private void Map()
        {
            rotateMap = new Dictionary<Squarie, Squarie>();
            //counter-clockwise rotation
            for (int orig = 0; orig < max; orig++)
            {
                for (int rotated = max;  rotated > 0; rotated--)
                {
                    rotateMap.Add(new Squarie(orig, max - rotated), new Squarie(rotated - 1, orig));
                }
            }

            //rotateMap.Add(new Squarie(0, 0), new Squarie(3, 0));
            //rotateMap.Add(new Squarie(0, 1), new Squarie(2, 0));
            //rotateMap.Add(new Squarie(0, 2), new Squarie(1, 0));
            //rotateMap.Add(new Squarie(0, 3), new Squarie(0, 0));
            //rotateMap.Add(new Squarie(1, 0), new Squarie(3, 1));
            //rotateMap.Add(new Squarie(1, 1), new Squarie(2, 1));
            //rotateMap.Add(new Squarie(1, 2), new Squarie(1, 1));
            //rotateMap.Add(new Squarie(1, 3), new Squarie(0, 1));
            //rotateMap.Add(new Squarie(2, 0), new Squarie(3, 2));
            //rotateMap.Add(new Squarie(2, 1), new Squarie(2, 2));
            //rotateMap.Add(new Squarie(2, 2), new Squarie(1, 2));
            //rotateMap.Add(new Squarie(2, 3), new Squarie(0, 2));
            //rotateMap.Add(new Squarie(3, 0), new Squarie(3, 3));
            //rotateMap.Add(new Squarie(3, 1), new Squarie(2, 3));
            //rotateMap.Add(new Squarie(3, 2), new Squarie(1, 3));
            //rotateMap.Add(new Squarie(3, 3), new Squarie(0, 3));
        }

        private void Add(Polyominoe poly)
        {
            foreach( Squarie square in poly.Squaries ) {
                Occupied[square.Row, square.Col] = true;
            }
        }

        private void Remove(Polyominoe poly)
        {
            foreach (Squarie square in poly.Squaries)
            {
                Occupied[square.Row, square.Col] = false;
            }
        }

        private bool IsValid(Polyominoe poly)
        {
            bool isValid = true;
            foreach(Squarie square in poly.Squaries)
            {
                if (Occupied[square.Row, square.Col] == true)
                {
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }
    }
}
