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
            Town b = graph.addTown(new Town("ville B",true));
            Town c = graph.addTown(new Town("ville C"));
            Town d = graph.addTown(new Town("ville D"));
            Town e = graph.addTown(new Town("ville E"));
            Town f = graph.addTown(new Town("ville F",true));
            Town g = graph.addTown(new Town("ville G",true));
            Town h = graph.addTown(new Town("ville H",true));
            Town i = graph.addTown(new Town("ville I"));
            Town j = graph.addTown(new Town("ville J",true));
            Town k = graph.addTown(new Town("ville K"));
            Town l = graph.addTown(new Town("ville L"));
            Town m = graph.addTown(new Town("ville M",true));
            Town n = graph.addTown(new Town("ville N"));
            Town o = graph.addTown(new Town("ville O",true));
            Town p = graph.addTown(new Town("ville P"));
            Town q = graph.addTown(new Town("ville Q",true));
            Town r = graph.addTown(new Town("ville R"));
            Town s = graph.addTown(new Town("ville S",true));
            Town t = graph.addTown(new Town("ville T",true));
            Town u = graph.addTown(new Town("ville U"));
            Town v = graph.addTown(new Town("ville V",true));
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
                if(town.isFarm) //If the town is a farm, we check the town
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
            var watch = System.Diagnostics.Stopwatch.StartNew();
            searchResult<Town> searchRes = graphSearch.astar(graph, st, end, null, treeRes);
            watch.Stop();
            lRes.Text = "";
            lRes.Text += "Elapsed time :\t" + watch.ElapsedMilliseconds + "ms\r\n";
            for (int i = 1; i < searchRes.sPath.Count; ++i)
            {
                Town A = searchRes.sPath[i - 1];
                Town B = searchRes.sPath[i];
                lRes.Text += A.ToString() + "\t->\t" + B.ToString() + "\t(" + graph.getCost(A, B) + ")\r\n";
            }
            lRes.Text += "\r\nTotal cost : " + searchRes.totalCost;
            lRes.Text += "\r\n" + searchRes.visitedNodes + " villes visitées."+ "\r\n routes testées: " + searchRes.testedArcs;
        }


        private void btnTour_Click(object sender, EventArgs e)
        {
            treeRes.Nodes.Clear();

            //Get town's list
            List<Town> listTown = new List<Town>();
            foreach (object itemChecked in checkedListBoxFarm.CheckedItems)
                listTown.Add((Town)itemChecked);
           
            //newGraph = graph.newSubMap(listTown, out listPath);
            lRes.Text = "";
            var watch = System.Diagnostics.Stopwatch.StartNew();
            searchResult<Town> res = graphSearch.tourSearch(graph, listTown);
            watch.Stop();
            lRes.Text += "Elapsed time :\t" + watch.ElapsedMilliseconds +"ms\r\n";
            lRes.Text += "Total cost:\t" + res.totalCost + "\r\nNode visited:\t" + res.visitedNodes + "\r\nArc tested:\t" + res.testedArcs + "\r\n";
            //test pour afficher les voisins du nouveau graphe
            for(int i = 1; i<res.sPath.Count;i++)
            {
                lRes.Text += res.sPath[i - 1].ToString() + "\t->\t" + res.sPath[i].ToString() + "\t(" + graph.getCost(res.sPath[i - 1], res.sPath[i]) + ")\r\n";

            }
        }
    }
}
