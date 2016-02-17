﻿using System;
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
       
    }
}