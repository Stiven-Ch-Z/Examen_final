using Examen_final.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Examen_final
{
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            //validaciones 
            if (string.IsNullOrEmpty(txtnombre.Text) || (!System.Text.RegularExpressions.Regex.IsMatch(txtnombre.Text, @"^[a-zA-Z\s]+$")))
            {
                MessageBox.Show("Por favor ingresa el nombre del personaje o verifica que solo tenga letras.", "Error con el nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //si no hay nombre o se introduce numeros en el nombre dice lo del messagebox y devuelve
            }
            if (cboclase.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione una clase para continuar.", "Error con la clase", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // si el combo esta vacio lo mismo
            }
            if (!rdbfemale.Checked && !rdbmale.Checked)
            {
                MessageBox.Show("Por favor seleccione una genero para continuar.", "Error con el genero", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //si no se selecciona un genero lo mismo
            }
            string genero = rdbfemale.Checked ? "Masculino" : "Femenino"; //dependiendo de lo seleccionado por el user se crea el genero

            Avatar nuevo = new Avatar(txtnombre.Text, cboclase.SelectedItem.ToString(), genero); //crea un nuevo avatar utilizando los datos anteriores

            MessageBox.Show(nuevo.MensajeBienvenida(), "Creacion de personaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //muestra el mensaje con el nombre y la clase del personaje creado


        }
        private void CambiarColores(Control parent, Color backColor, Color foreColor) //se crea la funcion para cambiar los colores
         // utilizando el control parent
        {
            parent.BackColor = backColor;//esto es color del fondo de contralador
            parent.ForeColor = foreColor;//y esto el color del texto del controlador

            foreach (Control control in parent.Controls) //aqui se recorre los controles uno por uno utilizando la lista que tiene el parent.control
            {
                CambiarColores(control, backColor, foreColor);//y de manera recursiva la funcion se llama asi misma para procesar subcontroles
            }
        }
        private void chboscuro_CheckedChanged(object sender, EventArgs e)
        {
            if (chboscuro.Checked)
            {
                CambiarColores(this, Color.Black, Color.White); // ahora aqui si esta marcado el checkbox
                                                                // se cambia el color del fondo a negro y el texto cambia a blanco
            }
            else
            {
                CambiarColores(this, SystemColors.Control, Color.Black); // y si no lo esta el form va a lucir normal
            }
        }

        

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            cboclase.SelectedIndex = -1;
            rdbfemale.Checked = false; // y la funcion de limpiar los campos
            rdbmale.Checked = false;
            chboscuro.Checked = false;
        }
    }
}
