namespace Examen_final
{
    partial class Ejercicio4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnvolver = new Button();
            btnagregar = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtnombre = new TextBox();
            lblnombre = new Label();
            lblduracion = new Label();
            lblgenero = new Label();
            lblclasificacion = new Label();
            lblcomentarios = new Label();
            txtduracion = new TextBox();
            txtgenero = new TextBox();
            txtclasificacion = new TextBox();
            txtcomentarios = new TextBox();
            chkmegusta = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnvolver
            // 
            btnvolver.BackColor = SystemColors.ControlLight;
            btnvolver.FlatStyle = FlatStyle.Popup;
            btnvolver.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnvolver.Location = new Point(591, 306);
            btnvolver.Margin = new Padding(3, 2, 3, 2);
            btnvolver.Name = "btnvolver";
            btnvolver.Size = new Size(107, 27);
            btnvolver.TabIndex = 9;
            btnvolver.Text = "Volver al menu";
            btnvolver.UseVisualStyleBackColor = false;
            btnvolver.Click += btnsalir_Click;
            // 
            // btnagregar
            // 
            btnagregar.BackColor = SystemColors.ControlLight;
            btnagregar.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnagregar.Location = new Point(464, 304);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(79, 29);
            btnagregar.TabIndex = 12;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(187, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(421, 220);
            dataGridView1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(249, 9);
            label1.Name = "label1";
            label1.Size = new Size(312, 28);
            label1.TabIndex = 14;
            label1.Text = "¡Busca tu pelicula 2025!🍿📽";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(3, 33);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 16;
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnombre.Location = new Point(3, 9);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(178, 21);
            lblnombre.TabIndex = 17;
            lblnombre.Text = "Nombre de tu pelicula:";
            // 
            // lblduracion
            // 
            lblduracion.AutoSize = true;
            lblduracion.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblduracion.Location = new Point(3, 66);
            lblduracion.Name = "lblduracion";
            lblduracion.Size = new Size(82, 21);
            lblduracion.TabIndex = 18;
            lblduracion.Text = "Duracion:";
            // 
            // lblgenero
            // 
            lblgenero.AutoSize = true;
            lblgenero.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblgenero.Location = new Point(3, 132);
            lblgenero.Name = "lblgenero";
            lblgenero.Size = new Size(69, 21);
            lblgenero.TabIndex = 19;
            lblgenero.Text = "Genero:";
            // 
            // lblclasificacion
            // 
            lblclasificacion.AutoSize = true;
            lblclasificacion.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblclasificacion.Location = new Point(3, 197);
            lblclasificacion.Name = "lblclasificacion";
            lblclasificacion.Size = new Size(110, 21);
            lblclasificacion.TabIndex = 20;
            lblclasificacion.Text = "Clasificacion:";
            // 
            // lblcomentarios
            // 
            lblcomentarios.AutoSize = true;
            lblcomentarios.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcomentarios.Location = new Point(3, 263);
            lblcomentarios.Name = "lblcomentarios";
            lblcomentarios.Size = new Size(109, 21);
            lblcomentarios.TabIndex = 21;
            lblcomentarios.Text = "Comentarios:";
            // 
            // txtduracion
            // 
            txtduracion.Location = new Point(3, 90);
            txtduracion.Name = "txtduracion";
            txtduracion.Size = new Size(100, 23);
            txtduracion.TabIndex = 22;
            // 
            // txtgenero
            // 
            txtgenero.Location = new Point(3, 158);
            txtgenero.Name = "txtgenero";
            txtgenero.Size = new Size(100, 23);
            txtgenero.TabIndex = 23;
            // 
            // txtclasificacion
            // 
            txtclasificacion.Location = new Point(3, 221);
            txtclasificacion.Name = "txtclasificacion";
            txtclasificacion.Size = new Size(100, 23);
            txtclasificacion.TabIndex = 24;
            // 
            // txtcomentarios
            // 
            txtcomentarios.Location = new Point(3, 287);
            txtcomentarios.Name = "txtcomentarios";
            txtcomentarios.Size = new Size(100, 23);
            txtcomentarios.TabIndex = 25;
            // 
            // chkmegusta
            // 
            chkmegusta.AutoSize = true;
            chkmegusta.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkmegusta.Location = new Point(139, 266);
            chkmegusta.Name = "chkmegusta";
            chkmegusta.Size = new Size(85, 19);
            chkmegusta.TabIndex = 26;
            chkmegusta.Text = "¡Me gusta!";
            chkmegusta.UseVisualStyleBackColor = true;
            // 
            // Ejercicio4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(700, 338);
            Controls.Add(chkmegusta);
            Controls.Add(txtcomentarios);
            Controls.Add(txtclasificacion);
            Controls.Add(txtgenero);
            Controls.Add(txtduracion);
            Controls.Add(lblcomentarios);
            Controls.Add(lblclasificacion);
            Controls.Add(lblgenero);
            Controls.Add(lblduracion);
            Controls.Add(lblnombre);
            Controls.Add(txtnombre);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnagregar);
            Controls.Add(btnvolver);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Ejercicio4";
            Text = "Ejercicio4cs";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnvolver;
        private Button btnagregar;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtnombre;
        private Label lblnombre;
        private Label lblduracion;
        private Label lblgenero;
        private Label lblclasificacion;
        private Label lblcomentarios;
        private TextBox txtduracion;
        private TextBox txtgenero;
        private TextBox txtclasificacion;
        private TextBox txtcomentarios;
        private CheckBox chkmegusta;
    }
}