using System;
using System.Drawing;

namespace PracP4
{
    public class Plant
    {
        //####################################################################
        //# Instance Variables
        /// <summary>
        /// The name of the plant.
        /// </summary>
        private string _name;
        /// <summary>
        /// Radius of plant, in pixels (or diameter in centimetres).
        /// </summary>
        private int _size;
        /// <summary>
        /// Price of plant, in dollars and cents.
        /// </summary>
        private decimal _price;
        /// <summary>
        /// x coordinate of centre of plant.
        /// </summary>
        private int _x;
        /// <summary>
        /// y coordinate of centre of plant.
        /// </summary>
        private int _y;
        /// <summary>
        /// Total cost of all plants
        /// </summary>
        private decimal _total;

        //####################################################################
        //# Constructor
        /// <summary>
        /// Creates a new plant with the given parameters.
        /// </summary>
        public Plant(string name, int size, decimal price, int x, int y, decimal total)
        {
            _name = name;
            _size = size;
            _price = price;
            _x = x;
            _y = y;
            _total = total;
        }

        //####################################################################
        //# Public Methods
        /// <summary>
        /// Draws this plant on the given graphics context.
        /// </summary>
        public void Draw(Graphics paper)
        {
            Brush brush = new SolidBrush(Color.DarkGreen);
            paper.FillEllipse(brush, _x - _size, _y - _size, 2 * _size, 2 * _size);
        }
        /// <summary>
        /// Checks if x,y position is in side the plant circle
        /// using pythagorus theorum
        /// </summary>
        /// <param name="x">x position of point to check</param>
        /// <param name="y">y position of point to check</param>
        /// <returns></returns>
        public bool IsClicked(int x, int y)
        {
            return (x - _x) * (x - _x) + (y - _y) * (y - _y) <= (_size * _size);
        }
        //####################################################################
        //# Properties
        /// <summary>
        /// The name of the plant.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Radius of plant, in pixels (or diameter in centimetres).
        /// </summary>
        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }

        /// <summary>
        /// gets the x axis of the plant
        /// </summary>
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// gets the y axis of the plant
        /// </summary>
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        /// <summary>
        /// Price of plant, in dollars and cents.
        /// </summary>
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        /// <summary>
        /// calculate the total cost
        /// </summary>
        public decimal Total
        {
            get { return _total; }
            set { _total = value; }
        }

        /// <summary>
        /// Gets all the information about a plant
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name.PadRight(10) + Size.ToString()+"cm wide at (" + X.ToString().PadRight(1)+", " + Y.ToString()+")  " + Price.ToString();
            //return Total.ToString();
        }

    }


}
