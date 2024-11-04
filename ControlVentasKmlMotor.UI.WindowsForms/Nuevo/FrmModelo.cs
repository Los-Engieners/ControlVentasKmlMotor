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
    public partial class FrmModelo : Form
    {
        ModeloBL modeloBL = new ModeloBL();
        public byte id = 0;

        public FrmModelo()
        {
            InitializeComponent();
        }
        private void Limpiar ()
        {
            marcaComboBox.SelectedIndex = 0;
            tipovehiculoComboBox.SelectedIndex = 0;
            nombreTextBox.Clear();
        }
        private bool ValidarControles()
        {
            bool datosvalidos = true;
            errorProvider.Clear();

            if (nombreTextBox.Text == "" || nombreTextBox.Text.Trim() == String.Empty)
            {
                datosvalidos = false;
                errorProvider.SetError(nombreTextBox, "Campo obligatorio");
            }

            if (marcaComboBox.SelectedValue == null || (byte)marcaComboBox.SelectedValue == 0) 
            {
                datosvalidos = false;
                errorProvider.SetError(marcaComboBox, "Campo obligatorio");
            }

            if (tipovehiculoComboBox.SelectedValue == null || (byte)tipovehiculoComboBox.SelectedValue == 0)
            {
                datosvalidos = false;
                errorProvider.SetError(tipovehiculoComboBox, "Campo obligatorio");
            }
            return datosvalidos;
        }
        
        private void CargarMarcas()
        {
            MarcaBL marcaBL = new MarcaBL();

            List<Marca> marca = new List<Marca>();
            marca.Add(new Marca { Id = 0, Nombre = "SELECCIONAR" });

            marca.AddRange(marcaBL.Buscar(new Marca()));
            marcaComboBox.DataSource = marca;

            marcaComboBox.DisplayMember = "Nombre";
            marcaComboBox.ValueMember = "Id";
        }

        private void CargarTipoAutos()
        {
            TipoAutosBL tipoautosBL = new TipoAutosBL();

            List<TipoAutos> tipoAutos = new List<TipoAutos>();
            tipoAutos.Add(new TipoAutos { Id = 0, Nombre = "SELECCIONAR" });

            tipoAutos.AddRange(tipoautosBL.Buscar(new TipoAutos()));
            tipovehiculoComboBox.DataSource = tipoAutos;

            tipovehiculoComboBox.DisplayMember = "Nombre";
            tipovehiculoComboBox.ValueMember = "Id";
        }

        private void FrmModelo_Load(object sender, EventArgs e)
        {
            CargarMarcas();
            CargarTipoAutos();

            if (id > 0)
            {
                Modelo modelo = modeloBL.ObtenerPorId(id);

                nombreTextBox.Text = modelo.Nombre;
                marcaComboBox.SelectedValue = modelo.IdMarca;
                tipovehiculoComboBox.SelectedValue = modelo.IdTipoAuto;
                this.Text = "Editar Modelo";
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
                    Modelo modelo = new Modelo();
                    modelo.Nombre = nombreTextBox.Text;
                    modelo.IdMarca = (byte)marcaComboBox.SelectedValue;
                    modelo.IdTipoAuto = (byte)tipovehiculoComboBox.SelectedValue;

                    if (id == 0)
                    {
                        modeloBL.Guardar(modelo);
                        Tools.NotificacionInfo("Guardado Exitosamente");
                        Limpiar();
                    }
                    else
                    {
                        modelo.Id = id;
                        modeloBL.Modificar(modelo);
                        Tools.NotificacionInfo("Actualizado Exitosamente");
                        this.Close();
                    }
                }
                else
                {
                    Tools.NotificacionAlerta("Complete los campos obligatorios");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
