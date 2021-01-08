
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
            this.Button_ModificarSolicitud = new System.Windows.Forms.Button();
            this.Button_VerSolicitud = new System.Windows.Forms.Button();
            this.Button_EliminarSolicitud = new System.Windows.Forms.Button();
            this.Panel_Separator = new System.Windows.Forms.Panel();
            this.Button_RefrescarTabla = new System.Windows.Forms.Button();
            this.Button_GuardarCambios = new System.Windows.Forms.Button();
            this.Button_ExportarExcelDB = new System.Windows.Forms.Button();
            this.DataGridView_VistaPrincipal = new System.Windows.Forms.DataGridView();
            this.Panel_Busqueda = new System.Windows.Forms.Panel();
        
            this.Button_NuevaSolicitud = new System.Windows.Forms.Button();
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
            this.FlowLayoutPanel_Acciones.Controls.Add(this.Button_ModificarSolicitud);
            this.FlowLayoutPanel_Acciones.Controls.Add(this.Button_VerSolicitud);
            this.FlowLayoutPanel_Acciones.Controls.Add(this.Button_EliminarSolicitud);
            this.FlowLayoutPanel_Acciones.Controls.Add(this.Panel_Separator);
            this.FlowLayoutPanel_Acciones.Controls.Add(this.Button_RefrescarTabla);
            this.FlowLayoutPanel_Acciones.Controls.Add(this.Button_GuardarCambios);
            this.FlowLayoutPanel_Acciones.Controls.Add(this.Button_ExportarExcelDB);
            this.FlowLayoutPanel_Acciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.FlowLayoutPanel_Acciones.Location = new System.Drawing.Point(750, 0);
            this.FlowLayoutPanel_Acciones.Margin = new System.Windows.Forms.Padding(0);
            this.FlowLayoutPanel_Acciones.Name = "FlowLayoutPanel_Acciones";
            this.FlowLayoutPanel_Acciones.Size = new System.Drawing.Size(50, 460);
            this.FlowLayoutPanel_Acciones.TabIndex = 9;
            // 
            // Button_ModificarSolicitud
            // 
            this.Button_ModificarSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_ModificarSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_ModificarSolicitud.FlatAppearance.BorderSize = 0;
            this.Button_ModificarSolicitud.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_ModificarSolicitud.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_ModificarSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ModificarSolicitud.Image = ((System.Drawing.Image)(resources.GetObject("Button_ModificarSolicitud.Image")));
            this.Button_ModificarSolicitud.Location = new System.Drawing.Point(4, 3);
            this.Button_ModificarSolicitud.Margin = new System.Windows.Forms.Padding(4, 3, 4, 1);
            this.Button_ModificarSolicitud.Name = "Button_ModificarSolicitud";
            this.Button_ModificarSolicitud.Size = new System.Drawing.Size(42, 36);
            this.Button_ModificarSolicitud.TabIndex = 5;
            this.Button_ModificarSolicitud.UseVisualStyleBackColor = false;
            // 
            // Button_VerSolicitud
            // 
            this.Button_VerSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_VerSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_VerSolicitud.FlatAppearance.BorderSize = 0;
            this.Button_VerSolicitud.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_VerSolicitud.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_VerSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_VerSolicitud.Image = ((System.Drawing.Image)(resources.GetObject("Button_VerSolicitud.Image")));
            this.Button_VerSolicitud.Location = new System.Drawing.Point(4, 41);
            this.Button_VerSolicitud.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.Button_VerSolicitud.Name = "Button_VerSolicitud";
            this.Button_VerSolicitud.Size = new System.Drawing.Size(42, 36);
            this.Button_VerSolicitud.TabIndex = 6;
            this.Button_VerSolicitud.UseVisualStyleBackColor = false;
            // 
            // Button_EliminarSolicitud
            // 
            this.Button_EliminarSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_EliminarSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_EliminarSolicitud.FlatAppearance.BorderSize = 0;
            this.Button_EliminarSolicitud.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_EliminarSolicitud.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_EliminarSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_EliminarSolicitud.Image = ((System.Drawing.Image)(resources.GetObject("Button_EliminarSolicitud.Image")));
            this.Button_EliminarSolicitud.Location = new System.Drawing.Point(4, 79);
            this.Button_EliminarSolicitud.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.Button_EliminarSolicitud.Name = "Button_EliminarSolicitud";
            this.Button_EliminarSolicitud.Size = new System.Drawing.Size(42, 36);
            this.Button_EliminarSolicitud.TabIndex = 6;
            this.Button_EliminarSolicitud.UseVisualStyleBackColor = false;
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
            this.DataGridView_VistaPrincipal.RowHeadersWidth = 51;
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
           
            this.Panel_Busqueda.Controls.Add(this.Button_NuevaSolicitud);
            this.Panel_Busqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Busqueda.Location = new System.Drawing.Point(0, 0);
            this.Panel_Busqueda.Name = "Panel_Busqueda";
            this.Panel_Busqueda.Size = new System.Drawing.Size(800, 40);
            this.Panel_Busqueda.TabIndex = 8;
            // 
            // searchBarColor1
            // 
           
        
            // 
            // Button_NuevaSolicitud
            // 
            this.Button_NuevaSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_NuevaSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_NuevaSolicitud.FlatAppearance.BorderSize = 0;
            this.Button_NuevaSolicitud.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_NuevaSolicitud.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_NuevaSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_NuevaSolicitud.Image = ((System.Drawing.Image)(resources.GetObject("Button_NuevaSolicitud.Image")));
            this.Button_NuevaSolicitud.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_NuevaSolicitud.Location = new System.Drawing.Point(667, 3);
            this.Button_NuevaSolicitud.Name = "Button_NuevaSolicitud";
            this.Button_NuevaSolicitud.Size = new System.Drawing.Size(129, 33);
            this.Button_NuevaSolicitud.TabIndex = 4;
            this.Button_NuevaSolicitud.Text = "Nuevo Color";
            this.Button_NuevaSolicitud.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_NuevaSolicitud.UseVisualStyleBackColor = false;
            // 
            // PinturasCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel_TablaContenido);
            this.Controls.Add(this.Panel_Busqueda);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "PinturasCrud";
            this.Size = new System.Drawing.Size(800, 500);
            this.Panel_TablaContenido.ResumeLayout(false);
            this.FlowLayoutPanel_Acciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_VistaPrincipal)).EndInit();
            this.Panel_Busqueda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_TablaContenido;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_Acciones;
        private System.Windows.Forms.Button Button_ModificarSolicitud;
        private System.Windows.Forms.Button Button_VerSolicitud;
        private System.Windows.Forms.Button Button_EliminarSolicitud;
        private System.Windows.Forms.Panel Panel_Separator;
        private System.Windows.Forms.Button Button_RefrescarTabla;
        private System.Windows.Forms.Button Button_GuardarCambios;
        private System.Windows.Forms.Button Button_ExportarExcelDB;
        private System.Windows.Forms.DataGridView DataGridView_VistaPrincipal;
        private System.Windows.Forms.Panel Panel_Busqueda;
        private System.Windows.Forms.Button Button_NuevaSolicitud;
       
    }
}
