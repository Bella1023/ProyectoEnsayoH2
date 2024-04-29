using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPDes
{
    public partial class frmPrincipal : Form
    {
        public usuario UsuarioActual {get;set; }
        public frmPrincipal() // colocar parametros
        {
            
            InitializeComponent();
        }
        
        public void ActualizarCampos(usuario user)
        {
            UsuarioActual = user;
            if (UsuarioActual.UsuarioId != "Admin")
            {
                verTodosLosPedidosToolStripMenuItem.Visible = false;
                hacerUnPedidoToolStripMenuItem.Visible = true;
                verOpinionesToolStripMenuItem.Visible = false;
            }
            else
            {
                verTodosLosPedidosToolStripMenuItem.Visible = true;
                hacerUnPedidoToolStripMenuItem.Visible = true;
                verOpinionesToolStripMenuItem.Visible = true;
            }
        }

        private void btnatr_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hasta pronto...");

            frminiciosesion ini = new frminiciosesion();
            ini.Show();

            this.Hide();
        }

        private void hacerUnPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pedidos ped = new pedidos();
            ped.Show();
            this.Hide();
        }

        private void verTodosLosPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verPedidos ped = new verPedidos();
            ped.Show();
            this.Hide();
        }



        private void mujeresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogoMujer cat = new CatalogoMujer();
            cat.Show();
            this.Hide();
        }

    }
}
