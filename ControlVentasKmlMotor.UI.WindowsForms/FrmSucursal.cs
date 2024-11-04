using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using ControlVentasKmlMotor.UI.WindowsForms.Nuevo;
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
    public partial class FrmSucursal : Form
    {

        SucursalBL sucursalBL = new SucursalBL();

        List<Sucursal> lista = new List<Sucursal>();
        public FrmSucursal()
        {
            InitializeComponent();
        }

        private void CargarLista()
        {
            listaDataGridView.DataSource = " ";

            listaDataGridView.DataSource = lista; 
        }

        private void FrmSucursal_Load(object sender, EventArgs e)
        {

        }

        private void iconButtonBuscar_Click(object sender, EventArgs e)
        {
            Sucursal sucursal = new Sucursal();
            sucursal.Nombre = textBoxBusqueda.Text;
            sucursal.Direccion = textBoxBusqueda.Text;

            lista = sucursalBL.Buscar(sucursal);

            CargarLista();
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            byte id = (byte)Tools.ObtenerIdGrid(listaDataGridView);
            if (id > 0)
            {
                MainSucursal form = new MainSucursal();

                form.id = id;
                form.ShowDialog();

                iconButtonBuscar.PerformClick();
            }
            else
            {
                MessageBox.Show("Primero debe seleccionar el registro que desea editar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            byte id = (byte)Tools.ObtenerIdGrid(listaDataGridView);
            if (id > 0)
            {
                if (Tools.MessageBoxConfirmar() == DialogResult.Yes)
                {
                    Sucursal sucursal = new Sucursal();
                    sucursal.Id = id;

                    if (sucursalBL.Eliminar(sucursal) > 0)
                    {
                        Tools.NotificacionInfo("Registro eliminado exitosamente");

                        iconButtonBuscar.PerformClick();
                    }
                    else
                    {
                        Tools.NotificacionError("A ocurrido un error, por favor intente otra vez");
                    }
                }
            }
           
            else
            {
                MessageBox.Show("Primero debe seleccionar el registro que desea editar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void registrarButton_Click(object sender, EventArgs e)
        {
            MainSucursal form = new MainSucursal();

            form.ShowDialog();

            iconButtonBuscar.PerformClick();

               
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            textBoxBusqueda.Text = "";
            
        }
    }
}
