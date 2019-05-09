using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public TimeSpan Edad { get; set; }

        public TimeSpan Edades()
        {
            //DateTime.Today nos da el dia actual
            DateTime Hoy = DateTime.Today;
            Edad = Hoy - FechaNacimiento;
            return Edad;
        }
        public void puestos(string puesto)
        {

        }
    }
        
      
}
