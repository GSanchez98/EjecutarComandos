namespace EjecutarComandos
{
    partial class MetodosEscalares
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
            this.txtEscalar = new System.Windows.Forms.TextBox();
            this.lblTotalFilas = new System.Windows.Forms.Label();
            this.btnContarFilas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEscalar
            // 
            this.txtEscalar.Location = new System.Drawing.Point(128, 42);
            this.txtEscalar.Multiline = true;
            this.txtEscalar.Name = "txtEscalar";
            this.txtEscalar.Size = new System.Drawing.Size(234, 101);
            this.txtEscalar.TabIndex = 1;
            // 
            // lblTotalFilas
            // 
            this.lblTotalFilas.AutoSize = true;
            this.lblTotalFilas.Location = new System.Drawing.Point(12, 86);
            this.lblTotalFilas.Name = "lblTotalFilas";
            this.lblTotalFilas.Size = new System.Drawing.Size(93, 13);
            this.lblTotalFilas.TabIndex = 2;
            this.lblTotalFilas.Text = "Total de Registros";
            // 
            // btnContarFilas
            // 
            this.btnContarFilas.Location = new System.Drawing.Point(378, 81);
            this.btnContarFilas.Name = "btnContarFilas";
            this.btnContarFilas.Size = new System.Drawing.Size(127, 23);
            this.btnContarFilas.TabIndex = 3;
            this.btnContarFilas.Text = "Contar Registros";
            this.btnContarFilas.UseVisualStyleBackColor = true;
            this.btnContarFilas.Click += new System.EventHandler(this.btnContarFilas_Click);
            // 
            // MetodosEscalares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 175);
            this.Controls.Add(this.btnContarFilas);
            this.Controls.Add(this.lblTotalFilas);
            this.Controls.Add(this.txtEscalar);
            this.Name = "MetodosEscalares";
            this.Text = "Metodos Escalares";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEscalar;
        private System.Windows.Forms.Label lblTotalFilas;
        private System.Windows.Forms.Button btnContarFilas;
    }
}