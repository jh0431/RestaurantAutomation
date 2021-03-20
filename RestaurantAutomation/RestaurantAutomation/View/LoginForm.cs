using Models;
using RestaurantAutomation.DAO;
using System; 
using System.Drawing; 
using System.Windows.Forms;

namespace RestaurantAutomation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(this.pictureBox1.ClientRectangle);
            Region reg = new Region(path);
            this.pictureBox1.Region = reg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserDao userDao = new UserDao();
            string username = textBox_username.Text;
            string password = textBox_password.Text;
            if (userDao.Login(new User(username, password)))
            {
                User user = userDao.GetUserByUserName(username);
                MainForm mainForm = new MainForm(user);
                mainForm.Show();
                Hide();
            }
            else {
                MessageBox.Show("Login failed, please check your username and password.","Error");
            } 
        }


    }
}
