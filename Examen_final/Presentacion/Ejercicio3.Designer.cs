namespace Examen_final
{
    partial class Ejercicio3
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
            components = new System.ComponentModel.Container();
            btnsalir = new Button();
            lblitulo = new Label();
            lbltitulodesc = new Label();
            btnjugar = new Button();
            cbojugada = new ComboBox();
            lbljugada = new Label();
            lblvictorias = new Label();
            lblempates = new Label();
            lblderrota = new Label();
            errorvacio = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorvacio).BeginInit();
            SuspendLayout();
            // 
            // btnsalir
            // 
            btnsalir.BackColor = SystemColors.ActiveBorder;
            btnsalir.FlatStyle = FlatStyle.Popup;
            btnsalir.Font = new Font("Microsoft JhengHei", 10F);
            btnsalir.Location = new Point(12, 396);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(149, 42);
            btnsalir.TabIndex = 9;
            btnsalir.Text = "Volver al menu";
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // lblitulo
            // 
            lblitulo.AutoSize = true;
            lblitulo.BackColor = SystemColors.Control;
            lblitulo.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblitulo.Location = new Point(277, 19);
            lblitulo.Name = "lblitulo";
            lblitulo.Size = new Size(249, 29);
            lblitulo.TabIndex = 10;
            lblitulo.Text = "Piedra, Papel y Tijeras";
            // 
            // lbltitulodesc
            // 
            lbltitulodesc.AutoSize = true;
            lbltitulodesc.BackColor = SystemColors.Control;
            lbltitulodesc.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitulodesc.Location = new Point(248, 48);
            lbltitulodesc.Name = "lbltitulodesc";
            lbltitulodesc.Size = new Size(307, 25);
            lbltitulodesc.TabIndex = 11;
            lbltitulodesc.Text = "Seleccione su jugada para jugar";
            // 
            // btnjugar
            // 
            btnjugar.BackColor = Color.LightGreen;
            btnjugar.FlatStyle = FlatStyle.Popup;
            btnjugar.Font = new Font("Microsoft JhengHei", 10F);
            btnjugar.Location = new Point(666, 396);
            btnjugar.Name = "btnjugar";
            btnjugar.Size = new Size(122, 42);
            btnjugar.TabIndex = 12;
            btnjugar.Text = "Jugar";
            btnjugar.UseVisualStyleBackColor = false;
            btnjugar.Click += btnjugar_Click;
            // 
            // cbojugada
            // 
            cbojugada.BackColor = SystemColors.HighlightText;
            cbojugada.DropDownStyle = ComboBoxStyle.DropDownList;
            cbojugada.FormattingEnabled = true;
            cbojugada.Items.AddRange(new object[] { "Piedra", "Papel", "Tijera" });
            cbojugada.Location = new Point(339, 151);
            cbojugada.Name = "cbojugada";
            cbojugada.Size = new Size(200, 28);
            cbojugada.TabIndex = 13;
            // 
            // lbljugada
            // 
            lbljugada.AutoSize = true;
            lbljugada.BackColor = SystemColors.Control;
            lbljugada.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbljugada.Location = new Point(254, 151);
            lbljugada.Name = "lbljugada";
            lbljugada.Size = new Size(79, 23);
            lbljugada.TabIndex = 14;
            lbljugada.Text = "Jugada: ";
            // 
            // lblvictorias
            // 
            lblvictorias.AutoSize = true;
            lblvictorias.BackColor = SystemColors.ActiveCaption;
            lblvictorias.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblvictorias.Location = new Point(148, 272);
            lblvictorias.Name = "lblvictorias";
            lblvictorias.Size = new Size(103, 23);
            lblvictorias.TabIndex = 15;
            lblvictorias.Text = "Victorias: 0";
            // 
            // lblempates
            // 
            lblempates.AutoSize = true;
            lblempates.BackColor = SystemColors.ActiveBorder;
            lblempates.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblempates.Location = new Point(339, 272);
            lblempates.Name = "lblempates";
            lblempates.Size = new Size(102, 23);
            lblempates.TabIndex = 16;
            lblempates.Text = "Empates: 0";
            // 
            // lblderrota
            // 
            lblderrota.AutoSize = true;
            lblderrota.BackColor = Color.LightSalmon;
            lblderrota.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblderrota.Location = new Point(529, 272);
            lblderrota.Name = "lblderrota";
            lblderrota.Size = new Size(103, 23);
            lblderrota.TabIndex = 17;
            lblderrota.Text = "Derrotas: 0";
            // 
            // errorvacio
            // 
            errorvacio.ContainerControl = this;
            // 
            // Ejercicio3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblderrota);
            Controls.Add(lblempates);
            Controls.Add(lblvictorias);
            Controls.Add(lbljugada);
            Controls.Add(cbojugada);
            Controls.Add(btnjugar);
            Controls.Add(lbltitulodesc);
            Controls.Add(lblitulo);
            Controls.Add(btnsalir);
            Name = "Ejercicio3";
            Text = "Ejercicio3";
            ((System.ComponentModel.ISupportInitialize)errorvacio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsalir;
        private Label lblitulo;
        private Label lbltitulodesc;
        private Button btnjugar;
        private ComboBox cbojugada;
        private Label lbljugada;
        private Label lblvictorias;
        private Label lblempates;
        private Label lblderrota;
        private ErrorProvider errorvacio;
    }
}