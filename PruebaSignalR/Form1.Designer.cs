namespace PruebaSignalR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            btnEnviar = new Button();
            lstLista = new ListBox();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(49, 25);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(426, 31);
            txtNombre.TabIndex = 0;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(532, 25);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(112, 34);
            btnEnviar.TabIndex = 1;
            btnEnviar.Text = "Agregar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // lstLista
            // 
            lstLista.FormattingEnabled = true;
            lstLista.ItemHeight = 25;
            lstLista.Location = new Point(48, 84);
            lstLista.Name = "lstLista";
            lstLista.Size = new Size(472, 304);
            lstLista.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstLista);
            Controls.Add(btnEnviar);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Button btnEnviar;
        private ListBox lstLista;
    }
}
