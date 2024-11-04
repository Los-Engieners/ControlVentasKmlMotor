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
using System.Xml.Serialization;

namespace ControlVentasKmlMotor.UI.WindowsForms.Nuevo
{
    public partial class MainSucursal : Form
    {
        SucursalBL sucursalBL = new SucursalBL();

        public byte id = 0;
        public MainSucursal()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            nombreTextBox.Clear();
            direccionTextBox.Clear();
        }

        private bool ValidarControles()
        {
            bool datosValidos = true;
            errorProvider.Clear();

            if (nombreTextBox.Text == "" || nombreTextBox.Text.Trim() == string.Empty)
            {
                datosValidos = false;
                errorProvider.SetError(nombreTextBox, "Campo Obligatorio");
            }
            if (direccionTextBox.Text == "" || direccionTextBox.Text.Trim() == string.Empty)
            {
                datosValidos = false;
                errorProvider.SetError(direccionTextBox, "Campo Obligatorio");
            }

            return datosValidos;
        }

        private void MainSucursal_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                Sucursal sucursal = sucursalBL.ObtenerPorId(id);

                nombreTextBox.Text = sucursal.Nombre;
                direccionTextBox.Text = sucursal.Direccion;
                this.Text = "Editar Sucursal";
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
                    Sucursal sucursal = new Sucursal();
                    sucursal.Nombre = nombreTextBox.Text;
                    sucursal.Direccion = direccionTextBox.Text;


                    if (id == 0)
                    {
                        sucursalBL.Guardar(sucursal);
                        Tools.NotificacionInfo("Guardado Exitosamente");
                        Limpiar();
                    }
                    else
                    {
                        sucursal.Id = id;
                        sucursalBL.Modificar(sucursal);
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
