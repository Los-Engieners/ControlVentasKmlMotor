using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlVentasKmlMotor.UI.WindowsForms
{
    public partial class Form1 : Form
    {
        //Instancia para conectarse
        EmpleadoBL empBL = new EmpleadoBL();
        public Form1()
        {
            InitializeComponent();
        }

        private void ocultarClavePictureBox_Click(object sender, EventArgs e)
        {
            //Imagen ver pasa al frente
            verClavePictureBox.BringToFront();
            //Ver Contraseña
            claveTextBox.PasswordChar = '*';
        }

        private void verClavePictureBox_Click(object sender, EventArgs e)
        {
            //Imagen ocultar pasa al frente
            ocultarClavePictureBox.BringToFront();
            claveTextBox.PasswordChar = '\0';
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            if (correoTextBox.Text.Trim() != String.Empty && claveTextBox.Text.Trim() != string.Empty)
            {
                //Obtener datos del formulario
                Empleado datoEmpleado = new Empleado();
                datoEmpleado.CorreoElectronico = correoTextBox.Text.ToLower();
                datoEmpleado.Clave = claveTextBox.Text;
                //datoEmpleado.Clave = Encriptar.GetSHA256(claveTextBox.Text);

                //Validar login y obtener usuario
                Empleado empleado = empBL.Login(datoEmpleado);
                if (empleado.Id > 0)
                {
                    this.Hide();
                    FrmMain menu = new FrmMain(empleado);
                    menu.ShowDialog();
                    //Limpaiar controles
                    claveTextBox.Text = "";
                    correoTextBox.Text = "";
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Credenciales Incorrectas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un correo o contraseña valido", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cerrarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void correoTextBox_Enter(object sender, EventArgs e)
        {
            if (correoTextBox.Text == "Correo@Example.com")
            {
                correoTextBox.Text = "";
                correoTextBox.ForeColor = System.Drawing.Color.Black;

            }
        }

        private void correoTextBox_Leave(object sender, EventArgs e)
        {
            if (correoTextBox.Text == "")
            {
                correoTextBox.Text = "Correo@Example.com";
                correoTextBox.ForeColor = System.Drawing.Color.DarkGray;
            }
        }
    }
}
