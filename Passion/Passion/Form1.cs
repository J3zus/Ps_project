using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passion
{
    public partial class Fcarga : Form
    {
        public Fcarga()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Se Inicia el timer de carga de la pantalla
            timer1.Start();
        }

        private void Runprincipal()
        {
            Login frm = new Login();
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Se manejan hilos para crrar la ventana de carga sin detener todo el programa
            System.Threading.Thread NuevoHilo = new System.Threading.Thread(new System.Threading.ThreadStart(Runprincipal));
            this.Close();
            NuevoHilo.SetApartmentState(System.Threading.ApartmentState.STA);
            NuevoHilo.Start();

            // Cambiar de ventana
            timer1.Enabled = false;
        }
    }
}
