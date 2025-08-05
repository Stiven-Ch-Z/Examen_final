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

namespace Examen_final
{
    public partial class Ejercicio4 : Form
    {
        private List<PeliculaRecomendada> peliculas = new List<PeliculaRecomendada>();//lista que almacena pbjrtos como peliculas
        public Ejercicio4()//constructor de la clase
        {
            InitializeComponent();//innicia 
            dataGridView1.AutoGenerateColumns = true;//crea las columnas del data
        }


        private void btnagregar_Click(object sender, EventArgs e)//hace funcionar al boton
        {
             //validaciones de campos
            if(string.IsNullOrWhiteSpace(txtnombre.Text)||
               string.IsNullOrWhiteSpace(txtgenero.Text)||
               !int.TryParse(txtduracion.Text, out int duracion)||
               !int.TryParse(txtclasificacion.Text, out int clasificacion))
            { //mensaje por si se llenan de manera incorrecta el formulario
            MessageBox.Show("por favor complete los campos");
            return; //retorna
            }
            var pelicula = new PeliculaRecomendada(//instancia de pelicula recomendada con los datos guardados
                //datos de la pelicula
                txtnombre.Text,
                txtgenero.Text,
                duracion,
                clasificacion,
                chkmegusta.Checked,
                txtcomentarios.Text
            );
                    //agrega la pelicula a la listaa
            peliculas.Add( pelicula );
            dataGridView1.DataSource = null;
            dataGridView1.DataSource= peliculas;
            //limpia los campos
            txtnombre.Clear();
            txtgenero.Clear();
            txtduracion.Clear();
            txtclasificacion.Clear();
            chkmegusta.Checked = false;
            txtcomentarios.Clear();
        }
         //para salir
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
