using AForge.Video;
using AForge.Video.DirectShow;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThootDentist
{
    public partial class AgregarPaciente : Form
    {
        private Conexiones Conex = new Conexiones();
        private string SqlComand;
        private int TipoInsert = 0; //1 es Ambos    2 es de Telefono    3 es de Correo

        private int I = 0;  //Contador para estructuras For
        public string Path = @"D:\eseba\Documents\Proyects\C#\ToothDentist\ThootDentist\Fotos";  //Ruta para alpacenamiento de imagenes

        private bool Dispositivos;  //Es para comprobar si existen dispositivos de entrada

        private FilterInfoCollection MisDispositivos; //Instancia que guarda los dispositivos seleccionados
        private VideoCaptureDevice WebCam;//Instancia que gurda la entrada de 

        public string Msg;
        int ContadorAprobadas = 0;

        long Cantidad;

        //Constructor de la Calse
        public AgregarPaciente()
        {
            InitializeComponent();
            BorrarErrores();
            CargarDispositivos();
            Calendario.MaxDate = DateTime.Now;
            
        }
        //Destructor de la clase
        ~AgregarPaciente()
        {
            MessageBox.Show("Llamada al destructor de AgregarPaciente");
        }

        /*
         * METODO
         * Funcion: Carga las camaras Existentes
         */
        private void CargarDispositivos()
        {
            MisDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (MisDispositivos.Count > 0)
            {
                Dispositivos = true;
                for(I = 0;I < MisDispositivos.Count;I++)
                {
                    CmBox_Dispositivos.Items.Add(MisDispositivos[I].Name.ToString());
                }
                CmBox_Dispositivos.Text = MisDispositivos[0].Name.ToString();
            }
            else Dispositivos = false;
        }
        /*
         * METODO
         * Funcion: Borrar todos lo errores generados anteriormente de los Labels
         */
        private void BorrarErrores()
        {
            Lbl_ErrorNombre.Text = "";
            Lbl_ErrorApellidoP.Text = "";
            Lbl_ErrorApellidoM.Text = "";
            Lbl_ErrorCalendario.Text = "";
            Lbl_ErrorGenero.Text = "";
            Lbl_ErrorTelefono.Text = "";
            Lbl_ErrorCorreo.Text = "";
        }

        /*
         * METODO
         * Funcion: Eliminar todo lo que se alla escrito anteriormente
         */
        private void VaciarForm()
        {
            BorrarErrores();
            TxBox_Nombres.Text = "";
            TxBox_ApellidoMa.Text = "";
            TxBox_ApellidoPa.Text = "";
            TxtBox_Correo.Text = "";
            Tx_Telefono.Text = "";

            CmBox_Genero.SelectedIndex = 0;
        }
        /*
         * METODO
         * Vaida si los TextBox contienen algo dentro
         */
        private bool Validadcion(Bunifu.Framework.UI.BunifuMetroTextbox Box)
        {
            if(Box.Text == "" || Box.Text == " " || Box.Text == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /*
         * METODO
         * Valida que todos los campos estes bien establecidos
         */
        private bool TodoBien()
        {
            ContadorAprobadas = 0;
            BorrarErrores();

            //Validadcion del Nombre
            if (this.Validadcion(TxBox_Nombres))
            {
                ContadorAprobadas++;
            }
            else Lbl_ErrorNombre.Text = "Datos invalidos";
            //
            //Validacion del Apellido Paterno
            //
            if (this.Validadcion(TxBox_ApellidoPa))
            {
                ContadorAprobadas++;
            }
            else Lbl_ErrorApellidoP.Text = "Datos Invalidos";
            //
            //Validacion del Apellido Materno
            //
            if (this.Validadcion(TxBox_ApellidoMa))
            {
                ContadorAprobadas++;
            }
            else Lbl_ErrorApellidoM.Text = "Datos Invalidos";
            //
            //Validacion del Genero Seleccionado
            //
            if (CmBox_Genero.SelectedIndex != 0 && CmBox_Genero.SelectedIndex != 1)
            {
                Lbl_ErrorGenero.Text = "Esta mal";
            }
            else ContadorAprobadas++;
            /*
            //
            //Validacion del Telfono
            //
            if (Validadcion(Tx_Telefono) && (Tx_Telefono.Text.Length == 10))
            {
                ContadorAprobadas++;
            }
            else Lbl_ErrorTelefono.Text = "Numero Invalido";
            //
            //Validacion del Correo
            //
            if (TxtBox_Correo.Text.Contains('@') && TxtBox_Correo.Text.Contains('.'))
            {
                ContadorAprobadas++;
            }
            else Lbl_ErrorCorreo.Text = "Correo intruducido invalido";
            */
            //
            //Validacion del Calendario
            //
            if (Calendario.SelectionStart > DateTime.Now)
            {
                Lbl_ErrorCalendario.Text = "Error con la fecha actual";
            }
            else ContadorAprobadas++;


            if(Validadcion(Tx_Telefono) && (Tx_Telefono.Text.Length == 10))
            {
                ContadorAprobadas++;
            }
            else if(TxtBox_Correo.Text.Contains('@') && TxtBox_Correo.Text.Contains('.'))
            {
                ContadorAprobadas++;
            }
            else 
            {
                Lbl_ErrorTelefono.Text = "Necesita instroducir correctamente Telefono o Correo";
            }


           //label1.Text = Convert.ToString(ContadorAprobadas);

            if (ContadorAprobadas >=6)
            {
                if((Validadcion(Tx_Telefono) && (Tx_Telefono.Text.Length == 10)) && (TxtBox_Correo.Text.Contains('@') && TxtBox_Correo.Text.Contains('.')))
                {
                    TipoInsert = 1;
                }
                else if(Validadcion(Tx_Telefono) && (Tx_Telefono.Text.Length == 10))
                {
                    TipoInsert = 2;
                }
                else if(TxtBox_Correo.Text.Contains('@') && TxtBox_Correo.Text.Contains('.'))
                {
                    TipoInsert = 3;
                }
                return true;
            }
            else return false;
        }
        /*
         *METODO
         */
        private void CerrarCamara()
        {
            if (WebCam != null && WebCam.IsRunning)
            {
                WebCam.SignalToStop();
                WebCam = null;
            }
        }
        /*
         * METODO
         */
        private void AbrirCamara()
        {
            
            /*VideoCaptureDeviceForm WebCamForm = new VideoCaptureDeviceForm();
            WebCamForm.ShowDialog();
            */
            CerrarCamara();
            
            int CamaraSeleccionada = CmBox_Dispositivos.SelectedIndex;
            string NombreCamara = MisDispositivos[CamaraSeleccionada].MonikerString;
            WebCam = new VideoCaptureDevice(NombreCamara);
            WebCam.NewFrame += new NewFrameEventHandler(Capturando);
            
            WebCam.Start();
        }

        //METODOS CONTROLADOS POR EVENTOS

        private void AgregarPaciente_Load(object sender, EventArgs e)
        {
            
        }

        /*
         * METODO CONTROLADO POR EVENTO
         * 
         */
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if(TodoBien())
            {
                MySqlConnection Conexion = Conex.Conectar();
                Conexion.Open();


                //String que contiene la cadena de SQL
                string Comando = "SELECT MAX(ID_Cliente) as Cantidad from Pacientes;";
                //Llama al metodo EjecutarComando_Datos de la instancia de Conexion y trae una tabla con los datos
                DataTable Tabla = Conex.EjecutarComando_Datos(Comando);
                //Separa los datos de la Tabla para pasarslos a la variable de Cantidad
                Cantidad = Convert.ToInt64(Tabla.Rows[0]["Cantidad"].ToString());
                Cantidad++;//Sumar 1 a cantidad
                DateTime Fecha = Calendario.SelectionStart;

                //label1.Text = Fecha.Date.ToString("yyyy/MM/dd");
                //Escoje el tipo de Insert que se usara
                switch (TipoInsert)
                {
                    case 1:
                        SqlComand = "INSERT INTO pacientes (ID_Cliente, Nombres, Apellido_Paterno, Apellido_Materno, Fecha_Nacimiento, ID_Genero, Numero_Celular, Correo, Foto) VALUES ('" + Cantidad + "', '" + TxBox_Nombres.Text + "', '" + TxBox_ApellidoPa.Text + "', '" + TxBox_ApellidoMa.Text + "', '" + Fecha.Date.ToString("yyyy/MM/dd") + "', '" + CmBox_Genero.SelectedIndex + "' ,'" + Tx_Telefono.Text + "', '" + TxtBox_Correo.Text + "',@imagen) ";
                        break;

                    case 2:
                        SqlComand = "INSERT INTO pacientes (ID_Cliente, Nombres, Apellido_Paterno, Apellido_Materno, Fecha_Nacimiento, ID_Genero, Numero_Celular, Foto) VALUES ('" + Cantidad + "', '" + TxBox_Nombres.Text + "', '" + TxBox_ApellidoPa.Text + "', '" + TxBox_ApellidoMa.Text + "', '" + Fecha.Date.ToString("yyyy/MM/dd") + "', '" + CmBox_Genero.SelectedIndex + "' ,'" + Tx_Telefono.Text + "',@imagen) ";
                        break;

                    case 3:
                        SqlComand = "INSERT INTO pacientes (ID_Cliente, Nombres, Apellido_Paterno, Apellido_Materno, Fecha_Nacimiento, ID_Genero, Correo, Foto) VALUES ('" + Cantidad + "', '" + TxBox_Nombres.Text + "', '" + TxBox_ApellidoPa.Text + "', '" + TxBox_ApellidoMa.Text + "', '" + Fecha.Date.ToString("yyyy/MM/dd") + "', '" + CmBox_Genero.SelectedIndex + "', '" + TxtBox_Correo.Text + "',@imagen) ";
                        break;
                }
                try
                {
                    MemoryStream ms = new MemoryStream();
                    PictBox_Foto.Image.Save(ms,ImageFormat.Jpeg);
                    byte[] aByte = ms.ToArray();

                    MySqlCommand Comandosql = new MySqlCommand(SqlComand,Conexion);
                    Comandosql.Parameters.AddWithValue("imagen", aByte);
                    Comandosql.ExecuteNonQuery();

                    MessageBox.Show("Imagen Guardada");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("No se puedo completar\n" + ex);
                }


                /*
                PictBox_Foto.Image.Save(Path + "FotoCliente" + Cantidad + ".jpg",ImageFormat.Jpeg);
                MessageBox.Show("Se guardo la Foto");
                */
                Conexion.Close();
                this.Close();
                
            }
            else
            {

            }

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect(0);
        }

        private void Tx_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        /*
         *METODO CONTROLADO POR EVENTO
         *
         */
        private void Capturando(object sender, NewFrameEventArgs EventArgs)
        {
            Bitmap Imagen = (Bitmap)EventArgs.Frame.Clone();
            PictBox_Foto.Image = Imagen;
            
        }

        private void AgregarPaciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarCamara();
        }

        private void Btn_IniciarCamara_Click(object sender, EventArgs e)
        {
            AbrirCamara();
        }

        private void Btn_TomarFoto_Click(object sender, EventArgs e)
        {
            CerrarCamara();
        }
    }
}
