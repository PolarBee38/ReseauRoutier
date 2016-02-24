using System.Collections.Generic;

namespace road_network
{
    public class Town : GraphNode
    {
        public Town(string name)
        {
            Name = name;
        }   
        public override string ToString()
        {
            return Name;
        }
    }
}