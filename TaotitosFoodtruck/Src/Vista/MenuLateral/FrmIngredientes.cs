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
using TaotitosFoodtruck.Src.Interfaces;
using TaotitosFoodtruck.Src.Modelo;

namespace TaotitosFoodtruck.Src.Vista
{
    public partial class FrmIngredientes : Form, IFrmEnviable
    {
        private ControladoraIngredientes ingredienteController = ControladoraIngredientes.GetInstancia();
        private ControladoraFrm formController = ControladoraFrm.GetInstance();

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
            ingredienteController.llenarDgv(dgvTortilla,2);
        }

        public void FrmClosed()
        {
            RefrescarTablaAlimentos();
        }

        private void btnNuevoAlimento_Click(object sender, EventArgs e)
        {
            formController.AbrirIngredienteCrud("Relleno", 2, this);
        }

        private void btnEliminarAlimento_Click(object sender, EventArgs e)
        {
            ingredienteController.EliminarIngrediente(Convert.ToInt32(dgvTortilla.SelectedRows[0].Cells[0].Value));
            RefrescarTablaAlimentos();
        }

        private void btnModificarAlimento_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvTortilla.SelectedRows[0].Cells[0].Value); // Obtener el ID seleccionado en dgvSalsa
            Ingrediente ingrediente = ingredienteController.GetById(id); // Obtener el objeto Ingrediente
            formController.AbrirIngredienteCrud("Relleno", ingrediente, this);
        }
    }
}
