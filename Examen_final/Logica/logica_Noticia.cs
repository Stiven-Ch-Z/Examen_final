using Examen_final.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_final.Logica
{
    public class logica_Noticia
    {
        public static Noticia ObtenerNoticia(string categoria)
        {

            switch(categoria) // utilizando la clase categoria y el switch
            {
                case "Politica": //dependiendo de lo este en el combo aqui por ejeplo Pölitica
                    return new Noticia("Politica", "Donald Trump dice que la lista de Eiptein es falsa y nunca exitio. ¿Sera que quiere esconder algo?.");//va regresar una nueva noticia de categoria politica y 
                                                                  //titular lo otro que esta entre parentesis
                case "Deportes":
                    return new Noticia("Deportes", "Fan interrumpe un momento de silencio durante un partido de football para dedicarle una hermosa palabra a Salvatierra.");
                case "Tecnologia":
                    return new Noticia("Tecnologia", "Se crea un robot en china que ayuda en todo lo que uno necesite y se puede comprar por tan solo 20 mil dolares.");
                case "Clima":
                    return new Noticia("Clima", "Los expertos del clima aseguran que hay un 90% de que hoy va a llover.");
                default:
                    return new Noticia("General", "No hay noticias disponibles.");
                    //y esta va a se la respuesta por defecto si no se detecta ninguna de las otras(en teoria esto nunca debe salir 
                    //ya que el combo no permite escribir y si se deja en blanco hay una validacion pero sin esto no sirve la funcion)
            }

        }
    }
}
