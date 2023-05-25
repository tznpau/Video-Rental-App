using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Rental
{
    class Operations
    {
        protected OleDbConnection GetConnection()
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\paula\\source\\repos\\Video-Rental\\VRdb.accdb";
            return connection;
        }


        public void insertData(string query)
        {
            OleDbConnection connection = GetConnection();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = query;
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully added data.");
            connection.Close();
        }

        public void editData(string query)
        {
            OleDbConnection connection = GetConnection();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = query;
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully updated data.");
            connection.Close();
        }


        public void deleteData(string query)
        {
            OleDbConnection connection = GetConnection();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = query;
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully deleted data.");
            connection.Close();
        }



        //public int count()
        //{
        //    OleDbConnection connection = GetConnection();
        //    string query = "SELECT * FROM FilmsTbl ORDER BY FilmId";
        //    OleDbCommand command = new OleDbCommand();
        //    command.Connection = connection;
        //    connection.Open();
        //    command.CommandText = query;

        //    OleDbDataReader reader = command.ExecuteReader();
        //    int id = 0;
        //    while (reader.Read())
        //    {
        //        id = reader.GetInt32(0);
        //    }
        //    id = id + 1;
        //    connection.Close();
        //    return id;
        //}





        public DataSet populate(string query)
        {
            OleDbConnection connection = GetConnection();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = query;
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }


        
    }
}
