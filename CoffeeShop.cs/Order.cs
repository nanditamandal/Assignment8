using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShop.cs.BLL;
using CoffeeShop.cs.Model;

namespace CoffeeShop.cs
{
    public partial class Order : Form
    {
        OrderManagement _orderManagement = new OrderManagement();

        public Order()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            OrderModel orderModel = new OrderModel();
            
            if (String.IsNullOrEmpty(customernamecomboBox.Text))
            {
                MessageBox.Show("name Can not be Empty!!!");
                return;
            }
            orderModel.Name = customernamecomboBox.Text;

            if (String.IsNullOrEmpty(itemnamecomboBox.Text))
            {
                MessageBox.Show("item name Can not be Empty!!!");
                return;
            }
            orderModel.ItemName = itemnamecomboBox.Text;

            if (String.IsNullOrEmpty(quantityTextBox.Text))
            {
                MessageBox.Show("quantity Can not be Empty!!!");
                return;
            }
            orderModel.Quantity =Convert.ToInt32( quantityTextBox.Text);

            if (_orderManagement.Addorder(orderModel))
            {
                MessageBox.Show("order added..");
            }
            else
            {
                MessageBox.Show("order can not added..");
            }
            
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            OrderModel orderModel = new OrderModel();

            DataTable showorder = _orderManagement.Showorder();
            if (showorder.Rows.Count > 0)
            {
                showdataGridView.DataSource = showorder;
            }
            else
            {
                MessageBox.Show("no data found");
            }

        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            OrderModel orderModel = new OrderModel();

            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("id Can not be Empty!!!");
                return;
            }
            orderModel.ID =Convert.ToInt32( idTextBox.Text);

            if (String.IsNullOrEmpty(customernamecomboBox.Text))
            {
                MessageBox.Show("name Can not be Empty!!!");
                return;
            }
            orderModel.Name = customernamecomboBox.Text;

            if (String.IsNullOrEmpty(itemnamecomboBox.Text))
            {
                MessageBox.Show("item name Can not be Empty!!!");
                return;
            }
            orderModel.ItemName = itemnamecomboBox.Text;

            if (String.IsNullOrEmpty(quantityTextBox.Text))
            {
                MessageBox.Show("quantity Can not be Empty!!!");
                return;
            }
            orderModel.Quantity =Convert.ToInt32 (quantityTextBox.Text);

            if (_orderManagement.Updateorder(orderModel))
            {
                MessageBox.Show("order updatede..");
            }
            else
            {
                MessageBox.Show("order can not updatede..");
            }

        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            OrderModel orderModel = new OrderModel();

            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("id Can not be Empty!!!");
                return;
            }
            orderModel.ID = Convert.ToInt32(idTextBox.Text);

            if (_orderManagement.Deleteorder(orderModel))
            { MessageBox.Show("delete successfull .."); }
            else { MessageBox.Show("id can not delete .."); }




        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            OrderModel orderModel = new OrderModel();

            if (String.IsNullOrEmpty(customernamecomboBox.Text))
            {
                MessageBox.Show("name Can not be Empty!!!");
                return;
            }
            orderModel.Name = customernamecomboBox.Text;
            //showdataGridView.DataSource = _orderManagement.Searchorder(orderModel);

            DataTable dataTable = _orderManagement.Searchorder(orderModel);
            if (dataTable.Rows.Count > 0)
            { showdataGridView.DataSource = dataTable; }
            else { MessageBox.Show("no data found"); }
            
        }

        

        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void idTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void customernamecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Order_Load(object sender, EventArgs e)
        {
            customernamecomboBox.DataSource = _orderManagement.NameComboBox();
            itemnamecomboBox.DataSource = _orderManagement.ItemNameComboBox();
        }

        
        private void showdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.showdataGridView.Rows[e.RowIndex];

                idTextBox.Text = row.Cells[0].Value.ToString();
                customernamecomboBox.Text = row.Cells[1].Value.ToString();
                itemnamecomboBox.Text = row.Cells[4].Value.ToString();
                quantityTextBox.Text = row.Cells[6].Value.ToString();

            }
        }
    }
}
