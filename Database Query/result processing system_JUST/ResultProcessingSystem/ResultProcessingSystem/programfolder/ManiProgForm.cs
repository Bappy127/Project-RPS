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
    public partial class ManiProgForm : Form
    {
        public ManiProgForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxPdnmIns.Items.Clear();
            textBoxPAbrChUpDe.Clear();
            textBoxPChNmUpDe.Clear();
            
            comboBoxPdnmUpDe.Items.Clear();
            listBoxPUpDe.Items.Clear();

            OracleConnection con = new OracleConnection(Connection.con_string);
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = con;

            cmd1.CommandText = "view_departments";
            cmd1.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = cmd1.Parameters.Add("dept_view_cursor", OracleType.Cursor);
            param1.Direction = ParameterDirection.Output;
            param1.Size = 100;

            con.Open();
            cmd1.ExecuteNonQuery();


            OracleDataReader reader = cmd1.ExecuteReader();
            comboBoxPdnmIns.Items.Clear();
            while (reader.Read())
            {
                comboBoxPdnmIns.Items.AddRange(new object[] { reader[1].ToString() });
            }


            reader.Dispose();
            con.Dispose();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxPdnmIns.Items.Clear();
            comboBoxPdnmUpDe.Items.Clear();
            textBoxPAbrIns.Clear();
            textBoxPNmIns.Clear();
            
            
            OracleConnection con = new OracleConnection(Connection.con_string);
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = con;

            cmd1.CommandText = "view_dept";
            cmd1.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = cmd1.Parameters.Add("prog_dept_cursor", OracleType.Cursor);
            param1.Direction = ParameterDirection.Output;
            param1.Size = 100;

            con.Open();
            cmd1.ExecuteNonQuery();


            OracleDataReader reader = cmd1.ExecuteReader();
            comboBoxPdnmUpDe.Items.Clear();
            
            while (reader.Read())
            {
                comboBoxPdnmUpDe.Items.AddRange(new object[] { reader[0].ToString() });
            }

           
            reader.Dispose();
            con.Dispose();




            /*OracleConnection cons = new OracleConnection(Connection.con_string);
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = cons;

            cmd2.CommandText = "view_level";
            cmd2.CommandType = CommandType.StoredProcedure;

            OracleParameter param2 = cmd2.Parameters.Add("prog_level_cursor", OracleType.Cursor);
            param2.Direction = ParameterDirection.Output;
            param2.Size = 100;

            cons.Open();
            cmd2.ExecuteNonQuery();


            OracleDataReader reader1 = cmd2.ExecuteReader();
            comboBoxLvlUpDe.Items.Clear();
            while (reader1.Read())
            {
                comboBoxLvlUpDe.Items.AddRange(new object[] { reader1[0].ToString() });
            }


            reader1.Dispose();
            cons.Dispose();*/

        }

        private void buttonIns_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(Connection.con_string);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert_programs";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = cmd.Parameters.Add("p_degree", OracleType.VarChar);
            param1.Direction = ParameterDirection.Input;
            param1.Value = comboBoxPLvlIns.Text;

            OracleParameter param2 = cmd.Parameters.Add("p_pname", OracleType.VarChar);
            param2.Direction = ParameterDirection.Input;
            param2.Value = textBoxPNmIns.Text;

            OracleParameter param3 = cmd.Parameters.Add("p_dname", OracleType.VarChar);
            param3.Direction = ParameterDirection.Input;
            param3.Value = comboBoxPdnmIns.Text;

            OracleParameter param4 = cmd.Parameters.Add("p_abbr", OracleType.VarChar);
            param4.Direction = ParameterDirection.Input;
            param4.Value = textBoxPAbrIns.Text;

            OracleParameter param5 = cmd.Parameters.Add("p_exc", OracleType.VarChar);
            param5.Direction = ParameterDirection.Output;
            param5.Size = 30;

            con.Open();
            
            cmd.ExecuteNonQuery();
            MessageBox.Show(param5.Value.ToString());
                     
            con.Dispose();
        }

        private void comboBoxPdnmUpDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(Connection.con_string);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            cmd.CommandText = "select_degree";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = cmd.Parameters.Add("p_dname", OracleType.VarChar);
            param1.Direction = ParameterDirection.Input;
            param1.Value = comboBoxPdnmUpDe.Text;

            OracleParameter param2 = cmd.Parameters.Add("prog_abbr_cursor", OracleType.Cursor);
            param2.Direction = ParameterDirection.Output;
            param2.Size = 30;

            con.Open();
            cmd.ExecuteNonQuery();


            OracleDataReader reader = cmd.ExecuteReader();
            listBoxPUpDe.Items.Clear();
            while (reader.Read())
            {
                listBoxPUpDe.Items.AddRange(new object[] { reader[0].ToString() });
            }


            reader.Dispose();
            con.Dispose();
        }

        private void buttoneditW_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(Connection.con_string);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            cmd.CommandText = "select_deg_name";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = cmd.Parameters.Add("p_abbr", OracleType.VarChar);
            param1.Direction = ParameterDirection.InputOutput;
            param1.Value = listBoxPUpDe.Text;
            param1.Size = 30;

            OracleParameter param2 = cmd.Parameters.Add("p_name", OracleType.VarChar);
            param2.Direction = ParameterDirection.Output;
            param2.Size = 60;

            OracleParameter param3 = cmd.Parameters.Add("p_exc", OracleType.VarChar);
            param3.Direction = ParameterDirection.Output;
            param3.Size = 30;

            con.Open();
            cmd.ExecuteNonQuery();

            string oname=param2.Value.ToString();

            textBoxPChNmUpDe.Text=param2.Value.ToString();
            textBoxPAbrChUpDe.Text=param1.Value.ToString();
            //MessageBox.Show(param3.Value.ToString());
            con.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(Connection.con_string);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            cmd.CommandText = "update_programs";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = cmd.Parameters.Add("p_oabbr", OracleType.VarChar);
            param1.Direction = ParameterDirection.Input;
            param1.Value = listBoxPUpDe.Text;

            OracleParameter param2 = cmd.Parameters.Add("p_name", OracleType.VarChar);
            param2.Direction = ParameterDirection.Input;
            param2.Value = textBoxPChNmUpDe.Text;
            //param2.Size = 60;

            OracleParameter param3 = cmd.Parameters.Add("p_abbr", OracleType.VarChar);
            param3.Direction = ParameterDirection.Input;
            param3.Value = textBoxPAbrChUpDe.Text;
            //param3.Size = 60;

            OracleParameter param4 = cmd.Parameters.Add("p_exc", OracleType.VarChar);
            param4.Direction = ParameterDirection.Output;
            param4.Size = 30;

            con.Open();
            cmd.ExecuteNonQuery();

            //textBoxPChNmUpDe.Text = param2.Value.ToString();
            //textBoxPAbrChUpDe.Text = param3.Value.ToString();
            MessageBox.Show(param4.Value.ToString());
            con.Dispose();
        }

        private void listBoxPUpDe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(Connection.con_string);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            cmd.CommandText = "delete_program";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = cmd.Parameters.Add("p_abbr", OracleType.VarChar);
            param1.Direction = ParameterDirection.Input;
            param1.Value = listBoxPUpDe.Text;

            OracleParameter param2 = cmd.Parameters.Add("p_exc", OracleType.VarChar);
            param2.Direction = ParameterDirection.Output;
            param2.Size = 30;

            con.Open();
            if (MessageBox.Show("সতর্কিকরণঃ আপনি কি নিশ্চিত?", "সতর্কিকরণ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // a 'DialogResult.Yes' value was returned from the MessageBox
                // proceed with your deletion
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show(param2.Value.ToString());
            con.Dispose();
        }

        private void comboBoxPdnmIns_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

                       
    }
}
