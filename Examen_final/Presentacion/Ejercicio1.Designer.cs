namespace Examen_final
{
    partial class Ejercicio1
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
            lbltitulo = new Label();
            lbldescripcion = new Label();
            lblnombre = new Label();
            txtnombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbxpromedios = new ListBox();
            cmspromedios = new ContextMenuStrip(components);
            elimiToolStripMenuItem = new ToolStripMenuItem();
            txtcalificacion1 = new TextBox();
            txtcalificacion2 = new TextBox();
            txtcalificacion3 = new TextBox();
            btnsacarpromedio = new Button();
            cmsmenu = new ContextMenuStrip(components);
            cambiarColorDelFondoToolStripMenuItem = new ToolStripMenuItem();
            cdmenu = new ColorDialog();
            cdpromedio = new ColorDialog();
            cambiarColorToolStripMenuItem = new ToolStripMenuItem();
            cmspromedios.SuspendLayout();
            cmsmenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnsalir
            // 
            btnsalir.BackColor = Color.LightSalmon;
            btnsalir.FlatStyle = FlatStyle.Popup;
            btnsalir.Font = new Font("Microsoft JhengHei", 10F);
            btnsalir.Location = new Point(12, 396);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(149, 42);
            btnsalir.TabIndex = 8;
            btnsalir.Text = "Volver al menu";
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitulo.Location = new Point(231, 19);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(302, 29);
            lbltitulo.TabIndex = 9;
            lbltitulo.Text = "Calculadora de promedios";
            // 
            // lbldescripcion
            // 
            lbldescripcion.AutoSize = true;
            lbldescripcion.Font = new Font("Microsoft JhengHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbldescripcion.Location = new Point(218, 48);
            lbldescripcion.Name = "lbldescripcion";
            lbldescripcion.Size = new Size(331, 22);
            lbldescripcion.TabIndex = 10;
            lbldescripcion.Text = "Ingrese los datos para sacar el promedio";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Microsoft JhengHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnombre.Location = new Point(174, 86);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(82, 22);
            lblnombre.TabIndex = 11;
            lblnombre.Text = "Nombre:";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(262, 84);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(325, 27);
            txtnombre.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(174, 119);
            label1.Name = "label1";
            label1.Size = new Size(167, 22);
            label1.TabIndex = 13;
            label1.Text = "Primera Calificacion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(174, 153);
            label2.Name = "label2";
            label2.Size = new Size(177, 22);
            label2.TabIndex = 14;
            label2.Text = "Segunda Calificacion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(174, 184);
            label3.Name = "label3";
            label3.Size = new Size(165, 22);
            label3.TabIndex = 15;
            label3.Text = "Tercera Calificacion:";
            // 
            // lbxpromedios
            // 
            lbxpromedios.ContextMenuStrip = cmspromedios;
            lbxpromedios.DrawMode = DrawMode.OwnerDrawFixed;
            lbxpromedios.FormattingEnabled = true;
            lbxpromedios.Location = new Point(157, 227);
            lbxpromedios.Name = "lbxpromedios";
            lbxpromedios.Size = new Size(453, 144);
            lbxpromedios.TabIndex = 16;
            // 
            // cmspromedios
            // 
            cmspromedios.ImageScalingSize = new Size(20, 20);
            cmspromedios.Items.AddRange(new ToolStripItem[] { elimiToolStripMenuItem, cambiarColorToolStripMenuItem });
            cmspromedios.Name = "cmspromedios";
            cmspromedios.Size = new Size(211, 80);
            // 
            // elimiToolStripMenuItem
            // 
            elimiToolStripMenuItem.Name = "elimiToolStripMenuItem";
            elimiToolStripMenuItem.Size = new Size(202, 24);
            elimiToolStripMenuItem.Text = "Eliminar promedio";
            elimiToolStripMenuItem.Click += elimiToolStripMenuItem_Click;
            // 
            // txtcalificacion1
            // 
            txtcalificacion1.Location = new Point(357, 117);
            txtcalificacion1.Name = "txtcalificacion1";
            txtcalificacion1.Size = new Size(230, 27);
            txtcalificacion1.TabIndex = 17;
            // 
            // txtcalificacion2
            // 
            txtcalificacion2.Location = new Point(357, 153);
            txtcalificacion2.Name = "txtcalificacion2";
            txtcalificacion2.Size = new Size(230, 27);
            txtcalificacion2.TabIndex = 18;
            // 
            // txtcalificacion3
            // 
            txtcalificacion3.Location = new Point(357, 186);
            txtcalificacion3.Name = "txtcalificacion3";
            txtcalificacion3.Size = new Size(230, 27);
            txtcalificacion3.TabIndex = 19;
            // 
            // btnsacarpromedio
            // 
            btnsacarpromedio.BackColor = Color.FromArgb(128, 255, 128);
            btnsacarpromedio.FlatStyle = FlatStyle.Popup;
            btnsacarpromedio.Font = new Font("Microsoft JhengHei", 10F);
            btnsacarpromedio.Location = new Point(639, 396);
            btnsacarpromedio.Name = "btnsacarpromedio";
            btnsacarpromedio.Size = new Size(149, 42);
            btnsacarpromedio.TabIndex = 20;
            btnsacarpromedio.Text = "Sacar promedio";
            btnsacarpromedio.UseVisualStyleBackColor = false;
            btnsacarpromedio.Click += btnsacarpromedio_Click;
            // 
            // cmsmenu
            // 
            cmsmenu.ImageScalingSize = new Size(20, 20);
            cmsmenu.Items.AddRange(new ToolStripItem[] { cambiarColorDelFondoToolStripMenuItem });
            cmsmenu.Name = "cmsmenu";
            cmsmenu.Size = new Size(242, 28);
            // 
            // cambiarColorDelFondoToolStripMenuItem
            // 
            cambiarColorDelFondoToolStripMenuItem.Name = "cambiarColorDelFondoToolStripMenuItem";
            cambiarColorDelFondoToolStripMenuItem.Size = new Size(241, 24);
            cambiarColorDelFondoToolStripMenuItem.Text = "Cambiar color del fondo";
            cambiarColorDelFondoToolStripMenuItem.Click += cambiarColorDelFondoToolStripMenuItem_Click;
            // 
            // cambiarColorToolStripMenuItem
            // 
            cambiarColorToolStripMenuItem.Name = "cambiarColorToolStripMenuItem";
            cambiarColorToolStripMenuItem.Size = new Size(210, 24);
            cambiarColorToolStripMenuItem.Text = "Cambiar Color";
            cambiarColorToolStripMenuItem.Click += cambiarColorToolStripMenuItem_Click;
            // 
            // Ejercicio1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = cmsmenu;
            Controls.Add(btnsacarpromedio);
            Controls.Add(txtcalificacion3);
            Controls.Add(txtcalificacion2);
            Controls.Add(txtcalificacion1);
            Controls.Add(lbxpromedios);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtnombre);
            Controls.Add(lblnombre);
            Controls.Add(lbldescripcion);
            Controls.Add(lbltitulo);
            Controls.Add(btnsalir);
            Name = "Ejercicio1";
            Text = "Ejercicio1";
            Load += Ejercicio1_Load;
            cmspromedios.ResumeLayout(false);
            cmsmenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsalir;
        private Label lbltitulo;
        private Label lbldescripcion;
        private Label lblnombre;
        private TextBox txtnombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox lbxpromedios;
        private TextBox txtcalificacion1;
        private TextBox txtcalificacion2;
        private TextBox txtcalificacion3;
        private Button btnsacarpromedio;
        private ContextMenuStrip cmspromedios;
        private ToolStripMenuItem elimiToolStripMenuItem;
        private ContextMenuStrip cmsmenu;
        private ToolStripMenuItem cambiarColorDelFondoToolStripMenuItem;
        private ColorDialog cdmenu;
        private ColorDialog cdpromedio;
        private ToolStripMenuItem cambiarColorToolStripMenuItem;
    }
}