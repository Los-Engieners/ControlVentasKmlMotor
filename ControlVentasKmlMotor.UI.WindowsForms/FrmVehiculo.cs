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
using ControlVentasKmlMotor.UI.WindowsForms.Mantenimiento;
using ControlVentasKmlMotor.UI.WindowsForms.Nuevo;
using ControlVentasKmlMotor.UI.WindowsForms.ViewModels;

namespace ControlVentasKmlMotor.UI.WindowsForms
{
    public partial class FrmVehiculo : Form
    {
        VehiculoBL vehiculoBL = new VehiculoBL();

        List<Vehiculo> lista = new List<Vehiculo>();

        public FrmVehiculo()
        {
            InitializeComponent();
        }

        private void CargarModelo()
        {

            ModeloBL modeloBL = new ModeloBL();


            List<Modelo> modelos = new List<Modelo>();
            modelos.Add(new Modelo { Id = 0, Nombre = "SELECCIONAR" });


            modelos.AddRange(modeloBL.Buscar(new Modelo()));
            modeloComboBox.DataSource = modelos;


            modeloComboBox.DisplayMember = "Nombre";
            modeloComboBox.ValueMember = "Id";

        }
        private void CargarListas()
        {
            listaDataGridView.DataSource = "";

            vehiculoBL.CargarColorVirtual(lista);
            vehiculoBL.CargarModeloVirtual(lista, listaModelos => {
                new ModeloBL().CargarMarcaVirtual(listaModelos);
            });


            listaDataGridView.DataSource = lista.Select( x => new VehiculoVM(x)).ToList();
        }

        private void FrmVehiculo_Load(object sender, EventArgs e)
        {
            CargarModelo();

        }

        private void iconButtonBuscar_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.IdModelo = (byte)modeloComboBox.SelectedValue;

            lista = vehiculoBL.Buscar(vehiculo);
            CargarListas();
            
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            byte id = (byte)Tools.ObtenerIdGrid(listaDataGridView);
            if (id > 0)
            {
                MainModelo form = new MainModelo();
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
                    Vehiculo vehiculo = new Vehiculo();
                    vehiculo.Id = id;

                    if (vehiculoBL.Eliminar(vehiculo) > 0)
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
            MainModelo form = new MainModelo();
            form.ShowDialog();

            iconButtonBuscar.PerformClick();
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            modeloComboBox.SelectedIndex = 0;
        }
    }
}
