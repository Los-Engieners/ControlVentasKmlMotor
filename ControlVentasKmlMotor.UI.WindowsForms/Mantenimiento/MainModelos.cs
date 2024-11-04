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

namespace ControlVentasKmlMotor.UI.WindowsForms.Mantenimiento
{
    public partial class MainModelos : Form
    {
        ModeloBL modeloBL = new ModeloBL();

        List<Modelo> lista = new List<Modelo>();
        public MainModelos()
        {
            InitializeComponent();
        }

        public void CargarMarca()
        {
            MarcaBL marcaBL = new MarcaBL();

            List<Marca> marca = new List<Marca>();
            marca.Add(new Marca { Id = 0, Nombre = "SELECCIONAR" });

            marca.AddRange(marcaBL.Buscar(new Marca()));
            marcaComboBox.DataSource = marca;

            marcaComboBox.DisplayMember = "Nombre";
            marcaComboBox.ValueMember = "Id";
        }

        public void CargarTipoAuto()
        {
            TipoAutosBL tipoAutoBL = new TipoAutosBL();

            List<TipoAutos> tipoAuto = new List<TipoAutos>();
            tipoAuto.Add(new TipoAutos { Id = 0, Nombre = "SELECCIONAR" });

            tipoAuto.AddRange(tipoAutoBL.Buscar(new TipoAutos()));
            tipoAutoComboBox.DataSource = tipoAuto;

            tipoAutoComboBox.DisplayMember = "Nombre";
            tipoAutoComboBox.ValueMember = "Id";
        }

        private void CargarListas()
        {
            listaDataGridView.DataSource = "";
            modeloBL.CargarMarcaVirtual(lista);
            modeloBL.CargarTipoAutosVirtual(lista);

            listaDataGridView.DataSource = lista.Select(X => new ModeloVM(X)).ToList();
        }

        private void MainModelos_Load(object sender, EventArgs e)
        {
            CargarMarca();
            CargarTipoAuto();
        }

        private void iconButtonBuscar_Click(object sender, EventArgs e)
        {
            Modelo modelo = new Modelo();           
            modelo.IdMarca = (byte)marcaComboBox.SelectedValue;
            modelo.IdTipoAuto = (byte)tipoAutoComboBox.SelectedValue;

            lista = modeloBL.Buscar(modelo);
            CargarListas();
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            byte id = (byte)Tools.ObtenerIdGrid(listaDataGridView);
            if (id > 0)
            {
                FrmModelo form = new FrmModelo();
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
                    Modelo modelo = new Modelo();
                    modelo.Id = id;

                    if (modeloBL.Eliminar(modelo) > 0)
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

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            tipoAutoComboBox.SelectedIndex = 0;
            marcaComboBox.SelectedIndex = 0;
        }

        private void registrarButton_Click(object sender, EventArgs e)
        {
            FrmModelo form = new FrmModelo();
            form.ShowDialog();

            iconButtonBuscar.PerformClick();
        }
    }
}
