namespace road_network
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeRes = new System.Windows.Forms.TreeView();
            this.cbStart = new System.Windows.Forms.ComboBox();
            this.cbEnd = new System.Windows.Forms.ComboBox();
            this.btnAstar = new System.Windows.Forms.Button();
            this.checkedListBoxFarm = new System.Windows.Forms.CheckedListBox();
            this.btnTour = new System.Windows.Forms.Button();
            this.lRes = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbRouteStart = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.nUDtownPerTour = new System.Windows.Forms.NumericUpDown();
            this.lMaxTownTour = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDtownPerTour)).BeginInit();
            this.SuspendLayout();
            // 
            // treeRes
            // 
            this.treeRes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.treeRes.Location = new System.Drawing.Point(0, 229);
            this.treeRes.Name = "treeRes";
            this.treeRes.Size = new System.Drawing.Size(252, 144);
            this.treeRes.TabIndex = 0;
            // 
            // cbStart
            // 
            this.cbStart.FormattingEnabled = true;
            this.cbStart.Location = new System.Drawing.Point(6, 52);
            this.cbStart.Name = "cbStart";
            this.cbStart.Size = new System.Drawing.Size(243, 21);
            this.cbStart.TabIndex = 2;
            // 
            // cbEnd
            // 
            this.cbEnd.FormattingEnabled = true;
            this.cbEnd.Location = new System.Drawing.Point(6, 108);
            this.cbEnd.Name = "cbEnd";
            this.cbEnd.Size = new System.Drawing.Size(243, 21);
            this.cbEnd.TabIndex = 3;
            // 
            // btnAstar
            // 
            this.btnAstar.Location = new System.Drawing.Point(6, 149);
            this.btnAstar.Name = "btnAstar";
            this.btnAstar.Size = new System.Drawing.Size(243, 43);
            this.btnAstar.TabIndex = 4;
            this.btnAstar.Text = "Shortest path";
            this.btnAstar.UseVisualStyleBackColor = true;
            this.btnAstar.Click += new System.EventHandler(this.btnAstar_Click);
            // 
            // checkedListBoxFarm
            // 
            this.checkedListBoxFarm.CheckOnClick = true;
            this.checkedListBoxFarm.FormattingEnabled = true;
            this.checkedListBoxFarm.Location = new System.Drawing.Point(6, 52);
            this.checkedListBoxFarm.Name = "checkedListBoxFarm";
            this.checkedListBoxFarm.Size = new System.Drawing.Size(210, 319);
            this.checkedListBoxFarm.TabIndex = 5;
            // 
            // btnTour
            // 
            this.btnTour.Location = new System.Drawing.Point(222, 149);
            this.btnTour.Name = "btnTour";
            this.btnTour.Size = new System.Drawing.Size(197, 221);
            this.btnTour.TabIndex = 6;
            this.btnTour.Text = "Route search";
            this.btnTour.UseVisualStyleBackColor = true;
            this.btnTour.Click += new System.EventHandler(this.btnTour_Click);
            // 
            // lRes
            // 
            this.lRes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lRes.Location = new System.Drawing.Point(0, 406);
            this.lRes.Multiline = true;
            this.lRes.Name = "lRes";
            this.lRes.ReadOnly = true;
            this.lRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lRes.Size = new System.Drawing.Size(856, 256);
            this.lRes.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAstar);
            this.panel1.Controls.Add(this.treeRes);
            this.panel1.Controls.Add(this.cbStart);
            this.panel1.Controls.Add(this.cbEnd);
            this.panel1.Location = new System.Drawing.Point(23, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 377);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "A star algorithm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Starting town :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Destination town :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Search tree :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lMaxTownTour);
            this.panel2.Controls.Add(this.nUDtownPerTour);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.cbRouteStart);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.checkedListBoxFarm);
            this.panel2.Controls.Add(this.btnTour);
            this.panel2.Location = new System.Drawing.Point(409, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 377);
            this.panel2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(422, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Route search";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Towns to visit :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Starting town :";
            // 
            // cbRouteStart
            // 
            this.cbRouteStart.FormattingEnabled = true;
            this.cbRouteStart.Location = new System.Drawing.Point(222, 52);
            this.cbRouteStart.Name = "cbRouteStart";
            this.cbRouteStart.Size = new System.Drawing.Size(197, 21);
            this.cbRouteStart.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(225, 80);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(162, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Limit number of town per tour";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // nUDtownPerTour
            // 
            this.nUDtownPerTour.Enabled = false;
            this.nUDtownPerTour.Location = new System.Drawing.Point(344, 103);
            this.nUDtownPerTour.Name = "nUDtownPerTour";
            this.nUDtownPerTour.Size = new System.Drawing.Size(75, 20);
            this.nUDtownPerTour.TabIndex = 9;
            // 
            // lMaxTownTour
            // 
            this.lMaxTownTour.AutoSize = true;
            this.lMaxTownTour.Enabled = false;
            this.lMaxTownTour.Location = new System.Drawing.Point(241, 105);
            this.lMaxTownTour.Name = "lMaxTownTour";
            this.lMaxTownTour.Size = new System.Drawing.Size(82, 13);
            this.lMaxTownTour.TabIndex = 10;
            this.lMaxTownTour.Text = "Max town/tour :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 662);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lRes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDtownPerTour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeRes;
        private System.Windows.Forms.ComboBox cbStart;
        private System.Windows.Forms.ComboBox cbEnd;
        private System.Windows.Forms.Button btnAstar;
        private System.Windows.Forms.CheckedListBox checkedListBoxFarm;
        private System.Windows.Forms.Button btnTour;
        private System.Windows.Forms.TextBox lRes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lMaxTownTour;
        private System.Windows.Forms.NumericUpDown nUDtownPerTour;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cbRouteStart;
        private System.Windows.Forms.Label label7;
    }
}

