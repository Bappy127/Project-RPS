using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace ResultProcessingSystem.semesterFolder
{
    public partial class semShow : Form
    {
        public semShow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new semEdit().Show();
            this.Hide();
        }

        private void listViewSem_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void semShow_Load(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(Connection.con_string);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            cmd.CommandText = "select_semesters";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = cmd.Parameters.Add("sem_cursor", OracleType.Cursor);
            param1.Direction = ParameterDirection.Output;
            param1.Size = 60;

            con.Open();
            cmd.ExecuteNonQuery();

            OracleDataReader reader = cmd.ExecuteReader();
            listViewSem.Items.Clear();

            while (reader.Read())
            {
                // output faculty Names
                ListViewItem listVI = new ListViewItem(reader[0].ToString());
                for (int i = 1; i < reader.FieldCount; i++)
                {
                    listVI.SubItems.Add(reader[i].ToString());
                }

                listViewSem.Items.Add(listVI);

            }

            reader.Dispose();
            con.Dispose();
        }
    }
}
