using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyominoes
{
    class Polyominoe
    {
        protected List<Squarie> squares;

        public Polyominoe(int[][] boxes)
        {
            squares = new List<Squarie>();
            for (int box = 0; box < boxes.Length; ++box)
            {
                squares.Add(new Squarie(boxes[box][0], boxes[box][1]));
            }
        }


        /**
         * move (translate) the Polyominoe
         *
         * @param x : int - number of units to the right
         * @param y : int = number of units up
         */
        public void translate(int x, int y)
        {
            foreach(Squarie sqr in squares)
            {
                sqr.Translate(x, y);
            }
        }

        /**
         * rotate the Polyominoe 90 degrees counter-clockwise 
         */
        public void rotate90()
        {
            foreach (Squarie sqr in squares)
            {
                sqr.Rotate90();
            }
        }
        
        public String toString()
        {
            String strRV = "{ ";
            foreach (Squarie sqr in squares)
            {
                strRV += sqr.ToString();
            }
            strRV += "}";
            return strRV;
        }
    }
}
