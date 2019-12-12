using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyominoes
{
    class Squarie
    {
        private int[] xy;

        public Squarie(int x, int y)
        {
            xy = new int[2];
            xy[0] = x;
            xy[1] = y;
        }

        public int[] GetCoordinates()
        {
            int[] coordinates = new int[2];
            for (int cc = 0; cc < 2; ++cc)
            {
                coordinates[cc] = xy[cc];
            }
            return coordinates;
        }

        /**
         * move (translate) the Squarie
         *
         * @param x : int - number of units to the right
         * @param y : int = number of units up
         */
        public void Translate(int x, int y)
        {
            xy[0] += x;
            xy[1] += y;
        }

        /**
         * rotate the Squarie 90 degrees counter-clockwise by applying the matrix
         * below to its implied upper left corner, which will be lower left 
         * after rotation: <br>
         * | 0 -1 |        <br>
         * | 1  0 |
         */
        public void Rotate90()
        {
            int tmp = xy[0];
            xy[0] = -1 - xy[1];
            xy[1] = tmp;
        }

        /**
         * reflect the Squarie across the x-axis This transformation is not possible
         * in 2 dimensions
         */
        public void Reflect()
        {
            xy[1] = -1 - xy[1];
        }

        public string ToString() => "[" + xy[0] + "," + xy[1] + "]";

        public bool Equals(Object other)
        {
            bool isEqual = false;
            if (other != null
                && (other.GetType() == typeof(Squarie))
                && ((Squarie)other).xy[0] == xy[0]
                && ((Squarie)other).xy[0] == xy[0])
        {
                isEqual = true;
            }
            return isEqual;
        }
    }
}
