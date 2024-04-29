using System;
using System.Windows.Forms;

namespace PPDes
{
    public partial class pedidos : Form
    {
        public pedidos()
        {
            InitializeComponent();
        }

        private void pedidos_Load(object sender, EventArgs e)
        {
            
        }
        

        private void btngua_Click_1(object sender, EventArgs e)
        {
            operacionesExcel OperacionesExcel = new operacionesExcel();
            string dato1= txtnom.Text;
            string dato2= txtciu.Text;
            string dato3= txtcor.Text;
            string dato4= txttel.Text;
            string dato5 = comboBox1.Text;
            string dato6 = txtdir.Text;
            string dato7 = txtar.Text;


            OperacionesExcel.ingresarUsuarios(dato1, dato2,dato3, dato4, dato5, dato6, dato7); 


        }
        private void btnatr_Click(object sender, EventArgs e)
        {
            
            frmPrincipal pri = new frmPrincipal();
            pri.Show();
            this.Hide();
        }


        private void txttel_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo puede ingresar números", "Alerta", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        
    }
}