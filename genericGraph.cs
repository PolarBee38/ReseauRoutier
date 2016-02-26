using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace road_network
{
    public class genericGraph<TNode> : IGraph<TNode> where TNode:GraphNode
    {
        Dictionary<TNode, Dictionary<TNode,double>> arcs;

        public genericGraph()
        {
            arcs = new Dictionary<TNode, Dictionary<TNode, double>>();
        }
        public List<TNode> nodes() {
            return new List<TNode>(arcs.Keys);
        }

        //Return : if the town is next door, return the road cost, else, return 0.
        //Variables : node1 the town we come frome, node2 the town we are going to
        public double getCost(TNode node1, TNode node2)
        {
            Dictionary<TNode, double> res;
            double cost = 0;
            if (arcs.TryGetValue(node1, out res))
                res.TryGetValue(node2, out cost);
            return cost;
        }
        public double heuristicCost(TNode node1, TNode node2)
        {
            return 1;
        }

        public IEnumerable<coupleItem<TNode, double>> neighbor(TNode node)
        {
            Dictionary<TNode, double> res = arcs[node];
            if (res == null)
                yield break;
            foreach (KeyValuePair<TNode, double> pair in res)
                yield return new coupleItem<TNode, double>(pair.Key, pair.Value);            
        }
        
        public TNode addTown(TNode t)
        {
            arcs[t] = new Dictionary<TNode, double>();
            return t;
        }

        public void addRoad(TNode t1, TNode t2, int cost)
        {
            if (arcs.ContainsKey(t1) && arcs.ContainsKey(t2))
            {
                arcs[t1][t2] = cost;
                arcs[t2][t1] = cost;
            }

        }
        public int nbNeighbor(TNode node)
        {
            if (arcs[node] != null)
                return arcs[node].Count;
            return 0;
        }

        public List<TNode> getRemoteTown()
        {
            List<TNode> l = new List<TNode>();
            foreach (TNode t in nodes())
            {
                if (nbNeighbor(t) == 1)
                {
                    l.Add(t);
                }
            }
            return l;
        }
    }
}
