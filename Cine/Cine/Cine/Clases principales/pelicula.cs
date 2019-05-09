using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine
{
    public class pelicula
    {
        public int Id { get; set; }
        public string titulo { get; set; }
        public TimeSpan duracion { get; set; }
        public string clasificacion { get; set; }
        public Horario HoraInicio { get; set; }
        public Sala sala { get; set; }
        public int salald { get; set; }

      

    }
}
