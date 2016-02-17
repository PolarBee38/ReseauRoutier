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
        public int nbNeighbor()
        {
            return neigh.Count;
        }
    }
}