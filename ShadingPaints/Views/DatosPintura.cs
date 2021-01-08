using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_CM;
using CTR;

namespace ShadingPaints.Views
{
    public partial class DatosPintura : Form{
        public DatosPintura() => InitializeComponent();
        DTO_COLOR color = new DTO_COLOR();
        CTR_COLOR colorctr = new CTR_COLOR();
        private void Button_Cerrar_Click(object sender, EventArgs e) => this.Close();

        private void Button_Continuar_Click(object sender, EventArgs e){
            switch (modo){
                case "R": {
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
                        color.T =Int32.Parse( PSpinnerBox_Tiempo.Text);
                        color.CI = Int32.Parse(PSpinnerBox_CostoInventario.Text);
                        colorctr.Registrar(color);
                        msj(color);
                    } break;
                case "M": {

                    }
                    break;
                default: break;
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

        private string modo;
        public string Modo{
            get => modo;
            set {
                modo = value;
                switch (modo){
                    case "R": {
                            this.Text = Label_Titulo.Text = "Nueva Pintura";
                            PTextBox_NombreColor.Enabled = PSpinnerBox_CostoInventario.Enabled = PSpinnerBox_Tiempo.Enabled = Button_Continuar.Visible = true;
                            Button_Continuar.Text = "Registrar";
                        } break;
                    case "M": {
                            this.Text = Label_Titulo.Text = "Modificar Pintura";
                            PTextBox_NombreColor.Enabled = PSpinnerBox_CostoInventario.Enabled = PSpinnerBox_Tiempo.Enabled = Button_Continuar.Visible = true;
                            Button_Continuar.Text = "Modificar";
                        }
                        break;
                    case "V": {
                            this.Text = Label_Titulo.Text = "Ver detalles de Pintura";
                            PTextBox_NombreColor.Enabled = PSpinnerBox_CostoInventario.Enabled = PSpinnerBox_Tiempo.Enabled = false;
                            Button_Continuar.Visible = false;

                        }
                        break;
                    default: break;
                }
            
            }
        }

    }
}
