using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReseauRoutier
{
    class Town : GenericNode
    {
        private List<Road> listRoad;

        public Town( string newname ) : base(newname)
        {
            listRoad = new List<Road>();
        }

        public void AddRoad(Road road)
        {
            listRoad.Add(road);
        }

        public override double GetArcCost(GenericNode N2) 
        {
            return 0;
        }
        
        public override bool EndState() 
        {
            return false;
        }
        
        public override List<GenericNode> GetListSucc() 
        {
            return new List<GenericNode>();
        }
        
        public override void CalculeHCost()
        {}
    }
}
