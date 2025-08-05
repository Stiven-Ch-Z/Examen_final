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
    public partial class Ejercicio1 : Form
    {
        private logica_PromedioEstudiante logica = new logica_PromedioEstudiante();
        public Ejercicio1()
        {
            InitializeComponent();
        }
        private void Ejercicio1_Load(object sender, EventArgs e)
        {
            lbxpromedios.DrawItem += lbxpromedios_DrawItem; 
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close(); //cerrar 
        }
        private void lbxpromedios_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return; //si no hay item regresa

            string itemText = lbxpromedios.Items[e.Index].ToString();
            Color fondo = Color.White; //agarra el texto del item osea el promedio ingresado y se define el fondo preterminado como blanco

            if (itemText.Contains("Promedio:")) //si el item tiene la palabra promedio
            {
                int index = itemText.IndexOf("Promedio:") + 9;
                string promedioStr = itemText.Substring(index).Trim(); //luego busca el numero que viene despues del promedio

                if (decimal.TryParse(promedioStr, out decimal promedio)) //lo parsea a decimal
                {
                    fondo = logica_PromedioEstudiante.ColorPromedio(promedio); //y se llama la funcion de la logica para determinar que color va a cambiar el fondo del promedio
                }
            }
            using (SolidBrush backgroundBrush = new SolidBrush(fondo)) //usando el color que se obtuvo
            {
                e.Graphics.FillRectangle(backgroundBrush, e.Bounds);//lo pinta el fondo donde se encuentra el promedio
            }

            using (SolidBrush textBrush = new SolidBrush(Color.Black))//usando el color negro
            {
                e.Graphics.DrawString(itemText, e.Font, textBrush, e.Bounds); // se pinta el texto del promedio por que si no, no se muestra
            }

            
        }
        private bool Validarcampos()
        {
            bool esvalido = true; // aqui se crea la validacion y se pone que es true

            if (string.IsNullOrEmpty(txtnombre.Text) || (!System.Text.RegularExpressions.Regex.IsMatch(txtnombre.Text, @"^[a-zA-Z\s]+$"))) // aqui estan las validaciones tipicas si esta vacio o el nombre tiene numeros y si lo que se introdujo era un decimal o no
            {
                MessageBox.Show("Por favor agregue un nombre para el estudiante y valide que no tenga numeros", "No hay nombre para el estudiante o no es valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnombre.Focus();
                esvalido = false;
            }
            if (!decimal.TryParse(txtcalificacion1.Text, out decimal PrimerCalificacion) || PrimerCalificacion > 100 || PrimerCalificacion < 0)
            {
                MessageBox.Show("Por favor agregue una calificacion valida", "Problema con la calificacion 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcalificacion1.Focus();
                esvalido = false;
            }
            if (!decimal.TryParse(txtcalificacion2.Text, out decimal SegundaCalificacion) || SegundaCalificacion > 100 || SegundaCalificacion < 0)
            {
                MessageBox.Show("Por favor agregue una calificacion valida", "Problema con la calificacion 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcalificacion2.Focus();
                esvalido = false;
            }
            if (!decimal.TryParse(txtcalificacion3.Text, out decimal TerceraCalificacion) || TerceraCalificacion > 100 || TerceraCalificacion < 0)
            {
                MessageBox.Show("Por favor agregue una calificacion valida", "Problema con la calificacion 3", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcalificacion3.Focus();
                esvalido = false;
            }
            return esvalido; //si los campos estan con informacion correcta devuelve la validacion como true 
        }
        private void Limpiar()
        {
            txtnombre.Clear();
            txtcalificacion1.Clear(); // esto es pa limpiar los espacios
            txtcalificacion2.Clear();
            txtcalificacion3.Clear();
        }

        private void btnsacarpromedio_Click(object sender, EventArgs e)
        {
            if (!Validarcampos()) //si la validacion es false osea no se cumplio con algo devuelve al usuario
            {
                return;
            }
            string nombre = txtnombre.Text;
            decimal primercali = decimal.Parse(txtcalificacion1.Text);
            decimal segundacali = decimal.Parse(txtcalificacion2.Text); // se le da los valores al constructor de la clase
            decimal terceracali = decimal.Parse(txtcalificacion3.Text);

            Estudiante est = new Estudiante(nombre, primercali, segundacali, terceracali); //se crea un nuevo estudiante con los datos anteriores
            decimal Promedio = logica_PromedioEstudiante.CalcularPromedio(est); //se calcula el promedio con calcularpromedio de la capa logica 
            

            string resultado = $"Estudiante: {est.Nombre} - Promedio: {Promedio:F2}"; //se saca el resultado con el nombre y promedio del estudiante
            MessageBox.Show($"El promedio del estudiante {est.Nombre} es: {Promedio:F2} ", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar(); //se limpia todos los espacios
            lbxpromedios.Items.Add(resultado); //y se agrega los resultados al listbox
        }

        //y esto de aqui son la funcionalidad de los colordialog y eliminar los promedios del listbox
        private void elimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbxpromedios.SelectedIndex != -1)
            {
                lbxpromedios.Items.RemoveAt(lbxpromedios.SelectedIndex);
            }
        }

        private void cambiarColorDelFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cdmenu.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = cdmenu.Color;
            }
        }

        private void cambiarColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cdpromedio.ShowDialog() == DialogResult.OK)
            {
                lbxpromedios.BackColor = cdpromedio.Color;
            }
        }
    }
}
