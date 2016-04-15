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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lMaxTownTour = new System.Windows.Forms.Label();
            this.nUDtownPerTour = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbRouteStart = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbColor3 = new System.Windows.Forms.TextBox();
            this.tbColor2 = new System.Windows.Forms.TextBox();
            this.tbColor1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDtownPerTour)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.lRes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lRes.Location = new System.Drawing.Point(10, 10);
            this.lRes.Margin = new System.Windows.Forms.Padding(10);
            this.lRes.Multiline = true;
            this.lRes.Name = "lRes";
            this.lRes.ReadOnly = true;
            this.lRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lRes.Size = new System.Drawing.Size(881, 242);
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
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 377);
            this.panel1.TabIndex = 8;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Destination town :";
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
            this.panel2.Location = new System.Drawing.Point(274, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 377);
            this.panel2.TabIndex = 9;
            // 
            // lMaxTownTour
            // 
            this.lMaxTownTour.AutoSize = true;
            this.lMaxTownTour.Enabled = false;
            this.lMaxTownTour.Location = new System.Drawing.Point(246, 110);
            this.lMaxTownTour.Name = "lMaxTownTour";
            this.lMaxTownTour.Size = new System.Drawing.Size(82, 13);
            this.lMaxTownTour.TabIndex = 10;
            this.lMaxTownTour.Text = "Max town/tour :";
            // 
            // nUDtownPerTour
            // 
            this.nUDtownPerTour.Enabled = false;
            this.nUDtownPerTour.Location = new System.Drawing.Point(344, 108);
            this.nUDtownPerTour.Name = "nUDtownPerTour";
            this.nUDtownPerTour.Size = new System.Drawing.Size(75, 20);
            this.nUDtownPerTour.TabIndex = 9;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(222, 85);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(162, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Limit number of town per tour";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbRouteStart
            // 
            this.cbRouteStart.FormattingEnabled = true;
            this.cbRouteStart.Location = new System.Drawing.Point(222, 52);
            this.cbRouteStart.Name = "cbRouteStart";
            this.cbRouteStart.Size = new System.Drawing.Size(197, 21);
            this.cbRouteStart.TabIndex = 5;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Towns to visit :";
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
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(3, 149);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(174, 221);
            this.btnColor.TabIndex = 10;
            this.btnColor.Text = "Coloration";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(901, 400);
            this.panel3.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.tbColor3);
            this.panel5.Controls.Add(this.tbColor2);
            this.panel5.Controls.Add(this.tbColor1);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.btnColor);
            this.panel5.Location = new System.Drawing.Point(707, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(184, 377);
            this.panel5.TabIndex = 11;
            // 
            // tbColor3
            // 
            this.tbColor3.Location = new System.Drawing.Point(68, 109);
            this.tbColor3.Name = "tbColor3";
            this.tbColor3.Size = new System.Drawing.Size(109, 20);
            this.tbColor3.TabIndex = 17;
            this.tbColor3.Text = "sculpt 3";
            // 
            // tbColor2
            // 
            this.tbColor2.Location = new System.Drawing.Point(68, 80);
            this.tbColor2.Name = "tbColor2";
            this.tbColor2.Size = new System.Drawing.Size(109, 20);
            this.tbColor2.TabIndex = 16;
            this.tbColor2.Text = "sculpt 2";
            // 
            // tbColor1
            // 
            this.tbColor1.Location = new System.Drawing.Point(68, 49);
            this.tbColor1.Name = "tbColor1";
            this.tbColor1.Size = new System.Drawing.Size(109, 20);
            this.tbColor1.TabIndex = 15;
            this.tbColor1.Text = "sculpt 1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Color 2 (7) :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Color 3 (3) :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Color 1 (8):";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "3-Coloration";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lRes);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 400);
            this.panel4.Margin = new System.Windows.Forms.Padding(10);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(901, 262);
            this.panel4.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 662);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDtownPerTour)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbColor3;
        private System.Windows.Forms.TextBox tbColor2;
        private System.Windows.Forms.TextBox tbColor1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

