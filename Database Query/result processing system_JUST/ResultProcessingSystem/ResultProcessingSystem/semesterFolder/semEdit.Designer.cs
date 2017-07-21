namespace ResultProcessingSystem.semesterFolder
{
    partial class semEdit
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
            this.panelIns = new System.Windows.Forms.Panel();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxSem = new System.Windows.Forms.ComboBox();
            this.buttonIns = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxYS = new System.Windows.Forms.ComboBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panelIns.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIns
            // 
            this.panelIns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelIns.Controls.Add(this.label2);
            this.panelIns.Controls.Add(this.label1);
            this.panelIns.Controls.Add(this.buttonIns);
            this.panelIns.Controls.Add(this.comboBoxSem);
            this.panelIns.Controls.Add(this.comboBoxYear);
            this.panelIns.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelIns.Location = new System.Drawing.Point(27, 122);
            this.panelIns.Name = "panelIns";
            this.panelIns.Size = new System.Drawing.Size(225, 134);
            this.panelIns.TabIndex = 0;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "1st",
            "2nd",
            "3rd",
            "4th"});
            this.comboBoxYear.Location = new System.Drawing.Point(61, 17);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(145, 25);
            this.comboBoxYear.TabIndex = 0;
            // 
            // comboBoxSem
            // 
            this.comboBoxSem.FormattingEnabled = true;
            this.comboBoxSem.Items.AddRange(new object[] {
            "1st",
            "2nd"});
            this.comboBoxSem.Location = new System.Drawing.Point(61, 53);
            this.comboBoxSem.Name = "comboBoxSem";
            this.comboBoxSem.Size = new System.Drawing.Size(145, 25);
            this.comboBoxSem.TabIndex = 1;
            // 
            // buttonIns
            // 
            this.buttonIns.Location = new System.Drawing.Point(61, 89);
            this.buttonIns.Name = "buttonIns";
            this.buttonIns.Size = new System.Drawing.Size(75, 27);
            this.buttonIns.TabIndex = 2;
            this.buttonIns.Text = "যোজন ";
            this.buttonIns.UseVisualStyleBackColor = true;
            this.buttonIns.Click += new System.EventHandler(this.buttonIns_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "বর্ষঃ ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "পর্বঃ ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonDel);
            this.panel1.Controls.Add(this.comboBoxYS);
            this.panel1.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(271, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 134);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxYS
            // 
            this.comboBoxYS.FormattingEnabled = true;
            this.comboBoxYS.Location = new System.Drawing.Point(83, 20);
            this.comboBoxYS.Name = "comboBoxYS";
            this.comboBoxYS.Size = new System.Drawing.Size(264, 25);
            this.comboBoxYS.TabIndex = 0;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(83, 55);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 27);
            this.buttonDel.TabIndex = 1;
            this.buttonDel.Text = "মুছুন ";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "বর্ষ ও পর্বঃ ";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(27, 96);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(124, 21);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "বর্ষ ও পর্ব সংযোজন ";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(271, 96);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(121, 21);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "বর্ষ ও পর্ব বিয়োজন ";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SolaimanLipi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 34);
            this.label4.TabIndex = 4;
            this.label4.Text = "বর্ষ ও পর্ব সংযোজন ও বিয়োজন ";
            // 
            // semEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 286);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelIns);
            this.Font = new System.Drawing.Font("SolaimanLipi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "semEdit";
            this.Text = "ফলাফল প্রস্তুতকরণ সফটওয়্যার,যবিপ্রবি ";
            this.panelIns.ResumeLayout(false);
            this.panelIns.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelIns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonIns;
        private System.Windows.Forms.ComboBox comboBoxSem;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ComboBox comboBoxYS;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
    }
}