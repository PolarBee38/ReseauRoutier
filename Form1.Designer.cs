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
            this.lRes = new System.Windows.Forms.Label();
            this.cbStart = new System.Windows.Forms.ComboBox();
            this.cbEnd = new System.Windows.Forms.ComboBox();
            this.btnAstar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeRes
            // 
            this.treeRes.Location = new System.Drawing.Point(267, 12);
            this.treeRes.Name = "treeRes";
            this.treeRes.Size = new System.Drawing.Size(238, 252);
            this.treeRes.TabIndex = 0;
            // 
            // lRes
            // 
            this.lRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lRes.Location = new System.Drawing.Point(267, 293);
            this.lRes.Name = "lRes";
            this.lRes.Size = new System.Drawing.Size(238, 157);
            this.lRes.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 475);
            this.Controls.Add(this.btnAstar);
            this.Controls.Add(this.cbEnd);
            this.Controls.Add(this.cbStart);
            this.Controls.Add(this.lRes);
            this.Controls.Add(this.treeRes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeRes;
        private System.Windows.Forms.Label lRes;
        private System.Windows.Forms.ComboBox cbStart;
        private System.Windows.Forms.ComboBox cbEnd;
        private System.Windows.Forms.Button btnAstar;
    }
}

