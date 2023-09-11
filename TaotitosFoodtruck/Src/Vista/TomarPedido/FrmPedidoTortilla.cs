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
            pbSalsa.Value = 0;
            dgvPedidoTortilla.SelectionChanged += DgvPedidoTortilla_SelectionChanged;
        }

        private void DgvPedidoTortilla_SelectionChanged(object sender, EventArgs e)
        {
            pbSalsa.Value = 25;
            Console.WriteLine("Selection Changed");
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
            ingredienteController.llenarDgv(dgvPedidoTortilla, 1);
        }

        private void FrmPedidoTortillo_Load(object sender, EventArgs e)
        {
            dgvPedidoTortilla.ClearSelection();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
