﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using CTR;
using ShadingPaints.Views;

namespace ShadingPaints.Components
{
    public partial class PinturasCrud : UserControl{
        public PinturasCrud()
        {
            InitializeComponent();
            
        }
        DTO_COLOR color = new DTO_COLOR();
        CTR_COLOR colorctr = new CTR_COLOR();
        DatosPintura datosPintura;

        private void PinturasCrud_Load(object sender, EventArgs e){
            CargarListaColor_T_CI();
            searchBarColor1.DataGridView(DataGridView_VistaPrincipal);
        }

        private void CargarListaColor_T_CI()
        {
            DataGridView_VistaPrincipal.DataSource = colorctr.ListarSColores();
            DataGridView_VistaPrincipal.Columns[0].ReadOnly = true;
        }

        private void Button_NuevoColor_Click(object sender, EventArgs e){
            datosPintura = new DatosPintura();
            datosPintura.Modo = "R";
            datosPintura.ShowDialog();
        }

        private void Button_VerColor_Click(object sender, EventArgs e){
            DataGridView_VistaPrincipal.Select();
            string codigoPintura = DataGridView_VistaPrincipal.CurrentRow.Cells["ID_COLOR"].Value.ToString();
            datosPintura = new DatosPintura();
            datosPintura.CodigoPintura(codigoPintura);
            datosPintura.Modo = "V";
            datosPintura.ShowDialog();
        }

        private void Button_ModificarColor_Click(object sender, EventArgs e){
            DataGridView_VistaPrincipal.Select();
            string codigoPintura = DataGridView_VistaPrincipal.CurrentRow.Cells["ID_COLOR"].Value.ToString();
            datosPintura = new DatosPintura();
            datosPintura.CodigoPintura(codigoPintura);
            datosPintura.Modo = "M";
            datosPintura.ShowDialog();
        }

        private void Button_EliminarColor_Click(object sender, EventArgs e){

        }

        private void Button_GuardarCambios_Click(object sender, EventArgs e)
        {
            bool correcto = true;
            if (DataGridView_VistaPrincipal.CurrentRow.Cells["COLOR"].Value.ToString() == "")
            {
                MessageBox.Show("ERROR!! ESPACIOS EN BLANCO!!");
                return;
            }
            if (Int32.Parse(DataGridView_VistaPrincipal.CurrentRow.Cells["T"].Value.ToString()).ToString() == "0" || Int32.Parse(DataGridView_VistaPrincipal.CurrentRow.Cells["CI"].Value.ToString()).ToString() == "0")
            {
                MessageBox.Show("ERROR!! CANTIDADES NO PUEDEN SER 0!!");
                return;
            }
            string letra = "";
            for (int i = 0; i < Int32.Parse(DataGridView_VistaPrincipal.CurrentRow.Cells["T"].Value.ToString().Length.ToString()); i++)
            {
                correcto = char.IsNumber(Int32.Parse(DataGridView_VistaPrincipal.CurrentRow.Cells["T"].Value.ToString()).ToString()[i]);
                if (!correcto)
                {
                    letra += Int32.Parse(DataGridView_VistaPrincipal.CurrentRow.Cells["T"].Value.ToString()).ToString()[i].ToString();
                }
            }
            if (letra.Length > 0)
            {
                MessageBox.Show("ERROR!! Se ingresó letras en el tiempo de fabricacion");
                return;
            }
            string letra2 = "";
            for (int i = 0; i < Int32.Parse(DataGridView_VistaPrincipal.CurrentRow.Cells["CI"].Value.ToString().Length.ToString()); i++)
            {
                correcto = char.IsNumber(Int32.Parse(DataGridView_VistaPrincipal.CurrentRow.Cells["CI"].Value.ToString()).ToString()[i]);
                if (!correcto)
                {
                    letra2 += Int32.Parse(DataGridView_VistaPrincipal.CurrentRow.Cells["CI"].Value.ToString()).ToString()[i].ToString();
                }
            }
            if (letra2.Length > 0)
            {
                MessageBox.Show("ERROR!! Se ingresó letras en el costo de inventario");
                return;
            }
            color.ID_COLOR =Int32.Parse( DataGridView_VistaPrincipal.CurrentRow.Cells["ID_COLOR"].Value.ToString());
            color.COLOR = DataGridView_VistaPrincipal.CurrentRow.Cells["COLOR"].Value.ToString();
            color.T = Int32.Parse(DataGridView_VistaPrincipal.CurrentRow.Cells["T"].Value.ToString());
            color.CI = Int32.Parse(DataGridView_VistaPrincipal.CurrentRow.Cells["CI"].Value.ToString());
            colorctr.ActualizarDetalleSP(color);
            msj(color);
            CargarListaColor_T_CI();
        }

        private void Button_RefrescarTabla_Click(object sender, EventArgs e){
            CargarListaColor_T_CI();
            DataGridView_VistaPrincipal.Refresh();
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
                    break;
                case 88:
                    MessageBox.Show("ACTUALIZACIÓN DE COLOR EXITOSO!!");
                    break;
            }
        }

        
    }
}
