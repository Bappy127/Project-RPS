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
    public partial class FormDeptManup : Form
    {
        public FormDeptManup()
        {
            InitializeComponent();
        }

        private void FormDeptManup_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBoxFacName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddD_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(Connection.con_string);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert_departments";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = cmd.Parameters.Add("p_dname",OracleType.VarChar);
            param1.Direction = ParameterDirection.Input;
            param1.Value = textBoxDname.Text;

            OracleParameter param2 = cmd.Parameters.Add("p_dabbr", OracleType.VarChar);
            param2.Direction = ParameterDirection.Input;
            param2.Value = textBoxDabbr.Text;

            OracleParameter param3 = cmd.Parameters.Add("p_dcode", OracleType.VarChar);
            param3.Direction = ParameterDirection.Input;
            param3.Value = textBoxDcode.Text;

            OracleParameter param4 = cmd.Parameters.Add("p_fac_name", OracleType.VarChar);
            param4.Direction = ParameterDirection.Input;
            param4.Value = comboBoxFacName.Text;

            OracleParameter param5 = cmd.Parameters.Add("p_exc", OracleType.VarChar);
            param5.Direction = ParameterDirection.Output;
            param5.Size = 30;

            con.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show(param5.Value.ToString());
  
            con.Dispose();
        }

        private void textBoxDname_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxDep.Items.Clear();
            comboBoxFdnm.Items.Clear();

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
            comboBoxFacName.Items.Clear();
            while (reader.Read())
            {
                comboBoxFacName.Items.AddRange(new object[] { reader[1].ToString() });
            }


            reader.Dispose();
            con.Dispose();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxFacName.Items.Clear();
            textBoxDabbr.Clear();
            textBoxDcode.Clear();
            textBoxDname.Clear();

            OracleConnection con = new OracleConnection(Connection.con_string);
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = con;

            cmd1.CommandText = "view_departments";
            cmd1.CommandType = CommandType.StoredProcedure;

            OracleParameter param4 = cmd1.Parameters.Add("dept_view_cursor", OracleType.Cursor);
            param4.Direction = ParameterDirection.Output;
            param4.Size = 100;

            con.Open();
            cmd1.ExecuteNonQuery();


            OracleDataReader reader = cmd1.ExecuteReader();
            comboBoxDep.Items.Clear();
            while (reader.Read())
            {
                comboBoxDep.Items.AddRange(new object[] { reader[1].ToString() });
            }


            reader.Dispose();
            //con.Dispose();



            OracleConnection con1 = new OracleConnection(Connection.con_string);
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = con1;

            cmd2.CommandText = "view_faculty";
            cmd2.CommandType = CommandType.StoredProcedure;

            OracleParameter param5 = cmd2.Parameters.Add("fac_view_cursor", OracleType.Cursor);
            param5.Direction = ParameterDirection.Output;
            param5.Size = 100;

            con1.Open();
            cmd2.ExecuteNonQuery();


            OracleDataReader reader1 = cmd2.ExecuteReader();
            comboBoxFdnm.Items.Clear();
            while (reader1.Read())
            {
                comboBoxFdnm.Items.AddRange(new object[] { reader1[1].ToString() });
            }


            reader1.Dispose();
            con1.Dispose();

        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(Connection.con_string);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            cmd.CommandText = "update_departments";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = cmd.Parameters.Add("p_dname",OracleType.VarChar);
            param1.Direction = ParameterDirection.InputOutput;
            param1.Value = textBoxDnm.Text;
            param1.Size = 60;

            OracleParameter param2 = cmd.Parameters.Add("p_doname", OracleType.VarChar);
            param2.Direction = ParameterDirection.Input;
            param2.Value = comboBoxDep.Text;
            
            OracleParameter param3 = cmd.Parameters.Add("p_dabbr", OracleType.VarChar);
            param3.Direction = ParameterDirection.InputOutput;
            param3.Value = textBoxDabr.Text;
            param3.Size = 60;

            OracleParameter param4 = cmd.Parameters.Add("p_dcode", OracleType.VarChar);
            param4.Direction = ParameterDirection.InputOutput;
            param4.Value = textBoxDcod.Text;
            param4.Size = 60;

            OracleParameter param5 = cmd.Parameters.Add("p_fac_name", OracleType.VarChar);
            param5.Direction = ParameterDirection.Input;
            param5.Value = comboBoxFdnm.Text;

            OracleParameter param6 = cmd.Parameters.Add("p_exc", OracleType.VarChar);
            param6.Direction = ParameterDirection.Output;
            param6.Size = 30;


            con.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show(param6.Value.ToString());

            textBoxDnm.Text = param1.Value.ToString();
            textBoxDabr.Text = param3.Value.ToString();
            textBoxDcod.Text = param4.Value.ToString();

            con.Dispose();

            comboBoxDep.Items.Clear();



        }

        private void comboBoxDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(Connection.con_string);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            cmd.CommandText = "select_departments";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = cmd.Parameters.Add("p_dname", OracleType.VarChar);
            param1.Direction = ParameterDirection.InputOutput;
            param1.Value =comboBoxDep.Text;
            param1.Size = 60;

            OracleParameter param2 = cmd.Parameters.Add("p_dabbr", OracleType.VarChar);
            param2.Direction = ParameterDirection.Output;
            param2.Size = 60;

            OracleParameter param3 = cmd.Parameters.Add("p_dcode", OracleType.VarChar);
            param3.Direction = ParameterDirection.Output;
            param3.Size = 60;

            OracleParameter param4 = cmd.Parameters.Add("p_exc", OracleType.VarChar);
            param4.Direction = ParameterDirection.Output;
            param4.Size = 30;

            con.Open();
            cmd.ExecuteNonQuery();
            textBoxDnm.Text = param1.Value.ToString();
            textBoxDabr.Text = param2.Value.ToString();
            textBoxDcod.Text = param3.Value.ToString();
            con.Dispose();

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(Connection.con_string);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            cmd.CommandText = "del_departments";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = cmd.Parameters.Add("p_dname", OracleType.VarChar);
            param1.Direction = ParameterDirection.Input;
            param1.Value = comboBoxDep.Text;
            
            OracleParameter param2 = cmd.Parameters.Add("p_exc", OracleType.VarChar);
            param2.Direction = ParameterDirection.Output;
            param2.Size = 60;

            con.Open();
            if (MessageBox.Show("সতর্কিকরণঃ আপনি কি নিশ্চিত?", "সতর্কিকরণ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // a 'DialogResult.Yes' value was returned from the MessageBox
                // proceed with your deletion
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show(param2.Value.ToString());

            con.Dispose();
            comboBoxDep.Items.Clear();
            textBoxDnm.Clear();
            textBoxDcod.Clear();
            textBoxDabr.Clear();
            comboBoxFdnm.Items.Clear();
           
        }

        
    }
}
