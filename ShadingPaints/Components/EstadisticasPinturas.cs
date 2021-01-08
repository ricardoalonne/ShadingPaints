using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTR;

namespace ShadingPaints.Components
{
    public partial class EstadisticasPinturas : UserControl
    {
        public EstadisticasPinturas() => InitializeComponent(); CTR_CM objCTR_CM = new CTR_CM();

        private void EstadisticasPinturas_Load(object sender, EventArgs e){
            vistaDemanda = true;
            DataGridView_VistaPrincipal.DataSource = objCTR_CM.CTR_SelectDemandaXColorYMes();
        }

        private void RadioButton_Demanda_CheckedChanged(object sender, EventArgs e) => VistaDemanda = RadioButton_Demanda.Checked;

        private void RadioButton_Bandera_CheckedChanged(object sender, EventArgs e) => VistaBandera = RadioButton_Bandera.Checked; 


        private void RadioButton_Produccion_CheckedChanged(object sender, EventArgs e) => VistaProduccion = RadioButton_Produccion.Checked;

        private void RadioButton_Inventario_CheckedChanged(object sender, EventArgs e) => VistaInventario = RadioButton_Inventario.Checked;

        private void Button_RefrescarTabla_Click(object sender, EventArgs e){
            if(vistaDemanda) DataGridView_VistaPrincipal.DataSource = objCTR_CM.CTR_SelectDemandaXColorYMes();
            if (vistaBandera) DataGridView_VistaPrincipal.DataSource = objCTR_CM.CTR_SelectBanderaXColorYMes();
            if (vistaProduccion) DataGridView_VistaPrincipal.DataSource = objCTR_CM.CTR_SelectProduccionXColorYMes();
            if (vistaInventario) DataGridView_VistaPrincipal.DataSource = objCTR_CM.CTR_SelectInventarioXColorYMes();
            DataGridView_VistaPrincipal.Refresh();
        }

        private bool vistaDemanda = false, vistaBandera = false, vistaProduccion = false, vistaInventario = false;
        public bool VistaDemanda {
            get => vistaDemanda; 
            set{               
                vistaDemanda = value;
                DataGridView_VistaPrincipal.DataSource = objCTR_CM.CTR_SelectDemandaXColorYMes();
            }

        }

        public bool VistaBandera
        {
            get => vistaBandera;
            set
            {
                vistaBandera = value;
                DataGridView_VistaPrincipal.DataSource = objCTR_CM.CTR_SelectBanderaXColorYMes();
            }

        }

        public bool VistaProduccion
        {
            get => vistaProduccion;
            set
            {
                vistaProduccion = value;
                DataGridView_VistaPrincipal.DataSource = objCTR_CM.CTR_SelectProduccionXColorYMes();
            }

        }

        public bool VistaInventario
        {
            get => vistaInventario;
            set
            {
                vistaInventario = value;
                DataGridView_VistaPrincipal.DataSource = objCTR_CM.CTR_SelectInventarioXColorYMes();
            }

        }



    }
}
