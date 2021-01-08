
namespace ShadingPaints.Components
{
    partial class PinturasCrud
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PinturasCrud));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel_TablaContenido = new System.Windows.Forms.Panel();
            this.FlowLayoutPanel_Acciones = new System.Windows.Forms.FlowLayoutPanel();
            this.Button_ModificarColor = new System.Windows.Forms.Button();
            this.Button_VerColor = new System.Windows.Forms.Button();
            this.Button_EliminarColor = new System.Windows.Forms.Button();
            this.Panel_Separator = new System.Windows.Forms.Panel();
            this.Button_RefrescarTabla = new System.Windows.Forms.Button();
            this.Button_GuardarCambios = new System.Windows.Forms.Button();
            this.Button_ExportarExcelDB = new System.Windows.Forms.Button();
            this.Button_CargarExcelBD = new System.Windows.Forms.Button();
            this.DataGridView_VistaPrincipal = new System.Windows.Forms.DataGridView();
            this.Panel_Busqueda = new System.Windows.Forms.Panel();
            this.searchBarColor1 = new SearchBarColor();
            this.Button_NuevoColor = new System.Windows.Forms.Button();
            this.Panel_TablaContenido.SuspendLayout();
            this.FlowLayoutPanel_Acciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_VistaPrincipal)).BeginInit();
            this.Panel_Busqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_TablaContenido
            // 
            this.Panel_TablaContenido.Controls.Add(this.FlowLayoutPanel_Acciones);
            this.Panel_TablaContenido.Controls.Add(this.DataGridView_VistaPrincipal);
            this.Panel_TablaContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_TablaContenido.Location = new System.Drawing.Point(0, 40);
            this.Panel_TablaContenido.Name = "Panel_TablaContenido";
            this.Panel_TablaContenido.Size = new System.Drawing.Size(800, 460);
            this.Panel_TablaContenido.TabIndex = 9;
            // 
            // FlowLayoutPanel_Acciones
            // 
            this.FlowLayoutPanel_Acciones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FlowLayoutPanel_Acciones.Controls.Add(this.Button_ModificarColor);
            this.FlowLayoutPanel_Acciones.Controls.Add(this.Button_VerColor);
            this.FlowLayoutPanel_Acciones.Controls.Add(this.Button_EliminarColor);
            this.FlowLayoutPanel_Acciones.Controls.Add(this.Panel_Separator);
            this.FlowLayoutPanel_Acciones.Controls.Add(this.Button_RefrescarTabla);
            this.FlowLayoutPanel_Acciones.Controls.Add(this.Button_GuardarCambios);
            this.FlowLayoutPanel_Acciones.Controls.Add(this.Button_ExportarExcelDB);
            this.FlowLayoutPanel_Acciones.Controls.Add(this.Button_CargarExcelBD);
            this.FlowLayoutPanel_Acciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.FlowLayoutPanel_Acciones.Location = new System.Drawing.Point(750, 0);
            this.FlowLayoutPanel_Acciones.Margin = new System.Windows.Forms.Padding(0);
            this.FlowLayoutPanel_Acciones.Name = "FlowLayoutPanel_Acciones";
            this.FlowLayoutPanel_Acciones.Size = new System.Drawing.Size(50, 460);
            this.FlowLayoutPanel_Acciones.TabIndex = 9;
            // 
            // Button_ModificarColor
            // 
            this.Button_ModificarColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_ModificarColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_ModificarColor.FlatAppearance.BorderSize = 0;
            this.Button_ModificarColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_ModificarColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_ModificarColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ModificarColor.Image = ((System.Drawing.Image)(resources.GetObject("Button_ModificarColor.Image")));
            this.Button_ModificarColor.Location = new System.Drawing.Point(4, 3);
            this.Button_ModificarColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 1);
            this.Button_ModificarColor.Name = "Button_ModificarColor";
            this.Button_ModificarColor.Size = new System.Drawing.Size(42, 36);
            this.Button_ModificarColor.TabIndex = 5;
            this.Button_ModificarColor.UseVisualStyleBackColor = false;
            this.Button_ModificarColor.Click += new System.EventHandler(this.Button_ModificarColor_Click);
            // 
            // Button_VerColor
            // 
            this.Button_VerColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_VerColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_VerColor.FlatAppearance.BorderSize = 0;
            this.Button_VerColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_VerColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_VerColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_VerColor.Image = ((System.Drawing.Image)(resources.GetObject("Button_VerColor.Image")));
            this.Button_VerColor.Location = new System.Drawing.Point(4, 41);
            this.Button_VerColor.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.Button_VerColor.Name = "Button_VerColor";
            this.Button_VerColor.Size = new System.Drawing.Size(42, 36);
            this.Button_VerColor.TabIndex = 6;
            this.Button_VerColor.UseVisualStyleBackColor = false;
            this.Button_VerColor.Click += new System.EventHandler(this.Button_VerColor_Click);
            // 
            // Button_EliminarColor
            // 
            this.Button_EliminarColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_EliminarColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_EliminarColor.FlatAppearance.BorderSize = 0;
            this.Button_EliminarColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_EliminarColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_EliminarColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_EliminarColor.Image = ((System.Drawing.Image)(resources.GetObject("Button_EliminarColor.Image")));
            this.Button_EliminarColor.Location = new System.Drawing.Point(4, 79);
            this.Button_EliminarColor.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.Button_EliminarColor.Name = "Button_EliminarColor";
            this.Button_EliminarColor.Size = new System.Drawing.Size(42, 36);
            this.Button_EliminarColor.TabIndex = 6;
            this.Button_EliminarColor.UseVisualStyleBackColor = false;
            this.Button_EliminarColor.Click += new System.EventHandler(this.Button_EliminarColor_Click);
            // 
            // Panel_Separator
            // 
            this.Panel_Separator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Separator.BackColor = System.Drawing.Color.Black;
            this.Panel_Separator.Location = new System.Drawing.Point(3, 119);
            this.Panel_Separator.Name = "Panel_Separator";
            this.Panel_Separator.Size = new System.Drawing.Size(44, 1);
            this.Panel_Separator.TabIndex = 10;
            // 
            // Button_RefrescarTabla
            // 
            this.Button_RefrescarTabla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_RefrescarTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_RefrescarTabla.FlatAppearance.BorderSize = 0;
            this.Button_RefrescarTabla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_RefrescarTabla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_RefrescarTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_RefrescarTabla.Image = ((System.Drawing.Image)(resources.GetObject("Button_RefrescarTabla.Image")));
            this.Button_RefrescarTabla.Location = new System.Drawing.Point(4, 126);
            this.Button_RefrescarTabla.Margin = new System.Windows.Forms.Padding(4, 3, 4, 1);
            this.Button_RefrescarTabla.Name = "Button_RefrescarTabla";
            this.Button_RefrescarTabla.Size = new System.Drawing.Size(42, 36);
            this.Button_RefrescarTabla.TabIndex = 6;
            this.Button_RefrescarTabla.UseVisualStyleBackColor = false;
            this.Button_RefrescarTabla.Click += new System.EventHandler(this.Button_RefrescarTabla_Click);
            // 
            // Button_GuardarCambios
            // 
            this.Button_GuardarCambios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_GuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_GuardarCambios.FlatAppearance.BorderSize = 0;
            this.Button_GuardarCambios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_GuardarCambios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_GuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_GuardarCambios.Image = ((System.Drawing.Image)(resources.GetObject("Button_GuardarCambios.Image")));
            this.Button_GuardarCambios.Location = new System.Drawing.Point(4, 164);
            this.Button_GuardarCambios.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.Button_GuardarCambios.Name = "Button_GuardarCambios";
            this.Button_GuardarCambios.Size = new System.Drawing.Size(42, 36);
            this.Button_GuardarCambios.TabIndex = 7;
            this.Button_GuardarCambios.UseVisualStyleBackColor = false;
            this.Button_GuardarCambios.Click += new System.EventHandler(this.Button_GuardarCambios_Click);
            // 
            // Button_ExportarExcelDB
            // 
            this.Button_ExportarExcelDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_ExportarExcelDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_ExportarExcelDB.FlatAppearance.BorderSize = 0;
            this.Button_ExportarExcelDB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_ExportarExcelDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_ExportarExcelDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ExportarExcelDB.Image = ((System.Drawing.Image)(resources.GetObject("Button_ExportarExcelDB.Image")));
            this.Button_ExportarExcelDB.Location = new System.Drawing.Point(4, 202);
            this.Button_ExportarExcelDB.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.Button_ExportarExcelDB.Name = "Button_ExportarExcelDB";
            this.Button_ExportarExcelDB.Size = new System.Drawing.Size(42, 36);
            this.Button_ExportarExcelDB.TabIndex = 8;
            this.Button_ExportarExcelDB.UseVisualStyleBackColor = false;
            // 
            // Button_CargarExcelBD
            // 
            this.Button_CargarExcelBD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_CargarExcelBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_CargarExcelBD.FlatAppearance.BorderSize = 0;
            this.Button_CargarExcelBD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_CargarExcelBD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_CargarExcelBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_CargarExcelBD.Image = ((System.Drawing.Image)(resources.GetObject("Button_CargarExcelBD.Image")));
            this.Button_CargarExcelBD.Location = new System.Drawing.Point(4, 240);
            this.Button_CargarExcelBD.Margin = new System.Windows.Forms.Padding(4, 1, 4, 3);
            this.Button_CargarExcelBD.Name = "Button_CargarExcelBD";
            this.Button_CargarExcelBD.Size = new System.Drawing.Size(42, 36);
            this.Button_CargarExcelBD.TabIndex = 5;
            this.Button_CargarExcelBD.UseVisualStyleBackColor = false;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_VistaPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_VistaPrincipal.ColumnHeadersHeight = 35;
            this.DataGridView_VistaPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_VistaPrincipal.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_VistaPrincipal.EnableHeadersVisualStyles = false;
            this.DataGridView_VistaPrincipal.GridColor = System.Drawing.Color.Silver;
            this.DataGridView_VistaPrincipal.Location = new System.Drawing.Point(5, 5);
            this.DataGridView_VistaPrincipal.Name = "DataGridView_VistaPrincipal";
            this.DataGridView_VistaPrincipal.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_VistaPrincipal.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_VistaPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_VistaPrincipal.Size = new System.Drawing.Size(740, 449);
            this.DataGridView_VistaPrincipal.TabIndex = 2;
            // 
            // Panel_Busqueda
            // 
            this.Panel_Busqueda.Controls.Add(this.searchBarColor1);
            this.Panel_Busqueda.Controls.Add(this.Button_NuevoColor);
            this.Panel_Busqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Busqueda.Location = new System.Drawing.Point(0, 0);
            this.Panel_Busqueda.Name = "Panel_Busqueda";
            this.Panel_Busqueda.Size = new System.Drawing.Size(800, 40);
            this.Panel_Busqueda.TabIndex = 8;
            // 
            // searchBarColor1
            // 
            this.searchBarColor1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBarColor1.AutoComplete = new string[] {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10",
        "11",
        "12"};
            this.searchBarColor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.searchBarColor1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBarColor1.Location = new System.Drawing.Point(0, 0);
            this.searchBarColor1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBarColor1.Name = "searchBarColor1";
            this.searchBarColor1.Size = new System.Drawing.Size(661, 40);
            this.searchBarColor1.TabIndex = 5;
            // 
            // Button_NuevoColor
            // 
            this.Button_NuevoColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_NuevoColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_NuevoColor.FlatAppearance.BorderSize = 0;
            this.Button_NuevoColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_NuevoColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_NuevoColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_NuevoColor.Image = ((System.Drawing.Image)(resources.GetObject("Button_NuevoColor.Image")));
            this.Button_NuevoColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_NuevoColor.Location = new System.Drawing.Point(667, 3);
            this.Button_NuevoColor.Name = "Button_NuevoColor";
            this.Button_NuevoColor.Size = new System.Drawing.Size(129, 33);
            this.Button_NuevoColor.TabIndex = 4;
            this.Button_NuevoColor.Text = "Nuevo Color";
            this.Button_NuevoColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_NuevoColor.UseVisualStyleBackColor = false;
            this.Button_NuevoColor.Click += new System.EventHandler(this.Button_NuevoColor_Click);
            // 
            // PinturasCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel_TablaContenido);
            this.Controls.Add(this.Panel_Busqueda);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "PinturasCrud";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.PinturasCrud_Load);
            this.Panel_TablaContenido.ResumeLayout(false);
            this.FlowLayoutPanel_Acciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_VistaPrincipal)).EndInit();
            this.Panel_Busqueda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_TablaContenido;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_Acciones;
        private System.Windows.Forms.Button Button_ModificarColor;
        private System.Windows.Forms.Button Button_VerColor;
        private System.Windows.Forms.Button Button_EliminarColor;
        private System.Windows.Forms.Panel Panel_Separator;
        private System.Windows.Forms.Button Button_RefrescarTabla;
        private System.Windows.Forms.Button Button_GuardarCambios;
        private System.Windows.Forms.Button Button_ExportarExcelDB;
        private System.Windows.Forms.Button Button_CargarExcelBD;
        private System.Windows.Forms.DataGridView DataGridView_VistaPrincipal;
        private System.Windows.Forms.Panel Panel_Busqueda;
        private System.Windows.Forms.Button Button_NuevoColor;
        private SearchBarColor searchBarColor1;
    }
}
