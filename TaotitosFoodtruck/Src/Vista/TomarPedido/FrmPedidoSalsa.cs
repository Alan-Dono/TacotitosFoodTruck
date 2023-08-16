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
    public partial class FrmPedidoSalsa : Form
    {
        private ControladoraFrm frmController = ControladoraFrm.GetInstance();
        private ControladoraIngredientes ingredienteController = ControladoraIngredientes.GetInstancia();
        private static FrmPedidoSalsa instancia;
        public static FrmPedidoSalsa GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new FrmPedidoSalsa();
            }
            return instancia;
        }
        private FrmPedidoSalsa()
        {
            InitializeComponent();
            RefrescarSalsas();
        }

        private void btnSalaAtras_Click(object sender, EventArgs e)
        {
            frmController.AbriFormHijo(FrmPedidoIngrediente.GetInstancia());
        }
        private void RefrescarSalsas()
        {
            ingredienteController.llenarDgv(dgvSalsa, 3);
        }
    }
}
