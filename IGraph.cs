using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace road_network
{
    public delegate double heuristicMethod<TNode>(TNode n1, TNode n2);
    
    public interface IGraph<TNode>
    {
        List<TNode> nodes();
        int nbNeighbor(TNode node);
        //get iterator on neighbors of 'node' : (Neighbor,Cost)
        IEnumerable<coupleItem<TNode, double>> neighbor(TNode node);

    }
}
