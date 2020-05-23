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
    public partial class ManagementPage : Form
    {
        public ManagementPage()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            // TODO: This line of code loads data into the 'qLSVDataSet.QLSVUser' table. You can move, or remove it, as needed.
            this.QLSVUserTableAdapter.Fill(this.QLSVDataSet.QLSVUser);
            UsersData.DataSource = GetUserList();

        }
        private void ManagementPage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private DataTable GetUserList()
        {
            //This will create a empty datatable
            DataTable Users = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString.ConnectionStringPC))
            {
                //Then load all the data in the database and then convert it into a table, and return as following type
                using (SqlCommand cmd = new SqlCommand("Select * FROM QLSVUser", con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    Users.Load(reader);
                }
            }
            return Users;
        }

        private void UsersData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //This for select all row when administrator select a row
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            UsersData.Rows[index].Selected = true;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            CreateAccountPage createAccount = new CreateAccountPage();
            createAccount.ShowDialog();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login LoginPage = new Login();
            LoginPage.Show();
            this.Close();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to delete this user?", "Delete User", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                DeleteUser();
            }
        }

        private void DeleteUser()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.ConnectionStringPC))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string count = "";

                //Calculate the current selected cell 
                if (UsersData.SelectedCells.Count > 0)
                {
                    int selectedrowindex = UsersData.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = UsersData.Rows[selectedrowindex];
                    count = selectedRow.Cells["ID"].Value.ToString();
                }

                //The query to remove the user at the selected cell
                string query = "Delete from QLSVUser where ID = " + count;
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    LoadData();
                }
            }
        }

        public string count = "";

        private void Update_Click(object sender, EventArgs e)
        {

            Profile_Page Profile = new Profile_Page();
            using (SqlConnection con = new SqlConnection(ConnectionString.ConnectionStringPC))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                //Load the user information from the current selected cell
                if (UsersData.SelectedCells.Count > 0)
                {
                    int selectedrowindex = UsersData.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = UsersData.Rows[selectedrowindex];
                    count = selectedRow.Cells["ID"].Value.ToString();
                }

                //Then add the selected cell to the query, then load all the information form the current cell in the database to textbox
                string query = "Select Username, Password, FullName, PhoneNumber, Email, Contact from QLSVUser where ID = '" + count + "'";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        Profile.count = count;
                        Profile.UsernameTxt.Text = reader.GetValue(0).ToString();
                        Profile.PasswordTxt.Text = reader.GetValue(1).ToString();
                        Profile.FullnameTxt.Text = reader.GetValue(2).ToString();
                        Profile.PhoneTxt.Text = reader.GetValue(3).ToString();
                        Profile.EmailTxt.Text = reader.GetValue(4).ToString();
                        Profile.ContactTxt.Text = reader.GetValue(5).ToString();
                    }
                    Profile.Show();
                }
            }
        }

        private void ManagementPage_Activated(object sender, EventArgs e)
        {
            LoadData();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
