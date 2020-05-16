using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Login : Form
    {
        public string ConnectionString = "Data Source=DESKTOP-A20UEMF;Initial Catalog=QLSV;Integrated Security=True";

        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Username != string.Empty)
            {
                Login_Username_txtBox.Text = Properties.Settings.Default.Username;
                Login_Password_txtBox.Text = Properties.Settings.Default.Password;
                Login_SavePasswordCheckBox.Checked = true;
            }
        }

        private void Login_loginButton_Click(object sender, EventArgs e)
        {
            SetLoginInfo();

            SqlConnection Connection = new SqlConnection(ConnectionString);
            string query = "Select * from QLSVUser where Username = '" + Login_Username_txtBox.Text.Trim() + "'and Password = '" + Login_Password_txtBox.Text.Trim() + "'";
            Connection.Open();
            if (Connection.State == System.Data.ConnectionState.Open)
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, Connection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    ManagementPage objMain = new ManagementPage();
                    this.Hide();
                    objMain.Show();
                }
                else
                {
                    MessageBox.Show("Check your username and password");
                }
            }
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(ShowPassword.Checked)
            {
                Login_Password_txtBox.UseSystemPasswordChar = false;
            }
            else
                Login_Password_txtBox.UseSystemPasswordChar = true;
        }

        private void Login_Username_txtBox_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = this.Login_loginButton;
        }

        private void Login_Password_txtBox_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = this.Login_loginButton;
        }
        private void SetLoginInfo()
        {
            if (Login_SavePasswordCheckBox.Checked)
            {
                Properties.Settings.Default.Username = Login_Username_txtBox.Text;
                Properties.Settings.Default.Password = Login_Password_txtBox.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
        }
    }
}
