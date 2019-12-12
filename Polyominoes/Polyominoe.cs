using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyominoes
{
    class Polyominoe
    {
        protected List<Squarie> polyominoe;

        public Polyominoe(int[][] squares)
        {
            polyominoe = new List<Squarie>();
            for (int square = 0; square < squares.Length; ++square)
            {
                polyominoe.Add(new Squarie(squares[square][0], squares[square][1]));
            }
        }


        /**
         * move (translate) the Polyominoe
         *
         * @param x : int - number of units to the right
         * @param y : int = number of units up
         */
        public void Translate(int x, int y)
        {
            foreach(Squarie sqr in polyominoe)
            {
                sqr.Translate(x, y);
            }
        }

        /**
         * rotate the Polyominoe 90 degrees counter-clockwise 
         */
        public void Rotate90()
        {
            foreach (Squarie sqr in polyominoe)
            {
                sqr.Rotate90();
            }
            // need to move it move it

        }

        public string ToString()
        {
            string strRV = "{ ";
            foreach (Squarie sqr in polyominoe)
            {
                strRV += sqr.ToString();
            }
            strRV += "}";
            return strRV;
        }
    }
}
