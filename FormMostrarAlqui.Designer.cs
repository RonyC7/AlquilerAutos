namespace AlquilerAutos
{
    partial class FormMostrarAlqui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMostrarAlqui));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewAlquiler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAlquiAlto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlquiler)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewAlquiler
            // 
            this.dataGridViewAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlquiler.Location = new System.Drawing.Point(12, 95);
            this.dataGridViewAlquiler.Name = "dataGridViewAlquiler";
            this.dataGridViewAlquiler.RowHeadersWidth = 51;
            this.dataGridViewAlquiler.RowTemplate.Height = 24;
            this.dataGridViewAlquiler.Size = new System.Drawing.Size(896, 187);
            this.dataGridViewAlquiler.TabIndex = 1;
            this.dataGridViewAlquiler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAlquiler_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor mas alto de recorrido";
            // 
            // labelAlquiAlto
            // 
            this.labelAlquiAlto.AutoSize = true;
            this.labelAlquiAlto.Location = new System.Drawing.Point(160, 60);
            this.labelAlquiAlto.Name = "labelAlquiAlto";
            this.labelAlquiAlto.Size = new System.Drawing.Size(44, 16);
            this.labelAlquiAlto.TabIndex = 3;
            this.labelAlquiAlto.Text = "label2";
            // 
            // FormMostrarAlqui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(920, 294);
            this.Controls.Add(this.labelAlquiAlto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewAlquiler);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMostrarAlqui";
            this.Text = "Alquiler de Autos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlquiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewAlquiler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAlquiAlto;
    }
}