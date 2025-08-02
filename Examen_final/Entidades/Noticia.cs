using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_final.Entidades
{
    public class Noticia
    {
        public string Categoria { get; set; }
               //las propiedades de la clases
        public string Titular { get; set; } 

        public Noticia(string categoria, string titular) //y el constructor de la noticia
        {
            Categoria = categoria;
            Titular = titular;  // los parametros de los atributos de la clase
        }
    }
}
