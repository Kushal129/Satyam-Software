using System;
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
        decimal totalAmount = 0;
        decimal productAmount = 0;
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
            txt_myamount.Clear();
            txt_note.Clear();
            date_Date.Text = DateTime.Now.ToString();
            combo_alldata.Text = "Select Item";

            /*rb_advance.Checked = false;
            rb_pending.Checked = false;
            rb_total.Checked = false;*/
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

            if (!string.IsNullOrWhiteSpace(txt_phonenumber.Text))
            {
                try
                {
                    con.Close();
                    cmd = new SqlCommand("select * from tbl_admindata where phonenumber =" + txt_phonenumber.Text + ";", con);
                    con.Open();
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                     dr.Read();

                        txt_name.Text = dr.GetValue(0).ToString();
                        date_Date.Text = dr.GetValue(2).ToString();
                        string work = dr.GetString(3);
                        if (work.Equals("Aadhar card"))
                        {
                            combo_alldata.SelectedItem = "Aadhar card";
                        }
                        else if (work.Equals("Pan card"))
                        {
                            combo_alldata.SelectedItem = "Pan card";

                        }
                        else if (work.Equals("Ration card"))
                        {
                            combo_alldata.SelectedItem = "Ration card";
                        }
                        
                        txt_myamount.Text = dr.GetValue(4).ToString();
                        txt_usersend.Text = dr.GetValue(5).ToString();
                        txt_final.Text = dr.GetValue(6).ToString();
                        pay_status.Text = dr.GetValue(7).ToString();
                        txt_note.Text = dr.GetValue(8).ToString();

                     dr.Close();    
                    }
                    else
                    {
                        MessageBox.Show("No records found.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(" Invalid Input ! Enter Phonenumber... ");
                }
            }
            else
            {
                MessageBox.Show("Enter Phone number !!");
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
            totalAmount = Convert.ToDecimal(txt_usersend.Text);
            productAmount = Convert.ToDecimal(txt_myamount.Text);
            decimal remainingAmount = totalAmount - productAmount;

            string paymentStatus = remainingAmount > 0 ? "Pending" : "Advance";


                con.Close();
                SqlCommand cmd = new SqlCommand("insert into tbl_admindata values ('" + txt_name.Text + "'," + txt_phonenumber.Text + ",'" + date_Date.Text.ToString() + "','" + combo_alldata.Text.ToString() + "','" + txt_myamount.Text + "' ," + txt_usersend.Text + ",'" + txt_final.Text + "','"+pay_status.Text+"','" + txt_note.Text + "');", con)
                {

                };
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully!!!!");
                ClearData();
                Bindxerox();

            }
            catch (Exception)
            {
                MessageBox.Show(" Invalid Input ! Enter Data !! ");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                totalAmount = Convert.ToDecimal(txt_usersend.Text);
                productAmount = Convert.ToDecimal(txt_myamount.Text);
                decimal remainingAmount = totalAmount - productAmount;

                string paymentStatus = remainingAmount > 0 ? "Pending" : "Advance";

                con.Close();
                con.Close();
                SqlCommand cmd = new SqlCommand("UPDATE tbl_admindata set name = '" + txt_name.Text + "', date = '" + date_Date.Text.ToString() + "', work = '" + combo_alldata.Text.ToString() + "', total = '" + txt_usersend.Text + "', amount = " + txt_myamount.Text + ", note = '" + txt_note.Text + "' WHERE phonenumber = " + txt_phonenumber.Text + ";", con);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Successfully!!!!");
                ClearData();
                Bindxerox();
            }
            catch (Exception)
            {
                MessageBox.Show(" Invalid Input ! Enter Phonenumber And Search !! ");
            }
        }

       /* private void rb_advance_CheckedChanged(object sender, EventArgs e)
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
        }*/

        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txt_phonenumber.Text))
            {
                try
                {
                        con.Close();
                        cmd = new SqlCommand("delete from tbl_admindata where phonenumber=" + txt_phonenumber.Text + ";", con);
                        con.Open();
                        //cmd.ExecuteNonQuery(); 
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record Deleted Successfully!");
                            ClearData();
                            Bindxerox();
                        }
                        else
                        {
                            MessageBox.Show("No records found for deletion.");
                        }

                        con.Close();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Input: " + ex.Message);
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

        private void combo_alldata_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gv_alldata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_total_g_TextChanged(object sender, EventArgs e)
        {
          
            calculate_amt(); 
        }
         private void txt_amount_TextChanged(object sender, EventArgs e)
            {
            calculate_amt();

            }

            public  void calculate_amt()
        {
int             bill_amt  = 0;
            int user_pay = 0;

            bool bill_amt_check = int.TryParse(txt_myamount.Text , out  bill_amt);

            bool user_pay_check = int.TryParse(txt_myamount.Text, out user_pay);
            if (!string.IsNullOrWhiteSpace(txt_myamount.Text) && !string.IsNullOrWhiteSpace(txt_usersend.Text) && bill_amt_check && user_pay_check)
            {


          
                bill_amt = Convert.ToInt32(txt_myamount.Text);
               user_pay = Convert.ToInt32(txt_usersend.Text);

                int amt = user_pay - bill_amt;
                txt_final.Text = amt.ToString();

                if (amt  ==  0)
                {
                    pay_status.Text = "No Remaining";
                }else if (amt > 0)
                {
                    pay_status.Text = "Advance";
                }
                else
                {
                    pay_status.Text = "Remaining ";
                }
            }

        }

    }
}

