using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace ResultProcessingSystem.departmentFolder
{
    public partial class FormDepartment : Form
    {
        public FormDepartment()
        {
            InitializeComponent();
        }

        private void listViewDep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormDepartment_Load(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(Connection.con_string);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            cmd.CommandText = "view_departments";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = cmd.Parameters.Add("dept_view_cursor", OracleType.Cursor);
            param1.Direction = ParameterDirection.Output;
            param1.Size = 150;

            con.Open();
            cmd.ExecuteNonQuery();


            OracleDataReader reader = cmd.ExecuteReader();
            listViewDep.Items.Clear();

            while (reader.Read())
            {
                // output faculty Names
                ListViewItem listVI = new ListViewItem(reader[0].ToString());
                for (int i = 1; i < reader.FieldCount; i++)
                {
                    listVI.SubItems.Add(reader[i].ToString());
                }

                listViewDep.Items.Add(listVI);

            }
            reader.Dispose();
            con.Dispose();
        }

        private void buttonModif_Click(object sender, EventArgs e)
        {
            (new FormDeptManup()).Show();
            this.Hide();
        }
    }
}
