using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace road_network
{
    public class searchResult<TNode>
    {
        public searchResult()
        {
            visitedNodes = 0;
            testedArcs = 0;
            totalCost = 0;
            sPath = new List<TNode>();
        }
        public int visitedNodes;
        public int testedArcs;
        public double totalCost;
        public List<TNode> sPath;
    }
    
    public static class graphSearch
    {

        //default heuristic <=> Dijkstrat
        private static double zero<TNode>(TNode n1, TNode n2)
        {
            return 0;
        }

        //depthfirst search : we will have a very wide tree, better go deep to find a first solution then try to improve the result
        public static searchResult<TNode> tourSearch<TNode>(IGraph<TNode> graph, List<TNode> subset, TNode start) where TNode : GraphNode
        {
            shortestSubGraph<TNode> sGraph = new shortestSubGraph<TNode>(graph, subset);
            //return value class:
            searchResult<TNode> sRes = new searchResult<TNode>();

            //variables for the recurise search function
            Dictionary<TNode, int> passedBy = new Dictionary<TNode, int>();
            foreach (TNode n in sGraph.nodes())
                passedBy[n] = 0;
            passedBy[start] = 1;
            List<TNode> currentPath = new List<TNode>();
            currentPath.Add(start);
            double minValue = /*GloutonHeuristique(sGraph, start).totalCost;*/double.PositiveInfinity;

            //Recursive call
            recTourSearch(sGraph, start, ref passedBy, ref currentPath, ref sRes, ref minValue);
            sRes.totalCost = minValue;
            //construct sub paths
            List<TNode> result = new List<TNode>();
            for(int i = 1; i<sRes.sPath.Count; ++i)
            {
                List<TNode> subPath = sGraph.sPath(sRes.sPath[i - 1], sRes.sPath[i]);
                subPath = subPath.GetRange(0, subPath.Count - 1);
                result.AddRange(subPath);
            }
            sRes.sPath = result;
            //TODO:
            //maybe add cost of precomputation to node and arc visited ?
           
            result.Add(start);
            return sRes;
        }
        public static void recTourSearch<TNode>(shortestSubGraph<TNode> graph, TNode currentNode, ref Dictionary<TNode,int> passedBy, ref List<TNode> currentPath, ref searchResult<TNode> res, ref double minValue) where TNode :GraphNode
        {
            //if all node visited, return
            int newNodeVisited = passedBy.Count(x => x.Value > 0);
            if (newNodeVisited >= graph.nbNodes())
            {
                //add cost from last to start
                res.totalCost += graph.getCost(currentPath.Last(), currentPath.First());
                //save current path
                res.sPath = new List<TNode>(currentPath);
                //add start at the end
                res.sPath.Add(res.sPath.First());
                //update min cost
                minValue = res.totalCost;
                return;
            }
            res.visitedNodes++;
            //iterate over neighbor of curent node
            List<coupleItem<TNode, double>> arcs = graph.neighbor(currentNode).ToList();
            for( int i = 0; i<graph.neighbor(currentNode).Count();++i)
            {
                TNode next = arcs[i].getItem();
                double cost = arcs[i].getValue();

                //stop research if next iteration will be worst than the better result found
                if (res.totalCost + cost + graph.getCost(next, currentPath.First()) >= minValue)
                    continue;

                res.testedArcs++;

                double previousCost = res.totalCost;
                //update variables
                passedBy[next]++;
                currentPath.Add(next);
                res.totalCost += cost;
                //remove the arc
                graph.removeArcAt(currentNode, i);
                //recursive call
                recTourSearch(graph, next, ref passedBy, ref currentPath, ref res, ref minValue);
                //restore variables
                passedBy[next]--;
                currentPath.RemoveAt(currentPath.Count-1);
                res.totalCost = previousCost;
                //readd the arc removed
                graph.addArc(currentNode, next, cost);
            }

        }

        //astar algorithm
        public static searchResult<TNode> astar<TNode>  (IGraph<TNode> graph, TNode from, TNode to, heuristicMethod<TNode> heuristic = null, TreeView path = null) where TNode :GraphNode
        {
            if (heuristic == null)
                heuristic = graphSearch.zero;
            
            //return value strucure:
            searchResult<TNode> sRes = new searchResult<TNode>();
           
            //priority queue for opened nodes (sorted by priority)
            priorityQueue<TNode> openNodes = new priorityQueue<TNode>();

            //Dicionary to store parent and lowest cost to origin node
            //<=> closed nodes  + totalCost (Gcost + Hcost)
            Dictionary<TNode, coupleItem<TNode, double>> fromNode = new Dictionary<TNode, coupleItem<TNode, double>>();

            //add origin node in queue, with highest priority
            openNodes.enqueue(from, 0);
            //add origin node in closed with lowest cost
            fromNode[from] = new coupleItem<TNode, double>(from, 0.0);

            //*To display solutions in tree view
            priorityQueue<TreeNode> solutionQueue = new priorityQueue<TreeNode>();
            TreeNode curNode = new TreeNode();
            if (path != null)
            {
                path.Nodes.Clear();
                TreeNode tn = new TreeNode(from.ToString());
                solutionQueue.enqueue(tn,0);
                path.Nodes.Add(tn);
            }
            //*/
            while (!openNodes.isEmpty())
            {
                //get highest priority node
                TNode current = openNodes.dequeue();

                //*
                if(path!=null)
                    curNode = solutionQueue.dequeue();
                //*/
                // increment opened nodes counter
                sRes.visitedNodes++;
                //break if goal reached
                if (current.Equals(to))
                    break;
                //check nieghbor of current
                foreach ( coupleItem<TNode, double> arc in graph.neighbor(current))
                {
                    TNode next = arc.getItem();
                    double costToNext = arc.getValue();
                    double costToCurrent = fromNode[current].getValue();
                    double totalCost = costToCurrent + costToNext;
                    //add in prority queue only if next not visited or newcost<oldcost
                    if (!fromNode.ContainsKey(next) || totalCost < fromNode[next].getValue())
                    {
                        //store cost and parent
                        sRes.testedArcs++;
                        fromNode[next] = new coupleItem<TNode,double>(current, totalCost);
                        //add node to openNodes
                        openNodes.enqueue(next, totalCost + heuristic(next, to));

                        //*
                        if (path != null)
                        {
                            TreeNode child = new TreeNode(next.ToString());
                            curNode.Nodes.Add(child);
                            solutionQueue.enqueue(child, totalCost + heuristic(current, next));
                        }
                        //*/
                    }

                }

            }
            //reconstruct path
            TNode n = to;
            while (!n.Equals(from))
            {
                sRes.sPath.Insert(0, n);
                n = fromNode[n].getItem();
            }
            sRes.sPath.Insert(0, from);
            sRes.totalCost = fromNode[to].getValue();
            //return results
            return sRes;
        }

        public static searchResult<TNode> GloutonHeuristique<TNode> (IGraph<TNode> graph, TNode StartingTown) where TNode : GraphNode
        {
            searchResult<TNode> result = new searchResult<TNode>();
            List<TNode> listNode = new List<TNode>();
            listNode.Add(StartingTown); result.sPath.Add(StartingTown);

            coupleItem<TNode,double> closestNode;
            IEnumerable<coupleItem<TNode, double>> listNeighbor;
            TNode t;
            int back = 0;

            //tant que toutes les villes n'ont pas été visitées
            while(listNode.Count() != graph.nodes().Count())
            {
                t = listNode.Last();
                result.visitedNodes ++;

                listNeighbor = graph.neighbor(t);
                closestNode = new coupleItem<TNode, double>(null, double.PositiveInfinity);
                foreach (coupleItem<TNode, double> couple in listNeighbor) //Find the closest Node
                {
                    //if the route did not already went throught this Node, we test if tis is the nearest Node
                    if (!listNode.Contains(couple.getItem() as TNode) && couple.getValue() < closestNode.getValue()) 
                    {
                        closestNode = new coupleItem<TNode, double>(couple.getItem(), couple.getValue());
                        result.testedArcs++;
                    }
                }

                //if the last tested node is a remote node, we turn back to a previous node. 
                if (closestNode.getValue().Equals(double.PositiveInfinity) || closestNode.getItem().Equals(null))
                {
                    TNode tmp = listNode[listNode.Count()-back-2];
                    listNode.Remove(tmp);
                    listNode.Add(tmp); result.sPath.Add(tmp);
                    result.totalCost += graph.getCost(listNode.Last(), listNode[listNode.Count()-2]);
                    back++;
                }
                else //we found the nearest Node
                {
                    //back = 0;
                    listNode.Add(closestNode.getItem());
                    result.sPath.Add(closestNode.getItem());
                    result.totalCost += closestNode.getValue();
                }
            } //end while we visited every town
            //We count the cost to reach the first city :
            searchResult<TNode> tmpresult = astar(graph, result.sPath.Last(), StartingTown, null, null);
            result.totalCost += tmpresult.totalCost;
            
            return result;
        }
    }
}
