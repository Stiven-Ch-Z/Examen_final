using Examen_final.Entidades;
using Examen_final.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_final
{
    public partial class Ejercicio3 : Form
    {
            int victorias = 0;
            int empates = 0; //aqui se definen los enteros que representan la cantidad de veces que se gana, pierde y empata
            int derrotas = 0;
        public Ejercicio3()
        {
            InitializeComponent();
            
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close(); //salir
        }

        private void btnjugar_Click(object sender, EventArgs e)
        {
            if (cbojugada.SelectedIndex == -1)
            {
                errorvacio.SetError(cbojugada, "Seleccione su jugada para continuar"); //si el combo esta vacio dice esto en el errorprovader y no continua
                return;
            }
            errorvacio.Clear(); //si esta lleno el combo, se limpia el error
            EleccionJugador jugador = new EleccionJugador(cbojugada.SelectedItem.ToString()); //se crea un nuevo jugador con su eleccion en la clase eleccionjugador
            logica_RondaJuego ronda = new logica_RondaJuego();//y se crea una nueva ronda en la clase logica ronda

            string resultado = ronda.EvaluarJugada(jugador.Eleccion);//resultado va a utilizar el evaluarjugada basandose en lo que jugo el jugador
            switch(resultado) 
            {
                case "Victoria": //si es victoria se suma un punto en el entero de victoria
                    victorias++;
                    break;
                case "Empate": //lo mismo pero con empate
                    empates++; 
                    break;
                case "Derrota": //lo mismo pero con derrota
                    derrotas++; 
                    break;
            }
            MessageBox.Show($"Jugador: {jugador.Eleccion}\n" + $"Rival: {ronda.EleccionCPU}\n" + $"Conclusion: {resultado}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cbojugada.SelectedItem = null;
            lblvictorias.Text = $"Victorias: {victorias}"; 
            lblempates.Text = $"Empates: {empates}"; 
            lblderrota.Text = $"Derrotas: {derrotas}";
            // y aqui se muestra un messagebox con el resultado de la jugada, se limpia de combo y se actualiza los label con 
            //con el resultado de la partida
        }
    }
}
