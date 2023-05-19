namespace Ejemplo1_Clases
{
    partial class FrmCentro
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
            this.GBox_DatosCentro = new System.Windows.Forms.GroupBox();
            this.label_Nom = new System.Windows.Forms.Label();
            this.label_Direc = new System.Windows.Forms.Label();
            this.label_Telf = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textTelf = new System.Windows.Forms.TextBox();
            this.textDir = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.GBox_DatosCentro.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBox_DatosCentro
            // 
            this.GBox_DatosCentro.Controls.Add(this.Btn_Cancel);
            this.GBox_DatosCentro.Controls.Add(this.Btn_Guardar);
            this.GBox_DatosCentro.Controls.Add(this.textEmail);
            this.GBox_DatosCentro.Controls.Add(this.textDir);
            this.GBox_DatosCentro.Controls.Add(this.textTelf);
            this.GBox_DatosCentro.Controls.Add(this.textNom);
            this.GBox_DatosCentro.Controls.Add(this.label_Email);
            this.GBox_DatosCentro.Controls.Add(this.label_Telf);
            this.GBox_DatosCentro.Controls.Add(this.label_Direc);
            this.GBox_DatosCentro.Controls.Add(this.label_Nom);
            this.GBox_DatosCentro.Location = new System.Drawing.Point(56, 57);
            this.GBox_DatosCentro.Name = "GBox_DatosCentro";
            this.GBox_DatosCentro.Size = new System.Drawing.Size(422, 234);
            this.GBox_DatosCentro.TabIndex = 0;
            this.GBox_DatosCentro.TabStop = false;
            this.GBox_DatosCentro.Text = "Datos del Centro";
            this.GBox_DatosCentro.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label_Nom
            // 
            this.label_Nom.AutoSize = true;
            this.label_Nom.Location = new System.Drawing.Point(49, 38);
            this.label_Nom.Name = "label_Nom";
            this.label_Nom.Size = new System.Drawing.Size(44, 13);
            this.label_Nom.TabIndex = 0;
            this.label_Nom.Text = "Nombre";
            this.label_Nom.Click += new System.EventHandler(this.label_Nom_Click);
            // 
            // label_Direc
            // 
            this.label_Direc.AutoSize = true;
            this.label_Direc.Location = new System.Drawing.Point(49, 70);
            this.label_Direc.Name = "label_Direc";
            this.label_Direc.Size = new System.Drawing.Size(52, 13);
            this.label_Direc.TabIndex = 1;
            this.label_Direc.Text = "Dirección";
            // 
            // label_Telf
            // 
            this.label_Telf.AutoSize = true;
            this.label_Telf.Location = new System.Drawing.Point(49, 103);
            this.label_Telf.Name = "label_Telf";
            this.label_Telf.Size = new System.Drawing.Size(49, 13);
            this.label_Telf.TabIndex = 2;
            this.label_Telf.Text = "Teléfono";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(49, 133);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(32, 13);
            this.label_Email.TabIndex = 3;
            this.label_Email.Text = "Email";
            this.label_Email.Click += new System.EventHandler(this.label_Email_Click);
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(132, 38);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(199, 20);
            this.textNom.TabIndex = 4;
            // 
            // textTelf
            // 
            this.textTelf.Location = new System.Drawing.Point(132, 103);
            this.textTelf.Name = "textTelf";
            this.textTelf.Size = new System.Drawing.Size(199, 20);
            this.textTelf.TabIndex = 5;
            // 
            // textDir
            // 
            this.textDir.Location = new System.Drawing.Point(132, 67);
            this.textDir.Name = "textDir";
            this.textDir.Size = new System.Drawing.Size(199, 20);
            this.textDir.TabIndex = 6;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(132, 133);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(199, 20);
            this.textEmail.TabIndex = 7;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(85, 180);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Guardar.TabIndex = 8;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(242, 180);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 9;
            this.Btn_Cancel.Text = "Cancelar";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // FrmCentro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.GBox_DatosCentro);
            this.Name = "FrmCentro";
            this.Text = "FrmCentro";
            this.GBox_DatosCentro.ResumeLayout(false);
            this.GBox_DatosCentro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBox_DatosCentro;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textDir;
        private System.Windows.Forms.TextBox textTelf;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Telf;
        private System.Windows.Forms.Label label_Direc;
        private System.Windows.Forms.Label label_Nom;
    }
}