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
    public partial class editGrd : Form
    {
        public editGrd()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxGdel.Items.Clear();
        }

        private void buttonGIns_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(Connection.con_string);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert_grade_scale";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = cmd.Parameters.Add("p_ul", OracleType.VarChar);
            param1.Direction = ParameterDirection.Input;
            param1.Value = textBoxUL.Text;

            OracleParameter param2 = cmd.Parameters.Add("p_ll", OracleType.VarChar);
            param2.Direction = ParameterDirection.Input;
            param2.Value = textBoxLL.Text;

            OracleParameter param3 = cmd.Parameters.Add("p_gp", OracleType.VarChar);
            param3.Direction = ParameterDirection.Input;
            param3.Value = textBoxGP.Text;

            OracleParameter param4 = cmd.Parameters.Add("p_lg", OracleType.VarChar);
            param4.Direction = ParameterDirection.Input;
            param4.Value = comboBoxGIns.Text;

            OracleParameter param5 = cmd.Parameters.Add("p_exc", OracleType.VarChar);
            param5.Direction = ParameterDirection.Output;
            param5.Size = 30;

            con.Open();

            cmd.ExecuteNonQuery();
            MessageBox.Show(param5.Value.ToString());

            con.Dispose();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxGdel.Items.Clear();
            
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
            comboBoxGdel.Items.Clear();
            while (reader.Read())
            {
                comboBoxGdel.Items.AddRange(new object[] { reader[0].ToString() });
            }

            reader.Dispose();
            con.Dispose();
        }

        private void buttonGDel_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(Connection.con_string);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            cmd.CommandText = "del_grade";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = cmd.Parameters.Add("p_lg", OracleType.VarChar);
            param1.Direction = ParameterDirection.Input;
            param1.Value = comboBoxGdel.Text;

            OracleParameter param3 = cmd.Parameters.Add("p_exc", OracleType.VarChar);
            param3.Direction = ParameterDirection.Output;
            param3.Size = 30;

            con.Open();

            if (MessageBox.Show("সতর্কিকরণঃ আপনি কি নিশ্চিত?", "সতর্কিকরণ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // a 'DialogResult.Yes' value was returned from the MessageBox
                // proceed with your deletion
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show(param3.Value.ToString());

            con.Dispose();
        }
    }
}
