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
using ControlVentasKmlMotor.EN;
using ControlVentasKmlMotor.UI.WindowsForms.Nuevo;
using ControlVentasKmlMotor.UI.WindowsForms.ViewModels;


namespace ControlVentasKmlMotor.UI.WindowsForms
{
    public partial class FrmClientes : Form
    {
        ClienteBL clienteBL = new ClienteBL();

        List<Cliente> lista = new List<Cliente>();
        public FrmClientes()
        {
            InitializeComponent();
        }
        public void CargarLista()
        {
            listaDataGridView.DataSource = "";
            clienteBL.CargarGeneroVirtual(lista);
            listaDataGridView.DataSource = lista.Select(x => new ClienteVM(x)).ToList();

            
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            
        }

        private void iconButtonBuscar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = textBoxBusqueda.Text;
            
            lista = clienteBL.Buscar(cliente);
            CargarLista();
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            byte id = (byte)Tools.ObtenerIdGrid(listaDataGridView);
            if (id > 0)
            {
                MainCliente form = new MainCliente();
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
                    Cliente cliente = new Cliente();
                    cliente.Id = id;

                    if (clienteBL.Eliminar(cliente) > 0)
                    {
                        Tools.NotificacionInfo("Registro eliminado exitosamente");

                        iconButtonBuscar.PerformClick();
                    }
                    else
                    {
                        Tools.NotificacionError("Ocurrio un error, por favor intente de nuevo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Primero debe seleccionar el registro que desea eliminar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void registrarButton_Click(object sender, EventArgs e)
        {
            MainCliente form = new MainCliente();
            form.ShowDialog();

            iconButtonBuscar.PerformClick();
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            textBoxBusqueda.Text = "";
        }
    }
}
