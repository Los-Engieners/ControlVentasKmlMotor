using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ControlVentasKmlMotor.UI.WindowsForms
{
    public class Tools
    {
        public static long ObtenerIdGrid(DataGridView pDataGridView)
        {
            try
            {
                long id = 0;
                //Obtener Id Seleccionado
                id = Convert.ToInt64(pDataGridView.Rows[pDataGridView.CurrentRow.Index].Cells[0].Value.ToString());
                return id;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public static DialogResult MessageBoxConfirmar()
        {
            return MessageBox.Show("¿Desea eliminar el registro seleccionado", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private static NotifyIcon CrearNotificacion(string pTexto, string pTitulo)
        {
            NotifyIcon notify = new NotifyIcon();
            notify.Icon = new Icon(SystemIcons.Application, 150, 150);
            notify.Text = pTexto;
            notify.Visible = true;
            notify.BalloonTipTitle = pTitulo;
            notify.BalloonTipText = pTexto;
            notify.BalloonTipClosed += (sender, e) => { var x = (NotifyIcon)sender; x.Visible = false; x.Dispose(); };
            notify.BalloonTipClicked += (sender, e) => { var x = (NotifyIcon)sender; x.Visible = false; x.Dispose(); };
            return notify;

        }
        public static void NotificacionInfo(string pTexto)
        {
            NotifyIcon notify = CrearNotificacion(pTexto, "Información");
            notify.BalloonTipIcon = ToolTipIcon.Info;
            notify.ShowBalloonTip(100); //Tiempo de duración
        }

        public static void NotificacionAlerta(string pTexto)
        {
            NotifyIcon notify = CrearNotificacion(pTexto, "Alerta");
            notify.BalloonTipIcon = ToolTipIcon.Warning;
            notify.ShowBalloonTip(100);
        }

        public static void NotificacionError(string pTexto)
        {
            NotifyIcon notify = CrearNotificacion(pTexto, "Error");
            notify.BalloonTipIcon = ToolTipIcon.Error;
            notify.ShowBalloonTip(100);
        }
    }
}
