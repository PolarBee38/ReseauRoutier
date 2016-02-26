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
            this.SuspendLayout();
            // 
            // treeRes
            // 
            this.treeRes.Location = new System.Drawing.Point(267, 12);
            this.treeRes.Name = "treeRes";
            this.treeRes.Size = new System.Drawing.Size(238, 252);
            this.treeRes.TabIndex = 0;
            // 
            // cbStart
            // 
            this.cbStart.FormattingEnabled = true;
            this.cbStart.Location = new System.Drawing.Point(27, 357);
            this.cbStart.Name = "cbStart";
            this.cbStart.Size = new System.Drawing.Size(210, 21);
            this.cbStart.TabIndex = 2;
            // 
            // cbEnd
            // 
            this.cbEnd.FormattingEnabled = true;
            this.cbEnd.Location = new System.Drawing.Point(27, 395);
            this.cbEnd.Name = "cbEnd";
            this.cbEnd.Size = new System.Drawing.Size(210, 21);
            this.cbEnd.TabIndex = 3;
            // 
            // btnAstar
            // 
            this.btnAstar.Location = new System.Drawing.Point(27, 426);
            this.btnAstar.Name = "btnAstar";
            this.btnAstar.Size = new System.Drawing.Size(210, 23);
            this.btnAstar.TabIndex = 4;
            this.btnAstar.Text = "A* algo";
            this.btnAstar.UseVisualStyleBackColor = true;
            this.btnAstar.Click += new System.EventHandler(this.btnAstar_Click);
            // 
            // checkedListBoxFarm
            // 
            this.checkedListBoxFarm.CheckOnClick = true;
            this.checkedListBoxFarm.FormattingEnabled = true;
            this.checkedListBoxFarm.Location = new System.Drawing.Point(27, 13);
            this.checkedListBoxFarm.Name = "checkedListBoxFarm";
            this.checkedListBoxFarm.Size = new System.Drawing.Size(210, 259);
            this.checkedListBoxFarm.TabIndex = 5;
            // 
            // btnTour
            // 
            this.btnTour.Location = new System.Drawing.Point(27, 279);
            this.btnTour.Name = "btnTour";
            this.btnTour.Size = new System.Drawing.Size(210, 23);
            this.btnTour.TabIndex = 6;
            this.btnTour.Text = "Cities Tour";
            this.btnTour.UseVisualStyleBackColor = true;
            this.btnTour.Click += new System.EventHandler(this.btnTour_Click);
            // 
            // lRes
            // 
            this.lRes.Location = new System.Drawing.Point(267, 282);
            this.lRes.Multiline = true;
            this.lRes.Name = "lRes";
            this.lRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lRes.Size = new System.Drawing.Size(238, 368);
            this.lRes.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 662);
            this.Controls.Add(this.lRes);
            this.Controls.Add(this.btnTour);
            this.Controls.Add(this.checkedListBoxFarm);
            this.Controls.Add(this.btnAstar);
            this.Controls.Add(this.cbEnd);
            this.Controls.Add(this.cbStart);
            this.Controls.Add(this.treeRes);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

