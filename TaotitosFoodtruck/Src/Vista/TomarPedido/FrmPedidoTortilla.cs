using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaotitosFoodtruck.Src.Controladora;
using TaotitosFoodtruck.Src.Vista.MenuLateral;

namespace TaotitosFoodtruck.Src.Vista.TomarPedido
{
    public partial class FrmPedidoTortillo : Form
    {
        private ControladoraFrm frmController = ControladoraFrm.GetInstance();
        private ControladoraIngredientes ingredienteController = ControladoraIngredientes.GetInstancia();

        private static FrmPedidoTortillo instancia;

        public static FrmPedidoTortillo GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new FrmPedidoTortillo();
            }
            return instancia;
        }

        private FrmPedidoTortillo()
        {
            InitializeComponent();
            RefrescarTortillas();
        }

        private void btnTortillaAtras_Click(object sender, EventArgs e)
        {
            frmController.AbriFormHijo(FrmPedido.GetInstancia());
        }

        private void btnTortillaSiguiente_Click(object sender, EventArgs e)
        {
            frmController.AbriFormHijo(FrmPedidoIngrediente.GetInstancia());
        }

        private void RefrescarTortillas()
        {
            ingredienteController.ListaIngredientes(1, dgvPedidoTortilla);
        }
    }
}
