namespace ResultProcessingSystem.departmentFolder
{
    partial class FormDepartment
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
            this.listViewDep = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonModif = new System.Windows.Forms.Button();
            this.labelDep = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewDep
            // 
            this.listViewDep.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewDep.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDep.GridLines = true;
            this.listViewDep.Location = new System.Drawing.Point(67, 71);
            this.listViewDep.Name = "listViewDep";
            this.listViewDep.Size = new System.Drawing.Size(626, 291);
            this.listViewDep.TabIndex = 0;
            this.listViewDep.UseCompatibleStateImageBehavior = false;
            this.listViewDep.View = System.Windows.Forms.View.Details;
            this.listViewDep.SelectedIndexChanged += new System.EventHandler(this.listViewDep_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "নং ";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "বিভাগের নাম ";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "বিভাগের ছোট নাম ";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "বিভাগ কোড ";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "অনুষদ ";
            this.columnHeader5.Width = 200;
            // 
            // buttonModif
            // 
            this.buttonModif.BackColor = System.Drawing.Color.Cyan;
            this.buttonModif.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonModif.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModif.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonModif.Location = new System.Drawing.Point(552, 368);
            this.buttonModif.Name = "buttonModif";
            this.buttonModif.Size = new System.Drawing.Size(141, 23);
            this.buttonModif.TabIndex = 1;
            this.buttonModif.Text = "পরিবর্তন করুন ";
            this.buttonModif.UseVisualStyleBackColor = false;
            this.buttonModif.Click += new System.EventHandler(this.buttonModif_Click);
            // 
            // labelDep
            // 
            this.labelDep.AutoSize = true;
            this.labelDep.Font = new System.Drawing.Font("SolaimanLipi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDep.Location = new System.Drawing.Point(323, 20);
            this.labelDep.Name = "labelDep";
            this.labelDep.Size = new System.Drawing.Size(83, 34);
            this.labelDep.TabIndex = 2;
            this.labelDep.Text = "বিভাগ ";
            // 
            // FormDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 403);
            this.Controls.Add(this.labelDep);
            this.Controls.Add(this.buttonModif);
            this.Controls.Add(this.listViewDep);
            this.Name = "FormDepartment";
            this.Text = "রেজাল্ট প্রস্তুতকরণ সফটওয়্যার,যবিপ্রবি";
            this.Load += new System.EventHandler(this.FormDepartment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewDep;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button buttonModif;
        private System.Windows.Forms.Label labelDep;
    }
}