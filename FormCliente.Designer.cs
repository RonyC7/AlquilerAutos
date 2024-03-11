namespace AlquilerAutos
{
    partial class FormCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            this.button1 = new System.Windows.Forms.Button();
            this.buttonGuardarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.textBoxDireccionCliente = new System.Windows.Forms.TextBox();
            this.textBoxNit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGuardarCliente
            // 
            this.buttonGuardarCliente.BackColor = System.Drawing.Color.Turquoise;
            this.buttonGuardarCliente.Location = new System.Drawing.Point(611, 103);
            this.buttonGuardarCliente.Name = "buttonGuardarCliente";
            this.buttonGuardarCliente.Size = new System.Drawing.Size(113, 49);
            this.buttonGuardarCliente.TabIndex = 1;
            this.buttonGuardarCliente.Text = "Guardar Cliente";
            this.buttonGuardarCliente.UseVisualStyleBackColor = false;
            this.buttonGuardarCliente.Click += new System.EventHandler(this.buttonGuardarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nit";
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Location = new System.Drawing.Point(219, 62);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.Size = new System.Drawing.Size(344, 22);
            this.textBoxNombreCliente.TabIndex = 5;
            // 
            // textBoxDireccionCliente
            // 
            this.textBoxDireccionCliente.Location = new System.Drawing.Point(219, 116);
            this.textBoxDireccionCliente.Name = "textBoxDireccionCliente";
            this.textBoxDireccionCliente.Size = new System.Drawing.Size(344, 22);
            this.textBoxDireccionCliente.TabIndex = 6;
            // 
            // textBoxNit
            // 
            this.textBoxNit.Location = new System.Drawing.Point(219, 179);
            this.textBoxNit.Name = "textBoxNit";
            this.textBoxNit.Size = new System.Drawing.Size(344, 22);
            this.textBoxNit.TabIndex = 7;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(750, 233);
            this.Controls.Add(this.textBoxNit);
            this.Controls.Add(this.textBoxDireccionCliente);
            this.Controls.Add(this.textBoxNombreCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGuardarCliente);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCliente";
            this.Text = "Datos Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonGuardarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNombreCliente;
        private System.Windows.Forms.TextBox textBoxDireccionCliente;
        private System.Windows.Forms.TextBox textBoxNit;
    }
}