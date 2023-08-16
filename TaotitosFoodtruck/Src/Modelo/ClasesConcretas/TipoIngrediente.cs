using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaotitosFoodtruck.Src.Modelo.ClasesConcretas
{
    public class TipoIngrediente
    {
        private int _id;
        private string _nombre;

        public TipoIngrediente(int id,string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
    }
}
