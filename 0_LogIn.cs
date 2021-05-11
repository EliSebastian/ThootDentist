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
    public partial class LogIn : Form
    {
        /*Constructor de la Clase*/
        public LogIn()
        {
            InitializeComponent();

            BorrarErrores();
        }

        //Instancia del Formulario de Menu
        Menu mainMenu = new Menu();

        //Instancia del objeto para las conexiones con las BD
        Conexiones Conex = new Conexiones();

        /*
         * METODO
         * Encargado de Boorar los Textos de Errores
         */
        private void BorrarErrores()
        {
            Lbl_ErrorUsuario.Text = "";
            Lbl_ErrorContraseña.Text = "";
        }

        
        /*METODOS POR EVENTOS*/

        /*
         * METODO CONTROLADO POR EVENTO
         * Evento: Click al Boton 
         * Objeto aplicado: Boton Cerrar
         * 
         * Proposito: Cerrar la aplicacion
         */
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*
         * METODO CONTROLADO POR EVENTO
         * Evento: Click al Boton
         * Obeto aplicado: Boton de Login
         * 
         * Proposito: Vereficar si los campos insertados en los Texbox son correctos y asi 
         */
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
            string QueryUsuario = "SELECT * FROM administrador WHERE (Usuario = '" + TxtBx_Usuario.Text + "')";
            string QueryContraseña = "SELECT * FROM administrador WHERE (Contraseña = '" + TxtBx_Contraseña.Text + "');";

            if(Conex.EjecutarComando_Bool(QueryUsuario))
            {
                if (Conex.EjecutarComando_Bool(QueryContraseña))
                {
                    this.Hide();
                    mainMenu.Show();

                }
                else
                {
                    BorrarErrores();
                    Lbl_ErrorContraseña.Text = "*Error: Contraseña Incorrecta";
                }
            }
            else
            {
                BorrarErrores();
                Lbl_ErrorUsuario.Text = "*Error: Usuario Inexistente";
            }
            
        }


    }
}
