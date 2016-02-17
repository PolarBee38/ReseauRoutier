using System.Collections.Generic;

namespace road_network
{
    public class Town
    {
        string name;
        List<coupleItem<Town,double>> neigh;
        public Town(string tname)
        {
            neigh = new List<coupleItem<Town,double>>();
            name = tname;
        }
        
        /*
         * Return : Add road to the road running from the towns
         * Variables : t the end town, cost: the cost of the road 
         */
        public void addNeigh(Town t, double cost)
        {
            neigh.Add(new coupleItem<Town,double>(t, cost));
        }

        public List<coupleItem<Town,double>> getNeigh()
        {
            return neigh;
        }

        public string getName()
        {
            return name;
        }

        public override string ToString()
        {
            return name;
        }

        /*
         * Return : number of neighbor/road running from the town
         */
        public int nbNeighbor()
        {
            return neigh.Count;
        }
    }
}