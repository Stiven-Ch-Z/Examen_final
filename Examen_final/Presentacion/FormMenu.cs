
namespace Examen_final

{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnejercicioCalcu1_Click(object sender, EventArgs e)
        {
            Ejercicio1 calcu = new Ejercicio1();
            this.Hide();
            calcu.ShowDialog();
            this.Show();

        }

        private void btnejercicioNoti2_Click(object sender, EventArgs e)
        {
            Ejercicio2 noti = new Ejercicio2();
            this.Hide();
            noti.ShowDialog();
            this.Show();
        }

        private void btnejercicioMini3_Click(object sender, EventArgs e)
        {
            Ejercicio3 juego = new Ejercicio3();
            this.Hide();
            juego.ShowDialog();
            this.Show();
        }

        private void btnejercicioPelis4_Click(object sender, EventArgs e)
        {
            Ejercicio4 peli = new Ejercicio4();
            this.Hide();
            peli.ShowDialog();
            this.Show();
        }

        private void btnejercicioAvatar5_Click(object sender, EventArgs e)
        {
            Ejercicio5 avatar = new Ejercicio5();
            this.Hide();
            avatar.ShowDialog();
            this.Show();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea salir del programa?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
