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
    public class ItemsRepository
    {
        public bool IsNameExists(ItemModel itemModel)
        {
            bool exists = false;
            try
            {

                string connectionString = @"NANDITA; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);


                string commandString = @"SELECT * FROM Items WHERE Name='" + itemModel.ItemName + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    exists = true;
                }

                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                //MessageBox.Show(exeption.Message);
            }

            return exists;
        }
        public bool Additem(ItemModel itemModel)
        {
            bool added = false;
            try
            {
                string connectionString = @"Server=NANDITA;DataBase=CoffeeShop;Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string CommandString = @"INSERT INTO Items (ItemName, Price) VALUES('" + itemModel.ItemName+ "'," + itemModel.Price + ")";

                SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);
                sqlConnection.Open();
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return added = true;
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("please fill the name and price");
            }
            return added;
        }

        public DataTable Showitem()
        {


            string connectionString = @"Server=NANDITA;DataBase=CoffeeShop;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string CommandString = @"SELECT *FROM Items";

            SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                //showdataGridView.DataSource = dataTable;
                return dataTable;
            }
            else
            {
               // MessageBox.Show("no data for show..");
            }
            sqlConnection.Close();

            return dataTable;
        }

        public bool Deleteitem(ItemModel itemModel)
        {
            try
            {
                string connection = @"Server=NANDITA;DataBase=CoffeeShop;Integrated Security=True";
                SqlConnection sqlconnection = new SqlConnection(connection);
                string delete = @"DELETE FROM Items WHERE ID='" + itemModel.ID + "'";
                SqlCommand command = new SqlCommand(delete, sqlconnection);

                sqlconnection.Open();
                int isExecuted = command.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return true;
                    //MessageBox.Show("delete successfull ..");
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

        public bool Modifyitem(ItemModel itemModel)
        {
            try
            {
                string connection = @"Server=NANDITA;DataBase=CoffeeShop;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connection);

                string modifi = @"UPDATE Items SET ItemName='" + itemModel.ItemName + "', Price=" + itemModel.Price + " WHERE ID='" + itemModel.ID + "'";
                SqlCommand command = new SqlCommand(modifi, sqlConnection);

                sqlConnection.Open();

                int isExecuted = command.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return true;
                }

                sqlConnection.Close();
            }
            catch (Exception e)
            {
                
            }
            return false;

        }

        public DataTable Searchitem(ItemModel itemModel)
        {

            string connectionString = @"Server=NANDITA;DataBase=CoffeeShop;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string CommandString = @"SELECT * FROM Items WHERE ItemName='" + itemModel.ItemName + "'";

            SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
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

    }
}
