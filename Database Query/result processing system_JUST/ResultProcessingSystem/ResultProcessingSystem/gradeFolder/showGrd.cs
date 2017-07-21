using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace ResultProcessingSystem.gradeFolder
{
    public partial class showGrd : Form
    {
        public showGrd()
        {
            InitializeComponent();
        }

        private void listViewShGrd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void showGrd_Load(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(Connection.con_string);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            cmd.CommandText = "view_grade_scale";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = cmd.Parameters.Add("grd_cursor", OracleType.Cursor);
            param1.Direction = ParameterDirection.Output;
            param1.Size = 60;

            con.Open();
            cmd.ExecuteNonQuery();

            OracleDataReader reader = cmd.ExecuteReader();
            listViewShGrd.Items.Clear();

            while (reader.Read())
            {
                // output faculty Names
                ListViewItem listVI = new ListViewItem(reader[0].ToString());
                for (int i = 1; i < reader.FieldCount; i++)
                {
                    listVI.SubItems.Add(reader[i].ToString());
                }

                listViewShGrd.Items.Add(listVI);

            }

            reader.Dispose();
            con.Dispose();
        }

        private void buttonChn_Click(object sender, EventArgs e)
        {
            new editGrd().Show();
            this.Hide();
        }
    }
}
