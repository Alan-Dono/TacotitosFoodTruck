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


namespace TaotitosFoodtruck.Src.Vista
{
    public partial class FrmSalsas : Form
    {
        public FrmSalsas()
        {
            InitializeComponent();
        }

        private void FrmSalsas_Load(object sender, EventArgs e)
        {
            RefrescarTablaSalsa();
        }
        private void RefrescarTablaSalsa()
        {
            using (TacotitoDosEntities db = new TacotitoDosEntities()) // Reemplaza con tu contexto de base de datos
            {
                var listaSalsas = from salsa in db.Ingrediente
                                  where salsa.TipoIngredienteID == 3
                                  select new
                                  {
                                      salsa.ID,
                                      salsa.Nombre,
                                      
                                      salsa.Descripcion,
                                      salsa.Precio,
                                      
                                  };

                dgvSalsas.DataSource = listaSalsas.ToList();
            }
        }

       
    }
}
