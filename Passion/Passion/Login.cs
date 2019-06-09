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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RunLogin()
        {
            Main frm = new Main();
            frm.ShowDialog();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            
            if(CbxUsuario.Text == "Gabriela" && TxtContraseña.Text =="12345")
            {
                System.Threading.Thread NuevoHilo = new System.Threading.Thread(new System.Threading.ThreadStart(RunLogin));
                this.Close();
                NuevoHilo.SetApartmentState(System.Threading.ApartmentState.STA);
                NuevoHilo.Start();

            }
            else
            {
                MessageBox.Show("Datos Erroneos");
            }
        }

        private void TxtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Evento para que al precionar enter se ejecute lo mismo que el boton de aceptar
            string a;
            a = Convert.ToString(e.KeyChar);

            if(a == "\r") //Compara si es enter
            {
                if (CbxUsuario.Text == "Gabriela" && TxtContraseña.Text == "12345")
                {
                    System.Threading.Thread NuevoHilo = new System.Threading.Thread(new System.Threading.ThreadStart(RunLogin));
                    this.Close();
                    NuevoHilo.SetApartmentState(System.Threading.ApartmentState.STA);
                    NuevoHilo.Start();
                }
                else
                {
                    MessageBox.Show("Datos Erroneos");
                }
            }
        }
    }
}
