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
    class Conexiones
    {
        /*
         * METODO
         * Devuelve MySqlConnection, la conexion ya cerada
         * En caso de no ejecutarse devuelve un null
         */
        public MySqlConnection Conectar()
        {
            string myConnString = "Server=localhost; Database=toothdentistdb; Uid=root; Pwd=E11172003";
            MySqlConnection myConnection;
            try
            {
                myConnection = new MySqlConnection(myConnString);
                return myConnection;
            }
            catch (Exception)
            {
                myConnection = null;
                MessageBox.Show("Error al conectar con la BD");
                return myConnection;
            }
        }


        /*
         * METODO
         * Devuelve un Dato booleano
         * Devuelve verdadero en caso de que si se ejecute el comando
         * Devuelve flaso en caso de que no se alla podido executar
         */


        public bool EjecutarComando_Bool(string mySelectQuery)
        {
            //Declaracion de objeto que lee los datos del query
            MySqlDataReader Reader;

            //Llama al metodo Conectar que crea la conexcion a la Base de Datos y la redefine
            MySqlConnection myConnection = Conectar();
            myConnection.Open();//Abre la Conexion con la BD

            //Llama al objeto que ejecuta el comando 
            MySqlCommand mySqlCommand = new MySqlCommand(mySelectQuery, myConnection);

            //Da a reader los datos del comando ejecutado
            Reader = mySqlCommand.ExecuteReader();



            if (Reader.HasRows)
            {
                myConnection.Close(); //Cierra la conexion con la BD
                return true;

            }
            else
            {
                myConnection.Close(); //Cierra la conexion con la BD
                return false;
            }


        }



        public DataTable EjecutarComando_Datos(string mySelectQuery)
        {
            //Llama al metodo Conectar que crea la conexcion a la Base de Datos y la redefine
            MySqlConnection myConnection = Conectar();
            myConnection.Open();//Abre la Conexion con la BD

            //Llama al objeto que ejecuta el comando 
            MySqlCommand mySqlCommand = new MySqlCommand(mySelectQuery, myConnection);

            MySqlDataAdapter Data = new MySqlDataAdapter(mySqlCommand);

            DataTable Tabla = new DataTable();
            Data.Fill(Tabla);
            myConnection.Close();
            return Tabla;
        }

        public void EjecutarComandoInsertar(string myInsertQuery)
        {
            //Llama al metodo Conectar que crea la conexcion a la Base de Datos y la redefine
            MySqlConnection myConnection = Conectar();
            myConnection.Open();
            //Llama al objeto que ejecuta el comando 
            MySqlCommand mySqlCommand = new MySqlCommand(myInsertQuery,myConnection);
            //Executa el comando en el servidior
            mySqlCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        /*
        public void ReadMyData(string myConnString)
        {
            string mySelectQuery = "SELECT * FROM administrador;";

            MySqlConnection myConnection = this.Conectar();

            MySqlCommand myCommand;

            
            
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

        }
        */
        
    }
}
