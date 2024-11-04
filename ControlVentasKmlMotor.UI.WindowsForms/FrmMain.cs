using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.DAL;
using ControlVentasKmlMotor.EN;
using ControlVentasKmlMotor.UI.WindowsForms.Mantenimiento;
using ControlVentasKmlMotor.UI.WindowsForms.Nuevo;
using FontAwesome.Sharp;
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
    public partial class FrmMain : Form
    {
        Empleado empleado = new Empleado();
        EmpleadoBL empBL = new EmpleadoBL();
        private static IconMenuItem ModuloActivo = null;
        public static Form formularioActivo = null;

        public FrmMain(Empleado pEmpleado)
        {
            InitializeComponent();
            empleado = pEmpleado;
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            List<Permiso> listaPermisos = new PermisoBL().Lista(empleado.Id);
            foreach (IconMenuItem iconMenu in menuStrip1.Items)
            {
                bool encontrado = listaPermisos.Where(x => x.Modulo.Nombre == iconMenu.Name).Count() > 0;

                if (encontrado == false)
                {
                    iconMenu.Visible = false;
                }
            }

            labelNombreUsuario.Text = "Bienvenido " + empleado.Nombre + empleado.Apellido;
           

        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (ModuloActivo != null)
            {
                ModuloActivo.BackColor = System.Drawing.Color.DarkGray;
            }
            menu.BackColor = System.Drawing.Color.Silver;
            ModuloActivo = menu;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = System.Drawing.Color.DarkGray;
            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void menuEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmEmpleado());
        }

        private void menuCliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmClientes());
        }

        private void menuAutomovil_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmVehiculo());
        }

        private void menuSucursales_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmSucursal());
        }

        private void labelNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesionButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de salir del sistema?","Sistema Contol Ventas",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

       

        private void subMenuMarca_Click(object sender, EventArgs e)
        {
            FrmMarca form = new FrmMarca();
            form.ShowDialog();
        }

        private void subMenuModelo_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuAutomovil, new MainModelos());
        }

        private void registrarsubMenuServicio_Click(object sender, EventArgs e)
        {
            FrmServicioExtra form = new FrmServicioExtra();
            form.ShowDialog();
        }
    }
}
