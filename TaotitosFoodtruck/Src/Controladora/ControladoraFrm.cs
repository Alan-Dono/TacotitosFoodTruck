using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaotitosFoodtruck.Src.Vista;
using TaotitosFoodtruck.Src.Vista.TomarPedido;


namespace TaotitosFoodtruck.Src.Controladora
{
    public class ControladoraFrm
    {
        #region AtributosFormularios
        //private FrmPrincipal principal = FrmPrincipal.GetInstance();
        private Panel panel1;
        private FrmTortillas tortillas = FrmTortillas.GetInstancia();
        private FrmIngredientes ingredientes = FrmIngredientes.GetInstancia();
        private FrmSalsas salsas = FrmSalsas.GetInstancia();
        private FrmHome home = FrmHome.GetInstancia();
        private FrmPedidoTortillo pedidoTortillo;
        private FrmPedidoIngrediente pedidoIngrediente;
        private FrmPedidoSalsa pedidoSalsa;
        #endregion
        private static ControladoraFrm Instance;
        private ControladoraFrm() { }
        public static ControladoraFrm GetInstance()
        {
            if (Instance == null)
            {
                Instance = new ControladoraFrm();
            }
            return Instance;
        }
        public void AbrirFormHijo(Form frmHijo, Panel panelPrincipal)
        {
            panel1 = panelPrincipal;
            if (panelPrincipal.Controls.Count > 0)
            {
                panelPrincipal.Controls.RemoveAt(0);
            }
            frmHijo.TopLevel = false;
            frmHijo.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(frmHijo);
            panelPrincipal.Tag = frmHijo;
            frmHijo.BringToFront();
            frmHijo.Show();
        }
        public void AbriFormHijo(Form FrmHijo)
        {
            if (panel1.Controls.Count > 0)
            {
                panel1.Controls.RemoveAt(0);
            }
            FrmHijo.TopLevel = false;
            FrmHijo.Dock = DockStyle.Fill;
            panel1.Controls.Add(FrmHijo);
            panel1.Tag = FrmHijo;
            FrmHijo.Show();
        }


    }

}

