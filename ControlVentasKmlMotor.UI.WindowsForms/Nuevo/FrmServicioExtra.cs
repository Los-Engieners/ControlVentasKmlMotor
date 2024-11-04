using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.DAL;
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

namespace ControlVentasKmlMotor.UI.WindowsForms.Nuevo
{
    public partial class FrmServicioExtra : Form
    {
        ServicioExtraBL servicioBL = new ServicioExtraBL();
        public short id = 0;
        public FrmServicioExtra()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            nombreTextBox.Clear();
            precioTextBox.Clear();
        }
        private bool ValidarControles()
        {
            bool datosValidos = true;
            errorProvider.Clear();
            if (nombreTextBox.Text == "" || nombreTextBox.Text.Trim() == String.Empty)
            {
                datosValidos = false;
                errorProvider.SetError(nombreTextBox, "Campo Obligatorio");
            }
            if (precioTextBox.Text == "" || decimal.Parse(precioTextBox.Text) <= 0)
            {
                //Nombre vacio
                datosValidos = false;
                errorProvider.SetError(precioTextBox, "Campo Obligatorio");
            }

            return datosValidos;

        }
        private void FrmServicioExtra_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                ServicioExtra servicio = servicioBL.ObtenerPorId(id);

                nombreTextBox.Text = servicio.Nombre;
                precioTextBox.Text = servicio.Precio.ToString("##.00");
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
                    ServicioExtra servicio = new ServicioExtra();
                    servicio.Nombre = nombreTextBox.Text;
                    servicio.Precio = decimal.Parse(precioTextBox.Text);

                    if (id == 0)
                    {
                        servicioBL.Guardar(servicio);
                        Tools.NotificacionInfo("Guardo Exitosamente");
                        Limpiar();
                    }
                    else
                    {
                        servicio.Id = id;
                        servicioBL.Modificar(servicio);
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
