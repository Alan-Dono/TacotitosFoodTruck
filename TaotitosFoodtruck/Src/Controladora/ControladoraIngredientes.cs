using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaotitosFoodtruck.Src.Modelo;
namespace TaotitosFoodtruck.Src.Controladora
{
    public class ControladoraIngredientes
    {
        private List<Ingrediente> ingredientes;
        private static ControladoraIngredientes instancia;
        public static ControladoraIngredientes GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new ControladoraIngredientes();
            }
            return instancia;
        }
        private ControladoraIngredientes() { }


        public void ListaIngredientes(int idColumna, DataGridView dgv)
        {
            using (TacotitoDosEntities db = new TacotitoDosEntities())
            {
                var listaSalsas = from salsa in db.Ingrediente
                                  where salsa.TipoIngredienteID == idColumna
                                  select new
                                  {
                                      salsa.ID,
                                      salsa.Nombre,
                                      salsa.Descripcion,
                                      salsa.Precio,
                                  };
                dgv.DataSource = listaSalsas.ToList();
            }
        }
        public void NuevoIngrediente()
    }
}
