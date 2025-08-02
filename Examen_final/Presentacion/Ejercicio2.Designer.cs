namespace Examen_final
{
    partial class Ejercicio2
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
            label1 = new Label();
            cmbnoticia = new ComboBox();
            lblnoticia = new Label();
            lbltitulomenu = new Label();
            btnvernoti = new Button();
            SuspendLayout();
            // 
            // btnsalir
            // 
            btnsalir.BackColor = SystemColors.ControlLight;
            btnsalir.FlatStyle = FlatStyle.Popup;
            btnsalir.Font = new Font("Microsoft JhengHei", 10F);
            btnsalir.Location = new Point(12, 242);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(137, 42);
            btnsalir.TabIndex = 9;
            btnsalir.Text = "Volver al menu";
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 24);
            label1.Name = "label1";
            label1.Size = new Size(280, 29);
            label1.TabIndex = 10;
            label1.Text = "Noticiero de ultima hora";
            // 
            // cmbnoticia
            // 
            cmbnoticia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbnoticia.FormattingEnabled = true;
            cmbnoticia.Location = new Point(294, 139);
            cmbnoticia.Name = "cmbnoticia";
            cmbnoticia.Size = new Size(236, 28);
            cmbnoticia.TabIndex = 11;
            // 
            // lblnoticia
            // 
            lblnoticia.AutoSize = true;
            lblnoticia.BackColor = SystemColors.Control;
            lblnoticia.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnoticia.Location = new Point(203, 140);
            lblnoticia.Name = "lblnoticia";
            lblnoticia.Size = new Size(84, 23);
            lblnoticia.TabIndex = 12;
            lblnoticia.Text = "Noticias:";
            // 
            // lbltitulomenu
            // 
            lbltitulomenu.AutoSize = true;
            lbltitulomenu.BackColor = SystemColors.Control;
            lbltitulomenu.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitulomenu.Location = new Point(170, 53);
            lbltitulomenu.Name = "lbltitulomenu";
            lbltitulomenu.Size = new Size(448, 23);
            lbltitulomenu.TabIndex = 13;
            lbltitulomenu.Text = "Seleccione una noticia de ultima hora  de su interes";
            // 
            // btnvernoti
            // 
            btnvernoti.BackColor = SystemColors.ControlLight;
            btnvernoti.FlatStyle = FlatStyle.Popup;
            btnvernoti.Font = new Font("Microsoft JhengHei", 10F);
            btnvernoti.Location = new Point(639, 242);
            btnvernoti.Name = "btnvernoti";
            btnvernoti.Size = new Size(149, 42);
            btnvernoti.TabIndex = 14;
            btnvernoti.Text = "Ver noticia";
            btnvernoti.UseVisualStyleBackColor = false;
            btnvernoti.Click += btnvernoti_Click;
            // 
            // Ejercicio2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 308);
            Controls.Add(btnvernoti);
            Controls.Add(lbltitulomenu);
            Controls.Add(lblnoticia);
            Controls.Add(cmbnoticia);
            Controls.Add(label1);
            Controls.Add(btnsalir);
            Name = "Ejercicio2";
            Text = "Ejercicio2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsalir;
        private Label label1;
        private ComboBox cmbnoticia;
        private Label lblnoticia;
        private Label lbltitulomenu;
        private Button btnvernoti;
    }
}