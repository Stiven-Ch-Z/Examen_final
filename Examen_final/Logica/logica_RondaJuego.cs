using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_final.Logica
{
    public class logica_RondaJuego
    {
        public string[] Opciones = { "Piedra", "Papel", "Tijera" };

        public string EleccionCPU { get; private set; }

        public string EvaluarJugada(string eleccionJugador) //la funcion para evaluar quien gano la ronda
        {
            Random rand = new Random(); //primero se crea un numero random
            EleccionCPU = Opciones[rand.Next(0, 3)]; //luego la eleccion de la cpu que va ser random en un rango de 0 a 3, 0 siendo piedra, 1 papel y 2 tijera
            if (eleccionJugador == EleccionCPU) //si la eleccion del jugador es igual al de la cpu va ser un empate
                return "Empate";
            if ((eleccionJugador == "Piedra" && EleccionCPU == "Tijera") || (eleccionJugador == "Papel" && EleccionCPU == "Piedra") || (eleccionJugador == "Tijera" && EleccionCPU == "Papel"))
                return "Victoria"; //si el jugador saca esa jugada que esta entre comillas y la cpu la otra jugada entre comillas va a ser una victoria
            else
                return "Derrota";//y las otras jugadas va a contar como derrota
        }
    }
}
