using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiProyecto
{
    public partial class frm_tiempo : Form
    {
        //Declaracion de variables para el formulario
        int Contador = 0; //incializando variable para el uso del timer
        //Fin de la declaracion de variables

        public frm_tiempo()
        {
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Contador < 100)
            {
                Contador++;
                txt_contador.Text = Convert.ToString(Contador);
                progressBar1.Increment(Contador);
            }
            else
            {
                timer1.Stop();
            }
           
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_detener_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
