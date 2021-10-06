using ConsoleApp1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Negocio
{
    class NClsCajero
    {

        public String SacarDinero(ClsCajero constructor)
        {

            if (constructor.Dato % 5 == 0)

            {

                return " Puedes sacar tu dinero";
            }

            else
            {
                return " No puedes retirar tu dinero ";
            }
        }
    }
}
    
