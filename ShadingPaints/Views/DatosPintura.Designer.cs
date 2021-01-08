
namespace ShadingPaints.Views
{
    partial class DatosPintura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label_Titulo = new System.Windows.Forms.Label();
            this.Panel_Opciones = new System.Windows.Forms.Panel();
            this.Button_Continuar = new System.Windows.Forms.Button();
            this.Button_Cerrar = new System.Windows.Forms.Button();
            this.Panel_NuevaPintura = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Label_Pintura = new System.Windows.Forms.Label();
            this.Label_Estadistica = new System.Windows.Forms.Label();
            this.Panel_Estadisticas = new System.Windows.Forms.Panel();
            this.Button_Agregar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DataGridView_VistaPrincipal = new System.Windows.Forms.DataGridView();
            this.PSpinnerBox_Bandera = new PeinUIWFA.Controls.PSpinnerBox();
            this.PSpinnerBox_Demanda = new PeinUIWFA.Controls.PSpinnerBox();
            this.PSpinnerBox_CostoInventario = new PeinUIWFA.Controls.PSpinnerBox();
            this.PSpinnerBox_Tiempo = new PeinUIWFA.Controls.PSpinnerBox();
            this.PTextBox_NombreColor = new PeinUIWFA.Controls.PTextBox();
            this.PTextBox_Codigo = new PeinUIWFA.Controls.PTextBox();
            this.PTextBox_Mes = new PeinUIWFA.Controls.PTextBox();
            this.Panel_Opciones.SuspendLayout();
            this.Panel_NuevaPintura.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Panel_Estadisticas.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_VistaPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Titulo
            // 
            this.Label_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Label_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label_Titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Titulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_Titulo.Location = new System.Drawing.Point(0, 0);
            this.Label_Titulo.Name = "Label_Titulo";
            this.Label_Titulo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Label_Titulo.Size = new System.Drawing.Size(431, 50);
            this.Label_Titulo.TabIndex = 4;
            this.Label_Titulo.Text = "Nueva Pintura";
            this.Label_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Panel_Opciones
            // 
            this.Panel_Opciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Panel_Opciones.Controls.Add(this.Button_Continuar);
            this.Panel_Opciones.Controls.Add(this.Button_Cerrar);
            this.Panel_Opciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Opciones.Location = new System.Drawing.Point(0, 266);
            this.Panel_Opciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel_Opciones.Name = "Panel_Opciones";
            this.Panel_Opciones.Size = new System.Drawing.Size(431, 48);
            this.Panel_Opciones.TabIndex = 5;
            // 
            // Button_Continuar
            // 
            this.Button_Continuar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Continuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Continuar.FlatAppearance.BorderSize = 0;
            this.Button_Continuar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Continuar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Continuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Continuar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Continuar.Location = new System.Drawing.Point(304, 5);
            this.Button_Continuar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 1);
            this.Button_Continuar.Name = "Button_Continuar";
            this.Button_Continuar.Size = new System.Drawing.Size(120, 36);
            this.Button_Continuar.TabIndex = 3;
            this.Button_Continuar.Text = "Registrar";
            this.Button_Continuar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Continuar.UseVisualStyleBackColor = false;
            this.Button_Continuar.Click += new System.EventHandler(this.Button_Continuar_Click);
            // 
            // Button_Cerrar
            // 
            this.Button_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Cerrar.FlatAppearance.BorderSize = 0;
            this.Button_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Cerrar.Location = new System.Drawing.Point(5, 5);
            this.Button_Cerrar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 1);
            this.Button_Cerrar.Name = "Button_Cerrar";
            this.Button_Cerrar.Size = new System.Drawing.Size(97, 36);
            this.Button_Cerrar.TabIndex = 2;
            this.Button_Cerrar.Text = "Cerrar";
            this.Button_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Cerrar.UseVisualStyleBackColor = false;
            this.Button_Cerrar.Click += new System.EventHandler(this.Button_Cerrar_Click);
            // 
            // Panel_NuevaPintura
            // 
            this.Panel_NuevaPintura.Controls.Add(this.PSpinnerBox_CostoInventario);
            this.Panel_NuevaPintura.Controls.Add(this.PSpinnerBox_Tiempo);
            this.Panel_NuevaPintura.Controls.Add(this.Label_Titulo);
            this.Panel_NuevaPintura.Controls.Add(this.PTextBox_NombreColor);
            this.Panel_NuevaPintura.Controls.Add(this.PTextBox_Codigo);
            this.Panel_NuevaPintura.Location = new System.Drawing.Point(0, 40);
            this.Panel_NuevaPintura.Name = "Panel_NuevaPintura";
            this.Panel_NuevaPintura.Size = new System.Drawing.Size(431, 226);
            this.Panel_NuevaPintura.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Label_Pintura, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Label_Estadistica, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(431, 40);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // Label_Pintura
            // 
            this.Label_Pintura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label_Pintura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Pintura.Location = new System.Drawing.Point(3, 0);
            this.Label_Pintura.Name = "Label_Pintura";
            this.Label_Pintura.Size = new System.Drawing.Size(209, 40);
            this.Label_Pintura.TabIndex = 0;
            this.Label_Pintura.Text = "Pintura";
            this.Label_Pintura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Estadistica
            // 
            this.Label_Estadistica.BackColor = System.Drawing.Color.Transparent;
            this.Label_Estadistica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Estadistica.Location = new System.Drawing.Point(218, 0);
            this.Label_Estadistica.Name = "Label_Estadistica";
            this.Label_Estadistica.Size = new System.Drawing.Size(210, 40);
            this.Label_Estadistica.TabIndex = 1;
            this.Label_Estadistica.Text = "Estadísticas";
            this.Label_Estadistica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_Estadisticas
            // 
            this.Panel_Estadisticas.Controls.Add(this.PTextBox_Mes);
            this.Panel_Estadisticas.Controls.Add(this.panel3);
            this.Panel_Estadisticas.Controls.Add(this.Button_Agregar);
            this.Panel_Estadisticas.Controls.Add(this.PSpinnerBox_Bandera);
            this.Panel_Estadisticas.Controls.Add(this.PSpinnerBox_Demanda);
            this.Panel_Estadisticas.Location = new System.Drawing.Point(0, 40);
            this.Panel_Estadisticas.Name = "Panel_Estadisticas";
            this.Panel_Estadisticas.Size = new System.Drawing.Size(431, 226);
            this.Panel_Estadisticas.TabIndex = 12;
            this.Panel_Estadisticas.Visible = false;
            // 
            // Button_Agregar
            // 
            this.Button_Agregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Agregar.FlatAppearance.BorderSize = 0;
            this.Button_Agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Agregar.Location = new System.Drawing.Point(6, 177);
            this.Button_Agregar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 1);
            this.Button_Agregar.Name = "Button_Agregar";
            this.Button_Agregar.Size = new System.Drawing.Size(106, 36);
            this.Button_Agregar.TabIndex = 4;
            this.Button_Agregar.Text = "Agregar";
            this.Button_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Agregar.UseVisualStyleBackColor = false;
            this.Button_Agregar.Click += new System.EventHandler(this.Button_Agregar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DataGridView_VistaPrincipal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(120, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 226);
            this.panel3.TabIndex = 5;
            // 
            // DataGridView_VistaPrincipal
            // 
            this.DataGridView_VistaPrincipal.AllowUserToResizeRows = false;
            this.DataGridView_VistaPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_VistaPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_VistaPrincipal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.DataGridView_VistaPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_VistaPrincipal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_VistaPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridView_VistaPrincipal.ColumnHeadersHeight = 35;
            this.DataGridView_VistaPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_VistaPrincipal.DefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridView_VistaPrincipal.EnableHeadersVisualStyles = false;
            this.DataGridView_VistaPrincipal.GridColor = System.Drawing.Color.Silver;
            this.DataGridView_VistaPrincipal.Location = new System.Drawing.Point(4, 4);
            this.DataGridView_VistaPrincipal.Name = "DataGridView_VistaPrincipal";
            this.DataGridView_VistaPrincipal.RowHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_VistaPrincipal.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridView_VistaPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_VistaPrincipal.Size = new System.Drawing.Size(302, 218);
            this.DataGridView_VistaPrincipal.TabIndex = 3;
            // 
            // PSpinnerBox_Bandera
            // 
            this.PSpinnerBox_Bandera.BackColor = System.Drawing.Color.Transparent;
            this.PSpinnerBox_Bandera.BorderColor = System.Drawing.Color.Black;
            this.PSpinnerBox_Bandera.DecimalPlaces = 0;
            this.PSpinnerBox_Bandera.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PSpinnerBox_Bandera.FundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PSpinnerBox_Bandera.Hexadecimal = false;
            this.PSpinnerBox_Bandera.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PSpinnerBox_Bandera.Location = new System.Drawing.Point(12, 64);
            this.PSpinnerBox_Bandera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PSpinnerBox_Bandera.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.PSpinnerBox_Bandera.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PSpinnerBox_Bandera.MinimumSize = new System.Drawing.Size(55, 50);
            this.PSpinnerBox_Bandera.Name = "PSpinnerBox_Bandera";
            this.PSpinnerBox_Bandera.ReadOnly = false;
            this.PSpinnerBox_Bandera.SelectBorderColor = System.Drawing.Color.Black;
            this.PSpinnerBox_Bandera.Size = new System.Drawing.Size(100, 50);
            this.PSpinnerBox_Bandera.Spacing = new System.Windows.Forms.Padding(10);
            this.PSpinnerBox_Bandera.TabIndex = 1;
            this.PSpinnerBox_Bandera.Text = "0";
            this.PSpinnerBox_Bandera.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PSpinnerBox_Bandera.ThousandsSeparator = false;
            this.PSpinnerBox_Bandera.Title = "Bandera";
            this.PSpinnerBox_Bandera.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.PSpinnerBox_Bandera.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // PSpinnerBox_Demanda
            // 
            this.PSpinnerBox_Demanda.BackColor = System.Drawing.Color.Transparent;
            this.PSpinnerBox_Demanda.BorderColor = System.Drawing.Color.Black;
            this.PSpinnerBox_Demanda.DecimalPlaces = 0;
            this.PSpinnerBox_Demanda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PSpinnerBox_Demanda.FundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PSpinnerBox_Demanda.Hexadecimal = false;
            this.PSpinnerBox_Demanda.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PSpinnerBox_Demanda.Location = new System.Drawing.Point(12, 7);
            this.PSpinnerBox_Demanda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PSpinnerBox_Demanda.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.PSpinnerBox_Demanda.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PSpinnerBox_Demanda.MinimumSize = new System.Drawing.Size(55, 50);
            this.PSpinnerBox_Demanda.Name = "PSpinnerBox_Demanda";
            this.PSpinnerBox_Demanda.ReadOnly = false;
            this.PSpinnerBox_Demanda.SelectBorderColor = System.Drawing.Color.Black;
            this.PSpinnerBox_Demanda.Size = new System.Drawing.Size(100, 50);
            this.PSpinnerBox_Demanda.Spacing = new System.Windows.Forms.Padding(10);
            this.PSpinnerBox_Demanda.TabIndex = 0;
            this.PSpinnerBox_Demanda.Text = "0";
            this.PSpinnerBox_Demanda.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PSpinnerBox_Demanda.ThousandsSeparator = false;
            this.PSpinnerBox_Demanda.Title = "Demanda";
            this.PSpinnerBox_Demanda.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.PSpinnerBox_Demanda.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // PSpinnerBox_CostoInventario
            // 
            this.PSpinnerBox_CostoInventario.BackColor = System.Drawing.Color.Transparent;
            this.PSpinnerBox_CostoInventario.BorderColor = System.Drawing.Color.Black;
            this.PSpinnerBox_CostoInventario.DecimalPlaces = 0;
            this.PSpinnerBox_CostoInventario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PSpinnerBox_CostoInventario.FundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PSpinnerBox_CostoInventario.Hexadecimal = false;
            this.PSpinnerBox_CostoInventario.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PSpinnerBox_CostoInventario.Location = new System.Drawing.Point(218, 119);
            this.PSpinnerBox_CostoInventario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PSpinnerBox_CostoInventario.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.PSpinnerBox_CostoInventario.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PSpinnerBox_CostoInventario.MinimumSize = new System.Drawing.Size(55, 50);
            this.PSpinnerBox_CostoInventario.Name = "PSpinnerBox_CostoInventario";
            this.PSpinnerBox_CostoInventario.ReadOnly = false;
            this.PSpinnerBox_CostoInventario.SelectBorderColor = System.Drawing.Color.Black;
            this.PSpinnerBox_CostoInventario.Size = new System.Drawing.Size(200, 50);
            this.PSpinnerBox_CostoInventario.Spacing = new System.Windows.Forms.Padding(10);
            this.PSpinnerBox_CostoInventario.TabIndex = 9;
            this.PSpinnerBox_CostoInventario.Text = "0";
            this.PSpinnerBox_CostoInventario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PSpinnerBox_CostoInventario.ThousandsSeparator = false;
            this.PSpinnerBox_CostoInventario.Title = "Costo de Inventario";
            this.PSpinnerBox_CostoInventario.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.PSpinnerBox_CostoInventario.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // PSpinnerBox_Tiempo
            // 
            this.PSpinnerBox_Tiempo.BackColor = System.Drawing.Color.Transparent;
            this.PSpinnerBox_Tiempo.BorderColor = System.Drawing.Color.Black;
            this.PSpinnerBox_Tiempo.DecimalPlaces = 0;
            this.PSpinnerBox_Tiempo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PSpinnerBox_Tiempo.FundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PSpinnerBox_Tiempo.Hexadecimal = false;
            this.PSpinnerBox_Tiempo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PSpinnerBox_Tiempo.Location = new System.Drawing.Point(12, 119);
            this.PSpinnerBox_Tiempo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PSpinnerBox_Tiempo.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.PSpinnerBox_Tiempo.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PSpinnerBox_Tiempo.MinimumSize = new System.Drawing.Size(55, 50);
            this.PSpinnerBox_Tiempo.Name = "PSpinnerBox_Tiempo";
            this.PSpinnerBox_Tiempo.ReadOnly = false;
            this.PSpinnerBox_Tiempo.SelectBorderColor = System.Drawing.Color.Black;
            this.PSpinnerBox_Tiempo.Size = new System.Drawing.Size(200, 50);
            this.PSpinnerBox_Tiempo.Spacing = new System.Windows.Forms.Padding(10);
            this.PSpinnerBox_Tiempo.TabIndex = 8;
            this.PSpinnerBox_Tiempo.Text = "0";
            this.PSpinnerBox_Tiempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PSpinnerBox_Tiempo.ThousandsSeparator = false;
            this.PSpinnerBox_Tiempo.Title = "Tiempo de Fabricación";
            this.PSpinnerBox_Tiempo.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.PSpinnerBox_Tiempo.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // PTextBox_NombreColor
            // 
            this.PTextBox_NombreColor.AcceptsReturn = false;
            this.PTextBox_NombreColor.AcceptsTab = false;
            this.PTextBox_NombreColor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PTextBox_NombreColor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PTextBox_NombreColor.BackColor = System.Drawing.Color.Transparent;
            this.PTextBox_NombreColor.BorderColor = System.Drawing.Color.Black;
            this.PTextBox_NombreColor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PTextBox_NombreColor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PTextBox_NombreColor.FundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PTextBox_NombreColor.HideSelection = true;
            this.PTextBox_NombreColor.Intelligence = false;
            this.PTextBox_NombreColor.Location = new System.Drawing.Point(218, 64);
            this.PTextBox_NombreColor.MaxLength = 32767;
            this.PTextBox_NombreColor.MinimumSize = new System.Drawing.Size(200, 48);
            this.PTextBox_NombreColor.Name = "PTextBox_NombreColor";
            this.PTextBox_NombreColor.ReadOnly = false;
            this.PTextBox_NombreColor.SelectBorderColor = System.Drawing.Color.Black;
            this.PTextBox_NombreColor.ShortcutsEnabled = true;
            this.PTextBox_NombreColor.Size = new System.Drawing.Size(200, 48);
            this.PTextBox_NombreColor.Spacing = new System.Windows.Forms.Padding(10);
            this.PTextBox_NombreColor.TabIndex = 7;
            this.PTextBox_NombreColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PTextBox_NombreColor.Title = "Nombre de Color";
            // 
            // PTextBox_Codigo
            // 
            this.PTextBox_Codigo.AcceptsReturn = false;
            this.PTextBox_Codigo.AcceptsTab = false;
            this.PTextBox_Codigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PTextBox_Codigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PTextBox_Codigo.BackColor = System.Drawing.Color.Transparent;
            this.PTextBox_Codigo.BorderColor = System.Drawing.Color.Black;
            this.PTextBox_Codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PTextBox_Codigo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PTextBox_Codigo.FundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PTextBox_Codigo.HideSelection = true;
            this.PTextBox_Codigo.Intelligence = false;
            this.PTextBox_Codigo.Location = new System.Drawing.Point(12, 64);
            this.PTextBox_Codigo.MaxLength = 32767;
            this.PTextBox_Codigo.MinimumSize = new System.Drawing.Size(200, 48);
            this.PTextBox_Codigo.Name = "PTextBox_Codigo";
            this.PTextBox_Codigo.ReadOnly = true;
            this.PTextBox_Codigo.SelectBorderColor = System.Drawing.Color.Black;
            this.PTextBox_Codigo.ShortcutsEnabled = true;
            this.PTextBox_Codigo.Size = new System.Drawing.Size(200, 48);
            this.PTextBox_Codigo.Spacing = new System.Windows.Forms.Padding(10);
            this.PTextBox_Codigo.TabIndex = 6;
            this.PTextBox_Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PTextBox_Codigo.Title = "Codigo";
            // 
            // PTextBox_Mes
            // 
            this.PTextBox_Mes.AcceptsReturn = false;
            this.PTextBox_Mes.AcceptsTab = false;
            this.PTextBox_Mes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PTextBox_Mes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PTextBox_Mes.BackColor = System.Drawing.Color.Transparent;
            this.PTextBox_Mes.BorderColor = System.Drawing.Color.Black;
            this.PTextBox_Mes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PTextBox_Mes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PTextBox_Mes.FundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PTextBox_Mes.HideSelection = true;
            this.PTextBox_Mes.Intelligence = false;
            this.PTextBox_Mes.Location = new System.Drawing.Point(12, 122);
            this.PTextBox_Mes.MaxLength = 32767;
            this.PTextBox_Mes.MinimumSize = new System.Drawing.Size(50, 48);
            this.PTextBox_Mes.Name = "PTextBox_Mes";
            this.PTextBox_Mes.ReadOnly = true;
            this.PTextBox_Mes.SelectBorderColor = System.Drawing.Color.Black;
            this.PTextBox_Mes.ShortcutsEnabled = true;
            this.PTextBox_Mes.Size = new System.Drawing.Size(100, 48);
            this.PTextBox_Mes.Spacing = new System.Windows.Forms.Padding(10);
            this.PTextBox_Mes.TabIndex = 6;
            this.PTextBox_Mes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PTextBox_Mes.Title = "Mes";
            // 
            // DatosPintura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 314);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Panel_Opciones);
            this.Controls.Add(this.Panel_Estadisticas);
            this.Controls.Add(this.Panel_NuevaPintura);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DatosPintura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatosPintura";
            this.Panel_Opciones.ResumeLayout(false);
            this.Panel_NuevaPintura.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Panel_Estadisticas.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_VistaPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_Titulo;
        private System.Windows.Forms.Panel Panel_Opciones;
        private System.Windows.Forms.Button Button_Continuar;
        private System.Windows.Forms.Button Button_Cerrar;
        private PeinUIWFA.Controls.PTextBox PTextBox_Codigo;
        private PeinUIWFA.Controls.PTextBox PTextBox_NombreColor;
        private PeinUIWFA.Controls.PSpinnerBox PSpinnerBox_Tiempo;
        private PeinUIWFA.Controls.PSpinnerBox PSpinnerBox_CostoInventario;
        private System.Windows.Forms.Panel Panel_NuevaPintura;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Label_Pintura;
        private System.Windows.Forms.Label Label_Estadistica;
        private System.Windows.Forms.Panel Panel_Estadisticas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Button_Agregar;
        private PeinUIWFA.Controls.PSpinnerBox PSpinnerBox_Bandera;
        private PeinUIWFA.Controls.PSpinnerBox PSpinnerBox_Demanda;
        private System.Windows.Forms.DataGridView DataGridView_VistaPrincipal;
        private PeinUIWFA.Controls.PTextBox PTextBox_Mes;
    }
}