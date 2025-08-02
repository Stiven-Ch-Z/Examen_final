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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
            cmbnoticia.Items.AddRange(new string[] { "Politica", "Deportes", "Tecnologia", "Clima" }); //se agregan las categorias al combo
            cmbnoticia.SelectedItem = 0;//al iniciar no va a esta seleccionado ninguna categoria
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close(); //cierra el form y abre y menu nuevamente
        }
        private bool combovacio()
        {
            if (cmbnoticia.SelectedItem == null) //validacion que verifica si el combo esta vacio
            {
                MessageBox.Show("Utilize la barra para seleccionar una noticia", "No hay noticia seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        private void btnvernoti_Click(object sender, EventArgs e)
        {
            if (combovacio()) //se llama la validacion y si se cumple no sigue el proceso
            return;
            string categoriaselect=cmbnoticia.SelectedItem.ToString(); //categoriaselect va a ser la categoria seleccionada en el combo por el user en 

            Noticia noticia=logica_Noticia.ObtenerNoticia(categoriaselect); //se va a crea una nueva noticia utilizando la logica obtenernoticia

            MessageBox.Show(noticia.Titular, $"Noticia de {noticia.Categoria}", MessageBoxButtons.OK, MessageBoxIcon.Information); //aqui se muestra la noticia con mesagebox

            DialogResult resultado= MessageBox.Show("¿Desea continuar viendo noticias?","¿Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //y aqui pregunta con mesagebox de si y no, si desea ver mas noticias y si dice que no cierra el form y devuelve al menu
            if (resultado == DialogResult.No)
            {
                this.Close();
            }
        }
    }
}
