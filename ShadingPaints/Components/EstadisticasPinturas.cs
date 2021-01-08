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
        CTR_CM objCTR_CM;
        public EstadisticasPinturas()
        {
            InitializeComponent();
            objCTR_CM = new CTR_CM();
        }

        private void btnDemanda_CheckedChanged(object sender, EventArgs e)
        {
            DataGridView_VistaPrincipal.DataSource= objCTR_CM.CTR_SelectDemandaXColorYMes();
        }
    }
}
