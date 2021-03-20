using Models;
using RestaurantAutomation.DAO;
using RestaurantAutomation.VIEW;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RestaurantAutomation
{
    public partial class MainForm : Form
    {
        TableDao tableDao = new TableDao();
        static User user = null;

        public MainForm(User user)
        {
            InitializeComponent();
            MainForm.user = user;
        } 

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm();
            userManagementForm.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxButtons msgButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Are you sure to exit?", "Exit", msgButton);
            if (dr == DialogResult.OK)
            {
                Environment.Exit(0);
            } 
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void menuManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuManagementForm menuManagementForm = new MenuManagementForm();
            menuManagementForm.ShowDialog();
        }
         

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            TableInfoForm tableInfoForm = new TableInfoForm(button.Text);
            tableInfoForm.ShowDialog();
            if (tableInfoForm.DialogResult == DialogResult.OK)
            {
                loadData();
            }
        }

        private void loadData()
        { 
            List<Table> tables = tableDao.GetTableList();
            foreach (Table table in tables)
            {
                Button button =(Button) Controls.Find("button"+table.Num, true)[0];
                if(table.Status=="Clean")
                {
                    button.BackColor = Color.Gray; 
                }else if(table.Status== "Occupied")
                {
                    button.BackColor = Color.Green;
                }else{
                    button.BackColor = Color.Red;
                }
            } 
        }


    }
}
