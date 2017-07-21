namespace ResultProcessingSystem
{
    partial class view_faculty
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
            this.buttonFac = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.listBoxFac = new System.Windows.Forms.ListBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxUpdate = new System.Windows.Forms.TextBox();
            this.panelInsert = new System.Windows.Forms.Panel();
            this.buttonInsFac = new System.Windows.Forms.Button();
            this.textBoxInsFac = new System.Windows.Forms.TextBox();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.labelInsert = new System.Windows.Forms.Label();
            this.labelModi = new System.Windows.Forms.Label();
            this.labelEditFac = new System.Windows.Forms.Label();
            this.panelInsert.SuspendLayout();
            this.panelUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFac
            // 
            this.buttonFac.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFac.Location = new System.Drawing.Point(194, 42);
            this.buttonFac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFac.Name = "buttonFac";
            this.buttonFac.Size = new System.Drawing.Size(75, 33);
            this.buttonFac.TabIndex = 1;
            this.buttonFac.Text = "দেখুন ";
            this.buttonFac.UseVisualStyleBackColor = true;
            this.buttonFac.Click += new System.EventHandler(this.buttonFac_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.Location = new System.Drawing.Point(197, 112);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 31);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "মুছুন ";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // listBoxFac
            // 
            this.listBoxFac.ColumnWidth = 150;
            this.listBoxFac.FormattingEnabled = true;
            this.listBoxFac.HorizontalScrollbar = true;
            this.listBoxFac.ItemHeight = 15;
            this.listBoxFac.Location = new System.Drawing.Point(3, 4);
            this.listBoxFac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxFac.Name = "listBoxFac";
            this.listBoxFac.Size = new System.Drawing.Size(185, 139);
            this.listBoxFac.TabIndex = 5;
            this.listBoxFac.SelectedIndexChanged += new System.EventHandler(this.listBoxFac_SelectedIndexChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(197, 169);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 26);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "পরিবর্তন ";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxUpdate
            // 
            this.textBoxUpdate.Location = new System.Drawing.Point(4, 173);
            this.textBoxUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUpdate.Name = "textBoxUpdate";
            this.textBoxUpdate.Size = new System.Drawing.Size(185, 22);
            this.textBoxUpdate.TabIndex = 7;
            // 
            // panelInsert
            // 
            this.panelInsert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInsert.Controls.Add(this.buttonInsFac);
            this.panelInsert.Controls.Add(this.textBoxInsFac);
            this.panelInsert.Location = new System.Drawing.Point(45, 158);
            this.panelInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelInsert.Name = "panelInsert";
            this.panelInsert.Size = new System.Drawing.Size(235, 133);
            this.panelInsert.TabIndex = 8;
            // 
            // buttonInsFac
            // 
            this.buttonInsFac.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsFac.Location = new System.Drawing.Point(144, 61);
            this.buttonInsFac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonInsFac.Name = "buttonInsFac";
            this.buttonInsFac.Size = new System.Drawing.Size(75, 26);
            this.buttonInsFac.TabIndex = 10;
            this.buttonInsFac.Text = "যোজন ";
            this.buttonInsFac.UseVisualStyleBackColor = true;
            this.buttonInsFac.Click += new System.EventHandler(this.buttonInsFac_Click);
            // 
            // textBoxInsFac
            // 
            this.textBoxInsFac.Location = new System.Drawing.Point(3, 14);
            this.textBoxInsFac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxInsFac.Name = "textBoxInsFac";
            this.textBoxInsFac.Size = new System.Drawing.Size(216, 22);
            this.textBoxInsFac.TabIndex = 10;
            this.textBoxInsFac.TextChanged += new System.EventHandler(this.textBoxInsFac_TextChanged);
            // 
            // panelUpdate
            // 
            this.panelUpdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelUpdate.Controls.Add(this.textBoxUpdate);
            this.panelUpdate.Controls.Add(this.buttonUpdate);
            this.panelUpdate.Controls.Add(this.listBoxFac);
            this.panelUpdate.Controls.Add(this.buttonDel);
            this.panelUpdate.Controls.Add(this.buttonFac);
            this.panelUpdate.Location = new System.Drawing.Point(338, 158);
            this.panelUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(290, 213);
            this.panelUpdate.TabIndex = 9;
            // 
            // labelInsert
            // 
            this.labelInsert.AutoSize = true;
            this.labelInsert.Font = new System.Drawing.Font("SolaimanLipi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInsert.Location = new System.Drawing.Point(46, 124);
            this.labelInsert.Name = "labelInsert";
            this.labelInsert.Size = new System.Drawing.Size(118, 21);
            this.labelInsert.TabIndex = 10;
            this.labelInsert.Text = "অনুষদ যোগ করুন ";
            // 
            // labelModi
            // 
            this.labelModi.AutoSize = true;
            this.labelModi.Font = new System.Drawing.Font("SolaimanLipi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModi.Location = new System.Drawing.Point(340, 124);
            this.labelModi.Name = "labelModi";
            this.labelModi.Size = new System.Drawing.Size(167, 21);
            this.labelModi.TabIndex = 11;
            this.labelModi.Text = "অনুষদ পরিবর্তন/ বিয়োজন ";
            // 
            // labelEditFac
            // 
            this.labelEditFac.AutoSize = true;
            this.labelEditFac.Font = new System.Drawing.Font("SolaimanLipi", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditFac.Location = new System.Drawing.Point(194, 49);
            this.labelEditFac.Name = "labelEditFac";
            this.labelEditFac.Size = new System.Drawing.Size(249, 34);
            this.labelEditFac.TabIndex = 12;
            this.labelEditFac.Text = "অনুষদের নাম সম্পাদনা ";
            // 
            // view_faculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 379);
            this.Controls.Add(this.labelEditFac);
            this.Controls.Add(this.labelModi);
            this.Controls.Add(this.labelInsert);
            this.Controls.Add(this.panelUpdate);
            this.Controls.Add(this.panelInsert);
            this.Font = new System.Drawing.Font("SolaimanLipi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "view_faculty";
            this.Text = "ফলাফল প্রস্তুতকরণ সফটওয়্যার, যবিপ্রবি ";
            this.panelInsert.ResumeLayout(false);
            this.panelInsert.PerformLayout();
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFac;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ListBox listBoxFac;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxUpdate;
        private System.Windows.Forms.Panel panelInsert;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.Button buttonInsFac;
        private System.Windows.Forms.TextBox textBoxInsFac;
        private System.Windows.Forms.Label labelInsert;
        private System.Windows.Forms.Label labelModi;
        private System.Windows.Forms.Label labelEditFac;
    }
}