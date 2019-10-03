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
    public partial class Customer : Form
    {
        CustomerManager _customerManager = new CustomerManager();

        public Customer()
        {
            InitializeComponent();
        }

        public void AddButton_Click(object sender, EventArgs e)
        {
            CustomerModel customerModel = new CustomerModel();
            customerModel.Name = NametextBox.Text;

            bool isExit = _customerManager.Exitname(customerModel);
            if (isExit)
            {
                MessageBox.Show(NametextBox.Text + "\t all ready exit...");
                return;
            }
            if (String.IsNullOrEmpty(customerModel.Name))
            {
                MessageBox.Show("name Can not be Empty!!!");
                return;
            }

            if (String.IsNullOrEmpty(AddresstextBox.Text))
            {
                MessageBox.Show("address Can not be Empty!!!");
                return;
            }
            customerModel.Address = AddresstextBox.Text;

            if (String.IsNullOrEmpty(contactTextBox.Text))
            {
                MessageBox.Show("contact Can not be Empty!!!");
                return;
            }
            customerModel.Contact = contactTextBox.Text;

            bool add =_customerManager .Addcustomer(customerModel);
            if (add)
            {
                MessageBox.Show("add successfull..");

            }
            else
            {
                MessageBox.Show("add false..");
            }
           

        }
        public void showButton_Click(object sender, EventArgs e)
        {

            showdataGridView.DataSource = _customerManager.Showcustomer();


        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            CustomerModel customerModel = new CustomerModel();
           
            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Id Can not be Empty!!!");
                return;
            }
            customerModel.ID = Convert.ToInt32(idTextBox.Text);
            bool isdelete =_customerManager .Deletecustomer(customerModel);
            if (isdelete)
            {
                MessageBox.Show(customerModel.ID+ "\tdelete successfull");
                
            }
            else
            {
                MessageBox.Show(idTextBox.Text + "\tdelete faild");

            }
           

        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            CustomerModel customerModel = new CustomerModel();

            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("id Can not be Empty!!!");
                return;
            }
            customerModel.ID =Convert.ToInt32 (idTextBox.Text);

            if (String.IsNullOrEmpty(NametextBox.Text))
            {
                MessageBox.Show("name Can not be Empty!!!");
                return;
            }
            customerModel.Name= NametextBox.Text;

            if (String.IsNullOrEmpty(AddresstextBox.Text))
            {
                MessageBox.Show("address Can not be Empty!!!");
                return;
            }
            customerModel.Address = AddresstextBox.Text;

            if (String.IsNullOrEmpty(contactTextBox.Text))
            {
                MessageBox.Show("contact Can not be Empty!!!");
                return;
            }
            customerModel.Contact = contactTextBox.Text;


            bool update =_customerManager .Modificustomer(customerModel);
            if (update)
            {
                MessageBox.Show(customerModel.ID + "update is ok..");
                return;
            }
            else
            {
                MessageBox.Show(idTextBox.Text + "no data found..");
            }
        }
       

       


        
    

        
        
        
       

        private void idTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void contactTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            namecomboBox.DataSource = _customerManager.NameComboBox();
        }

       
        private void SearchButton_Click(object sender, EventArgs e)
        {


            CustomerModel customerModel = new CustomerModel();

            customerModel.Name = namecomboBox.Text;
            showdataGridView.DataSource =_customerManager.Searchcustomer(customerModel);
           
        }
        
        private void showdataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.showdataGridView.Rows[e.RowIndex];

                idTextBox.Text = row.Cells[0].Value.ToString();
                NametextBox.Text = row.Cells[1].Value.ToString();
                AddresstextBox.Text = row.Cells[2].Value.ToString();
                contactTextBox.Text = row.Cells[3].Value.ToString();

            }
        }
    }
}
