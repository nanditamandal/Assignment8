using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.cs.Model;


namespace CoffeeShop.cs.Repository
{
    public class CustomerRepository
    {
        


        public bool Exitname(CustomerModel customerModel)
        {
            bool ishas = false;
            string connectionString = @"Server=NANDITA;DataBase=CoffeeShop;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string CommandString = @"SELECT * FROM Customers WHERE Name='" +customerModel.Name+ "'";

            SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            //showdataGridView.DataSource = dataTable;
            if (dataTable.Rows.Count > 0)
            {
                return ishas = true;
               // showdataGridView.DataSource = dataTable;
            }
            sqlConnection.Close();
            return ishas;


        }


        public bool Addcustomer(CustomerModel customerModel)
        {
            bool isadd = false;
            try
            {

                string connection = @"Server=NANDITA;DataBase=CoffeeShop;Integrated Security=True";
                SqlConnection sqlconnection = new SqlConnection(connection);
                string insert = @"INSERT INTO Customers(Name, Address , Contact)VALUES('" +customerModel.Name+ "', '" + customerModel.Address + "','" + customerModel.Contact + "')";
                SqlCommand command = new SqlCommand(insert, sqlconnection);

                sqlconnection.Open();
                int isExecuted = command.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    isadd = true;

                }

                sqlconnection.Close();

            }
            catch (Exception e)
            {
                //MessageBox.Show("please insert name address and contact..");
            }
            return isadd;
        }
        public bool Deletecustomer(CustomerModel customerModel )
            
        {
            bool isdelete = false;
            try
            {
                //Connection
                string connectionString = @"Server=NANDITA; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //DELETE FROM Items WHERE ID = 3
                string commandString = @"DELETE FROM Customers WHERE ID = " +customerModel.ID + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Delete
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return isdelete = true;
                }


                //Close
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                //MessageBox.Show(exeption.Message);
            }

            return isdelete ;

        }
        public bool Modificustomer(CustomerModel customerModel)
        {
            bool isupdate = false;
            try
            {
                string connection = @"Server=NANDITA;DataBase=CoffeeShop;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connection);

                string modifi = @"UPDATE Customers SET Name='" + customerModel.Name + "', Address='" +customerModel.Address + "',Contact='" + customerModel.Contact + "' WHERE ID='" + customerModel.ID+ "'";
                SqlCommand command = new SqlCommand(modifi, sqlConnection);

                sqlConnection.Open();

                int isExecuted = command.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return isupdate = true;
                }

                sqlConnection.Close();
            }
            catch (Exception e)
            {
                //MessageBox.Show("no customer recod in database");
            }
            return isupdate;

        }
        
        public DataTable Showcustomer()
        {
            
            string connectionString = @"Server=NANDITA; Database=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

   
            string commandString = @"SELECT * FROM Customers";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

         
            sqlConnection.Open();

        
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            
            sqlConnection.Close();
            return dataTable;



        }
        public DataTable Searchcustomer(CustomerModel customerModel)
        {
            

                string connectionString = @"Server=NANDITA;DataBase=CoffeeShop;Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string CommandString = @"SELECT * FROM Customers WHERE Name='" + customerModel.Name + "'";

                SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                //showdataGridView.DataSource = dataTable;
                if (dataTable.Rows.Count > 0)
                {
                    return dataTable;
                   // showdataGridView.DataSource = dataTable;
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
    }
}
