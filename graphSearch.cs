﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace road_network
{
    public struct astarResult<TNode>
    {
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
        public static astarResult<TNode> astar<TNode>  (IGraph<TNode> graph, TNode from, TNode to, heuristicMethod<TNode> heuristic = null, TreeView path = null)
        {
            if (heuristic == null)
                heuristic = graphSearch.zero;
            
            //return value strucure:
            astarResult<TNode> sRes = new astarResult<TNode>();
            sRes.visitedNodes = 0;
            sRes.testedArcs = 0;
            sRes.sPath = new List<TNode>();

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
                        openNodes.enqueue(next, totalCost + heuristic(current, next));

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
    }
}