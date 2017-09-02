using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas.Models
{
    public class Publicacion
    {
        public int id { get; set; }
        //public List<Calificacion> calificacion { get; set; }
        public string mensaje { get; set; }
        public string fecha_publicacion { get; set; }
        public bool esta_activo { get; set; }
        public string propietario { get; set; }
        public int estado { get; set; }

        public override string ToString()
        {
            return $"{mensaje}";
        }
    }
}
