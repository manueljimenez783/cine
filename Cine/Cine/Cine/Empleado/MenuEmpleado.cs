using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine
{
    public class MenuEmpleado
    {
        public void puestos(string puesto)
        {
            Console.WriteLine("Puestos");
        Console.WriteLine("1.-Proyector, 2.-Administrador, 3.-Cajero, 4.-Limpieza");
            int opc = Convert.ToInt32(Console.ReadLine());
            //
            switch(opc)
            {
                case 1:
                    {
                        puesto = "proyector";
                    }
                    break;
                case 2:
                    {
                        puesto = "Administrador";
                    }
                    break;
                case 3:
                    {
                        puesto = "Cajero";
                    }
                    break;
                case 4:
                    {
                        puesto = "Limpieza";
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Incorrecto");
                    }
                    break;
            }
        }
    }
}
