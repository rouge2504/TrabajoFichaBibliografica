namespace JazzProject
{
    partial class Index
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
            this.BuscarInicio = new System.Windows.Forms.Button();
            this.labelBienvenida = new System.Windows.Forms.Label();
            this.labelIntroduceDatos = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelTema = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelPalabraClave = new System.Windows.Forms.Label();
            this.textBoxPalabraClave = new System.Windows.Forms.TextBox();
            this.textBoxTema = new System.Windows.Forms.TextBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.buttonBuscarLibro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BuscarInicio
            // 
            this.BuscarInicio.Location = new System.Drawing.Point(455, 228);
            this.BuscarInicio.Name = "BuscarInicio";
            this.BuscarInicio.Size = new System.Drawing.Size(75, 23);
            this.BuscarInicio.TabIndex = 1;
            this.BuscarInicio.Text = "Buscar";
            this.BuscarInicio.UseVisualStyleBackColor = true;
            this.BuscarInicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelBienvenida
            // 
            this.labelBienvenida.AutoSize = true;
            this.labelBienvenida.Location = new System.Drawing.Point(281, 137);
            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.Size = new System.Drawing.Size(106, 13);
            this.labelBienvenida.TabIndex = 2;
            this.labelBienvenida.Text = "¿Que deseas hacer?";
            // 
            // labelIntroduceDatos
            // 
            this.labelIntroduceDatos.AutoSize = true;
            this.labelIntroduceDatos.Location = new System.Drawing.Point(72, 26);
            this.labelIntroduceDatos.Name = "labelIntroduceDatos";
            this.labelIntroduceDatos.Size = new System.Drawing.Size(83, 13);
            this.labelIntroduceDatos.TabIndex = 3;
            this.labelIntroduceDatos.Text = "Introduce Datos";
            this.labelIntroduceDatos.Visible = false;
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(72, 69);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(32, 13);
            this.labelAutor.TabIndex = 4;
            this.labelAutor.Text = "Autor";
            this.labelAutor.Visible = false;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(72, 108);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(33, 13);
            this.labelTitulo.TabIndex = 5;
            this.labelTitulo.Text = "Titulo";
            this.labelTitulo.Visible = false;
            // 
            // labelTema
            // 
            this.labelTema.AutoSize = true;
            this.labelTema.Location = new System.Drawing.Point(72, 149);
            this.labelTema.Name = "labelTema";
            this.labelTema.Size = new System.Drawing.Size(34, 13);
            this.labelTema.TabIndex = 6;
            this.labelTema.Text = "Tema";
            this.labelTema.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(75, 192);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(194, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "¿Deseas utilizar una palabra clave?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelPalabraClave
            // 
            this.labelPalabraClave.AutoSize = true;
            this.labelPalabraClave.Location = new System.Drawing.Point(72, 233);
            this.labelPalabraClave.Name = "labelPalabraClave";
            this.labelPalabraClave.Size = new System.Drawing.Size(73, 13);
            this.labelPalabraClave.TabIndex = 8;
            this.labelPalabraClave.Text = "Palabra Clave";
            this.labelPalabraClave.Visible = false;
            // 
            // textBoxPalabraClave
            // 
            this.textBoxPalabraClave.Location = new System.Drawing.Point(204, 225);
            this.textBoxPalabraClave.Name = "textBoxPalabraClave";
            this.textBoxPalabraClave.Size = new System.Drawing.Size(100, 20);
            this.textBoxPalabraClave.TabIndex = 9;
            this.textBoxPalabraClave.Visible = false;
            // 
            // textBoxTema
            // 
            this.textBoxTema.Location = new System.Drawing.Point(194, 142);
            this.textBoxTema.Name = "textBoxTema";
            this.textBoxTema.Size = new System.Drawing.Size(100, 20);
            this.textBoxTema.TabIndex = 10;
            this.textBoxTema.Visible = false;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(194, 105);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(193, 20);
            this.textBoxTitulo.TabIndex = 11;
            this.textBoxTitulo.Visible = false;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(194, 66);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(193, 20);
            this.textBoxAutor.TabIndex = 12;
            this.textBoxAutor.Visible = false;
            // 
            // buttonBuscarLibro
            // 
            this.buttonBuscarLibro.Location = new System.Drawing.Point(585, 222);
            this.buttonBuscarLibro.Name = "buttonBuscarLibro";
            this.buttonBuscarLibro.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarLibro.TabIndex = 13;
            this.buttonBuscarLibro.Text = "Buscar Libro";
            this.buttonBuscarLibro.UseVisualStyleBackColor = true;
            this.buttonBuscarLibro.Visible = false;
            this.buttonBuscarLibro.Click += new System.EventHandler(this.buttonBuscarLibro_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 304);
            this.Controls.Add(this.buttonBuscarLibro);
            this.Controls.Add(this.labelBienvenida);
            this.Controls.Add(this.BuscarInicio);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.textBoxTema);
            this.Controls.Add(this.textBoxPalabraClave);
            this.Controls.Add(this.labelPalabraClave);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelTema);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelIntroduceDatos);
            this.Name = "Index";
            this.Text = "Bienvenido";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarInicio;
        private System.Windows.Forms.Label labelBienvenida;
        private System.Windows.Forms.Label labelIntroduceDatos;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelTema;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelPalabraClave;
        private System.Windows.Forms.TextBox textBoxPalabraClave;
        private System.Windows.Forms.TextBox textBoxTema;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.Button buttonBuscarLibro;
    }
}

