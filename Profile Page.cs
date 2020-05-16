using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Profile_Page : Form
    {
        string ConnectionString = "Data Source=DESKTOP-A20UEMF;Initial Catalog=QLSV;Integrated Security=True";
        public string count = "";
        public Profile_Page()
        {
            InitializeComponent();
        }

        private void Profile_Page_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE QLSVUser  SET Username = @Username , Password = @Password, FullName = @FullName, PhoneNumber = @PhoneNumber, Email = @Email, Contact = @Contact  where id  = @id", con))
                {
                    cmd.Parameters.AddWithValue("@Username", UsernameTxt.Text);
                    cmd.Parameters.AddWithValue("@Password", PasswordTxt.Text);
                    cmd.Parameters.AddWithValue("@FullName", FullnameTxt.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneTxt.Text);
                    cmd.Parameters.AddWithValue("@Email", EmailTxt.Text);
                    cmd.Parameters.AddWithValue("@Contact", ContactTxt.Text);
                    cmd.Parameters.AddWithValue("@ID", count.ToString());
                    cmd.ExecuteNonQuery();
                    this.Close();
                }
            }
        }

        private void EmailTxt_Leave(object sender, EventArgs e)
        {
            Regex mRegxExpression;
            if (EmailTxt.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(EmailTxt.Text.Trim()))
                {
                    MessageBox.Show("E-mail address format is not correct.", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EmailTxt.Focus();
                }
            }
        }

        private void PhoneTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                PasswordTxt.UseSystemPasswordChar = false;
            }
            else
                PasswordTxt.UseSystemPasswordChar = true;
        }
    }
}
