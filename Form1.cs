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

namespace ProyectoMatematicas2daParcial
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            diseño();
        }

        private void diseño()
        {
            PnlSubMenuMetodos.Visible = false;
            PnlBajo.Visible = false;
        }

        private void esconderMenu()
        {
            if(PnlSubMenuMetodos.Visible == true)
            {
                PnlSubMenuMetodos.Visible=false;
            }
            if(PnlBajo.Visible == true)
            {
                PnlBajo.Visible=false;
            }
        }

        private void mostraMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                esconderMenu();
                subMenu.Visible=true;
            }
            else
            {
                subMenu.Visible=false;
            }
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void BtnMetodos_Click(object sender, EventArgs e)
        {
            mostraMenu(PnlSubMenuMetodos);
        }

        private void BtnFormulas_Click(object sender, EventArgs e)
        {
            mostraMenu(PnlBajo);
        }

        private void BtnAcercaDe_Click(object sender, EventArgs e)
        {
            openChildForm(new acercaDe());
            esconderMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PnlChildForm.Controls.Add(childForm);
            PnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BtnSecante_Click(object sender, EventArgs e)
        {
            openChildForm(new secante());
        }

        private void BtnBiseccion_Click(object sender, EventArgs e)
        {
            openChildForm(new biseccion());
        }

        private void BtnReglaFalsa_Click(object sender, EventArgs e)
        {
            openChildForm(new reglaFalsa());
            /*if(BtnReglaFalsa.Enabled)
            {
                BtnReglaFalsa.BackColor = Color.Black;
            }*/
        }

        private void BtnReglaFalsaM_Click(object sender, EventArgs e)
        {
            openChildForm(new reglaFalsaModificada());
        }

        private void BtnSecanteF_Click(object sender, EventArgs e)
        {
            openChildForm(new secanteF());
        }

        private void BtnBiseccionF_Click(object sender, EventArgs e)
        {
            openChildForm(new biseccionF());
        }

        private void BtnReglaFalsaF_Click(object sender, EventArgs e)
        {
            openChildForm(new reglaFalsaF());
        }

        private void BtnReglaFalsaMF_Click(object sender, EventArgs e)
        {
            openChildForm(new reglaFalsaModificadaF());
        }

        private void BtnReglaTrapezoidal_Click(object sender, EventArgs e)
        {
            openChildForm(new ReglaTrapezoidal());
        }
    }
}
