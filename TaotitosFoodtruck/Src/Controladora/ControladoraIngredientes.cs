using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics.Eventing.Reader;
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

        public List<Ingrediente> GetListaIngredientes()
        {
            return ingredientes;
        }

        public void ActualizarListaIngrediente()
        {
            using (TacotitoDosEntities db = new TacotitoDosEntities())
            {
                var lista = from ing in db.Ingrediente
                            select ing;
                ingredientes = lista.ToList();
            }
        }

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
        public void AltaModificacionIngrediente(string id, string nombre, int idTipo, string descripcion, decimal precio, int cantMax, bool esModificacion)
        {
            using (TacotitoDosEntities db = new TacotitoDosEntities())
            {
                Ingrediente ing = new Ingrediente
                {
                    Nombre = nombre,
                    TipoIngredienteID = idTipo,
                    Descripcion = descripcion,
                    Precio = precio,
                    CantidadMaxima = cantMax
                };
                if (esModificacion)
                {
                    ing.ID = Convert.ToInt32(id);
                    db.Entry(ing).State = EntityState.Modified;
                }
                else
                {
                    db.Ingrediente.Add(ing);
                }
                db.SaveChanges();
            }
            ActualizarListaIngrediente();
        }

        /*public void NuevoIngrediente(string nombre, int idTipo, string descripcion, decimal precio, int cantMax)
        {
            using (TacotitoDosEntities db = new TacotitoDosEntities())
            {
                Ingrediente ing = new Ingrediente
                {
                    Nombre = nombre,
                    TipoIngredienteID = idTipo,
                    Descripcion = descripcion,
                    Precio = precio,
                    CantidadMaxima = cantMax
                };
                db.Ingrediente.Add(ing);
                db.SaveChanges();
                // retornar 1 si fue exitoso (Hacer)
            }
            ActualizarListaIngrediente();
        }*/

        public void EliminarIngrediente(int id)
        {
            using (TacotitoDosEntities db =new TacotitoDosEntities())
            {
                Ingrediente ingredienteAEliminar = db.Ingrediente.FirstOrDefault(i => i.ID == id);

                if (ingredienteAEliminar != null)
                {
                    db.Ingrediente.Remove(ingredienteAEliminar); // Eliminar el ingrediente del contexto
                    db.SaveChanges(); // Guardar los cambios en la base de datos
                }
            }
            ActualizarListaIngrediente();
        }

        public Ingrediente GetById(int id)
        {
            using (TacotitoDosEntities db = new TacotitoDosEntities())
            {
                Ingrediente ingrediente = db.Ingrediente.FirstOrDefault(i => i.ID == id);
                return ingrediente;
            }
        }

    }
}
