using OfficeOpenXml;
using System.Data;
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace PPDes
{
    public class operacionesExcel
    
    {
        public void crearExcel()
        {
            Excel.Application excelapp = new Excel.Application(); //Crear excel
            
            // Abrir el archivo de excel
            Excel.Workbook excelWorkbook =
                excelapp.Workbooks.Open(
                    @"C:\Users\Isabella Tobon\source\repos\PPDes\Pedidos.xlsx");

            //Ubicamos la primera hoja
            Excel._Worksheet excelWorksheet = excelWorkbook.Sheets[1];

            //Leer celda A1
            Excel.Range excelRange = excelWorksheet.UsedRange;
            excelRange.Cells[1, 1] = "Nuevo valor";

            //Guardar cambios

            excelWorkbook.Save();
            excelWorkbook.Close();
            excelapp.Quit();
        }
        
        
        public void ingresarUsuarios(string dato1, string dato2, string dato3, string dato4, string dato5, string dato6, string dato7)
        {
            
            int intData;
            if (!int.TryParse(dato4, out intData))
            {
                MessageBox.Show("El tipo de dato ingresado para data1 no es el esperado. Se esperaba un entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //Crear excel
            Excel.Application excelapp = new Excel.Application(); //Crear el excel  

            // Abrir el archivo de excel
            Excel.Workbook excelWorkbook =
                excelapp.Workbooks.Open(
                    @"C:\Users\Isabella Tobon\source\repos\PPDes\Pedidos.xlsx");

            //Ubicamos la primera hoja
            Excel._Worksheet excelWorksheet = excelWorkbook.Sheets[1];

            //Encontrar la ultima fila que tiene datos en las columnas

            int ultimaFila = excelWorksheet.Cells[excelWorksheet.Rows.Count, 1].End(Excel.XlDirection.xlUp).Row;

            //Escribir los datos

            excelWorksheet.Cells[ultimaFila + 1, 1] = dato1;
            excelWorksheet.Cells[ultimaFila + 1, 2] = dato2;
            excelWorksheet.Cells[ultimaFila + 1, 3] = dato3;
            excelWorksheet.Cells[ultimaFila + 1, 4] = dato4;
            excelWorksheet.Cells[ultimaFila + 1, 5] = dato5;
            excelWorksheet.Cells[ultimaFila + 1, 6] = dato6;
            excelWorksheet.Cells[ultimaFila + 1, 7] = dato7;

            //Guardar cambios

            excelWorkbook.Save();
            excelWorkbook.Close();
            excelapp.Quit();

        }

        public DataTable ConvertirExcel()
        {
            using (ExcelPackage package = new ExcelPackage(new FileInfo(@"C:\Users\Isabella Tobon\source\repos\PPDes\Pedidos.xlsx")))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                DataTable dt = new DataTable();
                foreach (var firstRowCell in worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
                {
                    dt.Columns.Add(firstRowCell.Text);
                }

                for (int rowNumber = 2; rowNumber <= worksheet.Dimension.End.Row; rowNumber++)
                {
                    var row = worksheet.Cells[rowNumber, 1, rowNumber, worksheet.Dimension.End.Column];
                    DataRow newRow = dt.NewRow();
                    foreach (var cell in row)
                    {
                        newRow[cell.Start.Column - 1] = cell.Text;
                    }

                    dt.Rows.Add(newRow);
                }

                return dt;
            }
        }

        public void escribirDatos(string data1, string data2, string data3)
        {
            using (ExcelPackage package = new ExcelPackage(new FileInfo(@"C:\Users\Isabella Tobon\source\repos\PPDes\Pedidos.xlsx")))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int lastRow = worksheet.Dimension.End.Row;
                worksheet.Cells[lastRow + 1, 1].Value = data1;
                worksheet.Cells[lastRow + 1, 2].Value = data2;
                worksheet.Cells[lastRow + 1, 3].Value = data3;
                package.Save();

            }
        }
        
       
    }
}