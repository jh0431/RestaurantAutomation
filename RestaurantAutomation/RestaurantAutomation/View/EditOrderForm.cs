using Models;
using RestaurantAutomation.DAO;
using System;
using System.Collections.Generic;
using System.Drawing; 
using System.Windows.Forms;

namespace RestaurantAutomation
{
    public partial class EditOrderForm : Form
    {
        Order order = null;
        DishDao dishDao = new DishDao();
        MenuItemDao menuItemDao = new MenuItemDao();
        List<Menuitem> menu = null;

        public EditOrderForm(Order order)
        {
            InitializeComponent();
            this.order = order;
        } 

        private void Form1_Load(object sender, EventArgs e)
        {
            menu = menuItemDao.GetMenu();

            comboBox1.DataSource = menu; 
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dish dish = new Dish();
            dish.MenuItemId =int.Parse( comboBox1.SelectedValue.ToString());
            dish.OrderId = order.Id;
            dish.Status = "Ordered";
            dish.OrderedTime = DateTime.Now;
            dish.Count = int.Parse(textBox_count.Text);
            dishDao.addDish(dish); 
            this.DialogResult = DialogResult.OK;
            Close(); 
        }


    }
}
