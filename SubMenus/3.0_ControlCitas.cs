using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;

namespace ThootDentist
{
    public partial class Form_AgendarCita : Form
    {
        //Constructor de la Clase
        public Form_AgendarCita()
        {
            InitializeComponent();
            string Query = "SELECT Nombres , Apellido_Paterno, Apellido_Materno, ID_Cliente FROM Pacientes";
            DataGrid.DataSource = SQL.EjecutarComando_Datos(Query);


            //Me Pasa los datos de las Citas del paciente al DataGrid
            
            Query = "SELECT tratamientos.Nombre_Tratamiento, citas.Fecha,citas.Hora, citas.Comentario FROM citas  JOIN pacientes on citas.ID_Cliente = pacientes.ID_Cliente JOIN tratamientos on citas.ID_Tratamienro = tratamientos.ID_Tratamiento WHERE(citas.ID_Cliente = '0')";
            DataGridCitas.DataSource = SQL.EjecutarComando_Datos(Query);
        }
        //Destructor de la clase
        ~Form_AgendarCita()
        {

        }

        
        int Contador = 0;   //Establece El contador de  veces que se cambia el TxBox
        Conexiones SQL = new Conexiones(); //Instancia de las Conexiones


        public string Index;
        
        string Query;

        private void TxtBox_Buscar_OnValueChanged(object sender, EventArgs e)
        {

            
            Contador++;
            if (TxtBox_Buscar.Text == " " || TxtBox_Buscar.Text == "" || TxtBox_Buscar.Text == null)
            {
                Query = "SELECT Nombres, Apellido_Paterno, Apellido_Materno, ID_Cliente FROM Pacientes";
            }
            else
            {
                Query = "SELECT Nombres, Apellido_Paterno, Apellido_Materno, ID_Cliente FROM Pacientes WHERE (Nombres LIKE '%" + TxtBox_Buscar.Text + "%' OR Apellido_Paterno like '%" + TxtBox_Buscar.Text + "%' OR Apellido_Materno LIKE '%" + TxtBox_Buscar.Text + "%'); ";
            }

            DataGrid.DataSource = SQL.EjecutarComando_Datos(Query);
        }

        private void DataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Obtiene la ID del Cliente para la muestra de Datos
            try
            {
                Index = DataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                

                Query = "SELECT Nombres, Apellido_Paterno, Apellido_Materno, Fecha_Nacimiento, ID_Genero, Numero_Celular, Correo FROM Pacientes WHERE(ID_Cliente = '"+ Index +"')";
                DataTable TablaDatos = SQL.EjecutarComando_Datos(Query);

                Lbl_Nombre.Text = TablaDatos.Rows[0]["Nombres"].ToString() + " " + TablaDatos.Rows[0]["Apellido_Paterno"].ToString() + " " + TablaDatos.Rows[0]["Apellido_Materno"].ToString();

                if(TablaDatos.Rows[0]["ID_Genero"].ToString() == "0")
                {
                    Lbl_Genero.Text = "Genero: M";
                }
                else
                {
                    Lbl_Genero.Text = "Genero: F";
                }

                string FechaNacimiento_str = TablaDatos.Rows[0]["Fecha_Nacimiento"].ToString();
                
                DateTime FechaNacimiento = DateTime.Parse(FechaNacimiento_str);

                //Me calucula la Edad y me la Asigna auna variable
                int Edad = DateTime.Today.AddTicks(-FechaNacimiento.Ticks).Year - 1;

                Lbl_Edad.Text = "Edad: " + Convert.ToString(Edad);

                string Numero = TablaDatos.Rows[0]["Numero_Celular"].ToString();
                Lbl_NumeroCelular.Text = "Telefono: " + Numero;

                Lbl_Correo.Text = TablaDatos.Rows[0]["Correo"].ToString();


                //Me Pasa los datos de las Citas del paciente al DataGrid
                Pruebas.Text = Index;
                Query = "SELECT tratamientos.Nombre_Tratamiento, citas.Fecha,citas.Hora, citas.Comentario FROM citas  JOIN pacientes on citas.ID_Cliente = pacientes.ID_Cliente JOIN tratamientos on citas.ID_Tratamienro = tratamientos.ID_Tratamiento WHERE(citas.ID_Cliente = '"+ Index +"')";
                DataGridCitas.DataSource = SQL.EjecutarComando_Datos(Query);

                MySqlConnection Conexion = SQL.Conectar();
                Conexion.Open();


                Query = "SELECT Foto FROM Pacientes WHERE ID_Cliente = "+ Index +" ;";
                MySqlCommand ComandoFoto = new MySqlCommand(Query,Conexion);
                MySqlDataReader Reader = ComandoFoto.ExecuteReader();
                if(Reader.HasRows)
                {
                    Reader.Read();
                    MemoryStream ms = new MemoryStream((byte[])Reader["Foto"]);
                    Bitmap bm = new Bitmap(ms);
                    Foto.Image = bm;
                }
                
            }
            catch
            {
                MessageBox.Show("Error \n El cliente Seleccionado no ha tenido o tiene alguna cita programada");
            }

            

        }

        

        private void Btn_AgendarCita_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(Index) > 0)
            {
                AgendarCita FormAgendarCita = new AgendarCita(Index);
                FormAgendarCita.Show();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado Ningun Usuario");
            }

        }
    }
}
