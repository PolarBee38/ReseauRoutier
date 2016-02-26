using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace road_network
{
    public class shortestSubGraph<T> : IGraph<T> where T :GraphNode
    {
        private IGraph<T> graph;
        private Dictionary<T, priorityQueue<T>> arcs;
        private Dictionary<T, Dictionary<T,searchResult<T>>> shortestPath;
        private int testedAcs;
        private int visitedNodes;
        public int getTotalArcsTested()
        {
            return testedAcs;
        }
        public int getTotalVisitedNodes()
        {
            return visitedNodes;
        }
        public shortestSubGraph(IGraph<T> g,List<T> subset)
        {
            visitedNodes = 0;
            testedAcs = 0;
            arcs = new Dictionary<T, priorityQueue<T>>();
            shortestPath = new Dictionary<T, Dictionary<T, searchResult<T>>>();
            graph = g;


            //add nodes
            foreach (T node in subset)
            {
                shortestPath[node] = new Dictionary<T, searchResult<T>>();
                arcs[node] = new priorityQueue<T>();
            }

            //construct the sub graph
            foreach (T startNode in subset)
            {
                foreach(T destNode in subset)
                {
                    if (startNode.Equals(destNode))
                        continue;
                    Dictionary<T, searchResult<T>> shorestFromStart;
                    searchResult<T> pathRes;
                    //if not computed yet
                    if (shortestPath.TryGetValue(startNode, out shorestFromStart))
                        if (shorestFromStart.TryGetValue(destNode, out pathRes))
                            //shorest path already computed
                            continue;

                    //check for shortest path
                    searchResult<T> res = graphSearch.astar(graph, startNode, destNode);
                    visitedNodes += res.visitedNodes;
                    testedAcs += res.testedArcs;

                    //path without start and dest
                    List<T> slist = res.sPath.GetRange(1, res.sPath.Count - 2);

                    //copy of the result for start to end and end to start
                    searchResult<T> rescpy = new searchResult<T>();
                    rescpy.testedArcs = res.testedArcs;
                    rescpy.totalCost = res.totalCost;
                    rescpy.visitedNodes = res.visitedNodes;
                    //copy of the list
                    rescpy.sPath = new List<T>(res.sPath);
                    rescpy.sPath.Reverse();

                    //store shortest path
                    shortestPath[startNode][destNode] = res;
                    shortestPath[destNode][startNode] = rescpy;

                    //don't add an arc if passing by one node in the subset (exept startNode and destNode)
                    if (slist.Intersect(subset).Any())
                        continue;

                    //add arcs to graph
                    arcs[startNode].enqueue(destNode,res.totalCost);
                    arcs[destNode].enqueue(startNode, res.totalCost);

                    

                }
            }

        }

        public int nbNeighbor(T node)
        {
            priorityQueue<T> listNeigh;
            if (arcs.TryGetValue(node, out listNeigh))
                return listNeigh.Count;
            else
                return 0;
        }
        public void removeArc(T n1, T n2)
        {
            priorityQueue<T> listNeigh;
            if (arcs.TryGetValue(n1, out listNeigh))
            {
                listNeigh.removeItem(n2);
            }
        }
        public void removeArcAt(T n1, int i)
        {
            priorityQueue<T> listNeigh;
            if (arcs.TryGetValue(n1, out listNeigh))
            {
                listNeigh.removeAt(i);
            }
        }
        public void addArc(T n1, T n2, double cost)
        {
            priorityQueue<T> listNeigh;
            if (!arcs.TryGetValue(n1, out listNeigh))
                arcs[n1] = new priorityQueue<T>();
            listNeigh.enqueue(new coupleItem<T, double>(n2, cost));
        }
        
        public IEnumerable<coupleItem<T, double>> neighbor(T node)
        {
            priorityQueue<T> listNeigh;
            if (arcs.TryGetValue(node, out listNeigh))
               return listNeigh.getList();
            return null;
        }

        public int nbNodes()
        {
            return arcs.Keys.Count;
        }
        public List<T> nodes()
        {
            return new List<T>(arcs.Keys);
        }

        public List<T> sPath(T n1, T n2)
        {
            double a;
            return sPath(n1, n2, out a);
        }
        public List<T> sPath(T n1, T n2, out double cost)
        {
            searchResult<T> res = shortestPath[n1][n2];
            cost = res.totalCost;
            return res.sPath;
        }
        public double getCost(T n1, T n2)
        {
            return shortestPath[n1][n2].totalCost;
        }
        public searchResult<T> getResult(T n1, T n2)
        {
            return shortestPath[n1][n2];
        }
    }
}
