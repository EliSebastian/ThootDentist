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
    public partial class Reasignar_Cita : Form
    {
        string ID;
        public Reasignar_Cita(string IDCita)
        {
            InitializeComponent();
            LlenarTratamientos();
            ID = IDCita;
            //label3.Text = ID;
        }

        Conexiones SQL = new Conexiones();

        string Query;


        int Hora;

        private void LlenarTratamientos()
        {
            Query = "Select Nombre_Tratamiento from tratamientos;";
            DataTable Tratamientos = SQL.EjecutarComando_Datos(Query);
            int Filas = Tratamientos.Rows.Count;
            int I;
            for (I = 0; I < Filas; I++)
            {
                CmBox_Tratamientos.Items.Add(Tratamientos.Rows[I]["Nombre_Tratamiento"].ToString());
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Query = "SELECT COUNT(ID_Cita)  AS 'Cantidad' FROM citas";
            DataTable ContadorCitas = SQL.EjecutarComando_Datos(Query);

            //
            long Cantidad = Convert.ToInt64(ContadorCitas.Rows[0]["Cantidad"].ToString());
            Cantidad++;

            if (CmBox_Tratamientos.SelectedIndex == -1)
            {
                MessageBox.Show("No se ha sleccionado el Tratamiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CmBox_Hora.SelectedIndex == -1)
            {
                MessageBox.Show("No se ha seleccionado Hora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CmBox_Minutos.SelectedIndex == -1)
            {
                MessageBox.Show("No se ha seleccionado Minuto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CmBox_AMPM.SelectedIndex == -1)
            {
                MessageBox.Show("No se ha Seleccionado si de mañana o de tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                switch (CmBox_AMPM.SelectedIndex)
                {
                    case 0:
                        Hora = Convert.ToInt32(CmBox_Hora.SelectedItem.ToString());
                        break;

                    case 1:
                        Hora = Convert.ToInt32(CmBox_Hora.SelectedItem.ToString()) + 12;
                        break;
                }


                string HoraCompleta = Hora.ToString() + ":" + CmBox_Minutos.SelectedItem.ToString() + ":00";
                int Tratamiento = CmBox_Tratamientos.SelectedIndex + 1;
                // Pruebas.Text = Tratamiento.ToString();

                Query = "SELECT ID_Cita FROM citas WHERE Fecha = '" + Calendario.SelectionStart.ToString("yyyy/MM/dd") + "' AND Hora = '" + HoraCompleta + "' AND EstadoConsulta = 0;";
                if (SQL.EjecutarComando_Bool(Query))
                {
                    MessageBox.Show("La la fecha y el horario seleccionado ya se encuentra ocupado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Query = "UPDATE citas SET Fecha = '"+ Calendario.SelectionStart.ToString("yyyy/MM/dd") + "', Hora = '"+ HoraCompleta +"', ID_Tratamienro = "+ Tratamiento +" WHERE ID_Cita = "+ ID + ";" ;
                    SQL.EjecutarComandoInsertar(Query);
                    this.Hide();
                    MessageBox.Show("Se ha reagendado correctamente","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
