using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using MySql.Data.MySqlClient;//Libreria para conectar con la base de datos
using System.Data;

namespace ThootDentist
{
    class PruebasConexiones
    {
        public void ReadMyData(string myConnString)
        {
            string mySelectQuery = "SELECT OrderID, CustomerID FROM Orders";
            MySqlConnection myConnection = new MySqlConnection(myConnString);
            MySqlCommand myCommand = new MySqlCommand(mySelectQuery, myConnection);
            myConnection.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            // Always call Read before accessing data.
            while (myReader.Read())
            {
                Console.WriteLine(myReader.GetInt32(0) + ", " + myReader.GetString(1));
            }
            // always call Close when done reading.
            myReader.Close();
            // Close the connection when done with it.
            myConnection.Close();



            myReader = myCommand.ExecuteReader();
            // Always call Read before accessing data.
            while (myReader.Read())
            {
                Console.WriteLine(myReader.GetInt32(0) + ", " + myReader.GetString(1));
            }
            // always call Close when done reading.
            myReader.Close();
        }
    }

        
}
