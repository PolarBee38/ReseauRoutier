using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace road_network
{
    public delegate double heuristicMethod<TNode>(TNode n1, TNode n2);

    public abstract class GraphNode
    {
        protected string pname;
        public string Name
        {
            get
            {
                return pname;
            }
            set
            {
                pname = value;
            }
        }
        public abstract override string ToString();
    }

    public interface IGraph<TNode> where TNode : GraphNode
    {
        List<TNode> nodes();
        int nbNeighbor(TNode node);
        double getCost(TNode n1, TNode n2);
        //get iterator on neighbors of 'node' : (Neighbor,Cost)
        IEnumerable<coupleItem<TNode, double>> neighbor(TNode node);

    }
}
