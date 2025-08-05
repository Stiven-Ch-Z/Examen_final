namespace Examen_final
{
    partial class Ejercicio5
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
            btnsalir = new Button();
            lblmenu = new Label();
            lbltitulomenu = new Label();
            lblnombre = new Label();
            txtnombre = new TextBox();
            cboclase = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblclase = new Label();
            rdbmale = new RadioButton();
            rdbfemale = new RadioButton();
            lblgenero = new Label();
            chboscuro = new CheckBox();
            btnlimpiar = new Button();
            btncrear = new Button();
            grbgenero = new GroupBox();
            grbgenero.SuspendLayout();
            SuspendLayout();
            // 
            // btnsalir
            // 
            btnsalir.BackColor = SystemColors.ControlLight;
            btnsalir.FlatStyle = FlatStyle.Popup;
            btnsalir.Font = new Font("Microsoft JhengHei", 10F);
            btnsalir.Location = new Point(639, 396);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(149, 42);
            btnsalir.TabIndex = 9;
            btnsalir.Text = "Volver al menu";
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // lblmenu
            // 
            lblmenu.AutoSize = true;
            lblmenu.BackColor = SystemColors.Control;
            lblmenu.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblmenu.Location = new Point(256, 9);
            lblmenu.Name = "lblmenu";
            lblmenu.Size = new Size(261, 29);
            lblmenu.TabIndex = 10;
            lblmenu.Text = "Bienvenido aventurero";
            // 
            // lbltitulomenu
            // 
            lbltitulomenu.AutoSize = true;
            lbltitulomenu.BackColor = SystemColors.Control;
            lbltitulomenu.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitulomenu.Location = new Point(177, 38);
            lbltitulomenu.Name = "lbltitulomenu";
            lbltitulomenu.Size = new Size(430, 23);
            lbltitulomenu.TabIndex = 11;
            lbltitulomenu.Text = "Para comenzar con su aventura cree su personaje";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.BackColor = SystemColors.Control;
            lblnombre.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnombre.Location = new Point(106, 155);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(204, 23);
            lblnombre.TabIndex = 12;
            lblnombre.Text = "Nombre del personaje:";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(326, 154);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(358, 27);
            txtnombre.TabIndex = 13;
            // 
            // cboclase
            // 
            cboclase.DropDownStyle = ComboBoxStyle.DropDownList;
            cboclase.FormattingEnabled = true;
            cboclase.Items.AddRange(new object[] { "Mago", "Guerrero", "Arquero" });
            cboclase.Location = new Point(326, 198);
            cboclase.Name = "cboclase";
            cboclase.Size = new Size(209, 28);
            cboclase.TabIndex = 14;
            // 
            // lblclase
            // 
            lblclase.AutoSize = true;
            lblclase.BackColor = SystemColors.Control;
            lblclase.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblclase.Location = new Point(132, 203);
            lblclase.Name = "lblclase";
            lblclase.Size = new Size(178, 23);
            lblclase.TabIndex = 15;
            lblclase.Text = "Clase del personaje:";
            // 
            // rdbmale
            // 
            rdbmale.AutoSize = true;
            rdbmale.Location = new Point(0, 26);
            rdbmale.Name = "rdbmale";
            rdbmale.Size = new Size(97, 24);
            rdbmale.TabIndex = 16;
            rdbmale.TabStop = true;
            rdbmale.Text = "Masculino";
            rdbmale.UseVisualStyleBackColor = true;
            // 
            // rdbfemale
            // 
            rdbfemale.AutoSize = true;
            rdbfemale.Location = new Point(103, 26);
            rdbfemale.Name = "rdbfemale";
            rdbfemale.Size = new Size(95, 24);
            rdbfemale.TabIndex = 17;
            rdbfemale.TabStop = true;
            rdbfemale.Text = "Femenino";
            rdbfemale.UseVisualStyleBackColor = true;
            // 
            // lblgenero
            // 
            lblgenero.AutoSize = true;
            lblgenero.BackColor = SystemColors.Control;
            lblgenero.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblgenero.Location = new Point(132, 255);
            lblgenero.Name = "lblgenero";
            lblgenero.Size = new Size(195, 23);
            lblgenero.TabIndex = 18;
            lblgenero.Text = "Genero del personaje:";
            // 
            // chboscuro
            // 
            chboscuro.AutoSize = true;
            chboscuro.Location = new Point(679, 9);
            chboscuro.Name = "chboscuro";
            chboscuro.Size = new Size(119, 24);
            chboscuro.TabIndex = 19;
            chboscuro.Text = "Modo oscuro";
            chboscuro.UseVisualStyleBackColor = true;
            chboscuro.CheckedChanged += chboscuro_CheckedChanged;
            // 
            // btnlimpiar
            // 
            btnlimpiar.BackColor = SystemColors.ControlLight;
            btnlimpiar.FlatStyle = FlatStyle.Popup;
            btnlimpiar.Font = new Font("Microsoft JhengHei", 10F);
            btnlimpiar.Location = new Point(313, 396);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(149, 42);
            btnlimpiar.TabIndex = 20;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // btncrear
            // 
            btncrear.BackColor = SystemColors.ControlLight;
            btncrear.FlatStyle = FlatStyle.Popup;
            btncrear.Font = new Font("Microsoft JhengHei", 10F);
            btncrear.Location = new Point(12, 396);
            btncrear.Name = "btncrear";
            btncrear.Size = new Size(149, 42);
            btncrear.TabIndex = 21;
            btncrear.Text = "Crear personaje";
            btncrear.UseVisualStyleBackColor = false;
            btncrear.Click += btncrear_Click;
            // 
            // grbgenero
            // 
            grbgenero.Controls.Add(rdbmale);
            grbgenero.Controls.Add(rdbfemale);
            grbgenero.Location = new Point(333, 232);
            grbgenero.Name = "grbgenero";
            grbgenero.Size = new Size(202, 51);
            grbgenero.TabIndex = 22;
            grbgenero.TabStop = false;
            // 
            // Ejercicio5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbgenero);
            Controls.Add(btncrear);
            Controls.Add(btnlimpiar);
            Controls.Add(chboscuro);
            Controls.Add(lblgenero);
            Controls.Add(lblclase);
            Controls.Add(cboclase);
            Controls.Add(txtnombre);
            Controls.Add(lblnombre);
            Controls.Add(lbltitulomenu);
            Controls.Add(lblmenu);
            Controls.Add(btnsalir);
            Name = "Ejercicio5";
            Text = "Ejercicio5";
            grbgenero.ResumeLayout(false);
            grbgenero.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsalir;
        private Label lblmenu;
        private Label lbltitulomenu;
        private Label lblnombre;
        private TextBox txtnombre;
        private ComboBox cboclase;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblclase;
        private RadioButton rdbmale;
        private RadioButton rdbfemale;
        private Label lblgenero;
        private CheckBox chboscuro;
        private Button btnlimpiar;
        private Button btncrear;
        private GroupBox grbgenero;
    }
}