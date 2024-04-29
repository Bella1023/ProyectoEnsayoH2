using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Spreadsheet;

namespace PPDes
{
    public partial class frminiciosesion : Form
    {
        public frminiciosesion()
        {
            InitializeComponent();
        }

        private void btnini_Click(object sender, EventArgs e)
        {
            string variable_usuario = txtusu.Text;
            string variable_contra = txtcon.Text;

            string Usuario = "Usuario";
            string Contrasena = "1234";

            string Usuario_admin = "Admin";
            string Contrasena_admin = "4321";
            
            if (!string.IsNullOrEmpty(variable_usuario) && !string.IsNullOrEmpty(variable_contra))
            {
                usuario id = new usuario{UsuarioId = variable_usuario}; //Conecta la clase
                
                // condicion para acceder como usuario
                if (variable_usuario == Usuario && variable_contra == Contrasena)
                {
                    frmPrincipal pri = new frmPrincipal();
                    pri.ActualizarCampos(id);
                    pri.Show();
                    this.Hide();
                }
                else if (variable_usuario == Usuario_admin && variable_contra == Contrasena_admin)
                {
                    frmPrincipal pri = new frmPrincipal();
                    pri.ActualizarCampos(id);
                    pri.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error", "Usuario no encontrado");
                    txtusu.Text = " ";
                    txtcon.Text = " ";

                    txtusu.Focus();
                }
            }
            else
            {
                MessageBox.Show("Las casillas estan vacias");
            }
            
            
        }

        private void btnsal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
