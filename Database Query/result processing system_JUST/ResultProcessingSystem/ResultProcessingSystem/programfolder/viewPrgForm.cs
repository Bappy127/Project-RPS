using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace ResultProcessingSystem.programfolder
{
    public partial class viewPrgForm : Form
    {
        public viewPrgForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new ManiProgForm()).Show();
            this.Hide();
        }

        private void listViewProg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void viewPrgForm_Load(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(Connection.con_string);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            cmd.CommandText = "view_programs";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = cmd.Parameters.Add("prog_view_cursor", OracleType.Cursor);
            param1.Direction = ParameterDirection.Output;
            param1.Size = 150;

            con.Open();
            cmd.ExecuteNonQuery();

            OracleDataReader reader = cmd.ExecuteReader();
            listViewProg.Items.Clear();

            while (reader.Read())
            {
                // output faculty Names
                ListViewItem listVI = new ListViewItem(reader[0].ToString());
                for (int i = 1; i < reader.FieldCount; i++)
                {
                    listVI.SubItems.Add(reader[i].ToString());
                }

                listViewProg.Items.Add(listVI);

            }
            reader.Dispose();
            con.Dispose();
        }
    }
}
