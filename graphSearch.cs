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
            sPathFull = new List<TNode>();
        }
        public int visitedNodes;
        public int testedArcs;
        public double totalCost;
        public List<TNode> sPath;
        public List<TNode> sPathFull;
    }

    public static class graphSearch
    {

        #region ASTAR_REGION

        //default heuristic <=> Dijkstrat
        private static double zero<TNode>(TNode n1, TNode n2)
        {
            return 0;
        }

        //astar algorithm
        public static searchResult<TNode> astar<TNode>(IGraph<TNode> graph, TNode from, TNode to, heuristicMethod<TNode> heuristic = null, TreeView path = null) where TNode : GraphNode
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
                solutionQueue.enqueue(tn, 0);
                path.Nodes.Add(tn);
            }
            //*/
            while (!openNodes.isEmpty())
            {
                //get highest priority node
                TNode current = openNodes.dequeue();

                //*
                if (path != null)
                    curNode = solutionQueue.dequeue();
                //*/
                // increment opened nodes counter
                sRes.visitedNodes++;
                //break if goal reached
                if (current.Equals(to))
                    break;
                //check nieghbor of current
                foreach (coupleItem<TNode, double> arc in graph.neighbor(current))
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
                        fromNode[next] = new coupleItem<TNode, double>(current, totalCost);
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

        #endregion

        #region TOUR_SEARCH

        //tour search without constraint <=> tour search with constraint: tour length >= number of nodes in the graph 
        public static searchResult<TNode> tourSearch<TNode>(IGraph<TNode> graph, List<TNode> subset, TNode start) where TNode : GraphNode
        {
            return tourSearch(graph, subset, start, graph.nodes().Count);
        }

        //tour search with constraint
        //depthfirst search : we will have a very wide tree, better go deep to find a first solution then try to improve the result
        public static searchResult<TNode> tourSearch<TNode>(IGraph<TNode> graph, List<TNode> subset, TNode start, int tourLength) where TNode : GraphNode
        {
            if (!subset.Contains(start))
                subset.Add(start);
            //creation of the connected subgraph
            shortestSubGraph<TNode> sGraph = new shortestSubGraph<TNode>(graph, subset);
            //return value class:
            searchResult<TNode> sRes = new searchResult<TNode>();

            //variables for the recurise search function
            List<TNode> nodeToCheck = new List<TNode>();
            foreach (TNode n in sGraph.nodes())
                nodeToCheck.Add(n);
            nodeToCheck.Remove(start);
            List<TNode> currentPath = new List<TNode>();
            currentPath.Add(start);
            //glouton heuristic for initialistayion is not improving significatively the results
            //double minValue = GloutonHeuristique(sGraph, start).totalCost;
            double minValue = double.PositiveInfinity;

            //Recursive call
            recTourSearch(sGraph, start, ref nodeToCheck, ref currentPath, ref sRes, ref minValue, tourLength, tourLength);
            sRes.totalCost = minValue;
            //construct sub paths
            List<TNode> result = new List<TNode>();
            for (int i = 1; i < sRes.sPath.Count; ++i)
            {
                List<TNode> subPath = sGraph.sPath(sRes.sPath[i - 1], sRes.sPath[i]);
                subPath = subPath.GetRange(0, subPath.Count - 1);
                result.AddRange(subPath);
            }
            sRes.sPathFull = result;
            //TODO:
            //maybe add cost of precomputation to node and arc visited ?

            result.Add(start);
            return sRes;
        }


        //recursive search
        public static void recTourSearch<TNode>(shortestSubGraph<TNode> graph, TNode currentNode, ref List<TNode> nodeToCheck, ref List<TNode> currentPath, ref searchResult<TNode> res, ref double minValue, int currentTour, int tourLength) where TNode : GraphNode
        {

            double maxCost;
            double currentCost;

            //if all node visited, return
            int nodeVisited = graph.nbNodes() - nodeToCheck.Count;
            if (nodeVisited >= graph.nbNodes())
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
            //in case of tour constraint :
            if (nodeVisited > 1 && (nodeVisited - 1) % currentTour == 0)
            {
                //update next to constraint
                currentTour += tourLength;
                //if not at start, next town must be the strarting town
                if (!currentNode.Equals(currentPath.First()))
                {
                    currentPath.Add(currentPath.First());
                    res.totalCost += graph.getCost(currentNode, currentPath.First());
                }
                maxCost = 0;
                //here, currentNode is the starting node because of the constraint
                currentNode = currentPath.First();
            }
            maxCost = 0;
            //stop research if next iteration will be worst than the best result:
            //test cost to furthest node + back to start.
            //stop if cost >= best result found
            foreach (TNode next in nodeToCheck)
            {
                currentCost = graph.getCost(currentNode, next) + graph.getCost(next, currentPath.First());
                maxCost = Math.Max(currentCost, maxCost);
            }
            if (maxCost + res.totalCost >= minValue)
                return;

            //Check solutions from current node
            res.visitedNodes++;
            for (int i = 0; i < nodeToCheck.Count; ++i)
            {
                TNode next = nodeToCheck[i];
                res.testedArcs++;
                double cost = graph.getCost(currentNode, next);

                //store variables
                double previousCost = res.totalCost;
                int previousCount = currentPath.Count;
                nodeToCheck.RemoveAt(i);
                currentPath.Add(next);
                res.totalCost += cost;
                //recursive call
                recTourSearch(graph, next, ref nodeToCheck, ref currentPath, ref res, ref minValue, currentTour, tourLength);
                //restore variables
                nodeToCheck.Insert(i, next);
                currentPath.RemoveRange(previousCount, currentPath.Count - previousCount);
                res.totalCost = previousCost;

            }

        }

        //glouton heuristic to initialize the depthfirst search
        public static searchResult<TNode> GloutonHeuristique<TNode>(IGraph<TNode> graph, TNode StartingTown) where TNode : GraphNode
        {
            searchResult<TNode> result = new searchResult<TNode>();
            List<TNode> listNode = new List<TNode>();
            listNode.Add(StartingTown); result.sPath.Add(StartingTown);

            coupleItem<TNode, double> closestNode;
            IEnumerable<coupleItem<TNode, double>> listNeighbor;
            TNode t;
            int back = 0;

            //tant que toutes les villes n'ont pas été visitées
            while (listNode.Count() != graph.nodes().Count())
            {
                t = listNode.Last();
                result.visitedNodes++;

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
                    TNode tmp = listNode[listNode.Count() - back - 2];
                    listNode.Remove(tmp);
                    listNode.Add(tmp); result.sPath.Add(tmp);
                    result.totalCost += graph.getCost(listNode.Last(), listNode[listNode.Count() - 2]);
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
        #endregion

        #region COLORATION

        //check if 'color' is not present in 'current' neighboor
        private static bool checkColor<TNode>(IGraph<TNode> graph, TNode current, int color) where TNode : GraphNode
        {
            foreach (coupleItem<TNode, double> arcs in graph.neighbor(current))
                if (color == arcs.getItem().Color)
                    return false;
            return true;
        }

        //coloration algo
        //'nbColors' => colors available
        //ex: nbColors = {6,5,4}
        //=> 3 colors                       (nbColors.Count = 3)
        //=> 6 coloration max for color1    (nbColors[0] = 6)
        //=> 5 coloration max for color2    (nbColors[1] = 5)
        //=> 4 coloration max for color3    (nbColors[2] = 4)
        public static bool coloration<TNode>(IGraph<TNode> graph, List<int> nbColors) where TNode : GraphNode
        {
            List<TNode> notColoredNodes = new List<TNode>();
            foreach (TNode node in graph.nodes())
            {
                node.Color = -1;
                int i = 0;
                //insert node in order
                //maximum degree first
                while(i<notColoredNodes.Count && graph.nbNeighbor(notColoredNodes[i])>graph.nbNeighbor(node))
                    ++i;
                notColoredNodes.Insert(i,node);
            }
            //call recursive search
            return recColoration(graph, ref nbColors, ref notColoredNodes);
        }

        //recursive search
        public static bool recColoration<TNode>(IGraph<TNode> graph, ref List<int> nbColors, ref List<TNode> notColoredNode) where TNode : GraphNode
        {
            if (notColoredNode.Count == 0)
                return true;
            for (int n = 0; n < notColoredNode.Count; ++n)
            {
                TNode current = notColoredNode[n];
                notColoredNode.RemoveAt(n);
                for (int c = 0; c < nbColors.Count; ++c)
                    if (checkColor(graph, current, c) && nbColors[c] > 0)
                    {
                        //remove one from color c
                        nbColors[c]--;
                        current.Color = c;
                        if (recColoration(graph, ref nbColors, ref notColoredNode))
                            return true;
                        current.Color = -1;
                        //restore number
                        nbColors[c]++;
                    }
                notColoredNode.Insert(n, current);
            }
            return false;
        }

        #endregion
    }
}
