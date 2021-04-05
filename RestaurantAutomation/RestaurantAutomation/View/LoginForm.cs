// <copyright file="LoginForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace RestaurantAutomation
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Models;
    using RestaurantAutomation.DAO;

    public partial class LoginForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginForm"/> class.
        /// </summary>
        public LoginForm()
        {
            this.InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(this.pictureBox1.ClientRectangle);
            Region reg = new Region(path);
            this.pictureBox1.Region = reg;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UserDao userDao = new UserDao();
            string username = this.textBox_username.Text;
            string password = this.textBox_password.Text;
            if (userDao.Login(new User(username, password)))
            {
                User user = userDao.GetUserByUserName(username);
                MainForm mainForm = new MainForm(user);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed, please check your username and password.","Error");
            }
        }
    }
}
