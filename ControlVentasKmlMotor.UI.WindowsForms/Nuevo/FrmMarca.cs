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

namespace ControlVentasKmlMotor.UI.WindowsForms.Nuevo
{
    public partial class FrmMarca : Form
    {
        MarcaBL marcaBL = new MarcaBL();
        public byte id = 0;

        public FrmMarca()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            nombreTextBox.Clear();
        }
        private bool  ValidarControles()
        {
            bool datosValidos = true;
            errorProvider.Clear();
            if (nombreTextBox.Text == "" || nombreTextBox.Text.Trim() ==String.Empty)
            {
                datosValidos = false;
                errorProvider.SetError(nombreTextBox, "Campo Obligatorio");
            }

            return datosValidos;
            
        }
        private void FrmMarca_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                Marca marca = marcaBL.ObtenerPorId(id);

                nombreTextBox.Text = marca.Nombre;
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
                    Marca marca = new Marca();
                    marca.Nombre = nombreTextBox.Text;

                    if (id == 0)
                    {
                        marcaBL.Guardar(marca);
                        Tools.NotificacionInfo("Guardo Exitosamente");
                        Limpiar();
                    }
                    else
                    {
                        marca.Id = id;
                        marcaBL.Modificar(marca);
                        Tools.NotificacionInfo("Actualizado Exitosamente");
                        this.Close();
                    }
                }

                else
                {
                    Tools.NotificacionAlerta("Complete los campos obligatorios");
                }

            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
    }
}
