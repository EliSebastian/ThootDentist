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
    public partial class AgendarCita : Form
    {
        string ID;
        public AgendarCita(string IDCliente)
        {
            InitializeComponent();
            Pruebas.Text = IDCliente;
            ID = IDCliente;
            LlenarTratamientos();
        }


        Conexiones SQL = new Conexiones();

        string Query;

        int Contador_Aprovadas = 0;

        int Hora;

        private void LlenarTratamientos()
        {
            Query = "Select Nombre_Tratamiento from tratamientos;";
            DataTable Tratamientos = SQL.EjecutarComando_Datos(Query);
            int Filas = Tratamientos.Rows.Count;
            int I;
            for(I = 0; I < Filas;I++)
            {
                CmBox_Tratamientos.Items.Add(Tratamientos.Rows[I]["Nombre_Tratamiento"].ToString());
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Query = "SELECT MAX(ID_Cita)  AS 'Cantidad' FROM citas";
            DataTable ContadorCitas = SQL.EjecutarComando_Datos(Query);
                
            //
            long Cantidad = Convert.ToInt64(ContadorCitas.Rows[0]["Cantidad"].ToString());
            Cantidad++;

                if (CmBox_Tratamientos.SelectedIndex == -1)
                {
                    MessageBox.Show("No se ha sleccionado el Tratamiento");
                }
                else if (CmBox_Hora.SelectedIndex == -1)
                {
                    MessageBox.Show("No se ha seleccionado Hora");
                }
                else if (CmBox_Minutos.SelectedIndex == -1)
                {
                    MessageBox.Show("No se ha seleccionado Minuto");
                }
                else if(CmBox_AMPM.SelectedIndex == -1)
                {
                    MessageBox.Show("No se ha Seleccionado si de mañana o de tarde");
                }
                else
                {
                    switch(CmBox_AMPM.SelectedIndex)
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
                    Pruebas.Text = Tratamiento.ToString();
                    
                    
                    Query = "INSERT INTO `toothdentistdb`.`citas` (`ID_Cita`, `ID_Cliente`, `ID_Tratamienro`, `Fecha`, `Hora`) VALUES ('" + Cantidad.ToString() + "', '" + ID + "', '" + Tratamiento.ToString() + "', '" + Calendario.SelectionStart.ToString("yyyy/MM/dd") + "', '" + HoraCompleta + "');";
                    SQL.EjecutarComandoInsertar(Query);
                    
                }
            
        }
    }
}
