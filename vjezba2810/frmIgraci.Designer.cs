namespace vjezba2810
{
    partial class frmIgraci
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIgrac1 = new System.Windows.Forms.TextBox();
            this.txtIgrac2 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Igrac1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Igrac2:";
            // 
            // txtIgrac1
            // 
            this.txtIgrac1.Location = new System.Drawing.Point(161, 41);
            this.txtIgrac1.Name = "txtIgrac1";
            this.txtIgrac1.Size = new System.Drawing.Size(148, 26);
            this.txtIgrac1.TabIndex = 2;
            // 
            // txtIgrac2
            // 
            this.txtIgrac2.Location = new System.Drawing.Point(161, 95);
            this.txtIgrac2.Name = "txtIgrac2";
            this.txtIgrac2.Size = new System.Drawing.Size(148, 26);
            this.txtIgrac2.TabIndex = 3;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(213, 145);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(96, 35);
            this.button10.TabIndex = 10;
            this.button10.Text = "START";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // frmIgraci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(371, 203);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.txtIgrac2);
            this.Controls.Add(this.txtIgrac1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmIgraci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IGRACI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIgrac1;
        private System.Windows.Forms.TextBox txtIgrac2;
        private System.Windows.Forms.Button button10;
    }
}