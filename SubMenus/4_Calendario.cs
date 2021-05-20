using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThootDentist
{
    public partial class Calendario : Form
    {
        //Constructor de la Clase
        public Calendario()
        {
            InitializeComponent();
            LlamadaCalendario();
        }
        //Destructor de la Calse
        ~Calendario()
        {

        }

        /*Declaracion de Clases*/
        Conexiones SQL = new Conexiones();//Declaracion de la clase de conexiones



        /*Declaracion de Variables*/
        string Query;
        string Index;

        /*Metodos*/
        private void LlamadaCalendario()
        {
            string Fecha = Calendario3.SelectionStart.ToString("yyyy/MM/dd");


            Query = "SELECT citas.ID_Cita,citas.Hora,CONCAT(Pacientes.Nombres,' ',Pacientes.Apellido_Paterno,' ',Pacientes.Apellido_Materno) AS 'Nombre Completo',\n" +
                "CASE\n" +
                "WHEN EstadoConsulta = 0 THEN 'Pendiente'\n" +
                "WHEN EstadoConsulta = 1 THEN 'Realizada'\n" +
                "WHEN EstadoConsulta = 2 THEN 'Cancelada'\n" +
                "END AS 'Estado'\n" +
                "FROM Citas\n" +
                "JOIN Pacientes ON Citas.ID_Cliente = Pacientes.ID_Cliente\n" +
                "JOIN tratamientos ON Citas.ID_Tratamienro = tratamientos.ID_Tratamiento\n" +
                "WHERE Citas.Fecha = '"+ Fecha + "' AND Pacientes.Activo = 1";
            DataTable Tabla = SQL.EjecutarComando_Datos(Query);

            DataGridCalendario.DataSource = Tabla;
        }
       
        /*Metodos Controlados por eventos*/
        private void Calendario3_DateSelected(object sender, DateRangeEventArgs e)
        {
            LlamadaCalendario();
        }

        private void Btn_CitaLista_Click(object sender, EventArgs e)
        {
            if(DataGridCalendario.Rows.Count < 1)
            {
                MessageBox.Show("No hay citas en el dia seleccionado","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {

                Index = DataGridCalendario.Rows[DataGridCalendario.CurrentRow.Index].Cells[0].Value.ToString();
                //LabelPruebas.Text = Index;
                
                MarcarCita From = new MarcarCita(Index);
                From.ShowDialog();
                LlamadaCalendario();
            }
        }
    }
}
