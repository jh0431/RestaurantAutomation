using Models;
using RestaurantAutomation.DAO;
using System;  
using System.Windows.Forms;

namespace RestaurantAutomation
{
    public partial class EditMenuItemForm : Form
    {
         Menuitem menuItem = null;
        MenuItemDao menuItemDao = new MenuItemDao();

        public EditMenuItemForm(   )
        {
            InitializeComponent(); 
        }

        public EditMenuItemForm(Menuitem menuItem)
        {
            InitializeComponent();
            this.menuItem = menuItem;
            textBox_name.Text = menuItem.Name;
            textBox_price.Text = menuItem.Price+""; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (menuItem == null)
            {
                menuItem = new Menuitem(textBox_name.Text,decimal.Parse( textBox_price.Text));
                menuItemDao.addMenuItem(menuItem);
            }
            else{
                menuItem.Name = textBox_name.Text;
                menuItem.Price = decimal.Parse(textBox_price.Text);
                menuItemDao.updateMenuItem(menuItem);
            }
            this.DialogResult = DialogResult.OK;
            Close(); 
        }


    }
}
