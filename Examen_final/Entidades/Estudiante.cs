using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_final.Entidades
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public decimal PrimerCalificacion { get; set; }
        public decimal SegundaCalificacion { get; set; } //se crea los valores que tiene la clase 
        public decimal TerceraCalificacion { get; set; }

       public Estudiante(string nombre, decimal primercali,decimal segundacali,decimal terceracali )
        {
            Nombre = nombre;
            PrimerCalificacion = primercali;
            SegundaCalificacion= segundacali; //y este es el contructor de la clase
            TerceraCalificacion = terceracali;

        }
    }
}
