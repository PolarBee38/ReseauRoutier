using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace road_network
{
    public partial class Form1 : Form
    {
        genericGraph<Town> graph= new genericGraph<Town>();
        public Form1()
        {
            InitializeComponent();
            Town a = graph.addTown(new Town("ville A"));
            Town b = graph.addTown(new Town("ville B"));
            Town c = graph.addTown(new Town("ville C"));
            Town d = graph.addTown(new Town("ville D"));
            Town e = graph.addTown(new Town("ville E"));
            Town f = graph.addTown(new Town("ville F"));
            Town g = graph.addTown(new Town("ville G"));
            Town h = graph.addTown(new Town("ville H"));
            Town i = graph.addTown(new Town("ville I"));
            Town j = graph.addTown(new Town("ville J"));
            Town k = graph.addTown(new Town("ville K"));
            Town l = graph.addTown(new Town("ville L"));
            Town m = graph.addTown(new Town("ville M"));
            Town n = graph.addTown(new Town("ville N"));
            Town o = graph.addTown(new Town("ville O"));
            Town p = graph.addTown(new Town("ville P"));
            Town q = graph.addTown(new Town("ville Q"));
            Town r = graph.addTown(new Town("ville R"));
            Town s = graph.addTown(new Town("ville S"));
            Town t = graph.addTown(new Town("ville T"));
            Town u = graph.addTown(new Town("ville U"));
            Town v = graph.addTown(new Town("ville V"));
            Town w = graph.addTown(new Town("ville W"));
            //a
            graph.addRoad(a, b, 4);
            graph.addRoad(a, c, 5);
            graph.addRoad(a, d, 6);
            //b
            graph.addRoad(b, e, 5);
            //c
            graph.addRoad(c, e, 6);
            graph.addRoad(c, d, 4);
            graph.addRoad(c, g, 8);
            //d
            graph.addRoad(d, f, 9);
            //e
            graph.addRoad(e, h, 4);
            //f
            graph.addRoad(f, l, 9);
            //g
            graph.addRoad(g, h, 8);
            graph.addRoad(g, k, 8);
            //h
            graph.addRoad(h, i, 2);
            //i
            graph.addRoad(i, j, 3);
            graph.addRoad(i, k, 4);
            //k
            graph.addRoad(k, w, 7);
            //l
            graph.addRoad(l, m, 2);
            graph.addRoad(l, n, 4);
            graph.addRoad(l, q, 7);
            graph.addRoad(l, w, 10);
            //n
            graph.addRoad(n, o, 7);
            graph.addRoad(n, p, 3);
            //o
            graph.addRoad(o, s, 8);
            graph.addRoad(o, p, 3);
            //p
            graph.addRoad(p, r, 5);
            //q
            graph.addRoad(q, r, 3);
            //r
            graph.addRoad(r, t, 6);
            //s
            graph.addRoad(s, u, 7);
            //t
            graph.addRoad(t, u, 5);
            //u
            graph.addRoad(u, v, 11);
            //v
            graph.addRoad(v, w, 6);

            //Initialize checkBoxItems
            foreach (Town town in graph.nodes())
            {
                if(false) //If the town is a farm, we check the town
                {
                    checkedListBoxFarm.Items.Add(town, true);
                }
                else
                {
                    checkedListBoxFarm.Items.Add(town);
                }
                cbStart.Items.Add(town);
                cbEnd.Items.Add(town);
            }
            cbStart.SelectedIndex = 0;
            cbEnd.SelectedIndex = 0;

            
        }

        private void btnAstar_Click(object sender, EventArgs e)
        {
            Town st = (Town)cbStart.SelectedItem;
            Town end = (Town)cbEnd.SelectedItem;
            searchResult<Town> searchRes = graphSearch.astar(graph, st, end, null, treeRes);
            lRes.Text = "";
            for (int i = 1; i < searchRes.sPath.Count; ++i)
            {
                Town A = searchRes.sPath[i - 1];
                Town B = searchRes.sPath[i];
                lRes.Text += A.ToString() + " -> " + B.ToString() + " (" + graph.getCost(A, B) + ")\n";
            }
            lRes.Text += "\nTotal cost : " + searchRes.totalCost;
            lRes.Text += "\n" + searchRes.visitedNodes + " villes visitées."+"\n routes testées: "+searchRes.testedArcs;
        }

        private void btnTour_Click(object sender, EventArgs e)
        {
            List<Town> listTown = new List<Town>();
            List<List<Town>> listPath;
            genericGraph<Town> newGraph;
            foreach (object itemChecked in checkedListBoxFarm.CheckedItems)
            {
                listTown.Add((Town)itemChecked);
            }
            //newGraph = graph.newSubMap(listTown, out listPath);
            lRes.Text = "";
            shortestSubGraph<Town> sg = new shortestSubGraph<Town>(graph, listTown);

            /*
            //test pour afficher es voisins du nouveau graphe
            List<coupleItem<Town, double>> neigh = sg.neighbor(sg.nodes()[0]).ToList();
            int nbElem = neigh.Count;
            for(int i = 0;i< nbElem;++i)
            {
                lRes.Text += neigh[i].getItem().ToString() + " : " + neigh[i].getValue() + "\n";
               
            }
            */

        }
    }
}
