using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PasantiasProyecto
{
    public partial class FrmTutor : Form
    {
        public FrmTutor()
        {
            InitializeComponent();
        }
          //Ojo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL",EntryPoint ="SendMEssage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparas, int lparm);

        private void btnOpcione_Click(object sender, EventArgs e)
        {
            if (PnlIzquierdo.Width==239)
            {
                PnlIzquierdo.Width = 97;
            }
            else
            {
                PnlIzquierdo.Width = 239;
            }
                
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMaximixar_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Maximized;
            btnMinimizar.Visible = true;
            btnMaximixar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMinimizar.Visible = false;
            btnMaximixar.Visible = true;
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
