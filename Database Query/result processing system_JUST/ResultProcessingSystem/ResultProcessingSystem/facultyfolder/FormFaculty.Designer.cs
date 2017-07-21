namespace ResultProcessingSystem
{
    partial class faculty_class
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
            this.label_Exc = new System.Windows.Forms.Label();
            this.buttonShowFac = new System.Windows.Forms.Button();
            this.listViewShowFac = new System.Windows.Forms.ListView();
            this.columnHeaderIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFacName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelFacName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Exc
            // 
            this.label_Exc.AutoSize = true;
            this.label_Exc.BackColor = System.Drawing.SystemColors.Control;
            this.label_Exc.ForeColor = System.Drawing.Color.Red;
            this.label_Exc.Location = new System.Drawing.Point(225, 199);
            this.label_Exc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Exc.Name = "label_Exc";
            this.label_Exc.Size = new System.Drawing.Size(0, 17);
            this.label_Exc.TabIndex = 4;
            // 
            // buttonShowFac
            // 
            this.buttonShowFac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonShowFac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonShowFac.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowFac.Location = new System.Drawing.Point(542, 287);
            this.buttonShowFac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonShowFac.Name = "buttonShowFac";
            this.buttonShowFac.Size = new System.Drawing.Size(163, 78);
            this.buttonShowFac.TabIndex = 5;
            this.buttonShowFac.Text = "পরিবর্তন করুন";
            this.buttonShowFac.UseVisualStyleBackColor = false;
            this.buttonShowFac.Click += new System.EventHandler(this.buttonShowFac_Click);
            // 
            // listViewShowFac
            // 
            this.listViewShowFac.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listViewShowFac.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderIndex,
            this.columnHeaderFacName});
            this.listViewShowFac.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewShowFac.GridLines = true;
            this.listViewShowFac.Location = new System.Drawing.Point(119, 106);
            this.listViewShowFac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewShowFac.Name = "listViewShowFac";
            this.listViewShowFac.Size = new System.Drawing.Size(415, 259);
            this.listViewShowFac.TabIndex = 6;
            this.listViewShowFac.UseCompatibleStateImageBehavior = false;
            this.listViewShowFac.View = System.Windows.Forms.View.Details;
            this.listViewShowFac.SelectedIndexChanged += new System.EventHandler(this.listViewShowFac_SelectedIndexChanged);
            // 
            // columnHeaderIndex
            // 
            this.columnHeaderIndex.Text = "নং ";
            // 
            // columnHeaderFacName
            // 
            this.columnHeaderFacName.Text = "অনুষদের নাম ";
            this.columnHeaderFacName.Width = 350;
            // 
            // labelFacName
            // 
            this.labelFacName.AutoSize = true;
            this.labelFacName.Font = new System.Drawing.Font("SolaimanLipi", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacName.Location = new System.Drawing.Point(293, 42);
            this.labelFacName.Name = "labelFacName";
            this.labelFacName.Size = new System.Drawing.Size(87, 34);
            this.labelFacName.TabIndex = 7;
            this.labelFacName.Text = "অনুষদ ";
            // 
            // faculty_class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 385);
            this.Controls.Add(this.labelFacName);
            this.Controls.Add(this.listViewShowFac);
            this.Controls.Add(this.buttonShowFac);
            this.Controls.Add(this.label_Exc);
            this.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "faculty_class";
            this.Text = " ফলাফল প্রস্তুতকরণ সফটওয়্যার, যবিপ্রবি ";
            this.Load += new System.EventHandler(this.faculty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Exc;
        private System.Windows.Forms.Button buttonShowFac;
        private System.Windows.Forms.ListView listViewShowFac;
        private System.Windows.Forms.ColumnHeader columnHeaderIndex;
        private System.Windows.Forms.ColumnHeader columnHeaderFacName;
        private System.Windows.Forms.Label labelFacName;
    }
}

