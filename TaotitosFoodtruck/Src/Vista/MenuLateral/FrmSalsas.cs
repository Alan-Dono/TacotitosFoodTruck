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


namespace TaotitosFoodtruck.Src.Vista
{
    public partial class FrmSalsas : Form
    {
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
            //dgvSalsa.AllowUserToAddRows = false;
            ingredienteController.ListaIngredientes(3,dgvSalsa);
        }

       
    }
}
