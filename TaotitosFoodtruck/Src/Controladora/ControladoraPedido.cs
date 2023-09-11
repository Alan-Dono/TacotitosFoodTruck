using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaotitosFoodtruck.Src.Modelo;

namespace TaotitosFoodtruck.Src.Controladora
{
    public class ControladoraPedido
    {
        private List<Pedido> pedidos;
        private static ControladoraPedido instancia;
        private ControladoraPedido()
        {
            
        }
        public static ControladoraPedido getInstancia()
        {
            if (instancia == null)
            {
                instancia = new ControladoraPedido();
            }
            return instancia;
        }
        public List<Pedido> GetPedidos()
        {
            return pedidos;
        }
        
        public void ActualizarPedidos(DataGridView dgv)
        {
            using (TacotitoDosEntities db = new TacotitoDosEntities())
            {
                dgv.Rows.Clear();
                foreach (Pedido pedido in db.Pedido)
                {
                    {
                        int rowIndex = dgv.Rows.Add();
                        dgv.Rows[rowIndex].Cells[0].Value = pedido.ID;
                        dgv.Rows[rowIndex].Cells[1].Value = pedido.Fecha_Hora;
                        dgv.Rows[rowIndex].Cells[2].Value = pedido.Cliente.Nombre;
                        dgv.Rows[rowIndex].Cells[3].Value = pedido.ImporteTotal;
                    }
                }
            }
        }
        
    }
}
