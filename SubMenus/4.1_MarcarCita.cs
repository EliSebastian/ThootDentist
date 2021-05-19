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
    public partial class MarcarCita : Form
    {
        string Index;

        public MarcarCita()
        {
            InitializeComponent();
        }
        public MarcarCita(string ID)
        {
            InitializeComponent();
            Index = ID;
        }
        Conexiones SQL = new Conexiones();
        string Comentario = "";
        string Query;

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_MarcarCita_Click(object sender, EventArgs e)
        {
            if(Cmbox_Marca.SelectedIndex != -1)
            {
                string TipoMarca = Cmbox_Marca.SelectedIndex.ToString();
                string Comentario = TxBox_Comentario.Text;
                Query = "UPDATE citas SET EstadoConsulta = "+ TipoMarca +", Comentario = '"+ Comentario +"' WHERE ID_Cita = "+ Index +";";
                SQL.EjecutarComandoInsertar(Query);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
