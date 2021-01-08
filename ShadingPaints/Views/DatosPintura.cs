using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadingPaints.Views
{
    public partial class DatosPintura : Form{
        public DatosPintura() => InitializeComponent();

        private void Button_Cerrar_Click(object sender, EventArgs e) => this.Close();

        private void Button_Continuar_Click(object sender, EventArgs e){
            switch (modo){
                case "R": {

                    } break;
                case "M": {

                    }
                    break;
                default: break;
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
