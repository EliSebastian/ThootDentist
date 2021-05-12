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
    public partial class ControlPacientes : Form
    {
        int Contador = 0;
        Conexiones SQL = new Conexiones();

        AgregarPaciente FormAgregrarPaciente = new AgregarPaciente();

        //Contrsuctor de la Clase
        public ControlPacientes()
        {
            InitializeComponent();
            Pruebas.Text = Convert.ToString(Contador);

            LlenarDataGrid();
        }

        //Variables
        string Query;

        //Metodos
        private void LlenarDataGrid()
        {
            
            if (TxtBx_Buscar.Text == " " || TxtBx_Buscar.Text == "" || TxtBx_Buscar.Text == null)
            {
                Query = "SELECT ID_Cliente, Nombres , Apellido_Paterno, Apellido_Materno FROM Pacientes WHERE (Activo = 1)";
            }
            else if(TxtBx_Buscar.Text == "Buscar")
            {
                Query = "SELECT ID_Cliente, Nombres , Apellido_Paterno, Apellido_Materno FROM Pacientes WHERE (Activo = 1)";
            }
            else
            {
                Query = "SELECT ID_Cliente, Nombres , Apellido_Paterno, Apellido_Materno FROM Pacientes WHERE (Nombres LIKE '%" + TxtBx_Buscar.Text + "%' OR Apellido_Paterno like '%" + TxtBx_Buscar.Text + "%' OR Apellido_Materno LIKE '%" + TxtBx_Buscar.Text + "%') AND (Activo = 1) ";
            }

            DataGridPacientes.DataSource = SQL.EjecutarComando_Datos(Query);
        }
        //METODOS CONTROLADOS POR EVENTOS


        /*
         * METODO CONTROLADO POR EVENTO
         * Evento: Click a un Boton
         * Objeto asignado: Boton de Agregar
         * Proposito: Abrir Formulario para Agregar Paciente
         */
        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            
            
            FormAgregrarPaciente.ShowDialog();

            LlenarDataGrid();
            //agregarPaciente_Copia.Dispose();
            
            GC.Collect();
            GC.SuppressFinalize(FormAgregrarPaciente);
            GC.WaitForPendingFinalizers();
            
            //MessageBox.Show("Se inicio");
        }

        /*
         * METODO CONTROLADO POR EVENTO
         * Evento: Cambia un valor en un TextBox
         * Objeto asignado: TextBox para Bsucar
         */
        private void TxtBx_Buscar_OnValueChanged(object sender, EventArgs e)
        {
            LlenarDataGrid();
        }

        private void Btn_Borrar_Click(object sender, EventArgs e)
        {
            string ID = DataGridPacientes.Rows[DataGridPacientes.CurrentRow.Index].Cells[0].Value.ToString();

            Pruebas.Text = ID;

            if (MessageBox.Show("¿Esta seguro de borrar este registro?", "Advertencia", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Query = "UPDATE pacientes set Activo = 0 WHERE(ID_Cliente = " + ID + ")";
                SQL.EjecutarComandoInsertar(Query);
            }
            

            LlenarDataGrid();
        }
    }
}
