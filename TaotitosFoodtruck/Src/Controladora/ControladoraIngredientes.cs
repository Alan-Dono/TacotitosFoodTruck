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
        private ControladoraIngredientes()
        {
            ActualizarListaIngrediente();
        }

        //usar este... terminar
        public List<Ingrediente> GetListaIngredientes()
        {
            return ingredientes;
        }

        //usar este... terminar
        private void ActualizarListaIngrediente()
        {
            using (TacotitoDosEntities db = new TacotitoDosEntities())
            {
                var lista = from ing in db.Ingrediente
                            select ing;
                ingredientes = lista.ToList();
            }
        }
/*        public List<Ingrediente> ActualizarListaIngrediente(int id)
        {
            using (TacotitoDosEntities db = new TacotitoDosEntities())
            {
                var lista = from ing in db.Ingrediente
                            where ing.TipoIngrediente.ID == id
                            select ing;
                ingredientes = lista.ToList();
                return ingredientes;
            }
        }*/

        //usar este... terminar
        public void llenarDgv(DataGridView dgv, int id)
        {
            dgv.Rows.Clear();
            foreach (Ingrediente ingrediente in ingredientes)
            {
                if (ingrediente.TipoIngredienteID == id)
                {
                    int rowIndex = dgv.Rows.Add();
                    dgv.Rows[rowIndex].Cells[0].Value = ingrediente.ID;
                    dgv.Rows[rowIndex].Cells[1].Value = ingrediente.Nombre;
                    dgv.Rows[rowIndex].Cells[2].Value = ingrediente.Descripcion;
                    dgv.Rows[rowIndex].Cells[3].Value = ingrediente.Precio;
                }              
            }
        }

/*        public void llenarDgv(DataGridView dgv)
        {
            dgv.Rows.Clear();
            foreach (Ingrediente ingrediente in ingredientes)
            {
                int rowIndex = dgv.Rows.Add();
                dgv.Rows[rowIndex].Cells[0].Value = ingrediente.ID;
                dgv.Rows[rowIndex].Cells[1].Value = ingrediente.Nombre;
                dgv.Rows[rowIndex].Cells[2].Value = ingrediente.Descripcion;
                dgv.Rows[rowIndex].Cells[3].Value = ingrediente.Precio;
            }
        }*/
        /*public List<Ingrediente> GetListaIngrediente(int id)
        {
            //ActualizarListaIngrediente(id);
            return ingredientes;
        }
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
        }*/
    }
}
