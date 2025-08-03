using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_final.Entidades
{
    public class EleccionJugador
    {
        public string Eleccion {  get; set; }  //valor de la clase

        public  EleccionJugador (string eleccion)//constructor de la clase
        {
            Eleccion = eleccion; //parametros de los valores de la clase
        }
    }
}
