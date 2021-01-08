using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ShadingPaints.Components;

namespace ShadingPaints
{
    public partial class ShadingPaints : Form
    {
        public ShadingPaints() => InitializeComponent();

        private void ShadingPaints_Load(object sender, EventArgs e){
            VistaPinturas = true;
        }

        private void RadioButton_Pinturas_CheckedChanged(object sender, EventArgs e) => VistaPinturas = RadioButton_Pinturas.Checked;

        private void RadioButton_Estadisticas_CheckedChanged(object sender, EventArgs e) => VistaEstadisticas = RadioButton_Estadisticas.Checked;

        private void RadioButton_Configuracion_CheckedChanged(object sender, EventArgs e) => VistaConfiguracion = RadioButton_Configuracion.Checked;

        private bool vistaPinturas = false, vistaEstadisticas = false, vistaConfiguracion = false;

        public bool VistaPinturas{
            get => vistaPinturas;
            set{
                pinturasCrud1.Visible = vistaPinturas = value;
            }

        }

        public bool VistaEstadisticas{
            get => vistaEstadisticas;
            set{
                estadisticasPinturas1.Visible = vistaEstadisticas = value;
            }

        }

        public bool VistaConfiguracion{
            get => vistaConfiguracion;
            set{
                vistaConfiguracion = value;
            }

        }

    }
}
