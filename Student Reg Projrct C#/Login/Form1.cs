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
    public partial class Login : Form
    {
        SqlConnection mc = new SqlConnection(@"Data Source=DESKTOP-D1J9IM4\SQLEXPRESS;Initial Catalog=StudentLogin;Integrated Security=True");
        SqlCommand mcc;
        SqlDataReader bb;
        string qry, U, P;
        public Login()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void TxtUname_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Lbcreate_Click(object sender, EventArgs e)
        {
            CreateAc obj = new CreateAc();
            obj.Show();
            this.Hide();
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {

           
            try 
            {
                qry = "SELECT * FROM StuLog WHERE Uname='" + TxtUname.Text + "' AND Password='" + TxtPass.Text + "'";
                mcc = new SqlCommand(qry, mc);
                mc.Open();

                bb = mcc.ExecuteReader();
                while (bb.Read()) 
                {
                    U = (bb["Uname"].ToString());
                    P = (bb["Password"].ToString());
                    
                }
                if (TxtUname.Text == U && TxtPass.Text == P)
                {
                    AddStu Od = new AddStu();
                    Od.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login credentials. Please check User Name and Password and try again.", 
                        "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtUname.Clear();
                    TxtPass.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                mc.Close();
            }
            
        }
    }
}
