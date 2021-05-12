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
    public partial class Menu : Form
    {
        //Constuctor de la clase
        public Menu()
        {
            InitializeComponent();


            FormAncho = this.ClientSize.Width;
            FormAlto = this.ClientSize.Height;

            /*
            Lbl_Ancho.Text = "Ancho: " + FormAncho;
            LbL_Alto.Text = "Alto: " + FormAlto;
            */

            LocationX = PanelContenedor.Location.X;
            LocationY = PanelContenedor.Location.Y;
        }

        public void AbrirVentana(int VentanaActual)
        {
            switch(VentanaActual)
            {
                //Form ControlPacientes
                case 1:
                    AbrirFormularios<ControlPacientes>();
                    break;

                case 2:
                    AbrirFormularios<AgregarPaciente>();
                    break;

                case 3:
                    AbrirFormularios<Form_AgendarCita>();
                    break;

                case 4:
                    AbrirFormularios<Calendario>();
                    break;
            }
        }

        

        /*
         * METODO
         * Funcion: Reasignar  la posision de los boones de la esquina
         */
        private void RecolocarBotones()
        {

            TamañoAncho = PanelUp.ClientSize.Width;

            Btn_Close.Location = new Point(TamañoAncho - 3 - Btn_Close.Size.Width, Btn_Close.Location.Y);
            Btn_Maximizar.Location = new Point(TamañoAncho - 39 - Btn_Close.Size.Width, Btn_Close.Location.Y);
            Btn_Restaurar.Location = new Point(TamañoAncho - 39 - Btn_Close.Size.Width, Btn_Close.Location.Y);
            Btn_Minimizar.Location = new Point(TamañoAncho - 75 - Btn_Close.Size.Width, Btn_Close.Location.Y);
        }

        //Variables privadas y publicas
        public int FormAncho;
        public int FormAlto;

        public int LocationX;
        public int LocationY;

        public int TamañoAncho;


        /*METODOS*/

        /*
         * METODO
         * Funcion: Abrir el formulario asignado en el Panel
         */
        public void AbrirFormularios<FormularioAbrir>() where FormularioAbrir : Form, new()
        {
            Form Formularios;
            
            Formularios = PanelContenedor.Controls.OfType<FormularioAbrir>().FirstOrDefault();
            

            if (Formularios == null)
            {
                Formularios = new FormularioAbrir
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                    
                };

                //FormularioAbrir.Size = new Size(PanelContenedor.Size.Width,PanelContenedor.Size.Height);

                PanelContenedor.Controls.Add(Formularios);
                PanelContenedor.Tag = Formularios;
                Formularios.Show();
                Formularios.BringToFront();
            }
            else
            {
                Formularios.BringToFront();
            }

            
        }

        //METODOS CONTROLADOS POR EVENTOS

        /*
         * METODO CONTROLADO POR EVENTO
         * Evento: Click a un Boton
         * Objeto asignado: Boton Close (De cerrar)
         * Proposito: Preguntar si el usurio esta seguro de salir de la aplicacion y en caso de se verdadero se cierra la App
         */
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de cerrar el programa", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /*
         * EVENTO CONTROLADO POR EVENTO
         * Evento: Click a un Boton
         * Objeto asignado: Boton para Maximizar
         * Proposito:
         */
        private void Btn_Maximizar_Click(object sender, EventArgs e)
        {
            Btn_Maximizar.Visible = false;  //Hace que no se pueda ver el boton de Maximizar
            Btn_Restaurar.Visible = true;   //Hace que sea visible el boton de Restaurar
            WindowState = FormWindowState.Maximized; //Maximiza el formulario a pantalla completa

            /*Dan el ancho y alto del form*/
            FormAncho = this.ClientSize.Width;
            FormAlto = this.ClientSize.Height;
            /*Escriben en pnatalla las variables anteriores*/
            /*
            Lbl_Ancho.Text = "Ancho: " + FormAncho;
            LbL_Alto.Text = "Alto: " + FormAlto;
            */
            
            /*Redimenciona el Panel principal (PanelContenedor)*/
            //PanelContenedor.Size = new Size(FormAncho-12-LocationX,PanelContenedor.Height);

            /*Da el tamaño del panel superior*/
            TamañoAncho = PanelUp.ClientSize.Width;

            //Me saca la diferiencia de los Botones con el borde derecho
            int Diferencia = TamañoAncho - (Btn_Restaurar.Location.X + Btn_Restaurar.Size.Width);

            //Me reubica la posision del boton Cerrar
            RecolocarBotones();

            
        }

        //Evento para Minimizar
        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        


        //Evento para Restaurar
        private void Btn_Restaurar_Click(object sender, EventArgs e)
        {
            /*
            Size = new Size(sw,sh);
            Location = new Point(lx,ly);
            */

            WindowState = FormWindowState.Normal;

            Btn_Restaurar.Visible = false;
            Btn_Maximizar.Visible = true;

            FormAncho = this.ClientSize.Width;
            FormAlto = this.ClientSize.Height;
            /*
            Lbl_Ancho.Text = "Ancho: " + FormAncho;
            LbL_Alto.Text = "Alto: " + FormAlto;
            */

            //PanelContenedor.Size = new Size(FormAncho - 12 - LocationX, PanelContenedor.Height);


            //Me reubica la posision del boton Cerrar
            RecolocarBotones();

        }

        

        //BOTONES DE MENU

        private void Btn_Pacientes_Click(object sender, EventArgs e)
        {
            this.AbrirVentana(1);
        }

        private void Btn_AgendarCita_Click(object sender, EventArgs e)
        {
            this.AbrirVentana(3);
        }

        private void Btn_Calendario_Click(object sender, EventArgs e)
        {
            this.AbrirVentana(4);
        }


    }
}
