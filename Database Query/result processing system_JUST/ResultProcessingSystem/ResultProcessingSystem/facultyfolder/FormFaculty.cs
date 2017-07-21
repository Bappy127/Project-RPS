using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace ResultProcessingSystem
{
    public partial class faculty_class : Form
    {
        public faculty_class()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFaculty_TextChanged(object sender, EventArgs e)
        {

        }

        private void faculty_Load(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(Connection.con_string);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            cmd.CommandText = "view_faculty";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter param4 = cmd.Parameters.Add("fac_view_cursor", OracleType.Cursor);
            param4.Direction = ParameterDirection.Output;
            param4.Size = 100;

            con.Open();
            cmd.ExecuteNonQuery();


            OracleDataReader reader = cmd.ExecuteReader();
            listViewShowFac.Items.Clear();

            while (reader.Read())
            {
                // output faculty Names
                ListViewItem listVI = new ListViewItem(reader[0].ToString(), reader[1].ToString());
                for (int i = 1; i < reader.FieldCount; i++)
                {
                    listVI.SubItems.Add(reader[i].ToString());
                }

                listViewShowFac.Items.Add(listVI);

            }
            reader.Dispose();
            con.Dispose();
        }

        private void buttonAddFac_Click(object sender, EventArgs e)
        {
            

            
        }

        private void buttonShowFac_Click(object sender, EventArgs e)
        {
            (new view_faculty()).Show();
            this.Hide();
            
        }

        private void listViewShowFac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonVuFac_Click(object sender, EventArgs e)
        {
            
        }

  
     }
}
