using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.DAL;
using ControlVentasKmlMotor.EN;

namespace ControlVentasKmlMotor.UI.WindowsForms.Nuevo
{
    public partial class MainModelo : Form
    {
        VehiculoBL vehiculoBL = new VehiculoBL();
        public short id = 0;
        public MainModelo()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            marcaComboBox.SelectedIndex = 0;
            comboBoxmodelo.SelectedIndex = 0;
            tipoVehiculoTextBox.Clear();
            colorComboBox.SelectedIndex = 0;
            fechalanzamientoTextBox.Clear();
            precioTextBox.Clear();
            existenciasTextBox.Clear();

        }
        private bool ValidarControles()
        {
            bool datosValidos = true;
            errorProvider.Clear();
            if (marcaComboBox.SelectedValue == null || (byte)marcaComboBox.SelectedValue == 0)
            {
                datosValidos = false;
                errorProvider.SetError(marcaComboBox, "Campo Obligatorio");
            }
            if (comboBoxmodelo.SelectedValue == null || (byte)comboBoxmodelo.SelectedValue == 0)
            {
                datosValidos = false;
                errorProvider.SetError(comboBoxmodelo, "Campo Obligatorio");
            }
            if (colorComboBox.SelectedValue == null || (byte)colorComboBox.SelectedValue == 0)
            {
                datosValidos = false;
                errorProvider.SetError(colorComboBox, "Campo Obligatorio");
            }
            if (fechalanzamientoTextBox.Text == "" || fechalanzamientoTextBox.Text.Trim() == String.Empty)
            {
                //Nombre vacio
                datosValidos = false;
                errorProvider.SetError(fechalanzamientoTextBox, "Campo Obligatorio");
            }
            if (precioTextBox.Text == "" || decimal.Parse(precioTextBox.Text) <= 0)
            {
                //Nombre vacio
                datosValidos = false;
                errorProvider.SetError(precioTextBox, "Campo Obligatorio");
            }
            if (existenciasTextBox.Text == "" || existenciasTextBox.Text.Trim() == String.Empty)
            {
                //Nombre vacio
                datosValidos = false;
                errorProvider.SetError(existenciasTextBox, "Campo Obligatorio");
            }
            return datosValidos;
        }
        private void CargarMarca()
        {

            MarcaBL marcaBL = new MarcaBL();


            List<Marca> marcas = new List<Marca>();
            marcas.Add(new Marca { Id = 0, Nombre = "SELECCIONAR" });


            marcas.AddRange(marcaBL.Buscar(new Marca()));
            marcaComboBox.DataSource = marcas;


            marcaComboBox.DisplayMember = "Nombre";
            marcaComboBox.ValueMember = "Id";

        }
        private void CargarModelo(byte pValor = 0)
        {
            List<Modelo> modelos = new List<Modelo>();

            if (marcaComboBox.SelectedIndex > 0)
            {
                modelos.Add(new Modelo { Id = 0, Nombre = "SELECCIONAR" });
                ModeloBL modeloBL = new ModeloBL();
                modelos.AddRange(modeloBL.Buscar(new Modelo { IdMarca = (byte)marcaComboBox.SelectedValue}));
                comboBoxmodelo.DataSource = modelos;


            }
            else
            {
                modelos.Add(new Modelo { Id = 0, Nombre = "SELECCIONAR" });
                comboBoxmodelo.DataSource = modelos;
            }
            comboBoxmodelo.DisplayMember = "Nombre";
            comboBoxmodelo.ValueMember = "Id";
            comboBoxmodelo.SelectedValue = pValor;

        }
        private void CargarColor()
        {

            ColorBL colorBL = new ColorBL();


            List<EN.Color> colores = new List<EN.Color>();
            colores.Add(new EN.Color { Id = 0, Nombre = "SELECCIONAR" });


            colores.AddRange(colorBL.Buscar(new EN.Color()));
            colorComboBox.DataSource = colores;


            colorComboBox.DisplayMember = "Nombre";
            colorComboBox.ValueMember = "Id";

        }
        private void MainVehiculo_Load(object sender, EventArgs e)
        {
            CargarMarca();
            CargarModelo();
            CargarColor();
            if (id > 0)
            {
                Vehiculo vehiculo = vehiculoBL.ObtenerPorId(id);
                vehiculo.Modelo = new ModeloBL().ObtenerPorId(vehiculo.IdModelo);
                marcaComboBox.SelectedValue = vehiculo.Modelo.IdMarca;
                CargarModelo(vehiculo.IdModelo);

                //comboBoxmodelo.SelectedValue = vehiculo.IdModelo;
                colorComboBox.SelectedValue = vehiculo.IdColor;
                fechalanzamientoTextBox.Text = vehiculo.FechaLanzamiento;
                precioTextBox.Text = vehiculo.Precio.ToString("##.00");
                existenciasTextBox.Text = vehiculo.Existencias.ToString();
               
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
                    Vehiculo vehiculo = new Vehiculo();
                    vehiculo.IdModelo = (byte)comboBoxmodelo.SelectedValue;
                    vehiculo.IdColor = (byte)colorComboBox.SelectedValue;
                    vehiculo.FechaLanzamiento = fechalanzamientoTextBox.Text;
                    vehiculo.Precio = decimal.Parse(precioTextBox.Text);
                    vehiculo.Existencias = byte.Parse(existenciasTextBox.Text);

                    if (id == 0)
                    {
                        vehiculoBL.Guardar(vehiculo);
                        Tools.NotificacionInfo("Guardado Exitosamente");
                        Limpiar(); //Limpiar formulario
                    }
                    else
                    {
                        vehiculo.Id = id;
                        vehiculoBL.Modificar(vehiculo);
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

        private void comboBoxmodelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxmodelo.SelectedIndex != 0 && comboBoxmodelo.SelectedValue != null)
            {
                TipoAutosBL tipoAutosBL = new TipoAutosBL();

                Modelo modelo = comboBoxmodelo.SelectedItem as Modelo;

                TipoAutos tipoAutos = tipoAutosBL.ObtenerPorId(modelo.IdTipoAuto);
                tipoVehiculoTextBox.Text = tipoAutos.Nombre;
            }
        }

        private void marcaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarModelo();
        }
    }
}
