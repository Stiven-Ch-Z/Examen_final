using Examen_final.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_final.Logica
{
    public class logica_PromedioEstudiante
    {
        public static decimal CalcularPromedio(Estudiante est) // la logica del promedio que es tomar las 3 notas de la clase y sumarlas entre si y luego dividir el resultado entre 3
        {
            return (est.PrimerCalificacion + est.SegundaCalificacion + est.TerceraCalificacion) / 3; 
        }
        public static Color ColorPromedio(decimal Promedio)// aqui dependiendo del promedio se cambia el color con las condicionales
        {
            if (Promedio >= 70)
            {
                return Color.Green;
            }
            else if (Promedio >= 60)
            {
                return Color.Yellow;
            }
            else
            {
                return Color.Red;
            }
        }
    }
}
