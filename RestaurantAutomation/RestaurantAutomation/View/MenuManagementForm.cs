using Models;
using RestaurantAutomation.DAO;
using RestaurantAutomation.View;
using System;
using System.Collections.Generic; 
using System.Linq; 
using System.Windows.Forms;

namespace RestaurantAutomation.View
{
    public partial class MenuManagementForm : Form
    {
        MenuItemDao menuItemDao = new MenuItemDao();
         
        public MenuManagementForm()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            EditMenuItemForm editMenuItemForm = new EditMenuItemForm();
            editMenuItemForm.ShowDialog();
            if (editMenuItemForm.DialogResult == DialogResult.OK)
            {
                loadData();
            }
        }

        private void loadData()
        {
            List<Menuitem> menu = menuItemDao.GetMenu();
            var userItems = (from t in menu select new { t.Id, t.Name, t.Price }).ToList();
            dataGridView1.DataSource = userItems.ToList();
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Menuitem menuitem = menuItemDao.GetMenuItemById(Int32.Parse(id));
            EditMenuItemForm editMenuItemForm = new EditMenuItemForm(menuitem);
            editMenuItemForm.ShowDialog();
            if (editMenuItemForm.DialogResult == DialogResult.OK)
            {
                loadData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            MessageBoxButtons msgButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Are you sure to delete this menu item?", "Confirm", msgButton);
            if (dr == DialogResult.OK)
            {
                menuItemDao.RemoveMenuItem(Int32.Parse(id));
                loadData();
            }
        }

        private void MenuManagementForm_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
