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

namespace Login
{
    public partial class CreateAc : Form
    {
        SqlConnection mc = new SqlConnection(@"Data Source=DESKTOP-D1J9IM4\SQLEXPRESS;Initial Catalog=StudentLogin;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        string qry;
        public CreateAc()
        {
            InitializeComponent();
        }

        private void TxtUname_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void BtnCreAc_Click(object sender, EventArgs e)
        {
            string F, L, P, CP;

            F = TxtFname.Text + TxtLname.Text;
            L = F + "@Detaden.com";

            P = TxtPass.Text;
            CP = TxtPassConf.Text;

            if (P == CP) 
            {
                try 
                {
                    qry = "INSERT INTO StuLog (Uname,Password) VALUES ('" + L + "','" + CP + "')";
                    cmd = new SqlCommand(qry, mc);
                    mc.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Account Created Successful. Your User Name is " + L, "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally 
                {
                    mc.Close();
                }

                Login mcc = new Login();
                mcc.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Your Password is wrong. Please fix it.","Create fail",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
        }
    }
}
