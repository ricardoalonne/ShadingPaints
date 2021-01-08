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
using DTO;
using PeinCoreWFA;

namespace ShadingPaints.Components
{
    public partial class SearchBarColor : UserControl
    {
        public SearchBarColor()
        {
            InitializeComponent();
        }

        private string messageSearchBox = "Buscar en el sistema e internet.";
        private ControlController controlController;
        private string[] autoComplete;

        public DataGridView dgv;

        private void SearchBar_BackColorChanged(object sender, EventArgs e) {
            this.ComboBox_Filtro.BackColor = this.BackColor;
        }

        private void SearchBar_Load(object sender, EventArgs e) {
            controlController = new ControlController();
            TextBox_Búsqueda.Text = messageSearchBox = "Buscar en los colores de pinturas";
            LoadItemsFilter(new string[] { "Codigo", "Nombre", "Tiempo", "Costo"});
            SearchBoxInteractive();
        }

        private void Button_Buscar_Click(object sender, EventArgs e) => Search();
        //---------------------------------------------------------------------------------------------

        public void DataGridView(DataGridView dgv) => this.dgv = dgv;

        public void RefreshDataGridView() => dgv.Refresh();

        public void LoadItemsFilter(string[] items){
            controlController.ChangeItems(ComboBox_Filtro, items);
            ComboBox_Filtro.Text = items[0];
        }

        public void SearchBoxInteractive() {
            this.TextBox_Búsqueda.DoubleClick += new EventHandler(TextBox_Búsqueda_DoubleClick);
            this.TextBox_Búsqueda.Enter += new EventHandler(TextBox_Búsqueda_Enter);
            this.TextBox_Búsqueda.KeyDown += new KeyEventHandler(TextBox_Búsqueda_KeyDown);
            this.TextBox_Búsqueda.Leave += new EventHandler(TextBox_Búsqueda_Leave);

            void TextBox_Búsqueda_DoubleClick(object sender, EventArgs e) { TextBox_Búsqueda.Clear(); TextBox_Búsqueda.Select(); }

            void TextBox_Búsqueda_KeyDown(object sender, KeyEventArgs e){
                if (e.KeyCode == Keys.Enter){
                    Search(); Button_Buscar.Select();
                }
            }
            void TextBox_Búsqueda_Enter(object sender, EventArgs e){
                if (TextBox_Búsqueda.Text == messageSearchBox){
                    TextBox_Búsqueda.Text = ""; TextBox_Búsqueda.Select();
                    TextBox_Búsqueda.Location = new Point(6, 11);
                    TextBox_Búsqueda.Font = new Font(TextBox_Búsqueda.Font, FontStyle.Regular);
                    TextBox_Búsqueda.ForeColor = Color.Black;
                    Button_Buscar.Visible = true;
                    PictureBox_ImagenBuscar.Visible = !Button_Buscar.Visible;
                }
            }
            void TextBox_Búsqueda_Leave(object sender, EventArgs e){
                if (TextBox_Búsqueda.Text.Trim().Length == 0){
                    TextBox_Búsqueda.Text = messageSearchBox;
                    TextBox_Búsqueda.Location = new Point(41, 11);
                    Button_Buscar.Visible = false;
                    TextBox_Búsqueda.ForeColor = Color.Gray;
                    TextBox_Búsqueda.Font = new Font(TextBox_Búsqueda.Font, FontStyle.Italic);
                    PictureBox_ImagenBuscar.Visible = !Button_Buscar.Visible;
                }
            }

        }

        private string pintura;
        DTO_COLOR color = new DTO_COLOR();
        CTR_COLOR colorctr = new CTR_COLOR();

        public virtual void Search() {
            if (TextBox_Búsqueda.Text == "")
            {
                MessageBox.Show("ERROR!! ESPACIOS EN BLANCO!!");
                return;
            }
            color.ID_COLOR = int.Parse(TextBox_Búsqueda.Text);
            /*if (!colorctr.ExistenciaColor(color))
            {
                MessageBox.Show("ERROR!! Color INEXISTENTE!!");
                return;
            }*/
            pintura = color.ID_COLOR.ToString();
            //var listaConsultas = colorctr.ConsultarPinturas(FilterText, SearchText);
            //dgv.DataSource = listaConsultas;
        }
        private string[] ConsultarEnColores(string filtro)
        {
            switch (filtro){
                case "Codigo": filtro = "ID_COLOR"; break;
                case "Nombre": filtro = "COLOR"; break;
                case "Tiempo": filtro = "T"; break;
                case "Costo": filtro = "CI"; break;
                default: break;
            }
            List<string> result = new List<string>();
            foreach (DataRow row in colorctr.ListarSColores().Rows)
            {
                result.Add(row[filtro].ToString());
            }
            result.RemoveAll(str => String.IsNullOrEmpty(str));
            return result.ToArray();
        }

        //-------------------------------------------------------------------------------------------------------

        public void ResetState() => TextBox_Búsqueda.Text = messageSearchBox;

        public string[] AutoComplete {
            get => autoComplete;
            set {
                autoComplete = value;
                if(autoComplete != null && controlController != null) controlController.AutoComplete(TextBox_Búsqueda, autoComplete);
            }
        }

        public string Pintura() => pintura;

        public virtual void ComboBox_Filtro_SelectedIndexChanged(object sender, EventArgs e) => AutoComplete = ConsultarEnColores(ComboBox_Filtro.Text);

        
    }
}
