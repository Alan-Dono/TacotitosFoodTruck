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

namespace TaotitosFoodtruck.Src.Vista.TomarPedido
{
    public partial class FrmPedidoIngrediente : Form
    {
        private ControladoraIngredientes ingredienteController = ControladoraIngredientes.GetInstancia();

        private ControladoraFrm frmController = ControladoraFrm.GetInstance();
        private static FrmPedidoIngrediente instancia;
        public static FrmPedidoIngrediente GetInstancia()
        {
            if ( instancia == null)
            {
                instancia = new FrmPedidoIngrediente();
            }
            return instancia;
        }
        private FrmPedidoIngrediente()
        {
            InitializeComponent();
            RefrescarIngredientes();
        }

        private void btnAlimentoSiguiente_Click(object sender, EventArgs e)
        {
            frmController.AbriFormHijo(FrmPedidoSalsa.GetInstancia());
        }

        private void btnAlimentoAtras_Click(object sender, EventArgs e)
        {
            frmController.AbriFormHijo(FrmPedidoTortillo.GetInstancia());
        }
        private void RefrescarIngredientes()
        {
            ingredienteController.ListaIngredientes(2, dgvTortilla);
        }
    }
}
