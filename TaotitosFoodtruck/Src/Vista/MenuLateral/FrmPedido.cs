using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaotitosFoodtruck.Src.Vista.TomarPedido;
using TaotitosFoodtruck.Src.Controladora;
using TaotitosFoodtruck.Src.Modelo;

namespace TaotitosFoodtruck.Src.Vista.MenuLateral
{
    public partial class FrmPedido : Form
    {
        private ControladoraFrm controladoraFrm = ControladoraFrm.GetInstance();
        private ControladoraPedido controladoraPedido = ControladoraPedido.getInstancia();
        private static FrmPedido instancia;

        
        public static FrmPedido GetInstancia()
        {
            if(instancia == null)
            {
                instancia = new FrmPedido();
            }
            return instancia;
        }

        private FrmPedido()
        {
            InitializeComponent();
        }

        private void btnNuevaSalsa_Click_1(object sender, EventArgs e)
        {
            controladoraFrm.AbriFormHijo(FrmPedidoTortillo.GetInstancia());
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            controladoraPedido.ActualizarPedidos(dgvSalsa);    
        }
    }
}
