namespace AlquilerAutos
{
    partial class FormAlquiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlquiler));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerAlquiler = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerDevolucion = new System.Windows.Forms.DateTimePicker();
            this.textBoxKilometroReco = new System.Windows.Forms.TextBox();
            this.buttonGuardarAlqui = new System.Windows.Forms.Button();
            this.comboBoxNit = new System.Windows.Forms.ComboBox();
            this.comboBoxPlaca = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Placa";
            // 
            // dateTimePickerAlquiler
            // 
            this.dateTimePickerAlquiler.Location = new System.Drawing.Point(221, 156);
            this.dateTimePickerAlquiler.Name = "dateTimePickerAlquiler";
            this.dateTimePickerAlquiler.Size = new System.Drawing.Size(285, 22);
            this.dateTimePickerAlquiler.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Alquiler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha Devolucion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kilometros Recorridos";
            // 
            // dateTimePickerDevolucion
            // 
            this.dateTimePickerDevolucion.Location = new System.Drawing.Point(221, 206);
            this.dateTimePickerDevolucion.Name = "dateTimePickerDevolucion";
            this.dateTimePickerDevolucion.Size = new System.Drawing.Size(285, 22);
            this.dateTimePickerDevolucion.TabIndex = 7;
            // 
            // textBoxKilometroReco
            // 
            this.textBoxKilometroReco.Location = new System.Drawing.Point(221, 249);
            this.textBoxKilometroReco.Name = "textBoxKilometroReco";
            this.textBoxKilometroReco.Size = new System.Drawing.Size(285, 22);
            this.textBoxKilometroReco.TabIndex = 10;
            // 
            // buttonGuardarAlqui
            // 
            this.buttonGuardarAlqui.BackColor = System.Drawing.Color.Turquoise;
            this.buttonGuardarAlqui.Location = new System.Drawing.Point(524, 144);
            this.buttonGuardarAlqui.Name = "buttonGuardarAlqui";
            this.buttonGuardarAlqui.Size = new System.Drawing.Size(118, 51);
            this.buttonGuardarAlqui.TabIndex = 11;
            this.buttonGuardarAlqui.Text = "Guardar Alquiler";
            this.buttonGuardarAlqui.UseVisualStyleBackColor = false;
            this.buttonGuardarAlqui.Click += new System.EventHandler(this.buttonGuardarAlqui_Click);
            // 
            // comboBoxNit
            // 
            this.comboBoxNit.FormattingEnabled = true;
            this.comboBoxNit.Location = new System.Drawing.Point(221, 56);
            this.comboBoxNit.Name = "comboBoxNit";
            this.comboBoxNit.Size = new System.Drawing.Size(285, 24);
            this.comboBoxNit.TabIndex = 12;
            // 
            // comboBoxPlaca
            // 
            this.comboBoxPlaca.FormattingEnabled = true;
            this.comboBoxPlaca.Location = new System.Drawing.Point(221, 103);
            this.comboBoxPlaca.Name = "comboBoxPlaca";
            this.comboBoxPlaca.Size = new System.Drawing.Size(285, 24);
            this.comboBoxPlaca.TabIndex = 13;
            // 
            // FormAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(669, 319);
            this.Controls.Add(this.comboBoxPlaca);
            this.Controls.Add(this.comboBoxNit);
            this.Controls.Add(this.buttonGuardarAlqui);
            this.Controls.Add(this.textBoxKilometroReco);
            this.Controls.Add(this.dateTimePickerDevolucion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerAlquiler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlquiler";
            this.Text = "Alquiler de autos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerAlquiler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerDevolucion;
        private System.Windows.Forms.TextBox textBoxKilometroReco;
        private System.Windows.Forms.Button buttonGuardarAlqui;
        private System.Windows.Forms.ComboBox comboBoxNit;
        private System.Windows.Forms.ComboBox comboBoxPlaca;
    }
}