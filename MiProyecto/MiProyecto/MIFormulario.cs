using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiProyecto
{
    public partial class MIFormulario : Form
    {
        public MIFormulario()
        {
            InitializeComponent();
        }

        //Inicio de mis variables 
        int NestadoGuarda = 0;


        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            NestadoGuarda = 1;//Es nuevo registro
            lst_mantenimiento.Enabled = false;

            txt_codigo.Text = "";
            txt_descripcion.Text = "";

            grb_mantenimiento.Enabled = true;
            txt_codigo.Enabled = true;

            grb_botonoes_principales.Enabled = false;
            txt_codigo.Focus();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txt_codigo.Text = "";
            txt_descripcion.Text = "";

            grb_mantenimiento.Enabled = false;

            grb_botonoes_principales.Enabled = true;

            lst_mantenimiento.Enabled = true;
        }

        private void MIFormulario_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string Registro;
            Registro = txt_codigo.Text.Trim() + "  |  "+ txt_descripcion.Text.Trim();

            if (NestadoGuarda == 1)//Nuevo registro
            {
                lst_mantenimiento.Items.Add(Registro);
            }
            else//actualizar registro
            {
                int ElementoSeleccionado = lst_mantenimiento.SelectedIndex;

                lst_mantenimiento.Items.Remove(lst_mantenimiento.SelectedItem);
                lst_mantenimiento.Items.Insert(ElementoSeleccionado, Registro);
                MessageBox.Show("Elemento actualizado");


            }

            MessageBox.Show("Datos guardados");

            txt_codigo.Text = "";
            txt_descripcion.Text = "";

            grb_mantenimiento.Enabled = false;
            grb_botonoes_principales.Enabled = true;

            lst_mantenimiento.Enabled = true;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            lst_mantenimiento.Items.Remove(lst_mantenimiento.SelectedItem);
            MessageBox.Show("Elemento eliminado");
        }

        private void lst_mantenimiento_Click(object sender, EventArgs e)
        {
            string TextoSeleccionado;
            int LongitudTexto;
            TextoSeleccionado = lst_mantenimiento.SelectedItem.ToString().Trim();
            LongitudTexto = TextoSeleccionado.Length;
            txt_codigo.Text = TextoSeleccionado.Substring(0, 3);
            txt_descripcion.Text = TextoSeleccionado.Substring(6, LongitudTexto - 6);
            
            
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            NestadoGuarda = 2;//Actualiza registro
            lst_mantenimiento.Enabled = false;

            grb_mantenimiento.Enabled = true;
            txt_codigo.Enabled = false;
            grb_botonoes_principales.Enabled = false;
            lst_mantenimiento.Enabled = true;

            txt_codigo.Focus();

        }
    }
}
