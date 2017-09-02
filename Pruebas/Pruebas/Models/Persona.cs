using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas.Models
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Pais { get; set; }

        public override string ToString()
        {
            return $"{Nombre} | {Pais}";
        }
    }
}
