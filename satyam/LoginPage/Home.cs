﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginPage
{
    public partial class Home : Form
    {
        SqlConnection con = new SqlConnection(" Data Source=LAPTOP-867BHLVP;Initial Catalog=Satyam;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        String selectedItem = "";
        String payment = "";
        public Home()
        {
            InitializeComponent();
        }
        private void Bindxerox()
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            DataTable dt = new DataTable();

            con.Close();
            adp = new SqlDataAdapter("select * from tbl_admindata;", con);
            con.Open();
            adp.Fill(dt);
            con.Close();

            gv_alldata.DataSource = dt;
        }

        private void ClearData()
        {
            txt_name.Clear();
            txt_phonenumber.Clear();
            //combo_alldata.Items.Clear();
            txt_amount.Clear();
            txt_note.Clear();
            date_Date.Text = DateTime.Now.ToString();
            combo_alldata.Text = "";

            rb_advance.Checked = false;
            rb_pending .Checked = false;
            rb_total .Checked = false;
        }
        private void Home_Load(object sender, EventArgs e)
        {
            txt_adminname.Text = "Username :  " + Storage.username as string;

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {

                cmd = new SqlCommand("select * from tbl_admindata where phonenumber =" + txt_phonenumber.Text + ";", con);

                con.Close();
                SqlDataReader dr;
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    // txt_firstname.Text = dr.GetValue(1).ToString();
                    txt_name.Text = dr.GetValue(0).ToString();
                    date_Date.Text = dr.GetValue(2).ToString();
                    //selectedItem = dr.GetValue(3).ToString();
                    //payment = dr.GetValue(4).ToString();
                    txt_note.Text = dr.GetValue(6).ToString();
                    txt_amount.Text = dr.GetValue(5).ToString();

                    string temp =  dr.GetValue(4).ToString();

                    if (temp.Equals("Advance"))
                    {
                        rb_advance.Checked = true;
                    }
                    else if (temp.Equals("Total"))
                    {
                        rb_total.Checked = true;

                    }else if (temp.Equals("Panding"))
                    {
                        rb_pending.Checked = true;
                    }


                    string work = dr.GetValue(3).ToString();
                    combo_alldata.SelectedItem = work;

                }
                con.Close();

            }
            catch (Exception)
            {
                MessageBox.Show(" Invalid Input... ");
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {

                con.Close();
                SqlCommand cmd = new SqlCommand("insert into tbl_admindata values ('" + txt_name.Text + "'," + txt_phonenumber.Text + ",'" + date_Date.Text.ToString() + "','" + combo_alldata.Text.ToString() + "','" + payment + "' ," + txt_amount.Text + ",'" + txt_note.Text + "');", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully!!!!");
                ClearData();
                Bindxerox();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                SqlCommand cmd = new SqlCommand("UPDATE tbl_admindata set name = '" + txt_name.Text + "', date = '" + date_Date.Text.ToString() + "', work = '" + combo_alldata.Text.ToString() + "', payment = '" + payment + "', amount = " + txt_amount.Text + ", note = '" + txt_note.Text + "' WHERE phonenumber = " + txt_phonenumber.Text + ";", con);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Successfully!!!!");
                ClearData();
                Bindxerox();
            }
            catch (Exception)
            {
                MessageBox.Show(" Invalid Input... ");
            }
        }

        private void rb_advance_CheckedChanged(object sender, EventArgs e)
        {
            payment = "Advance";

        }

        private void rb_total_CheckedChanged(object sender, EventArgs e)
        {
            payment = "Total";
        }

        private void rb_pending_CheckedChanged(object sender, EventArgs e)
        {
            payment = "Pending";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32( txt_phonenumber.Text ) != 1)
            {
                try
                {
                    con.Close();
                    cmd = new SqlCommand("delete from tbl_admindata where phonenumber=" + txt_phonenumber.Text + ";", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted Successfully!!!!");
                    ClearData();
                    Bindxerox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Invalid Input... Enter Phonenumber ");
                }
            }
            else
            {
                MessageBox.Show("Empty Phonenumber");
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Bindxerox();
        }

        private void txt_note_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}

