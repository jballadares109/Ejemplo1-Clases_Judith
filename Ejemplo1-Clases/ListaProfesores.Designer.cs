namespace Ejemplo1_Clases
{
    partial class ListaProfesores
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
            this.GBox_ListCentro = new System.Windows.Forms.GroupBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GBox_ListCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GBox_ListCentro
            // 
            this.GBox_ListCentro.Controls.Add(this.BtnCancel);
            this.GBox_ListCentro.Controls.Add(this.dataGridView1);
            this.GBox_ListCentro.Location = new System.Drawing.Point(87, 26);
            this.GBox_ListCentro.Name = "GBox_ListCentro";
            this.GBox_ListCentro.Size = new System.Drawing.Size(421, 258);
            this.GBox_ListCentro.TabIndex = 1;
            this.GBox_ListCentro.TabStop = false;
            this.GBox_ListCentro.Text = "Lista de los Profesores";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(323, 229);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(378, 183);
            this.dataGridView1.TabIndex = 0;
            // 
            // ListaProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GBox_ListCentro);
            this.Name = "ListaProfesores";
            this.Text = "ListaProfesores";
            this.Load += new System.EventHandler(this.ListaProfesores_Load);
            this.GBox_ListCentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBox_ListCentro;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}