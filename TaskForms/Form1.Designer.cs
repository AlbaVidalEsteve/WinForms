namespace TaskForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNombre = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.buttonNombre = new System.Windows.Forms.Button();
            this.listBoxDias = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(12, 53);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 20);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(91, 50);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(420, 26);
            this.textNombre.TabIndex = 1;
            // 
            // buttonNombre
            // 
            this.buttonNombre.Location = new System.Drawing.Point(319, 457);
            this.buttonNombre.Name = "buttonNombre";
            this.buttonNombre.Size = new System.Drawing.Size(187, 37);
            this.buttonNombre.TabIndex = 2;
            this.buttonNombre.Text = "Pulsar Aquí";
            this.buttonNombre.UseVisualStyleBackColor = true;
            this.buttonNombre.Click += new System.EventHandler(this.buttonNombre_Click);
            // 
            // listBoxDias
            // 
            this.listBoxDias.FormattingEnabled = true;
            this.listBoxDias.ItemHeight = 20;
            this.listBoxDias.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.listBoxDias.Location = new System.Drawing.Point(91, 175);
            this.listBoxDias.Name = "listBoxDias";
            this.listBoxDias.Size = new System.Drawing.Size(415, 144);
            this.listBoxDias.TabIndex = 3;
            this.listBoxDias.SelectedIndexChanged += new System.EventHandler(this.listBoxDias_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AccessibleName = "FormPrincipal";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 517);
            this.Controls.Add(this.listBoxDias);
            this.Controls.Add(this.buttonNombre);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.labelNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Button buttonNombre;
        private System.Windows.Forms.ListBox listBoxDias;
    }
}

