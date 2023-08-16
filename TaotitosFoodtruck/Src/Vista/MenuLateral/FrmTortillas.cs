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
using TaotitosFoodtruck.Src.Modelo;

namespace TaotitosFoodtruck.Src.Vista
{
    public partial class FrmTortillas : Form
    {
        private ControladoraIngredientes ingredienteController = ControladoraIngredientes.GetInstancia();

        private static FrmTortillas instancia;
        public static FrmTortillas GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new FrmTortillas();
            }
            return instancia;
        }
        private FrmTortillas()
        {
            InitializeComponent();
        }
        private void FrmTortillas_Load(object sender, EventArgs e)
        {
            RefrescarTablaTortillas();
        }
        private void RefrescarTablaTortillas()
        {
            ingredienteController.llenarDgv(dgvTortilla, 1);
        }

   
    }
}
