using System.Collections.Generic;

namespace road_network
{
    public class Town : GraphNode
    {
        private bool farm;
        public bool isFarm
        {
            get
            {
                return farm;
            }
            set
            {
                farm = value;
            }
        }
        public Town(string name, bool isFarm =false)
        {
            Name = name;
            farm = isFarm;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}