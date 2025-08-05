using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Examen_final.Entidades
{
    public class Avatar
    {
        public string Nombre {  get; set; }
        public string Clase { get; set; } //los valores de la clase
        public string Genero { get; set; }

        public Avatar(string nombre, string clase, string genero) //constructor
        {
            Nombre = nombre;
            Clase = clase;  //y parametros de los atributos de la clase
            Genero = genero;
        }
        public string MensajeBienvenida() //y este es el mensaje que dira uilizando la clase y nombre seleccionados por el user
        {
            return $"¡Bienvenido {Clase} {Nombre}! Tu aventura esta por empezar.";

        }
    }
}
