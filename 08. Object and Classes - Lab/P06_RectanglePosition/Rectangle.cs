﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_RectanglePosition
{
   public class Rectangle
    {
        public int Left { get; set; }

        public int Top { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }


        public int Bottom => Top - Height;
                   
        public int Right
        {
            get
            {
                return Left + Width;
            }
        }

        public int Area()
        {
            return Height * Width;
        }
    }
}
