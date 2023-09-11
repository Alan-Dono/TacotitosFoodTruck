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
    public partial class FrmTortillas : Form, IFrmEnviable
    {
        private ControladoraIngredientes ingredienteController = ControladoraIngredientes.GetInstancia();
        private ControladoraFrm formController = ControladoraFrm.GetInstance();

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

        private void btnNuevaTortilla_Click(object sender, EventArgs e)
        {
            formController.AbrirIngredienteCrud("Tortilla", 1, this);
        }

        public void FrmClosed()
        {
            RefrescarTablaTortillas();
        }

        private void btnEliminarTortilla_Click(object sender, EventArgs e)
        {
            ingredienteController.EliminarIngrediente(Convert.ToInt32(dgvTortilla.SelectedRows[0].Cells[0].Value));
            RefrescarTablaTortillas();
        }

        private void btnModificarTortilla_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvTortilla.SelectedRows[0].Cells[0].Value); // Obtener el ID seleccionado en dgvSalsa
            Ingrediente ingrediente = ingredienteController.GetById(id); // Obtener el objeto Ingrediente
            formController.AbrirIngredienteCrud("Tortilla", ingrediente, this);
        }
    }
}
