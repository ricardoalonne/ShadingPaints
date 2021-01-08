
using ShadingPaints.Components;

namespace ShadingPaints
{
    partial class ShadingPaints
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
            this.RadioButton_Pinturas = new System.Windows.Forms.RadioButton();
            this.RadioButton_Estadisticas = new System.Windows.Forms.RadioButton();
            this.RadioButton_Configuracion = new System.Windows.Forms.RadioButton();
            this.estadisticasPinturas1 = new EstadisticasPinturas();
            this.pinturasCrud1 = new PinturasCrud();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RadioButton_Pinturas
            // 
            this.RadioButton_Pinturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioButton_Pinturas.Appearance = System.Windows.Forms.Appearance.Button;
            this.RadioButton_Pinturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RadioButton_Pinturas.Checked = true;
            this.RadioButton_Pinturas.FlatAppearance.BorderSize = 0;
            this.RadioButton_Pinturas.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RadioButton_Pinturas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RadioButton_Pinturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RadioButton_Pinturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RadioButton_Pinturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RadioButton_Pinturas.Location = new System.Drawing.Point(0, 0);
            this.RadioButton_Pinturas.Margin = new System.Windows.Forms.Padding(0);
            this.RadioButton_Pinturas.Name = "RadioButton_Pinturas";
            this.RadioButton_Pinturas.Size = new System.Drawing.Size(406, 35);
            this.RadioButton_Pinturas.TabIndex = 4;
            this.RadioButton_Pinturas.TabStop = true;
            this.RadioButton_Pinturas.Text = "Pinturas";
            this.RadioButton_Pinturas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RadioButton_Pinturas.UseVisualStyleBackColor = false;
            // 
            // RadioButton_Estadisticas
            // 
            this.RadioButton_Estadisticas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioButton_Estadisticas.Appearance = System.Windows.Forms.Appearance.Button;
            this.RadioButton_Estadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RadioButton_Estadisticas.FlatAppearance.BorderSize = 0;
            this.RadioButton_Estadisticas.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RadioButton_Estadisticas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RadioButton_Estadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RadioButton_Estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RadioButton_Estadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RadioButton_Estadisticas.Location = new System.Drawing.Point(406, 0);
            this.RadioButton_Estadisticas.Margin = new System.Windows.Forms.Padding(0);
            this.RadioButton_Estadisticas.Name = "RadioButton_Estadisticas";
            this.RadioButton_Estadisticas.Size = new System.Drawing.Size(406, 35);
            this.RadioButton_Estadisticas.TabIndex = 5;
            this.RadioButton_Estadisticas.Text = "Estadísticas";
            this.RadioButton_Estadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RadioButton_Estadisticas.UseVisualStyleBackColor = false;
            // 
            // RadioButton_Configuracion
            // 
            this.RadioButton_Configuracion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioButton_Configuracion.Appearance = System.Windows.Forms.Appearance.Button;
            this.RadioButton_Configuracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RadioButton_Configuracion.FlatAppearance.BorderSize = 0;
            this.RadioButton_Configuracion.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RadioButton_Configuracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RadioButton_Configuracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RadioButton_Configuracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RadioButton_Configuracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RadioButton_Configuracion.Location = new System.Drawing.Point(812, 0);
            this.RadioButton_Configuracion.Margin = new System.Windows.Forms.Padding(0);
            this.RadioButton_Configuracion.Name = "RadioButton_Configuracion";
            this.RadioButton_Configuracion.Size = new System.Drawing.Size(407, 35);
            this.RadioButton_Configuracion.TabIndex = 7;
            this.RadioButton_Configuracion.Text = "Configuración";
            this.RadioButton_Configuracion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RadioButton_Configuracion.UseVisualStyleBackColor = false;
            // 
            // estadisticasPinturas1
            // 
            this.estadisticasPinturas1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.estadisticasPinturas1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadisticasPinturas1.Location = new System.Drawing.Point(0, 39);
            this.estadisticasPinturas1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.estadisticasPinturas1.MinimumSize = new System.Drawing.Size(800, 500);
            this.estadisticasPinturas1.Name = "estadisticasPinturas1";
            this.estadisticasPinturas1.Size = new System.Drawing.Size(981, 520);
            this.estadisticasPinturas1.TabIndex = 7;
            this.estadisticasPinturas1.Visible = false;
            // 
            // pinturasCrud1
            // 
            this.pinturasCrud1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pinturasCrud1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinturasCrud1.Location = new System.Drawing.Point(3, 39);
            this.pinturasCrud1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pinturasCrud1.MinimumSize = new System.Drawing.Size(800, 500);
            this.pinturasCrud1.Name = "pinturasCrud1";
            this.pinturasCrud1.Size = new System.Drawing.Size(978, 520);
            this.pinturasCrud1.TabIndex = 8;
            this.pinturasCrud1.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.RadioButton_Configuracion, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.RadioButton_Pinturas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RadioButton_Estadisticas, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1219, 35);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // ShadingPaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.estadisticasPinturas1);
            this.Controls.Add(this.pinturasCrud1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ShadingPaints";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shading Paints";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton RadioButton_Pinturas;
        private System.Windows.Forms.RadioButton RadioButton_Estadisticas;
        private System.Windows.Forms.RadioButton RadioButton_Configuracion;
        private EstadisticasPinturas estadisticasPinturas1;
        private PinturasCrud pinturasCrud1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

