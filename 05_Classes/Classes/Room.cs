using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes.Classes
{
    public class Room
    {
        //Give properties of length,width,height,surface area, and volume
        //Empty and full constructor

        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int SurfaceArea
        {
            get
            {
                return (
                    2 * Length * Width +
                    2 * Length * Height +
                    2 * Width * Height);
            }
        }

        public int Volume
        {
            get
            {
                return Length * Width * Height;
            }
        }

        public Room() { }


        public Room(int length, int width, int height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
    }
}

