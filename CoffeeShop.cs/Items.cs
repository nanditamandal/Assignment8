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
    public partial class Items : Form
    {
        ItemsManager _itemsManager = new ItemsManager();
        public Items()
        {
            InitializeComponent();
        }

        private void Items_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ItemModel itemModel = new ItemModel();
            itemModel.ItemName = nameTextBox.Text;

            if (_itemsManager.IsNameExists(itemModel))
            {
                MessageBox.Show(nameTextBox.Text + "Already Exists!");
                return;
            }

           

            if (String.IsNullOrEmpty(priceTextBox.Text))
            {
                MessageBox.Show("Price Can not be Empty!!!");
                return;
            }
            itemModel.Price =Convert.ToInt32( priceTextBox.Text);

            bool added = _itemsManager.Additem(itemModel);

            if (added)
            {
                MessageBox.Show("Saved");
              
            }
            else
            {
                MessageBox.Show("Not Saved");
            }

            _itemsManager.Showitem();
           
           

        }
        

        private void showButton_Click(object sender, EventArgs e)
        {
            ItemModel itemModel = new ItemModel();
            DataTable showitem = _itemsManager.Showitem();

            if (showitem.Rows.Count > 0)
            {
                showdataGridView.DataSource = showitem;
            }
            else
            {
                MessageBox.Show("can not show item..");
            }
        }
        
        private void deleteButton_Click(object sender, EventArgs e)
        {
            ItemModel itemModel = new ItemModel();

            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Id Can not be Empty!!!");
                return;
            }
            itemModel.ID =Convert.ToInt32 (idTextBox.Text);
            if (_itemsManager.Deleteitem(itemModel))
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }
            _itemsManager.Showitem();
            
        }
       


        private void updateButton_Click(object sender, EventArgs e)
        {
            ItemModel itemModel = new ItemModel();

            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("name Can not be Empty!!!");
                return;
            }
            itemModel.ItemName = nameTextBox.Text;
 

            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Id Can not be Empty!!!");
                return;
            }
            itemModel.ID =Convert.ToInt32( idTextBox.Text);
            //Set Price as Mandatory
            if (String.IsNullOrEmpty(priceTextBox.Text))
            {
                MessageBox.Show("Price Can not be Empty!!!");
                return;
            }
            itemModel.Price =Convert.ToInt32( priceTextBox.Text);

            if (_itemsManager.Modifyitem(itemModel))
            { 
                MessageBox.Show("Updated");
                _itemsManager.Showitem();
            }
            else
            {
                MessageBox.Show("Not Updated");
            }
            
        }
       


        private void searchButton_Click(object sender, EventArgs e)
        {
            ItemModel itemModel = new ItemModel();
            itemModel.ItemName = nameTextBox.Text;
            DataTable dataTable = _itemsManager.Searchitem(itemModel);

            if (dataTable.Rows.Count>0)
            {
                showdataGridView.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("no data found");
            }
        }
        
        
     
      
        

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void showdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.showdataGridView.Rows[e.RowIndex];

                idTextBox.Text = row.Cells[0].Value.ToString();
                nameTextBox.Text = row.Cells[1].Value.ToString();
                priceTextBox.Text = row.Cells[2].Value.ToString();
                

            }
        }
    }
}
