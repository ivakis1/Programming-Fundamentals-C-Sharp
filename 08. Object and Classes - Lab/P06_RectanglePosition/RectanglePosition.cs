using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_RectanglePosition
{

    class RectanglePosition
    {
        static void Main(string[] args)
        {
            var firstRectangle = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var secondRectangle = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var r1 = new Rectangle
            {
                Left = firstRectangle[0],
                Top = firstRectangle[1],
                Width = firstRectangle[2],
                Height = firstRectangle[3]

            };

            var r2 = new Rectangle
            {
                Left = secondRectangle[0],
                Top = secondRectangle[1],
                Width = secondRectangle[2],
                Height = secondRectangle[3]
            };
            
            if (IsInside(r1, r2))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }
        public static bool IsInside(Rectangle r1, Rectangle r2)
        {
            bool LeftIsCorrect = false;
            bool RightIsCorrect = false;
            bool TopIsCorrect = false;
            bool BottomIsCorrect = false;


            if (r1.Left >= r2.Left)
            {
                LeftIsCorrect = true;
            }
            if (r1.Right <= r2.Right)
            {
                RightIsCorrect = true;
            }
            if (r1.Top <= r2.Top)
            {
                TopIsCorrect = true;
            }
            if (r1.Bottom >= r2.Bottom)
            {
                BottomIsCorrect = true;
            }

            if (LeftIsCorrect && RightIsCorrect && TopIsCorrect && BottomIsCorrect)
            {
                return true;
            }
            return false;
        }
    }
}
