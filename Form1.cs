using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReseauRoutier
{
    public partial class Form1 : Form
    {
        enum enumTown { A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W };
        List<Town> listTown = new List<Town>();

        public Form1()
        {
            InitializeComponent();
            
            
            //Graphe initialization
            Graph g = new Graph();
            for(int i=0;i<22;i++) //
            {
                listTown.Add(new Town(""+(char)(i+65)));
            }
            Town B = getTown(enumTown.B);
        }

        public Town getTown(enumTown t)
        {   
            return listTown[(int)t];
        }
    }
}
