using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using CoffeeShop.cs.Model;

namespace CoffeeShop.cs.Repository
{
    public class OrderRepository
    {
        public bool Addorder(OrderModel orderModel)
        {

            try
            {
                string connection = @"Server=NANDITA;DataBase=CoffeeShop;Integrated Security=True";
                SqlConnection sqlconnection = new SqlConnection(connection);

                string insert = @"INSERT INTO Orders(Quantity, Name , ItemName)VALUES(" +orderModel.Quantity+ ",'" + orderModel.Name + "','" + orderModel.ItemName+ "')";
                SqlCommand command = new SqlCommand(insert, sqlconnection);

                sqlconnection.Open();
                int isExecuted = command.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return true;
                }



                sqlconnection.Close();
            }
            catch (Exception ex)
            {
               
            }
            return false;
        }



        public DataTable Showorder()
        {

            string connection = @"Server=NANDITA;DataBase=CoffeeShop;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection);

            string show = @"SELECT Orders.ID,Orders.Name, Customers.Address, Customers.Contact,Orders.ItemName, Items.Price,Orders.Quantity,(Orders.Quantity*Items.Price) As TotalPrice FROM Orders, Customers, Items WHERE Orders.Name=Customers.Name AND Orders.ItemName=Items.ItemName";
            SqlCommand command = new SqlCommand(show, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                return dataTable;
                //showdataGridView.DataSource = dataTable;
            }


            sqlConnection.Close();
            return dataTable;


        }


        public bool Updateorder(OrderModel orderModel)
        {
            try
            {
                string connection = @"Server=NANDITA;DataBase=CoffeeShop;Integrated Security=True";
                SqlConnection sqlconnection = new SqlConnection(connection);

                string query = @"UPDATE Orders SET Quantity=" + orderModel.Quantity + ", Name='" + orderModel.Name + "', ItemName='" + orderModel.ItemName + "'WHERE ID=" +orderModel.ID + "";
                SqlCommand command = new SqlCommand(query, sqlconnection);

                sqlconnection.Open();
                int isExecuted = command.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return true;
                }



                sqlconnection.Close();
            }
            catch (Exception ex)
            {
                
            }
            return false;
        }


        public bool Deleteorder(OrderModel orderModel)
        {
            try
            {
                string connection = @"Server=NANDITA;DataBase=CoffeeShop;Integrated Security=True";
                SqlConnection sqlconnection = new SqlConnection(connection);
                string query = @"DELETE FROM Orders WHERE ID='" + orderModel.ID + "'";
                SqlCommand command = new SqlCommand(query, sqlconnection);

                sqlconnection.Open();
                int isExecuted = command.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return true;
                }
                else
                {
                   
                }
                sqlconnection.Close();
            }
            catch (Exception e)
            {
                
            }
            return false;
        }


        public DataTable Searchorder(OrderModel orderModel)
        {
             
            string connectionString = @"Server=NANDITA;DataBase=CoffeeShop;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string show = @"SELECT Orders.ID,Orders.Name, Customers.Address, Customers.Contact,Orders.ItemName, Items.Price,Orders.Quantity,(Orders.Quantity*Items.Price) As TotalPrice FROM Orders, Customers, Items WHERE Orders.Name=Customers.Name AND Orders.ItemName=Items.ItemName AND Orders.Name='" +orderModel.Name + "'";

            SqlCommand sqlCommand = new SqlCommand(show, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                return dataTable;
            }

            sqlConnection.Close();
            return dataTable;



        }
        public DataTable NameComboBox()
        {
            string connectionString = @"Server=NANDITA;DataBase=CoffeeShop;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string CommandString = @"SELECT ID, Name FROM Customers ";

            SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            //showdataGridView.DataSource = dataTable;
            if (dataTable.Rows.Count > 0)
            {
                return dataTable;

            }

            sqlConnection.Close();

            return dataTable;

        }

        public DataTable ItemNameComboBox()
        {
            string connectionString = @"Server=NANDITA;DataBase=CoffeeShop;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string CommandString = @"SELECT ID, ItemName FROM Items ";

            SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            //showdataGridView.DataSource = dataTable;
            if (dataTable.Rows.Count > 0)
            {
                return dataTable;

            }

            sqlConnection.Close();

            return dataTable;

        }

    }
}
