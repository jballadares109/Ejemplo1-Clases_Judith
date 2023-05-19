namespace Ejemplo1_Clases
{
    partial class FrmProfesor
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
            this.GBox_DatoProfesor = new System.Windows.Forms.GroupBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelDir = new System.Windows.Forms.Label();
            this.labelTelf = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textDir = new System.Windows.Forms.TextBox();
            this.textTelf = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.GBox_DatoProfesor.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBox_DatoProfesor
            // 
            this.GBox_DatoProfesor.Controls.Add(this.btnGuardar);
            this.GBox_DatoProfesor.Controls.Add(this.textEmail);
            this.GBox_DatoProfesor.Controls.Add(this.btnCancel);
            this.GBox_DatoProfesor.Controls.Add(this.textTelf);
            this.GBox_DatoProfesor.Controls.Add(this.textDir);
            this.GBox_DatoProfesor.Controls.Add(this.textNom);
            this.GBox_DatoProfesor.Controls.Add(this.labelEmail);
            this.GBox_DatoProfesor.Controls.Add(this.labelTelf);
            this.GBox_DatoProfesor.Controls.Add(this.labelDir);
            this.GBox_DatoProfesor.Controls.Add(this.labelNom);
            this.GBox_DatoProfesor.Location = new System.Drawing.Point(87, 53);
            this.GBox_DatoProfesor.Name = "GBox_DatoProfesor";
            this.GBox_DatoProfesor.Size = new System.Drawing.Size(539, 234);
            this.GBox_DatoProfesor.TabIndex = 0;
            this.GBox_DatoProfesor.TabStop = false;
            this.GBox_DatoProfesor.Text = "Datos del Profesor";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(125, 31);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(44, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nombre";
            // 
            // labelDir
            // 
            this.labelDir.AutoSize = true;
            this.labelDir.Location = new System.Drawing.Point(125, 64);
            this.labelDir.Name = "labelDir";
            this.labelDir.Size = new System.Drawing.Size(52, 13);
            this.labelDir.TabIndex = 1;
            this.labelDir.Text = "Dirección";
            // 
            // labelTelf
            // 
            this.labelTelf.AutoSize = true;
            this.labelTelf.Location = new System.Drawing.Point(125, 105);
            this.labelTelf.Name = "labelTelf";
            this.labelTelf.Size = new System.Drawing.Size(49, 13);
            this.labelTelf.TabIndex = 2;
            this.labelTelf.Text = "Teléfono";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(125, 144);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email";
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(243, 24);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(174, 20);
            this.textNom.TabIndex = 4;
            // 
            // textDir
            // 
            this.textDir.Location = new System.Drawing.Point(243, 57);
            this.textDir.Name = "textDir";
            this.textDir.Size = new System.Drawing.Size(174, 20);
            this.textDir.TabIndex = 5;
            // 
            // textTelf
            // 
            this.textTelf.Location = new System.Drawing.Point(243, 98);
            this.textTelf.Name = "textTelf";
            this.textTelf.Size = new System.Drawing.Size(174, 20);
            this.textTelf.TabIndex = 6;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(243, 137);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(174, 20);
            this.textEmail.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(161, 193);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(360, 193);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GBox_DatoProfesor);
            this.Name = "FrmProfesor";
            this.Text = "FrmProfesor";
            this.GBox_DatoProfesor.ResumeLayout(false);
            this.GBox_DatoProfesor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBox_DatoProfesor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textTelf;
        private System.Windows.Forms.TextBox textDir;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTelf;
        private System.Windows.Forms.Label labelDir;
        private System.Windows.Forms.Label labelNom;
    }
}