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
                cbRouteStart.Items.Add(town);
            }
            cbStart.SelectedIndex = 0;
            cbEnd.SelectedIndex = 0;
            nUDtownPerTour.Minimum = 1;
            nUDtownPerTour.Maximum = graph.nodes().Count;
            nUDtownPerTour.Value = 4;
            cbRouteStart.SelectedIndex = 0;
            
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
            Town start = (Town)cbRouteStart.SelectedItem;
            lRes.Text = "";
            var watch = System.Diagnostics.Stopwatch.StartNew();
            searchResult<Town> res;
            if(checkBox1.Checked)
                res = graphSearch.tourSearch(graph, listTown, start, (int)nUDtownPerTour.Value);
            else
                res = graphSearch.tourSearch(graph, listTown, start);

            watch.Stop();
            lRes.Text += "Elapsed time :\t" + watch.ElapsedMilliseconds +"ms\r\n";
            lRes.Text += "Total cost:\t" + res.totalCost + "\r\nNode visited:\t" + res.visitedNodes + "\r\nArc tested:\t" + res.testedArcs + "\r\n";
            //test pour afficher les voisins du nouveau graphe
            lRes.Text += "\r\nGlobal path:\r\n"; 
            for (int i = 0; i < res.sPath.Count; i++)
            {
                lRes.Text += res.sPath[i].ToString() + " -> ";
            }
            lRes.Text += "\r\n\r\nDetailed path:\r\n";
            for(int i = 1; i<res.sPathFull.Count;i++)
            {
                lRes.Text += res.sPathFull[i - 1].ToString() + "\t->\t" + res.sPathFull[i].ToString() + "\t(" + graph.getCost(res.sPathFull[i - 1], res.sPathFull[i]) + ")\r\n";

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lMaxTownTour.Enabled = checkBox1.Checked;
            nUDtownPerTour.Enabled = checkBox1.Checked;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            List<int> nbColors = new List<int>();
            nbColors.Add(8);//8 for the 1st color
            nbColors.Add(8);//8 for the second
            nbColors.Add(7);//7 for the third
            if (!graphSearch.coloration(graph, nbColors))
                lRes.Text = "not solution found";
            else
            {
                lRes.Text = "Colors\r\n";
                foreach (Town t in graph.nodes())
                    lRes.Text += t + " sc:" +(t.Color+1)+"\r\n"; 
            }
        }
    }
}