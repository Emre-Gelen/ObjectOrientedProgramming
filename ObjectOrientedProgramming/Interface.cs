using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    interface IHouseWare
    {
        int Height { get; }
        int Width { get; }
        int Depth { get; }
        long Size { get; }
        string Color { get; }
        long MeasureSize(int Height, int Width, int Depth);
        string ShowAsString();

    }
    class CoffeeTable : IHouseWare //When you implemented an interface you have to implement all of its methods, properties ...
    {
        public int Height { get; }  // Using only getter, block to change property value after object created.
        public int Width { get; }
        public int Depth { get; }
        public string Color { get; }
        // It can do with method but I used it like this because I preffered to measure the Size by using values entered when creating the object instead of the input given from the user.
        public long Size { get { return MeasureSize(this.Height, this.Width, this.Depth); } }
        public CoffeeTable(int Height, int Width, int Depth, string Color) //Constructor
        {
            this.Height = Height;
            this.Width = Width;
            this.Depth = Depth;
            this.Color = Color;
        }
        public long MeasureSize(int Height, int Width, int Depth)
        {
            return Height * Width * Depth;
        }

        public string ShowAsString()
        {
            string res = "Height: " + Height + " Width: " + Width + " Depth: " + Depth + " Size: " + Size;
            return res;
        }
    }
}
