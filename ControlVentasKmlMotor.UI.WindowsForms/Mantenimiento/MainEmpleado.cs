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
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;

namespace ControlVentasKmlMotor.UI.WindowsForms.Mantenimiento
{
    public partial class MainEmpleado : Form
    {
        EmpleadoBL empleadoBL = new EmpleadoBL();

        public byte id = 0;
        public MainEmpleado()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            comboBoxGenero.SelectedIndex = 0;
            comboBoxSucursal.SelectedIndex = 0;
            comboBoxCargo.SelectedIndex = 0;
            nombreTextBox.Clear();
            apellidoTextBox.Clear();
            correoTextBox.Clear();
            claveTextBox.Clear();
            confirmarClaveTextBox.Clear();
           
        }

        private bool ValidarControles()
        {
            bool datosValidos = true;
            errorProvider.Clear();

           

            if (comboBoxGenero.SelectedValue == null || (byte)comboBoxGenero.SelectedValue == 0)
            {
                datosValidos = false;
                errorProvider.SetError(comboBoxGenero, "Campo Obligatorio");
            }
            if (comboBoxSucursal.SelectedValue == null || (byte)comboBoxSucursal.SelectedValue == 0)
            {
                datosValidos = false;
                errorProvider.SetError(comboBoxSucursal, "Campo Obligatorio");
            }
            if (comboBoxCargo.SelectedValue == null || (byte)comboBoxCargo.SelectedValue == 0)
            {
                datosValidos = false;
                errorProvider.SetError(comboBoxCargo, "Campo Obligatorio");
            }
            if (nombreTextBox.Text == "" || nombreTextBox.Text.Trim() == String.Empty)
            {
                
                datosValidos = false;
                errorProvider.SetError(nombreTextBox, "Campo Obligatorio");
            }
            if (apellidoTextBox.Text == "" || apellidoTextBox.Text.Trim() == String.Empty)
            {
                
                datosValidos = false;
                errorProvider.SetError(apellidoTextBox, "Campo Obligatorio");
            }
            if (correoTextBox.Text == "" || correoTextBox.Text.Trim() == String.Empty)
            {
                
                datosValidos = false;
                errorProvider.SetError(correoTextBox, "Campo Obligatorio");
            }
            if (ValidarEmail(correoTextBox.Text) == false)
            {
                datosValidos = false;
                MessageBox.Show("Formato de Correo Electrónico invalido","Validar Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (claveTextBox.Text == "" || claveTextBox.Text.Trim() == String.Empty)
            {
                
                datosValidos = false;
                errorProvider.SetError(claveTextBox, "Campo Obligatorio");
            }
            if (confirmarClaveTextBox.Text == "" || confirmarClaveTextBox.Text.Trim() == String.Empty)
            {
                datosValidos = false;
                errorProvider.SetError(confirmarClaveTextBox, "Campo Obligatorio");
            }
            if (claveTextBox.Text != confirmarClaveTextBox.Text)
            {
                datosValidos = false;
                MessageBox.Show("Las claves no coinciden, Intente otra vez", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

            return datosValidos;
        }

        public static bool ValidarEmail(string comprobarEmail)
        {
            string emailFormato;
            emailFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(comprobarEmail, emailFormato))
            {
                if (Regex.Replace(comprobarEmail, emailFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void CargarGenero()
        {

            GeneroBL generoBL = new GeneroBL();


            List<Genero> generos = new List<Genero>();
            generos.Add(new Genero { Id = 0, Nombre = "SELECCIONAR" });


            generos.AddRange(generoBL.Buscar(new Genero()));
            comboBoxGenero.DataSource = generos;


            comboBoxGenero.DisplayMember = "Nombre";
            comboBoxGenero.ValueMember = "Id";

        }

        private void CargarSucursales()
        {

            SucursalBL sucursalBL = new SucursalBL();


            List<Sucursal> sucursales = new List<Sucursal>();
            sucursales.Add(new Sucursal { Id = 0, Nombre = "SELECCIONAR" });


            sucursales.AddRange(sucursalBL.Buscar(new Sucursal()));
            comboBoxSucursal.DataSource = sucursales;


            comboBoxSucursal.DisplayMember = "Nombre";
            comboBoxSucursal.ValueMember = "Id";

        }

        private void CargarCargos()
        {

            CargoBL cargoBL = new CargoBL();


            List<Cargo> cargos = new List<Cargo>();
            cargos.Add(new Cargo { Id = 0, Nombre = "SELECCIONAR" });


            cargos.AddRange(cargoBL.Buscar(new Cargo()));
            comboBoxCargo.DataSource = cargos;


            comboBoxCargo.DisplayMember = "Nombre";
            comboBoxCargo.ValueMember = "Id";

        }

        private void MainEmpleado_Load(object sender, EventArgs e)
        {
            CargarGenero();
            CargarSucursales();
            CargarCargos();
            if (id > 0)
            {
                Empleado empleado = empleadoBL.ObtenerPorId(id);

                comboBoxGenero.SelectedValue = empleado.IdGenero;
                comboBoxSucursal.SelectedValue = empleado.IdSucursal;
                comboBoxCargo.SelectedValue = empleado.IdCargo;
                nombreTextBox.Text = empleado.Nombre;
                apellidoTextBox.Text = empleado.Apellido;
                correoTextBox.Text = empleado.CorreoElectronico;
                claveTextBox.Text = empleado.Clave;
                confirmarClave.Text = empleado.Clave;
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarControles() == true)
                {
                    Empleado empleado = new Empleado();
                    empleado.IdGenero = (byte)comboBoxGenero.SelectedValue;
                    empleado.IdSucursal = (byte)comboBoxSucursal.SelectedValue;
                    empleado.IdCargo = (byte)comboBoxCargo.SelectedValue;
                    empleado.Nombre = nombreTextBox.Text;
                    empleado.Apellido = apellidoTextBox.Text;
                    empleado.CorreoElectronico = correoTextBox.Text;
                    empleado.Clave =  Encriptar.MD5(claveTextBox.Text);
                   
                    if (id == 0)
                    {
                        empleadoBL.Guardar(empleado);
                        Tools.NotificacionInfo("Guardado Exitosamente");
                        Limpiar(); //Limpiar formulario
                    }
                    else
                    {
                        empleado.Id = id;
                        empleadoBL.Modificar(empleado);
                        Tools.NotificacionInfo("Actualizado Exitosamente");
                        this.Close();
                    }

                }
                else
                {
                    Tools.NotificacionAlerta("Completa los campos obligatorios");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void ocultarClavePictureBox_Click(object sender, EventArgs e)
        {
            verClavePictureBox.BringToFront();
            //Ver Contraseña
            claveTextBox.PasswordChar = '*';
        }

        private void verClavePictureBox_Click(object sender, EventArgs e)
        {
            ocultarClavePictureBox.BringToFront();
            claveTextBox.PasswordChar = '\0';
        }

        private void ocultarPictureBox_Click(object sender, EventArgs e)
        {
            verPictureBox.BringToFront();
            //Ver Contraseña
            confirmarClaveTextBox.PasswordChar = '*';
        }

        private void verPictureBox_Click(object sender, EventArgs e)
        {
            ocultarPictureBox.BringToFront();
            confirmarClaveTextBox.PasswordChar = '\0';
        }

        private void comboBoxSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void apellidoEmpleadoLabel_Click(object sender, EventArgs e)
        {

        }

        private void labelSucursal_Click(object sender, EventArgs e)
        {

        }

        private void labelCargo_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nombreEmpleadoLabel_Click(object sender, EventArgs e)
        {

        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void apellidoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void correoLabel_Click(object sender, EventArgs e)
        {

        }

        private void correoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void claveLabel_Click(object sender, EventArgs e)
        {

        }

        private void claveTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmarClaveTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmarClave_Click(object sender, EventArgs e)
        {

        }
    }
}
