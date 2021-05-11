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


        /*Metodos*/
        private void LlamadaCalendario()
        {
            string Fecha = Calendario3.SelectionStart.ToString("yyyy/MM/dd");


            Query = "SELECT C.ID_Cita, C.Hora, CONCAT(P.Nombres,' ',P.Apellido_Paterno,' ',P.Apellido_Materno) AS 'Nombre Completo' FROM citas C, pacientes P where(C.ID_Cliente = P.ID_Cliente AND C.Fecha = '" + Fecha + "');";
            DataTable Tabla = SQL.EjecutarComando_Datos(Query);

            DataGridCalendario.DataSource = Tabla;
        }

        /*Metodos Controlados por eventos*/
        private void Calendario3_DateSelected(object sender, DateRangeEventArgs e)
        {
            LlamadaCalendario();
        }
    }
}
