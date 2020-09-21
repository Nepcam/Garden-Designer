using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //####################################################################
        //# Constructor
        /// <summary>
        /// Creates a new Feature with the given parameters.
        /// </summary>
        public Feature(string name, int size, decimal price, int x, int y, decimal total) : base(name, size, price, x, y, total)
        {
            _name = name;
            _size = size;
            _price = price;
            _x = x;
            _y = y;
            _total = total;
        }
    }
}
