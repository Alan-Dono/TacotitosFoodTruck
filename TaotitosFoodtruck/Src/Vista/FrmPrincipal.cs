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
using TaotitosFoodtruck.Src.Vista.MenuLateral;
using TaotitosFoodtruck.Src.Controladora;

namespace TaotitosFoodtruck.Src.Vista
{
    public partial class FrmPrincipal : Form
    {       
        private ControladoraFrm formController = ControladoraFrm.GetInstance();
        private static FrmPrincipal instance;
        public static FrmPrincipal GetInstance()
        {
            if (instance == null)
            {
                instance = new FrmPrincipal();
            }
            return instance;
        }
        private FrmPrincipal()
        {
            InitializeComponent();

        }
        public Panel PanelContenedor
        {
            get { return PanelPrincipal; }
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            iconPictureBox1_Click(null, e);
        }
        #region VenanasEmergentes
     /*   public void AbrirFormHijo(object frmHijo)
        {
            if(this.PanelPrincipal.Controls.Count > 0)
            {
                this.PanelPrincipal.Controls.RemoveAt(0);
            }
            Form hijo = frmHijo as Form;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.PanelPrincipal.Controls.Add(hijo);
            this.PanelPrincipal.Tag = hijo;
            hijo.Show();
        }*/
        #endregion

        #region BotenesVentana
        private void bntCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMazimizr_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizr.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizr.Visible=true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;

        }
        #endregion
        
        #region MoverPantalla
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region BotonesMenu
        private void btnSalsa_Click(object sender, EventArgs e)
        {
            formController.AbrirFormHijo(FrmSalsas.GetInstancia(), PanelContenedor);
            //formController.AbriFormHijo(FrmSalsas.GetInstancia());
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            formController.AbrirFormHijo(FrmHome.GetInstancia(), PanelContenedor);
            //formController.AbriFormHijo(FrmHome.GetInstancia());
        }

        private void btnTortillas_Click(object sender, EventArgs e)
        {
            formController.AbrirFormHijo(FrmTortillas.GetInstancia(), PanelContenedor);
            //formController.AbriFormHijo(FrmTortillas.GetInstancia());
        }

        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            formController.AbrirFormHijo(FrmIngredientes.GetInstancia(), PanelContenedor);
            //formController.AbriFormHijo(FrmIngredientes.GetInstancia());
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            //formController.AbriFormHijo(FrmPedido.GetInstancia());
            formController.AbrirFormHijo(FrmPedido.GetInstancia(), PanelContenedor);

        }
        #endregion

    }
}
