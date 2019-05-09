using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine
{
  public  class MenuCliente
    {
        public void Tipo(string tipocliente)
        {
            Console.WriteLine("Clientes");
            Console.WriteLine("1.-Adulto, 2.-Niño, 3.-3ra Edad");
            int opc = Convert.ToInt32(Console.ReadLine());
            //
            switch(opc)
            {
                case 1:
                    {
                        tipocliente="Adulto";
                    }
                    break;
                case 2:
                    {
                        tipocliente = "Niño";
                    }
                    break;
                case 3:
                    {
                        tipocliente = "3ra Edad";
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
