namespace cliente3
{
    partial class frmCliente
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(197, 29);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(197, 214);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 43);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(179, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtChat
            // 
            this.txtChat.AllowDrop = true;
            this.txtChat.Location = new System.Drawing.Point(12, 69);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChat.Size = new System.Drawing.Size(260, 131);
            this.txtChat.TabIndex = 3;
            // 
            // txtEnviar
            // 
            this.txtEnviar.Location = new System.Drawing.Point(12, 214);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(179, 20);
            this.txtEnviar.TabIndex = 4;
            // 
            // frmCliente
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtEnviar);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnConectar);
            this.Name = "frmCliente";
            this.Text = "Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.TextBox txtEnviar;
    }
}

