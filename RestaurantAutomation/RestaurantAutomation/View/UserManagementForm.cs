using Models;
using RestaurantAutomation.DAO;
using System;
using System.Collections.Generic; 
using System.Linq; 
using System.Windows.Forms;

namespace RestaurantAutomation.View
{
    public partial class UserManagementForm : Form
    {
        UserDao userDao = new UserDao(); 

        public UserManagementForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Add button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            EditUserForm editUserForm = new EditUserForm();
            editUserForm.ShowDialog();
            if (editUserForm.DialogResult == DialogResult.OK)
            {
                loadData();
            }
        }

        private void loadData()
        {
            List<User> userEntitys = userDao.GetUsers();
            var users = (from t in userEntitys select new { t.Id, t.Username, t.Role }).ToList(); 
            dataGridView1.DataSource = users.ToList();
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id= dataGridView1.SelectedRows[0].Cells[0].Value.ToString(); 
            User user = userDao.GetUserById(Int32.Parse(id));
            EditUserForm editUserForm = new EditUserForm(user);
            editUserForm.ShowDialog();
            if (editUserForm.DialogResult == DialogResult.OK)
            {
                loadData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            MessageBoxButtons msgButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Are you sure to delete this user?", "Confirm", msgButton);
            if (dr == DialogResult.OK)
            {
                userDao.removeUser(Int32.Parse(id));
                loadData();
            } 
        }
    }
}
