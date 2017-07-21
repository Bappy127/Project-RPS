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
    public partial class view_faculty : Form
    {
        
        public view_faculty()
        {
            InitializeComponent();
        }

        private void buttonFac_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(Connection.con_string);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "view_faculty";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = cmd.Parameters.Add("fac_view_cursor",OracleType.Cursor);
            param1.Direction = ParameterDirection.Output;
            param1.Size = 100;

            con.Open();
            cmd.ExecuteNonQuery();

            OracleDataReader reader = cmd.ExecuteReader();
            /*listViewFac.Items.Clear();
            
            while (reader.Read())
            {
                // output faculty Names
                ListViewItem listVI = new ListViewItem(reader[0].ToString());
                for (int i = 1; i < reader.FieldCount; i++)
                {
                    listVI.SubItems.Add(reader[i].ToString());
                }

                listViewFac.Items.Add(listVI);

             }*/
            listBoxFac.Items.Clear();
            while (reader.Read())
            {
                listBoxFac.Items.AddRange(new object[] {reader[1].ToString() });
            
            }


            // Clean up
            reader.Dispose();
            con.Dispose();

        }

        private void listViewFac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(Connection.con_string);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "del_faculty";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = cmd.Parameters.Add("p_fname", OracleType.VarChar);
            param1.Direction = ParameterDirection.Input;
            param1.Value = listBoxFac.Text;

            OracleParameter param2 = cmd.Parameters.Add("p_exc", OracleType.VarChar);
            param2.Direction = ParameterDirection.Output;
            param2.Size = 20;

            con.Open();
            if (MessageBox.Show("সতর্কিকরণঃ আপনি কি নিশ্চিত?", "সতর্কিকরণ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // a 'DialogResult.Yes' value was returned from the MessageBox
                // proceed with your deletion
                cmd.ExecuteNonQuery();
            }
            
            //MessageBox.Show(param2.Value.ToString());
            con.Dispose();
            
            //(new DelWarn()).Show();
        }



        private void checkedListBoxFac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(Connection.con_string);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "update_faculty";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = cmd.Parameters.Add("p_name",OracleType.VarChar);
            param1.Direction = ParameterDirection.Input;
            param1.Value = textBoxUpdate.Text;

            OracleParameter param2 = cmd.Parameters.Add("p_oname",OracleType.VarChar);
            param2.Direction = ParameterDirection.Input;
            param2.Value = listBoxFac.Text;

            OracleParameter param3 = cmd.Parameters.Add("p_exc",OracleType.VarChar);
            param3.Direction = ParameterDirection.Output;
            param3.Size = 20;

            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show(param3.Value.ToString());
            con.Dispose();

        }

        private void buttonInsFac_Click(object sender, EventArgs e)
        {
            string ins_fac = null;
            ins_fac = textBoxInsFac.Text;

            string sh_exc = null;


            OracleConnection con = new OracleConnection(Connection.con_string);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert_faculty";
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("p_name", OracleType.VarChar).Value = ins_fac;
            //cmd.Parameters.Add("p_exc", OracleType.VarChar).Direction = ParameterDirection.Output;

            OracleParameter param1 = cmd.Parameters.Add("p_name", OracleType.VarChar);
            param1.Direction = ParameterDirection.Input;
            param1.Value = ins_fac;

            OracleParameter param2 = cmd.Parameters.Add("p_exc", OracleType.VarChar);
            param2.Direction = ParameterDirection.Output;
            param2.Size = 30;


            con.Open();
            cmd.ExecuteNonQuery();
            sh_exc = param2.Value.ToString();
            MessageBox.Show(sh_exc);

            con.Dispose();

            //label_Exc.Text = sh_exc;
        }

        private void textBoxInsFac_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxFac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
