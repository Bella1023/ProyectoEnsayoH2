using System;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using DocumentFormat.OpenXml.Spreadsheet;

namespace PPDes
{
    public partial class verPedidos : Form
    {
        public verPedidos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnmos_Click(object sender, EventArgs e)
        {
            operacionesExcel operacionesExcel = new operacionesExcel();
            System.Data.DataTable dt = operacionesExcel.ConvertirExcel();
            dataGridView1.DataSource = dt;
        }

        private void btnsal_Click(object sender, EventArgs e)
        {
            frmPrincipal pri = new frmPrincipal();
            pri.Show();
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtusu.Text =Convert.ToString(dataGridView1.CurrentRow.Cells["Nombre"].Value);
            txttel.Text =Convert.ToString(dataGridView1.CurrentRow.Cells["Telefono"].Value);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnel_Click(object sender, EventArgs e)
        {
           // Workbook wb = new Workbook("Pedidos.xlsx");
            //Worksheet sheet =  wb.Worksheets[0];
            //sheet.Cells.DeleteRows(1, 7);
            //wb.Save("");
        }
    }
}