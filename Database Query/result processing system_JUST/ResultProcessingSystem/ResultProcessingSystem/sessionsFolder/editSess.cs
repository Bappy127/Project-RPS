using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace ResultProcessingSystem.sessionsFolder
{
    public partial class editSess : Form
    {
        public editSess()
        {
            InitializeComponent();
        }

        private void buttonPInsCon_Click(object sender, EventArgs e)
        {

        }

        private void editSess_Load(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(Connection.con_string);
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = con;

            cmd1.CommandText = "view_dept_sess";
            cmd1.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = cmd1.Parameters.Add("sess_dept_cursor", OracleType.Cursor);
            param1.Direction = ParameterDirection.Output;
            param1.Size = 100;

            con.Open();
            cmd1.ExecuteNonQuery();


            OracleDataReader reader = cmd1.ExecuteReader();
            comboBoxPInsCon.Items.Clear();

            while (reader.Read())
            {
                comboBoxPInsCon.Items.AddRange(new object[] { reader[0].ToString() });
            }


            reader.Dispose();
            con.Dispose();
        }

        private void comboBoxPInsCon_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxInsProg.Items.Clear();
            OracleConnection con = new OracleConnection(Connection.con_string);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            cmd.CommandText = "view_prog_sess";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = cmd.Parameters.Add("p_dname", OracleType.VarChar);
            param1.Direction = ParameterDirection.Input;
            param1.Value = comboBoxPInsCon.Text;

            OracleParameter param2 = cmd.Parameters.Add("prog_sess_cursor", OracleType.Cursor);
            param2.Direction = ParameterDirection.Output;
            param2.Size = 30;

            con.Open();
            
            cmd.ExecuteNonQuery();


            OracleDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                comboBoxInsProg.Items.AddRange(new object[] { reader[0].ToString() });
            }


            reader.Dispose();
            con.Dispose();
        }
    }
}
