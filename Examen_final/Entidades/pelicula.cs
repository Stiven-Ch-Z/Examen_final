using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_final.Entidades
{
    public class Pelicula
    {   //propiedades que almacenan datos de la pelicula
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public int Duracion { get; set; }
        public int Clasificacion { get; set; }
        //constructor de la clase pelicula
        public Pelicula(string nombre, string genero, int duracion, int clasificacion)
        {// asigna datos de la pelicula
            Nombre = nombre;
            Genero = genero;
            Duracion = duracion;
            Clasificacion = clasificacion;
        }
    }  
    public class PeliculaRecomendada : Pelicula//clase que tiene herencia
    {     
        public bool Esfavorita { get; set; }//propiedad que indica si la peli es favorita
        public string Comentario { get; set; }//propiedad que almacena un comentario de la pelicula
         // constructor de laa clase pelicularecomendada que inicia
        public PeliculaRecomendada(string nombre, string genero, int duracion, int clasificacion, bool esFavorita, string comentario)//ace el llamado al constructor
            : base(nombre, genero, duracion, clasificacion)//hace llamado al constructor
        {
            Esfavorita = esFavorita;//marca si la peli esta selecconadasi te gusta
           Comentario = comentario;//da el comentario de la peloi
        }
        //nos da la opcion de recomendacion si es para adulto,niño o adolecente
        public string RecomendadaPara
        {
            get
            {      //Clasificacion de edades
                if (Clasificacion <= 7)
                    return "niños";
                else if (Clasificacion <= 13)
                    return "adolecentes";
                else
                    return "adultos";



            }
        }
    }
}