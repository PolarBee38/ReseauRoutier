using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReseauRoutier
{
    class Road
    {
        private Town _town;
        private int _distance;

        public Road(Town newTown, int newDistance)
        {
            _town = newTown;
            _distance = newDistance;
        }

        public Town GetTown()
        {
            return _town;
        }
        public int GetDistance()
        {
            return _distance;
        }
 
    }
}
