using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace App
{
    internal class DB
    {
        MySqlConnection db = new MySqlConnection("server=localhost;user=root;" +
            "password=root;database=AppWinForms;port=3306;");

        public void OpenConnection()
        {
            if(db.State == System.Data.ConnectionState.Closed)
                db.Open();
        }

        public void CloseConnection()
        {
            if (db.State == System.Data.ConnectionState.Open)
                db.Close();
        }

        public MySqlConnection GetConnection()
        {
            return db;
        }
    }
}
