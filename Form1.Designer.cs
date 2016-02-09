namespace ReseauRoutier
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_Result = new System.Windows.Forms.TextBox();
            this.B_Display_DeadEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_Result
            // 
            this.TB_Result.Location = new System.Drawing.Point(445, 253);
            this.TB_Result.Name = "TB_Result";
            this.TB_Result.Size = new System.Drawing.Size(208, 20);
            this.TB_Result.TabIndex = 0;
            // 
            // B_Display_DeadEnd
            // 
            this.B_Display_DeadEnd.Location = new System.Drawing.Point(445, 307);
            this.B_Display_DeadEnd.Name = "B_Display_DeadEnd";
            this.B_Display_DeadEnd.Size = new System.Drawing.Size(208, 23);
            this.B_Display_DeadEnd.TabIndex = 1;
            this.B_Display_DeadEnd.Text = "button1";
            this.B_Display_DeadEnd.UseVisualStyleBackColor = true;
            this.B_Display_DeadEnd.Click += new System.EventHandler(this.B_Display_DeadEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 421);
            this.Controls.Add(this.B_Display_DeadEnd);
            this.Controls.Add(this.TB_Result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Result;
        private System.Windows.Forms.Button B_Display_DeadEnd;
    }
}