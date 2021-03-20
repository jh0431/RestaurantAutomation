using Models;
using RestaurantAutomation.DAO;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RestaurantAutomation.VIEW
{
    public partial class TableInfoForm : Form
    {
        TableDao tableDao = new TableDao();
        DishDao dishDao = new DishDao();
        OrderDao orderDao = new OrderDao();
        Table table = null;
        Order order = null; 

        public TableInfoForm(string num)
        {
            InitializeComponent();
            table = tableDao.GetTableById(Int32.Parse(num));
            label_tableNum.Text = table.Num;
            label_status.Text = table.Status;

            order = orderDao.GetOrderByTableNum(table.Num); 

        }

        /// <summary>
        /// Add button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            EditOrderForm editOrderForm = new EditOrderForm(order);
            editOrderForm.ShowDialog();
            if (editOrderForm.DialogResult == DialogResult.OK)
            {
                loadData();
            }
        }

        private void loadData()
        {
            if (order == null)
            {
                return;
            }

            var list = DBHelper.GetInstance()
                .Queryable<Dish, Menuitem>((di, me) => new JoinQueryInfos(JoinType.Left, di.MenuItemId == me.Id))
                .Where((di, me) => di.OrderId==order.Id)
                .Select((di, me) => new { di.Id, me.Name, di.Count,Price=me.Price ,Total=di.Count*me.Price,di.Status }).ToList(); 
            dataGridView1.DataSource = list;
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msgButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Are you sure to CHECK OUT for TABLE "+table.Num+"? Order will set to \"Completed\" and Table will be set \"Dirty\"", "Confirm", msgButton);
            if (dr == DialogResult.OK)
            {
                order.Status = "Completed";
                order.FinishedTime = DateTime.Now;
                table.Status = "Dirty";
                orderDao.updateOrder(order);
                tableDao.updateTable(table);
            } 
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            MessageBoxButtons msgButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("Are you sure to remove this dish?", "Confirm", msgButton);
            if (dr == DialogResult.OK)
            {
                dishDao.removeDish(Int32.Parse(id));
                loadData();
            }
        }
         

        /// <summary>
        /// Place order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            if (order == null)
            {
                order = new Order();
                order.Status = "Ordered";
                order.TableNum = table.Num;
                order.OrderedTime = DateTime.Now;
                orderDao.addOrder(order);
                order = orderDao.GetOrderByTableNum(table.Num);
                MessageBox.Show("Order created successfully.", "Error");
            }
            else {
                MessageBox.Show("Order is already created.","Error");
            }
            table.Status = "Occupied";
            tableDao.updateTable(table);
        }

        /// <summary>
        /// Clean table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            table.Status = "Clean";
            tableDao.updateTable(table);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Dish dish = dishDao.GetDishById(int.Parse(id));
            dish.Status = "Completed";
            dish.CompletedTime = DateTime.Now; 
            dishDao.updateDish(dish);
            loadData();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Dish dish = dishDao.GetDishById(int.Parse(id));
            dish.Status = "Finished";
            dish.FinishedTime = DateTime.Now;
            dishDao.updateDish(dish);
            loadData();
        }

        private void TableInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
