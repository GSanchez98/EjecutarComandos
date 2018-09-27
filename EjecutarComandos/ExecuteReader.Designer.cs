namespace EjecutarComandos
{
    partial class ExecuteReader
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
            this.txtExecuteReader = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtExecuteReader
            // 
            this.txtExecuteReader.Location = new System.Drawing.Point(12, 12);
            this.txtExecuteReader.Multiline = true;
            this.txtExecuteReader.Name = "txtExecuteReader";
            this.txtExecuteReader.Size = new System.Drawing.Size(454, 235);
            this.txtExecuteReader.TabIndex = 0;
            // 
            // ExecuteReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 259);
            this.Controls.Add(this.txtExecuteReader);
            this.Name = "ExecuteReader";
            this.Text = "ExecuteReader";
            this.Load += new System.EventHandler(this.ExecuteReader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExecuteReader;
    }
}