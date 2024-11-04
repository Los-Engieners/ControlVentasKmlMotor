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
using ControlVentasKmlMotor.UI.WindowsForms.ViewModels;
using ControlVentasKmlMotor.UI.WindowsForms.Mantenimiento;

namespace ControlVentasKmlMotor.UI.WindowsForms
{
    public partial class FrmEmpleado : Form
    {
        EmpleadoBL empleadoBL = new EmpleadoBL();

        List<Empleado> lista = new List<Empleado>();

        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void CargarCargos()
        {

            CargoBL cargoBL = new CargoBL();


            List<Cargo> cargos = new List<Cargo>();
            cargos.Add(new Cargo { Id = 0, Nombre = "SELECCIONAR" });


            cargos.AddRange(cargoBL.Buscar(new Cargo()));
            cargoComboBox.DataSource = cargos;


            cargoComboBox.DisplayMember = "Nombre";
            cargoComboBox.ValueMember = "Id";

        }

        private void CargarLista()
        {
            listaDataGridView.DataSource = " ";
            empleadoBL.CargarGeneroVirtual(lista);
            empleadoBL.CargarSucursalVirtual(lista);
            empleadoBL.CargarCargoVirtual(lista);

            listaDataGridView.DataSource = lista.Select( x => new EmpleadoVM(x)  ).ToList();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            CargarCargos();
        }

        private void iconButtonBuscar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.Nombre = textBoxBusqueda.Text;
            empleado.IdCargo = (byte)cargoComboBox.SelectedValue;
            

            lista = empleadoBL.Buscar(empleado);
            CargarLista();
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            byte id = (byte)Tools.ObtenerIdGrid(listaDataGridView);
            if (id > 0)
            {
                MainEmpleado form = new MainEmpleado();
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
                    Empleado empleado = new Empleado();
                    empleado.Id = id;

                    if (empleadoBL.Eliminar(empleado) > 0)
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
            MainEmpleado form = new MainEmpleado();
            form.ShowDialog();

            iconButtonBuscar.PerformClick();
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            textBoxBusqueda.Text = "";
            cargoComboBox.SelectedIndex = 0;
         
        }
    }
}
