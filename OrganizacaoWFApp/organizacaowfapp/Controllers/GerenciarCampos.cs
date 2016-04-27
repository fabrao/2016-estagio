using System;
using System.Windows.Forms;

namespace OrganizacaoWFApp.Controllers {
    public class GerenciarCampos {
        public bool ExistemCamposVazios(TextBox txtb, ErrorProvider errorProvider) {
            string c1 = txtb.Text;
            if (String.IsNullOrEmpty(c1)) {
                errorProvider.SetError(txtb, "Campo obrigatório!");
                return true;
            } else
                errorProvider.Clear();
                return false;
        }
        public bool ConfirmaSair() {
            DialogResult result = MessageBox.Show("Deseja encerrar a operação?", "Fechar janela", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }
        public bool VerficaData1MenorIgualData2(DateTimePicker dtp1, string nomeData1, DateTimePicker dtp2, string nomeData2, ErrorProvider error1, ErrorProvider error2) {
            DateTime dt1 = dtp1.Value;
            DateTime dt2 = dtp2.Value;
            if (DateTime.Compare(dt1, dt2) <= 0) {
                error1.Clear();
                error2.Clear();                
                return true;
            } else {
                error1.SetError(dtp1, nomeData1 + " não pode ser posterior a " + nomeData2);
                error2.SetError(dtp2, nomeData1 + " não pode ser posterior a " + nomeData2);
                return false;
            }
        }
        public void AlterarFormatoDateTimePicker(DateTimePicker dtp1, DateTimePicker dtp2) {
            dtp1.Format = DateTimePickerFormat.Custom;
            dtp1.CustomFormat = "dd/MM/yyyy";
            dtp2.Format = DateTimePickerFormat.Custom;
            dtp2.CustomFormat = "dd/MM/yyyy";
        }
        public void AlterarFormatoDateTimePicker(DateTimePicker dtp1, DateTimePicker dtp2, DateTimePicker dtp3 = null) {
            dtp1.Format = DateTimePickerFormat.Custom;
            dtp1.CustomFormat = "dd/MM/yyyy";
            dtp2.Format = DateTimePickerFormat.Custom;
            dtp2.CustomFormat = "dd/MM/yyyy";
            dtp3.Format = DateTimePickerFormat.Custom;
            dtp3.CustomFormat = "dd/MM/yyyy";
        }

        public bool ComboBoxIsEmpty(ComboBox cbo, ErrorProvider error) {
            if (cbo.Items.Count <= 0) {
                error.SetError(cbo, "Não existem itens cadastrados ou itens não atuaram durante o período de execução do projeto");
                return true;
            } else {
                error.Clear();
                return false;
            }

        }
    }
}