using Models;
using RestaurantAutomation.DAO;
using System;  
using System.Windows.Forms;

namespace RestaurantAutomation.View
{
    public partial class EditMenuItemForm : Form
    {
       private  Menuitem _menuItem = null;
       private readonly MenuItemDao _menuItemDao = new MenuItemDao();

        public EditMenuItemForm(   )
        {
            InitializeComponent(); 
        }

        public EditMenuItemForm(Menuitem menuItem)
        {
            InitializeComponent();
            this._menuItem = menuItem;
            textBox_name.Text = menuItem.Name;
            textBox_price.Text = menuItem.Price+""; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (_menuItem == null)
            {
                _menuItem = new Menuitem(textBox_name.Text,decimal.Parse( textBox_price.Text));
                _menuItemDao.AddMenuItem(_menuItem);
            }
            else{
                _menuItem.Name = textBox_name.Text;
                _menuItem.Price = decimal.Parse(textBox_price.Text);
                _menuItemDao.UpdateMenuItem(_menuItem);
            }
            this.DialogResult = DialogResult.OK;
            Close(); 
        }


    }
}
