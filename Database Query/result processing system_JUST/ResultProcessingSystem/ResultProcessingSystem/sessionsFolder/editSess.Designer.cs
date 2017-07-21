namespace ResultProcessingSystem.sessionsFolder
{
    partial class editSess
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPInsCon = new System.Windows.Forms.Button();
            this.comboBoxPInsCon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxInsProg = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxInsProg);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonPInsCon);
            this.panel1.Controls.Add(this.comboBoxPInsCon);
            this.panel1.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(26, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 92);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "বিভাগঃ ";
            // 
            // buttonPInsCon
            // 
            this.buttonPInsCon.Location = new System.Drawing.Point(378, 48);
            this.buttonPInsCon.Name = "buttonPInsCon";
            this.buttonPInsCon.Size = new System.Drawing.Size(75, 23);
            this.buttonPInsCon.TabIndex = 1;
            this.buttonPInsCon.Text = "যোজন ";
            this.buttonPInsCon.UseVisualStyleBackColor = true;
            this.buttonPInsCon.Click += new System.EventHandler(this.buttonPInsCon_Click);
            // 
            // comboBoxPInsCon
            // 
            this.comboBoxPInsCon.FormattingEnabled = true;
            this.comboBoxPInsCon.Location = new System.Drawing.Point(88, 14);
            this.comboBoxPInsCon.Name = "comboBoxPInsCon";
            this.comboBoxPInsCon.Size = new System.Drawing.Size(396, 25);
            this.comboBoxPInsCon.TabIndex = 0;
            this.comboBoxPInsCon.SelectedIndexChanged += new System.EventHandler(this.comboBoxPInsCon_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SolaimanLipi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 34);
            this.label4.TabIndex = 4;
            this.label4.Text = "রেজিষ্ট্রেশন সেশন";
            // 
            // comboBoxInsProg
            // 
            this.comboBoxInsProg.FormattingEnabled = true;
            this.comboBoxInsProg.Location = new System.Drawing.Point(88, 46);
            this.comboBoxInsProg.Name = "comboBoxInsProg";
            this.comboBoxInsProg.Size = new System.Drawing.Size(249, 25);
            this.comboBoxInsProg.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "প্রোগ্রামঃ ";
            // 
            // editSess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 193);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "editSess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "editSess";
            this.Load += new System.EventHandler(this.editSess_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPInsCon;
        private System.Windows.Forms.ComboBox comboBoxPInsCon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxInsProg;
    }
}