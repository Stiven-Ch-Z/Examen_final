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
            // Ejercicio5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnsalir);
            Name = "Ejercicio5";
            Text = "Ejercicio5";
            ResumeLayout(false);
        }

        #endregion

        private Button btnsalir;
    }
}