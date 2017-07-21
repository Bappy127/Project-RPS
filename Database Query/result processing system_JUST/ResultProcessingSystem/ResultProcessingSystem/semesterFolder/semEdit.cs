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
    public partial class semEdit : Form
    {
        public semEdit()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxYS.Items.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(Connection.con_string);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            cmd.CommandText = "select_semesters";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = cmd.Parameters.Add("sem_cursor",OracleType.Cursor);
            param1.Direction = ParameterDirection.Output;
            param1.Size = 60;

            con.Open();
            cmd.ExecuteNonQuery();

            OracleDataReader reader = cmd.ExecuteReader();
            comboBoxYS.Items.Clear();
                while(reader.Read())
                {
                    comboBoxYS.Items.AddRange(new object[] {reader[0].ToString()});
                }
                
            reader.Dispose();
            con.Dispose();
        }

        private void buttonIns_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(Connection.con_string);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert_semesters";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = cmd.Parameters.Add("p_year", OracleType.VarChar);
            param1.Direction = ParameterDirection.Input;
            param1.Value = comboBoxYear.Text;

            OracleParameter param2 = cmd.Parameters.Add("p_sem", OracleType.VarChar);
            param2.Direction = ParameterDirection.Input;
            param2.Value = comboBoxSem.Text;

            OracleParameter param3 = cmd.Parameters.Add("p_exc", OracleType.VarChar);
            param3.Direction = ParameterDirection.Output;
            param3.Size = 30;

            con.Open();

            cmd.ExecuteNonQuery();
            MessageBox.Show(param3.Value.ToString());

            con.Dispose();

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(Connection.con_string);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            cmd.CommandText = "del_semesters";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = cmd.Parameters.Add("sem_cur_val", OracleType.VarChar);
            param1.Direction = ParameterDirection.Input;
            param1.Value = comboBoxYS.Text;

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
