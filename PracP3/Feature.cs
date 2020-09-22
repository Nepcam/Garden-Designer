using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PracP4
{
    class Feature : Plant
    {
        //####################################################################
        //# Instance Variables
        /// <summary>
        /// The name of the Feature.
        /// </summary>
        private string _name;
        /// <summary>
        /// Radius of Feature, in pixels (or diameter in centimetres).
        /// </summary>
        private int _size;
        /// <summary>
        /// Price of Feature, in dollars and cents.
        /// </summary>
        private decimal _price;
        /// <summary>
        /// x coordinate of centre of Feature.
        /// </summary>
        private int _x;
        /// <summary>
        /// y coordinate of centre of Feature.
        /// </summary>
        private int _y;
        /// <summary>
        /// Total cost of all Features
        /// </summary>
        private decimal _total;
        private int _length;

        //####################################################################
        //# Constructor
        /// <summary>
        /// Initialises the object with the values passed in
        /// </summary>
        /// <param name="name">Name of the Feature</param>
        /// <param name="size">Size of the Feature</param>
        /// <param name="price">Price of the Feature</param>
        /// <param name="x">X position of the Feature</param>
        /// <param name="y">Y position of the Feature</param>
        /// <param name="total">Total cost of the Feature</param>
        public Feature(string name, int size, decimal price, int x, int y, decimal total, int length) : base(name, size, price, x, y, total)
        {
            _name = name;
            _size = size;
            _price = price;
            _x = x;
            _y = y;
            _total = total;
            Length = length;
        }

        public override string ToString()
        {
            return Name.PadRight(10) + Size.ToString() + "cm wide at (" + X.ToString().PadRight(1) + ", " + Y.ToString() + ")  " + Price.ToString();
        }

        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }

        //# Public Methods
        /// <summary>
        /// Draws this Feature on the given graphics context.
        /// </summary>
        public void Draw(Graphics paper)
        {
            Brush brush = new SolidBrush(Color.Blue);
            //paper.FillEllipse(brush, _x - _size, _y - _size, 2 * _size, 2 * _size);
            paper.FillRectangle(brush, X, Y, Size, Size);
        }
        /// <summary>
        /// Checks if x,y position is in side the Feature rectangle
        /// using pythagorus theorum
        /// </summary>
        /// <param name="x">x position of point to check</param>
        /// <param name="y">y position of point to check</param>
        /// <returns></returns>
        public new bool IsClicked(int x, int y)
        {
            return (x - _x) * (x - _x) + (y - _y) * (y - _y) <= (_size * _size);
        }
    }
}
