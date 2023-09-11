using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaotitosFoodtruck.Src.Modelo;
using TaotitosFoodtruck.Src.Controladora;
using TaotitosFoodtruck.Src.Modelo.ClasesConcretas;
using System.Runtime.CompilerServices;
using TaotitosFoodtruck.Src.Interfaces;

namespace TaotitosFoodtruck.Src.Vista
{
    public partial class FrmSalsas : Form, IFrmEnviable
    {
        private ControladoraFrm fomrController = ControladoraFrm.GetInstance();
        private ControladoraIngredientes ingredienteController = ControladoraIngredientes.GetInstancia();
        private static FrmSalsas instancia;
        public static FrmSalsas GetInstancia()
        {
            if(instancia == null)
            {
                instancia = new FrmSalsas();
            }
            return instancia;
        }
        private FrmSalsas()
        {
            InitializeComponent();
 
        }

        private void FrmSalsas_Load(object sender, EventArgs e)
        {
            RefrescarTablaSalsa();
        }
        private void RefrescarTablaSalsa()
        {
            ingredienteController.llenarDgv(dgvSalsa, 3);
        }

        private void btnNuevaSalsa_Click(object sender, EventArgs e)
        {
            fomrController.AbrirIngredienteCrud("Salsa",3,this);
        }

        public void FrmClosed()
        {
            RefrescarTablaSalsa();
        }

        private void btnEliminarSalsa_Click(object sender, EventArgs e)
        {
            ingredienteController.EliminarIngrediente(Convert.ToInt32(dgvSalsa.SelectedRows[0].Cells[0].Value));
            RefrescarTablaSalsa();
        }

        private void btnModificarSalsa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvSalsa.SelectedRows[0].Cells[0].Value); // Obtener el ID seleccionado en dgvSalsa
            Ingrediente ingrediente = ingredienteController.GetById(id); // Obtener el objeto Ingrediente
            fomrController.AbrirIngredienteCrud("Salsa", ingrediente, this);
        }

    }
}

