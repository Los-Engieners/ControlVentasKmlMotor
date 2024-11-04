using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlVentasKmlMotor.EN;
using ControlVentasKmlMotor.BL;

namespace ControlVentasKmlMotor.UI.WindowsForms.Nuevo
{
    public partial class MainCliente : Form
    {
        ClienteBL clienteBL = new ClienteBL();

        public byte id = 0;
        public MainCliente()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            comboBoxGenero.SelectedIndex = 0;
            nombreTextBox.Clear();
            apellidoTextBox.Clear();
            duiTextBox.Clear();
            telefonoTextBox.Clear();
            direccionTextBox.Clear();
            fechaNacimientoTimePicker = new DateTimePicker();
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
            if (nombreTextBox.Text == "" || nombreTextBox.Text.Trim() == String.Empty)
            {
                //Nombre vacio
                datosValidos = false;
                errorProvider.SetError(nombreTextBox, "Campo Obligatorio");
            }
            if (apellidoTextBox.Text == "" || apellidoTextBox.Text.Trim() == String.Empty)
            {
                //Nombre vacio
                datosValidos = false;
                errorProvider.SetError(apellidoTextBox, "Campo Obligatorio");
            }
            if (duiTextBox.Text == "" || duiTextBox.Text.Trim() == String.Empty)
            {
                //Nombre vacio
                datosValidos = false;
                errorProvider.SetError(duiTextBox, "Campo Obligatorio");
            }
            if (telefonoTextBox.Text == "" || telefonoTextBox.Text.Trim() == String.Empty)
            {
                //Nombre vacio
                datosValidos = false;
                errorProvider.SetError(telefonoTextBox, "Campo Obligatorio");
            }
            if (fechaNacimientoTimePicker.Value == null )
            {
                datosValidos = false;
                errorProvider.SetError(fechaNacimientoTimePicker, "Campo Obligatorio");
            }
            if (direccionTextBox.Text == "" || direccionTextBox.Text.Trim() == String.Empty)
            {
                //Nombre vacio
                datosValidos = false;
                errorProvider.SetError(direccionTextBox, "Campo Obligatorio");
            }

            return datosValidos;
        }

        private void CargarGeneros()
        {
            GeneroBL generoBL = new GeneroBL();

            List<Genero> generos = new List<Genero>();
            generos.Add(new Genero { Id = 0, Nombre = "SELECCIONAR " });

            generos.AddRange(generoBL.Buscar(new Genero()));
            comboBoxGenero.DataSource = generos;

            comboBoxGenero.DisplayMember = "Nombre";
            comboBoxGenero.ValueMember = "Id";
        }
    

        private void MainCliente_Load(object sender, EventArgs e)
        {
            CargarGeneros();
            
            
            if (id > 0)
            {
                Cliente cliente = clienteBL.ObtenerPorId(id);

                comboBoxGenero.SelectedValue = cliente.IdGenero;
                nombreTextBox.Text = cliente.Nombre;
                apellidoTextBox.Text = cliente.Apellido;
                duiTextBox.Text = cliente.DUI;
                telefonoTextBox.Text = cliente.Telefono;
                fechaNacimientoTimePicker.Value = cliente.FechaNacimiento;
                direccionTextBox.Text = cliente.Direccion;
                
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarControles() == true)
                {
                    Cliente cliente = new Cliente();
                    cliente.IdGenero = (byte)comboBoxGenero.SelectedValue;
                    cliente.Nombre = nombreTextBox.Text;
                    cliente.Apellido = apellidoTextBox.Text;
                    cliente.DUI = duiTextBox.Text;
                    cliente.Telefono = telefonoTextBox.Text;
                    cliente.FechaNacimiento = fechaNacimientoTimePicker.Value;
                    cliente.Direccion = direccionTextBox.Text;
                    

                    if (id == 0)
                    {
                        clienteBL.Guardar(cliente);
                        Tools.NotificacionInfo("Guardado Exitosamente");
                        Limpiar(); //Limpiar formulario
                    }
                    else
                    {
                        cliente.Id = id;
                        clienteBL.Modificar(cliente);
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
    }
}
