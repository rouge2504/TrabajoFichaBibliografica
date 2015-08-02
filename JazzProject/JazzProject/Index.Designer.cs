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
            this.textBoxTema = new System.Windows.Forms.TextBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.buttonBuscarLibro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.textBoxTipo = new System.Windows.Forms.TextBox();
            this.buttonPrestados = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Prestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.labelIntroduceDatos.Size = new System.Drawing.Size(0, 13);
            this.labelIntroduceDatos.TabIndex = 3;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Procesando";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(72, 182);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(28, 13);
            this.labelTipo.TabIndex = 15;
            this.labelTipo.Text = "Tipo";
            this.labelTipo.Visible = false;
            // 
            // textBoxTipo
            // 
            this.textBoxTipo.Location = new System.Drawing.Point(194, 175);
            this.textBoxTipo.Name = "textBoxTipo";
            this.textBoxTipo.Size = new System.Drawing.Size(100, 20);
            this.textBoxTipo.TabIndex = 16;
            this.textBoxTipo.Visible = false;
            // 
            // buttonPrestados
            // 
            this.buttonPrestados.Location = new System.Drawing.Point(269, 228);
            this.buttonPrestados.Name = "buttonPrestados";
            this.buttonPrestados.Size = new System.Drawing.Size(137, 23);
            this.buttonPrestados.TabIndex = 17;
            this.buttonPrestados.Text = "Buscar prestados";
            this.buttonPrestados.UseVisualStyleBackColor = true;
            this.buttonPrestados.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prestado,
            this.title,
            this.name,
            this.date});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(25, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(554, 270);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Prestado
            // 
            this.Prestado.HeaderText = "Prestado";
            this.Prestado.Name = "Prestado";
            this.Prestado.ReadOnly = true;
            // 
            // title
            // 
            this.title.HeaderText = "Titulo";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Fecha de prestamo";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 304);
            this.Controls.Add(this.buttonPrestados);
            this.Controls.Add(this.textBoxTipo);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuscarLibro);
            this.Controls.Add(this.labelBienvenida);
            this.Controls.Add(this.BuscarInicio);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.textBoxTema);
            this.Controls.Add(this.labelTema);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelIntroduceDatos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Index";
            this.Text = "Bienvenido";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxTema;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.Button buttonBuscarLibro;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.TextBox textBoxTipo;
        private System.Windows.Forms.Button buttonPrestados;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}

