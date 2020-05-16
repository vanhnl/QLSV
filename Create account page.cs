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
using System.Text.RegularExpressions;

namespace QLSV
{
    public partial class CreateAccountPage : Form
    {
        public string ConnectionString = "Data Source=DESKTOP-A20UEMF;Initial Catalog=QLSV;Integrated Security=True";

        public CreateAccountPage()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Create this user?", "Create user", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                {
                    string QueryTest = "Insert into QLSVUser (Username, Password, FullName, PhoneNumber, Email, Contact) VALUES (@username,@password,@fullname,@phonenumber,@email,@contact)";

                    using (SqlCommand cmd = new SqlCommand(QueryTest))
                    {
                        cmd.Connection = Connection;
                        cmd.Parameters.Add("@username", SqlDbType.VarChar, 15).Value = UsernameTxt.Text;
                        cmd.Parameters.Add("@password", SqlDbType.VarChar, 15).Value = PasswordTxt.Text;
                        cmd.Parameters.Add("@fullname", SqlDbType.VarChar, 50).Value = FullNameTxt.Text;
                        cmd.Parameters.Add("@phonenumber", SqlDbType.Int).Value = PhoneNumberTxt.Text;
                        cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = EmailTxt.Text;
                        cmd.Parameters.Add("@contact", SqlDbType.VarChar, 50).Value = ContactTxt.Text;
                        Connection.Open();

                        cmd.ExecuteNonQuery();
                        this.Close();
                    }
                }
                ManagementPage prev = (ManagementPage)Application.OpenForms["ManagementPage"];
                prev.LoadData();
            }
            else
            {
                return;
            }
        }

        private void PhoneNumberTxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CreateAccountPage_Load(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
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
