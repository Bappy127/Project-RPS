namespace ResultProcessingSystem.departmentFolder
{
    partial class FormDeptManup
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
            this.comboBoxFacName = new System.Windows.Forms.ComboBox();
            this.panelInsert = new System.Windows.Forms.Panel();
            this.textBoxDname = new System.Windows.Forms.TextBox();
            this.textBoxDabbr = new System.Windows.Forms.TextBox();
            this.textBoxDcode = new System.Windows.Forms.TextBox();
            this.labelDname = new System.Windows.Forms.Label();
            this.labelDabbr = new System.Windows.Forms.Label();
            this.labelDfac = new System.Windows.Forms.Label();
            this.labelDcode = new System.Windows.Forms.Label();
            this.labelMcode = new System.Windows.Forms.Label();
            this.buttonAddD = new System.Windows.Forms.Button();
            this.radioButtonIns = new System.Windows.Forms.RadioButton();
            this.radioButtonUpDe = new System.Windows.Forms.RadioButton();
            this.panelUpDe = new System.Windows.Forms.Panel();
            this.comboBoxDep = new System.Windows.Forms.ComboBox();
            this.textBoxDnm = new System.Windows.Forms.TextBox();
            this.textBoxDabr = new System.Windows.Forms.TextBox();
            this.comboBoxFdnm = new System.Windows.Forms.ComboBox();
            this.textBoxDcod = new System.Windows.Forms.TextBox();
            this.buttonUpd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.labelDep = new System.Windows.Forms.Label();
            this.labelDnm = new System.Windows.Forms.Label();
            this.labelDabr = new System.Windows.Forms.Label();
            this.labelFac = new System.Windows.Forms.Label();
            this.labelDcod = new System.Windows.Forms.Label();
            this.labelDepModi = new System.Windows.Forms.Label();
            this.panelInsert.SuspendLayout();
            this.panelUpDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxFacName
            // 
            this.comboBoxFacName.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFacName.FormattingEnabled = true;
            this.comboBoxFacName.Location = new System.Drawing.Point(96, 100);
            this.comboBoxFacName.Name = "comboBoxFacName";
            this.comboBoxFacName.Size = new System.Drawing.Size(217, 25);
            this.comboBoxFacName.TabIndex = 0;
            this.comboBoxFacName.Text = "বাছাই করুন ";
            this.comboBoxFacName.SelectedIndexChanged += new System.EventHandler(this.comboBoxFacName_SelectedIndexChanged);
            // 
            // panelInsert
            // 
            this.panelInsert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInsert.Controls.Add(this.buttonAddD);
            this.panelInsert.Controls.Add(this.labelMcode);
            this.panelInsert.Controls.Add(this.labelDcode);
            this.panelInsert.Controls.Add(this.labelDfac);
            this.panelInsert.Controls.Add(this.labelDabbr);
            this.panelInsert.Controls.Add(this.labelDname);
            this.panelInsert.Controls.Add(this.textBoxDcode);
            this.panelInsert.Controls.Add(this.textBoxDabbr);
            this.panelInsert.Controls.Add(this.textBoxDname);
            this.panelInsert.Controls.Add(this.comboBoxFacName);
            this.panelInsert.Location = new System.Drawing.Point(44, 119);
            this.panelInsert.Name = "panelInsert";
            this.panelInsert.Size = new System.Drawing.Size(322, 251);
            this.panelInsert.TabIndex = 1;
            // 
            // textBoxDname
            // 
            this.textBoxDname.Location = new System.Drawing.Point(96, 23);
            this.textBoxDname.Name = "textBoxDname";
            this.textBoxDname.Size = new System.Drawing.Size(217, 20);
            this.textBoxDname.TabIndex = 1;
            this.textBoxDname.TextChanged += new System.EventHandler(this.textBoxDname_TextChanged);
            // 
            // textBoxDabbr
            // 
            this.textBoxDabbr.Location = new System.Drawing.Point(96, 59);
            this.textBoxDabbr.Name = "textBoxDabbr";
            this.textBoxDabbr.Size = new System.Drawing.Size(217, 20);
            this.textBoxDabbr.TabIndex = 2;
            // 
            // textBoxDcode
            // 
            this.textBoxDcode.Location = new System.Drawing.Point(96, 145);
            this.textBoxDcode.Name = "textBoxDcode";
            this.textBoxDcode.Size = new System.Drawing.Size(100, 20);
            this.textBoxDcode.TabIndex = 3;
            // 
            // labelDname
            // 
            this.labelDname.AutoSize = true;
            this.labelDname.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDname.Location = new System.Drawing.Point(11, 23);
            this.labelDname.Name = "labelDname";
            this.labelDname.Size = new System.Drawing.Size(79, 17);
            this.labelDname.TabIndex = 4;
            this.labelDname.Text = "বিভাগের নামঃ ";
            // 
            // labelDabbr
            // 
            this.labelDabbr.AutoSize = true;
            this.labelDabbr.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDabbr.Location = new System.Drawing.Point(32, 59);
            this.labelDabbr.Name = "labelDabbr";
            this.labelDabbr.Size = new System.Drawing.Size(58, 17);
            this.labelDabbr.TabIndex = 5;
            this.labelDabbr.Text = "ছোট নামঃ ";
            // 
            // labelDfac
            // 
            this.labelDfac.AutoSize = true;
            this.labelDfac.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDfac.Location = new System.Drawing.Point(43, 100);
            this.labelDfac.Name = "labelDfac";
            this.labelDfac.Size = new System.Drawing.Size(47, 17);
            this.labelDfac.TabIndex = 6;
            this.labelDfac.Text = "অনুষদঃ ";
            // 
            // labelDcode
            // 
            this.labelDcode.AutoSize = true;
            this.labelDcode.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDcode.Location = new System.Drawing.Point(49, 145);
            this.labelDcode.Name = "labelDcode";
            this.labelDcode.Size = new System.Drawing.Size(41, 17);
            this.labelDcode.TabIndex = 7;
            this.labelDcode.Text = "কোডঃ ";
            // 
            // labelMcode
            // 
            this.labelMcode.AutoSize = true;
            this.labelMcode.Font = new System.Drawing.Font("SolaimanLipi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMcode.ForeColor = System.Drawing.Color.Green;
            this.labelMcode.Location = new System.Drawing.Point(93, 168);
            this.labelMcode.Name = "labelMcode";
            this.labelMcode.Size = new System.Drawing.Size(194, 15);
            this.labelMcode.TabIndex = 8;
            this.labelMcode.Text = "শিক্ষার্থীর রোল নম্বর তৈরীতে কোডটি গুরুত্বপূর্ণ ";
            // 
            // buttonAddD
            // 
            this.buttonAddD.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddD.Location = new System.Drawing.Point(188, 207);
            this.buttonAddD.Name = "buttonAddD";
            this.buttonAddD.Size = new System.Drawing.Size(75, 23);
            this.buttonAddD.TabIndex = 9;
            this.buttonAddD.Text = "যোজন ";
            this.buttonAddD.UseVisualStyleBackColor = true;
            this.buttonAddD.Click += new System.EventHandler(this.buttonAddD_Click);
            // 
            // radioButtonIns
            // 
            this.radioButtonIns.AutoSize = true;
            this.radioButtonIns.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonIns.Location = new System.Drawing.Point(44, 96);
            this.radioButtonIns.Name = "radioButtonIns";
            this.radioButtonIns.Size = new System.Drawing.Size(101, 21);
            this.radioButtonIns.TabIndex = 2;
            this.radioButtonIns.TabStop = true;
            this.radioButtonIns.Text = "বিভাগ অন্তর্ভুক্তি ";
            this.radioButtonIns.UseVisualStyleBackColor = true;
            this.radioButtonIns.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonUpDe
            // 
            this.radioButtonUpDe.AutoSize = true;
            this.radioButtonUpDe.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonUpDe.Location = new System.Drawing.Point(394, 96);
            this.radioButtonUpDe.Name = "radioButtonUpDe";
            this.radioButtonUpDe.Size = new System.Drawing.Size(153, 21);
            this.radioButtonUpDe.TabIndex = 3;
            this.radioButtonUpDe.TabStop = true;
            this.radioButtonUpDe.Text = "বিভাগ পরিবর্তন/ বিয়োজন ";
            this.radioButtonUpDe.UseVisualStyleBackColor = true;
            this.radioButtonUpDe.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // panelUpDe
            // 
            this.panelUpDe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelUpDe.Controls.Add(this.labelDcod);
            this.panelUpDe.Controls.Add(this.labelFac);
            this.panelUpDe.Controls.Add(this.labelDabr);
            this.panelUpDe.Controls.Add(this.labelDnm);
            this.panelUpDe.Controls.Add(this.labelDep);
            this.panelUpDe.Controls.Add(this.buttonDel);
            this.panelUpDe.Controls.Add(this.buttonUpd);
            this.panelUpDe.Controls.Add(this.textBoxDcod);
            this.panelUpDe.Controls.Add(this.comboBoxFdnm);
            this.panelUpDe.Controls.Add(this.textBoxDabr);
            this.panelUpDe.Controls.Add(this.textBoxDnm);
            this.panelUpDe.Controls.Add(this.comboBoxDep);
            this.panelUpDe.Location = new System.Drawing.Point(394, 119);
            this.panelUpDe.Name = "panelUpDe";
            this.panelUpDe.Size = new System.Drawing.Size(325, 251);
            this.panelUpDe.TabIndex = 4;
            // 
            // comboBoxDep
            // 
            this.comboBoxDep.FormattingEnabled = true;
            this.comboBoxDep.Location = new System.Drawing.Point(137, 23);
            this.comboBoxDep.Name = "comboBoxDep";
            this.comboBoxDep.Size = new System.Drawing.Size(181, 21);
            this.comboBoxDep.TabIndex = 0;
            this.comboBoxDep.SelectedIndexChanged += new System.EventHandler(this.comboBoxDep_SelectedIndexChanged);
            // 
            // textBoxDnm
            // 
            this.textBoxDnm.Location = new System.Drawing.Point(137, 58);
            this.textBoxDnm.Name = "textBoxDnm";
            this.textBoxDnm.Size = new System.Drawing.Size(181, 20);
            this.textBoxDnm.TabIndex = 1;
            // 
            // textBoxDabr
            // 
            this.textBoxDabr.Location = new System.Drawing.Point(137, 100);
            this.textBoxDabr.Name = "textBoxDabr";
            this.textBoxDabr.Size = new System.Drawing.Size(135, 20);
            this.textBoxDabr.TabIndex = 2;
            // 
            // comboBoxFdnm
            // 
            this.comboBoxFdnm.FormattingEnabled = true;
            this.comboBoxFdnm.Location = new System.Drawing.Point(137, 145);
            this.comboBoxFdnm.Name = "comboBoxFdnm";
            this.comboBoxFdnm.Size = new System.Drawing.Size(181, 21);
            this.comboBoxFdnm.TabIndex = 3;
            // 
            // textBoxDcod
            // 
            this.textBoxDcod.Location = new System.Drawing.Point(137, 182);
            this.textBoxDcod.Name = "textBoxDcod";
            this.textBoxDcod.Size = new System.Drawing.Size(100, 20);
            this.textBoxDcod.TabIndex = 4;
            // 
            // buttonUpd
            // 
            this.buttonUpd.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpd.Location = new System.Drawing.Point(137, 221);
            this.buttonUpd.Name = "buttonUpd";
            this.buttonUpd.Size = new System.Drawing.Size(75, 23);
            this.buttonUpd.TabIndex = 5;
            this.buttonUpd.Text = "পরিবর্তন ";
            this.buttonUpd.UseVisualStyleBackColor = true;
            this.buttonUpd.Click += new System.EventHandler(this.buttonUpd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.Location = new System.Drawing.Point(243, 221);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 6;
            this.buttonDel.Text = "মুছুন ";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // labelDep
            // 
            this.labelDep.AutoSize = true;
            this.labelDep.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDep.Location = new System.Drawing.Point(54, 23);
            this.labelDep.Name = "labelDep";
            this.labelDep.Size = new System.Drawing.Size(74, 17);
            this.labelDep.TabIndex = 7;
            this.labelDep.Text = "বিভাগ খুজুনঃ ";
            // 
            // labelDnm
            // 
            this.labelDnm.AutoSize = true;
            this.labelDnm.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDnm.Location = new System.Drawing.Point(49, 58);
            this.labelDnm.Name = "labelDnm";
            this.labelDnm.Size = new System.Drawing.Size(79, 17);
            this.labelDnm.TabIndex = 8;
            this.labelDnm.Text = "বিভাগের নামঃ ";
            // 
            // labelDabr
            // 
            this.labelDabr.AutoSize = true;
            this.labelDabr.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDabr.Location = new System.Drawing.Point(25, 100);
            this.labelDabr.Name = "labelDabr";
            this.labelDabr.Size = new System.Drawing.Size(103, 17);
            this.labelDabr.TabIndex = 9;
            this.labelDabr.Text = "বিভাগের ছোট নামঃ ";
            // 
            // labelFac
            // 
            this.labelFac.AutoSize = true;
            this.labelFac.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFac.Location = new System.Drawing.Point(81, 145);
            this.labelFac.Name = "labelFac";
            this.labelFac.Size = new System.Drawing.Size(47, 17);
            this.labelFac.TabIndex = 10;
            this.labelFac.Text = "অনুষদঃ ";
            // 
            // labelDcod
            // 
            this.labelDcod.AutoSize = true;
            this.labelDcod.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDcod.Location = new System.Drawing.Point(87, 182);
            this.labelDcod.Name = "labelDcod";
            this.labelDcod.Size = new System.Drawing.Size(41, 17);
            this.labelDcod.TabIndex = 11;
            this.labelDcod.Text = "কোডঃ ";
            // 
            // labelDepModi
            // 
            this.labelDepModi.AutoSize = true;
            this.labelDepModi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepModi.Location = new System.Drawing.Point(218, 30);
            this.labelDepModi.Name = "labelDepModi";
            this.labelDepModi.Size = new System.Drawing.Size(291, 31);
            this.labelDepModi.TabIndex = 5;
            this.labelDepModi.Text = "বিভাগ সংযোজন,বিয়োজন ও পরিবর্তন";
            // 
            // FormDeptManup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 382);
            this.Controls.Add(this.labelDepModi);
            this.Controls.Add(this.panelUpDe);
            this.Controls.Add(this.radioButtonUpDe);
            this.Controls.Add(this.radioButtonIns);
            this.Controls.Add(this.panelInsert);
            this.Name = "FormDeptManup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " রেজাল্ট প্রস্তুতকরণ সফটওয়্যার, যবিপ্রবি ";
            this.Load += new System.EventHandler(this.FormDeptManup_Load);
            this.panelInsert.ResumeLayout(false);
            this.panelInsert.PerformLayout();
            this.panelUpDe.ResumeLayout(false);
            this.panelUpDe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFacName;
        private System.Windows.Forms.Panel panelInsert;
        private System.Windows.Forms.Button buttonAddD;
        private System.Windows.Forms.Label labelMcode;
        private System.Windows.Forms.Label labelDcode;
        private System.Windows.Forms.Label labelDfac;
        private System.Windows.Forms.Label labelDabbr;
        private System.Windows.Forms.Label labelDname;
        private System.Windows.Forms.TextBox textBoxDcode;
        private System.Windows.Forms.TextBox textBoxDabbr;
        private System.Windows.Forms.TextBox textBoxDname;
        private System.Windows.Forms.RadioButton radioButtonIns;
        private System.Windows.Forms.RadioButton radioButtonUpDe;
        private System.Windows.Forms.Panel panelUpDe;
        private System.Windows.Forms.Label labelDcod;
        private System.Windows.Forms.Label labelFac;
        private System.Windows.Forms.Label labelDabr;
        private System.Windows.Forms.Label labelDnm;
        private System.Windows.Forms.Label labelDep;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonUpd;
        private System.Windows.Forms.TextBox textBoxDcod;
        private System.Windows.Forms.ComboBox comboBoxFdnm;
        private System.Windows.Forms.TextBox textBoxDabr;
        private System.Windows.Forms.TextBox textBoxDnm;
        private System.Windows.Forms.ComboBox comboBoxDep;
        private System.Windows.Forms.Label labelDepModi;
    }
}