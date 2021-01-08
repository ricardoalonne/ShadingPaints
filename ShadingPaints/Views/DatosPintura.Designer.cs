
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
            this.Label_Titulo = new System.Windows.Forms.Label();
            this.Panel_Opciones = new System.Windows.Forms.Panel();
            this.Button_Continuar = new System.Windows.Forms.Button();
            this.Button_Cerrar = new System.Windows.Forms.Button();
            this.PTextBox_Codigo = new PeinUIWFA.Controls.PTextBox();
            this.PTextBox_NombreColor = new PeinUIWFA.Controls.PTextBox();
            this.PSpinnerBox_Tiempo = new PeinUIWFA.Controls.PSpinnerBox();
            this.PSpinnerBox_CostoInventario = new PeinUIWFA.Controls.PSpinnerBox();
            this.Panel_Opciones.SuspendLayout();
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
            this.Label_Titulo.Size = new System.Drawing.Size(390, 50);
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
            this.Panel_Opciones.Location = new System.Drawing.Point(0, 185);
            this.Panel_Opciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel_Opciones.Name = "Panel_Opciones";
            this.Panel_Opciones.Size = new System.Drawing.Size(390, 48);
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
            this.Button_Continuar.Location = new System.Drawing.Point(263, 5);
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
            // PTextBox_Codigo
            // 
            this.PTextBox_Codigo.AcceptsReturn = false;
            this.PTextBox_Codigo.AcceptsTab = false;
            this.PTextBox_Codigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PTextBox_Codigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PTextBox_Codigo.BackColor = System.Drawing.Color.Transparent;
            this.PTextBox_Codigo.BorderColor = System.Drawing.Color.Black;
            this.PTextBox_Codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PTextBox_Codigo.Enabled = false;
            this.PTextBox_Codigo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PTextBox_Codigo.FundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PTextBox_Codigo.HideSelection = true;
            this.PTextBox_Codigo.Intelligence = false;
            this.PTextBox_Codigo.Location = new System.Drawing.Point(12, 63);
            this.PTextBox_Codigo.MaxLength = 32767;
            this.PTextBox_Codigo.MinimumSize = new System.Drawing.Size(200, 48);
            this.PTextBox_Codigo.Name = "PTextBox_Codigo";
            this.PTextBox_Codigo.ReadOnly = false;
            this.PTextBox_Codigo.SelectBorderColor = System.Drawing.Color.Black;
            this.PTextBox_Codigo.ShortcutsEnabled = true;
            this.PTextBox_Codigo.Size = new System.Drawing.Size(200, 48);
            this.PTextBox_Codigo.Spacing = new System.Windows.Forms.Padding(10);
            this.PTextBox_Codigo.TabIndex = 6;
            this.PTextBox_Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PTextBox_Codigo.Title = "Codigo";
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
            this.PTextBox_NombreColor.Location = new System.Drawing.Point(12, 121);
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
            this.PSpinnerBox_Tiempo.Location = new System.Drawing.Point(218, 63);
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
            this.PSpinnerBox_Tiempo.Size = new System.Drawing.Size(160, 50);
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
            this.PSpinnerBox_CostoInventario.Location = new System.Drawing.Point(218, 121);
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
            this.PSpinnerBox_CostoInventario.Size = new System.Drawing.Size(160, 50);
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
            // DatosPintura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 233);
            this.Controls.Add(this.PSpinnerBox_CostoInventario);
            this.Controls.Add(this.PSpinnerBox_Tiempo);
            this.Controls.Add(this.PTextBox_NombreColor);
            this.Controls.Add(this.PTextBox_Codigo);
            this.Controls.Add(this.Panel_Opciones);
            this.Controls.Add(this.Label_Titulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DatosPintura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatosPintura";
            this.Panel_Opciones.ResumeLayout(false);
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
    }
}