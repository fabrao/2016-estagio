using System;
using System.Windows.Forms;

namespace OrganizacaoWFApp.Controllers {
    public class ExportToExcel {
        public void ToExcel(DataGridView grdExport) {
            Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
            if (grdExport.Rows.Count > 0) {
                try {
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < grdExport.Columns.Count + 1; i++)
                        XcelApp.Cells[1, i] = grdExport.Columns[i - 1].HeaderText;
                    for (int i = 0; i <= grdExport.Rows.Count - 1; i++) {
                        for (int j = 0; j < grdExport.Columns.Count; j++) {
                            try {
                                string aux = grdExport.Rows[i].Cells[j].Value.ToString();
                                aux = aux.Replace("00:00:00", "");
                                XcelApp.Cells[i + 2, j + 1] = aux;
                            } catch {
                                XcelApp.Cells[i + 2, j + 1] = "";
                            }
                        }
                    }
                    XcelApp.Columns.AutoFit();
                    XcelApp.Visible = true;
                } catch (Exception ex) {
                    MessageBox.Show("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
            }
        }
    }
}