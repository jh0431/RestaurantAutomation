using Models;
using RestaurantAutomation.DAO;
using System; 
using System.Drawing; 
using System.Windows.Forms;

namespace RestaurantAutomation
{
    public partial class EditUserForm : Form
    {
        User user = null;
        UserDao userDao = new UserDao();

        public EditUserForm(   )
        {
            InitializeComponent(); 
        }

        public EditUserForm(User user)
        {
            InitializeComponent();
            this.user = user;
            textBox_username.Text = user.Username;
            textBox_password.Text = user.Password;
            comboBox1.SelectedItem = user.Role;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (user == null)
            { 
                user = new User(textBox_username.Text,textBox_password.Text);
                user.Role = comboBox1.SelectedItem.ToString();
                userDao.addUser(user);
            }
            else{
                user.Username = textBox_username.Text;
                user.Password = textBox_password.Text;
                user.Role= comboBox1.SelectedItem.ToString();
                userDao.updateUser(user);
            }
            this.DialogResult = DialogResult.OK;
            Close(); 
        }


    }
}
