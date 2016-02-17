using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace road_network
{
    public class roadMapGraph : IGraph<Town>
    {
        List<Town> towns;

        public roadMapGraph()
        {
            towns = new List<Town>();
        }
        public List<Town> nodes() {
            return towns;
        }

        //Return : if the town is next door, return the road cost, else, return 0.
        //Variables : node1 the town we come frome, node2 the town we are going to
        public double getCost(Town node1, Town node2)
        {
            foreach(coupleItem<Town,double> road in node1.getNeigh())
            {
                if (node2.Equals(road.getItem()))
                    return road.getValue();
            }
            return 0;
        }
        public double heuristicCost(Town node1, Town node2)
        {
            return 1;
        }

        public IEnumerable<coupleItem<Town,double>> neighbor(Town node)
        {
            return node.getNeigh();
            /*
            //or use an iterator:
            int count = node.getNeigh().Count;
            for (int i = 0; i< count; ++i)
            {
                yield return node.getNeigh()[i];
            }
            */
        }
        
        public Town addTown(string name)
        {
            Town t = new Town(name);
            towns.Add(t);
            return t;
        }

        public void addRoad(Town t1, Town t2, int cost)
        {
            if (!towns.Contains(t1))
                towns.Add(t1);
            if (!towns.Contains(t2))
                towns.Add(t2);
            t1.addNeigh(t2, cost);
            t2.addNeigh(t1, cost);

        }
        public int nbNeighbor(Town node)
        {
            return node.nbNeighbor();
        }

        public List<Town> getRemoteTown()
        {
            List<Town> l = new List<Town>();
            foreach (Town t in towns)
            {
                if (t.nbNeighbor() == 1)
                {
                    l.Add(t);
                }
            }
            return l;
        }

        public roadMapGraph newSubMap(List<Town> newListTowns, out List<List<Town>> listPath)
        {
            roadMapGraph newRoadMap = new roadMapGraph();
            int i, j, length = newListTowns.Count();
            Town t1, t2;
            listPath = new List<List<Town>>();
            foreach (Town t in towns)
            { 
                newRoadMap.addTown(t.getName());
            }

            for(i=0;i<length;i++)
            {
                t1 = newListTowns[i];
                for(j=i;j<length;j++)
                {
                    t2 = newListTowns[j];
                    if (newRoadMap.getCost(t1, t2) == 0)
                    {
                        astarResult<Town> searchRes = graphSearch.astar(newRoadMap, t1, t2, null, null);
                        listPath.Add(searchRes.sPath);
                    }
                }
            }            
            return newRoadMap;
        }
       
    }
}
