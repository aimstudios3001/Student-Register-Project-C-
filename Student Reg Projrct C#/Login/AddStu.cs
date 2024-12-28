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
    public partial class AddStu : Form
    {
        SqlConnection mc = new SqlConnection(@"Data Source=DESKTOP-D1J9IM4\SQLEXPRESS;Initial Catalog=StudentLogin;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader sdr;
        string gend, qry;
        public AddStu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
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

        private void RbtMale_CheckedChanged(object sender, EventArgs e)
        {
            gend = "Male";
        }

        private void RbtFemale_CheckedChanged(object sender, EventArgs e)
        {
            gend = "Female";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtAddre.Clear();
            txtContNum.Clear();
            txtEmail.Clear();
            txtFname.Clear();
            txtHomeNo.Clear();
            txtLname.Clear();
            txtNIC.Clear();
            txtParent.Clear();
            txtPhoneN.Clear();
            RbtMale.Checked = false;
            RbtFemale.Checked = false;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int ID, Pn, Hn, Cn;
            ID = int.Parse(CombID.Text);
            Pn = int.Parse(txtPhoneN.Text);
            Hn = int.Parse(txtHomeNo.Text);
            Cn = int.Parse(txtContNum.Text);
            try 
            {
                qry = "INSERT INTO StuRegist1 (regNo,firstName,lastName,dateOfBirth,Gender,address,email,mobilePhone,homePhone,parentName,NIC,contactNo) VALUES ('" +
                    ID + "','" +
                    txtFname.Text + "','" +
                    txtLname.Text + "','" +
                    this.DtpDB.Text + "','" +
                    gend + "','" +
                    txtAddre.Text + "','" +
                    txtEmail.Text + "','" +
                    Pn + "','" +
                    Hn + "','" +
                    txtParent.Text + "','" +
                    txtNIC.Text + "','" +
                    Cn + "')";

                cmd = new SqlCommand(qry, mc);
                mc.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Added successfully.","Register Student",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                mc.Close();
            }
            txtAddre.Clear();
            txtContNum.Clear();
            txtEmail.Clear();
            txtFname.Clear();
            txtHomeNo.Clear();
            txtLname.Clear();
            txtNIC.Clear();
            txtParent.Clear();
            txtPhoneN.Clear();
            RbtMale.Checked = false;
            RbtFemale.Checked = false;

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int ID, Pn, Hn, Cn;
            ID = int.Parse(CombID.Text);
            Pn = int.Parse(txtPhoneN.Text);
            Hn = int.Parse(txtHomeNo.Text);
            Cn = int.Parse(txtContNum.Text);

            DialogResult rs = MessageBox.Show("Update this student Details?", "Update Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes) 
            {
                try 
                {
                    qry = "UPDATE StuRegist1 SET firstName='"+
                        txtFname.Text+"',lastName='"+
                        txtLname.Text+"',dateOfBirth='"+
                        this.DtpDB.Text+"',Gender='"+
                        gend+"',address='"+
                        txtAddre.Text+"',email='"+
                        txtEmail.Text+"',mobilePhone='"+
                        Pn+"',homePhone='"+
                        Hn+"',parentName='"+
                        txtParent.Text+"',NIC='"+
                        txtNIC.Text+"',contactNo='"+
                        Cn+ "' WHERE regNo='" +
                        ID + "'";

                    cmd = new SqlCommand(qry, mc);
                    mc.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally 
                {
                    mc.Close();
                }
                txtAddre.Clear();
                txtContNum.Clear();
                txtEmail.Clear();
                txtFname.Clear();
                txtHomeNo.Clear();
                txtLname.Clear();
                txtNIC.Clear();
                txtParent.Clear();
                txtPhoneN.Clear();
                RbtMale.Checked = false;
                RbtFemale.Checked = false;
            }
            else 
            {
                txtAddre.Clear();
                txtContNum.Clear();
                txtEmail.Clear();
                txtFname.Clear();
                txtHomeNo.Clear();
                txtLname.Clear();
                txtNIC.Clear();
                txtParent.Clear();
                txtPhoneN.Clear();
                RbtMale.Checked = false;
                RbtFemale.Checked = false;
            }
 
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int ID;
            ID = int.Parse(CombID.Text);
            DialogResult rt = MessageBox.Show("Are you sure, Do you really want to Delete this Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rt == DialogResult.Yes) 
            {
                try 
                {
                    qry= "DELETE FROM StuRegist1 WHERE regNo='" + ID + "'";

                    cmd = new SqlCommand(qry, mc);
                    mc.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted successfully.", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally 
                {
                    mc.Close();
                }
                txtAddre.Clear();
                txtContNum.Clear();
                txtEmail.Clear();
                txtFname.Clear();
                txtHomeNo.Clear();                
                txtLname.Clear();
                txtNIC.Clear();
                txtParent.Clear();
                txtPhoneN.Clear();
                RbtMale.Checked = false;
                RbtFemale.Checked = false;
            }
            else
            {
                txtAddre.Clear();
                txtContNum.Clear();
                txtEmail.Clear();
                txtFname.Clear();
                txtHomeNo.Clear();               
                txtLname.Clear();
                txtNIC.Clear();
                txtParent.Clear();
                txtPhoneN.Clear();
                RbtMale.Checked = false;
                RbtFemale.Checked = false;
            }
        }

        private void LbLogout_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Are you Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                Login obi = new Login();
                obi.Show();
                this.Hide();
            }
        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void CombID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID;
            ID = int.Parse(CombID.Text);
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            int ID;
            ID = int.Parse(CombID.Text);
            
            
            mc.Open();
            SqlCommand cmd = new SqlCommand("SELECT firstName,lastName,dateOfBirth,Gender,address,email,mobilePhone,homePhone,parentName,NIC,contactNo FROM " +
                "StuRegist1 WHERE regNo='"+ID+"'", mc);
            SqlDataReader sdr = cmd.ExecuteReader();
            
            while (sdr.Read()) 
            {
                txtFname.Text = sdr.GetValue(0).ToString();
                txtLname.Text= sdr.GetValue(1).ToString();
                gend = sdr.GetValue(3).ToString();
                DtpDB.Text = sdr.GetSqlDateTime(2).ToString();
                txtAddre.Text= sdr.GetValue(4).ToString();
                txtEmail.Text= sdr.GetValue(5).ToString();
                txtPhoneN.Text= sdr.GetValue(6).ToString();
                txtHomeNo.Text= sdr.GetValue(7).ToString();
                txtParent.Text= sdr.GetValue(8).ToString();
                txtNIC.Text= sdr.GetValue(9).ToString();
                txtContNum.Text= sdr.GetValue(10).ToString();
            }
            if (gend == "Male")
            {
                RbtMale.Checked = true;                
            }
            else
            {
                RbtFemale.Checked = true;                
            }
            
            mc.Close();
            
        }
    }
}
