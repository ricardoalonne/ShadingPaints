using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using CTR;

namespace ShadingPaints.Views
{
    public partial class DatosPintura : Form{
        public DatosPintura() => InitializeComponent();

        DTO_COLOR color = new DTO_COLOR();
        CTR_COLOR colorctr = new CTR_COLOR();
        public string[] meses = {"Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Setiembre","Octubre","Noviembre","Diciembre" };
        int cont = 0;

        private void Button_Cerrar_Click(object sender, EventArgs e) => this.Close();

        private void Button_Continuar_Click(object sender, EventArgs e){

            if (Label_Estadistica.BackColor == Color.Transparent)
            {
                switch (modo)
                {
                    case "R":
                        {
                            bool correcto = true;
                            if (PTextBox_NombreColor.Text == "")
                            {
                                MessageBox.Show("ERROR!! ESPACIOS EN BLANCO!!");
                                return;
                            }
                            if (PSpinnerBox_Tiempo.Text == "0" || PSpinnerBox_CostoInventario.Text == "0")
                            {
                                MessageBox.Show("ERROR!! CANTIDADES NO PUEDEN SER 0!!");
                                return;
                            }
                            string letra = "";
                            for (int i = 0; i < PSpinnerBox_Tiempo.Text.Length; i++)
                            {
                                correcto = char.IsNumber(PSpinnerBox_Tiempo.Text.Trim()[i]);
                                if (!correcto)
                                {
                                    letra += PSpinnerBox_Tiempo.Text.Trim()[i].ToString();
                                }
                            }
                            if (letra.Length > 0)
                            {
                                MessageBox.Show("ERROR!! Se ingresó letras en el tiempo de fabricacion");
                                return;
                            }
                            string letra2 = "";
                            for (int i = 0; i < PSpinnerBox_CostoInventario.Text.Length; i++)
                            {
                                correcto = char.IsNumber(PSpinnerBox_CostoInventario.Text.Trim()[i]);
                                if (!correcto)
                                {
                                    letra2 += PSpinnerBox_CostoInventario.Text.Trim()[i].ToString();
                                }
                            }
                            if (letra2.Length > 0)
                            {
                                MessageBox.Show("ERROR!! Se ingresó letras en el costo de inventario");
                                return;
                            }
                            color.COLOR = PTextBox_NombreColor.Text;
                            color.T = Int32.Parse(PSpinnerBox_Tiempo.Text);
                            color.CI = Int32.Parse(PSpinnerBox_CostoInventario.Text);
                            colorctr.Registrar(color);
                            msj(color);
                        }
                        break;
                    case "M":
                        {

                        }
                        break;
                    default: break;
                }
                Label_Pintura.BackColor = Label_Estadistica.BackColor;
                Label_Estadistica.BackColor = Color.FromArgb(240, 240, 240);
                Button_Continuar.Text = "Finalizar";
                Button_Continuar.Enabled = false;
                PTextBox_Mes.Text = meses[cont];
            }
            else {
                this.Close();
            }

            
        }

        private void Button_Agregar_Click(object sender, EventArgs e){
            //Realizar registro en CM

            //para obtener numero del mes use:
            ObtenerNumeroMes(PTextBox_Codigo.Text);

            //Cargar demanda y bandera en datagridview
            cont++;
            PTextBox_Codigo.Text = meses[cont];
            PSpinnerBox_Bandera.Value = 0;
            PSpinnerBox_Demanda.Value = 0;
            DataGridView_VistaPrincipal.Refresh();
            if (cont == 11) {
                Button_Continuar.Enabled = true;
                Button_Agregar.Enabled = false;
                PSpinnerBox_Bandera.ReadOnly = true;
                PSpinnerBox_Demanda.ReadOnly = true;
            }
        }

        public void msj(DTO_COLOR p)
        {
            switch (p.error)
            {

                case 1:
                    MessageBox.Show("ERROR!  cantidad invalida!!");
                    break;
                case 2:
                    MessageBox.Show("ERROR!  supero los 50 caracteres!!");
                    break;
                case 3:
                    MessageBox.Show("ERROR!  cantidad invalida!!");
                    break;
                case 77:
                    MessageBox.Show("REGISTRO DE COLOR EXITOSO!!");
                    PSpinnerBox_Tiempo.Text="0";
                    PSpinnerBox_CostoInventario.Text = "0";
                    PTextBox_NombreColor.Clear();
                    break;
                case 88:
                    MessageBox.Show("ACTUALIZACIÓN DE COLOR EXITOSO!!");
                    PSpinnerBox_Tiempo.Text = "0";
                    PSpinnerBox_CostoInventario.Text = "0";
                    PTextBox_NombreColor.Clear();
                    break;
            }
        }
        private string codigoPintura;
        public void CodigoPintura(string codigoPintura) => this.codigoPintura = codigoPintura;

        public int ObtenerNumeroMes(string mes) {
            switch (mes) {
                case "Enero": return 1;
                case "Febrero": return 2;
                case "Marzo": return 3;
                case "Abril": return 4;
                case "Mayo": return 5;
                case "Junio": return 6;
                case "Julio": return 7;
                case "Agosto": return 8;
                case "Setiembre": return 9;
                case "Octubre": return 10;
                case "Noviembre": return 11;
                case "Diciembre": return 12;
                default: return 0; 
            }
        }

        private string modo;
        public string Modo{
            get => modo;
            set {
                modo = value;
                switch (modo){
                    case "R": {
                            this.Text = Label_Titulo.Text = "Nueva Pintura";
                            PTextBox_NombreColor.ReadOnly = PSpinnerBox_CostoInventario.ReadOnly = PSpinnerBox_Tiempo.ReadOnly = false;
                            Button_Continuar.Text = "Registrar";
                            PTextBox_Codigo.Text = Obtener_ID_Color().ToString();
                        } break;
                    case "M": {
                            this.Text = Label_Titulo.Text = "Modificar Pintura";
                            PTextBox_NombreColor.ReadOnly = PSpinnerBox_CostoInventario.ReadOnly = PSpinnerBox_Tiempo.ReadOnly = false;
                            Button_Continuar.Text = "Modificar";
                        }
                        break;
                    case "V": {
                            this.Text = Label_Titulo.Text = "Ver detalles de Pintura";
                            PTextBox_NombreColor.ReadOnly = PSpinnerBox_CostoInventario.ReadOnly = PSpinnerBox_Tiempo.ReadOnly = true;
                            Button_Continuar.Text = "Continuar";
                        }
                        break;
                    default: break;
                }
            
            }
        }
        public int Obtener_ID_Color()
        {
            int idColor = 0;
            DataTable dtColor = new DataTable();
            dtColor = colorctr.ObtenerIDColor();
            //DataRow row = dtColor.NewRow();
            return idColor = int.Parse(dtColor.Rows[0]["ID_COLOR"].ToString())+1;
        }
    }
}
