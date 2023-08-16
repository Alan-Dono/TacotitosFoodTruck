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
    public partial class FrmIngredientes : Form
    {
        private ControladoraIngredientes ingredienteController = ControladoraIngredientes.GetInstancia();

        private static FrmIngredientes instancia;
        public static FrmIngredientes GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new FrmIngredientes();
            }
            return instancia;
        }

        private FrmIngredientes()
        {
            InitializeComponent();
        }

        private void FrmIngredientes_Load(object sender, EventArgs e)
        {
            RefrescarTablaAlimentos();
        }
        private void RefrescarTablaAlimentos()
        {
           /* foreach(Ingrediente in ingredienteController.ListaIngredientes(2))
            {
                
            }*/
            //dgvTortilla.AllowUserToAddRows = false;
            ingredienteController.ListaIngredientes(2, dgvTortilla);
        }
    }
}
