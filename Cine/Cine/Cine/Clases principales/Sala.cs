using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine
{
    public class Sala
    {
        public int Id { get; set; }
        public int NoSala { get; set; }
        public int CanidadAsientos { get; set; }
        public string Descripcion { get; set; }
        public string CodigoAsiento { get; set; }
        public collection<peliculas> { get; set; }

    }
}
