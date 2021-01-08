using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadingPaints.Components
{
    public partial class EstadisticasPinturas : UserControl
    {
        public EstadisticasPinturas() => InitializeComponent();

        private void EstadisticasPinturas_Load(object sender, EventArgs e){
            vistaDemanda = true;
        }

        private void RadioButton_Demanda_CheckedChanged(object sender, EventArgs e) => VistaDemanda = RadioButton_Demanda.Checked;

        private void RadioButton_Bandera_CheckedChanged(object sender, EventArgs e) => VistaBandera = RadioButton_Bandera.Checked;

        private void RadioButton_Produccion_CheckedChanged(object sender, EventArgs e) => VistaProduccion = RadioButton_Produccion.Checked;

        private void RadioButton_Inventario_CheckedChanged(object sender, EventArgs e) => VistaInventario = RadioButton_Inventario.Checked;

        private void Button_RefrescarTabla_Click(object sender, EventArgs e){
            if(vistaDemanda) //CargarvistaDemanda
            if(vistaBandera) //CargarvistaBandera
            if(vistaProduccion) //CargarvistaProduccion
            if(vistaInventario) //CargarvistaInventario
            DataGridView_VistaPrincipal.Refresh();
        }

        private bool vistaDemanda = false, vistaBandera = false, vistaProduccion = false, vistaInventario = false;
        public bool VistaDemanda {
            get => vistaDemanda;
            set{
                vistaDemanda = value;

            }

        }

        public bool VistaBandera
        {
            get => vistaBandera;
            set
            {
                vistaBandera = value;

            }

        }

        public bool VistaProduccion
        {
            get => vistaProduccion;
            set
            {
                vistaProduccion = value;

            }

        }

        public bool VistaInventario
        {
            get => vistaInventario;
            set
            {
                vistaInventario = value;

            }

        }


    }
}
