namespace ResultProcessingSystem.gradeFolder
{
    partial class showGrd
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
            this.listViewShGrd = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChn = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewShGrd
            // 
            this.listViewShGrd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewShGrd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewShGrd.GridLines = true;
            this.listViewShGrd.Location = new System.Drawing.Point(79, 81);
            this.listViewShGrd.Name = "listViewShGrd";
            this.listViewShGrd.Size = new System.Drawing.Size(370, 273);
            this.listViewShGrd.TabIndex = 0;
            this.listViewShGrd.UseCompatibleStateImageBehavior = false;
            this.listViewShGrd.View = System.Windows.Forms.View.Details;
            this.listViewShGrd.SelectedIndexChanged += new System.EventHandler(this.listViewShGrd_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SolaimanLipi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "গ্রেড স্কেল ";
            // 
            // buttonChn
            // 
            this.buttonChn.BackColor = System.Drawing.Color.Lime;
            this.buttonChn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChn.Font = new System.Drawing.Font("SolaimanLipi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChn.Location = new System.Drawing.Point(315, 360);
            this.buttonChn.Name = "buttonChn";
            this.buttonChn.Size = new System.Drawing.Size(134, 23);
            this.buttonChn.TabIndex = 2;
            this.buttonChn.Text = "পরিবর্তন করতে চান? ";
            this.buttonChn.UseVisualStyleBackColor = false;
            this.buttonChn.Click += new System.EventHandler(this.buttonChn_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "গ্রেড ";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "স্কেল ";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "হইতে ";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "পর্যন্ত ";
            this.columnHeader4.Width = 100;
            // 
            // showGrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 404);
            this.Controls.Add(this.buttonChn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewShGrd);
            this.Name = "showGrd";
            this.Text = "showGrd";
            this.Load += new System.EventHandler(this.showGrd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewShGrd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}