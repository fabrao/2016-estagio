using System;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using Microsoft.JScript;        // needs a reference to Microsoft.JScript.dll
using Microsoft.JScript.Vsa;    // needs a reference to Microsoft.Vsa.dll

namespace Calculadora {

    public partial class CalculadoraForm : Form {
        public Expression expre;
        public CalculadoraForm() {
            InitializeComponent();

        }
        #region Numeric_Buttons_Click
        private void bt0_Click(object sender, EventArgs e) {
            tbResultado.Text += bt0.Text;
        }
        private void bt1_Click(object sender, EventArgs e) {
            tbResultado.Text += bt1.Text;
        }

        private void bt2_Click(object sender, EventArgs e) {
            tbResultado.Text += bt2.Text;

        }

        private void bt3_Click(object sender, EventArgs e) {
            tbResultado.Text += bt3.Text;
        }

        private void bt4_Click(object sender, EventArgs e) {
            tbResultado.Text += bt4.Text;
        }

        private void bt5_Click(object sender, EventArgs e) {
            tbResultado.Text += bt5.Text;
        }

        private void bt6_Click(object sender, EventArgs e) {
            tbResultado.Text += bt6.Text;
        }

        private void bt7_Click(object sender, EventArgs e) {
            tbResultado.Text += bt7.Text;
        }

        private void bt8_Click(object sender, EventArgs e) {
            tbResultado.Text += bt8.Text;
        }

        private void bt9_Click(object sender, EventArgs e) {
            tbResultado.Text += bt9.Text;
        }
        #endregion


        #region Operations_Buttons_Click
        private void btSubtracao_Click(object sender, EventArgs e) {
            if (Char.IsNumber(tbResultado.Text.Last()) || tbResultado.Text.Last().Equals(")")) {
                tbResultado.Text += btSubtracao.Text;
            }
        }

        private void btSoma_Click(object sender, EventArgs e) {
            if (Char.IsNumber(tbResultado.Text.Last()) || tbResultado.Text.Last().Equals(")")) {
                tbResultado.Text += btSoma.Text;
            }
        }

        private void btMultiplicacao_Click(object sender, EventArgs e) {
            if (Char.IsNumber(tbResultado.Text.Last()) || tbResultado.Text.Last().Equals(")")) {
                tbResultado.Text += btMultiplicacao.Text;
            }
        }

        private void btDivisao_Click(object sender, EventArgs e) {
            if (Char.IsNumber(tbResultado.Text.Last()) || tbResultado.Text.Last().Equals(")")) {
                tbResultado.Text += btDivisao.Text;
            }
        }

        private void brPow2_Click(object sender, EventArgs e) {
            if (Char.IsNumber(tbResultado.Text.Last())) {
                tbResultado.Text = tbResultado.Text.Remove(tbResultado.Text.Length - 1) +
                     "pow(" + tbResultado.Text.ElementAt(tbResultado.Text.Length - 1) + ",2)";
            }
        }

        private void btPow3_Click(object sender, EventArgs e) {
            if (Char.IsNumber(tbResultado.Text.Last())) {
                tbResultado.Text = tbResultado.Text.Remove(tbResultado.Text.Length - 1) +
                  "pow(" + tbResultado.Text.ElementAt(tbResultado.Text.Length - 1) + ",3)";
            }
        }

        private void brSqrt2_Click(object sender, EventArgs e) {
            if (Char.IsNumber(tbResultado.Text.Last())) {
                tbResultado.Text = tbResultado.Text.Remove(tbResultado.Text.Length - 1) +
                 "√(" + tbResultado.Text.ElementAt(tbResultado.Text.Length - 1) + ",2)";
            }
        }

        private void btSen_Click(object sender, EventArgs e) {
            if (Char.IsNumber(tbResultado.Text.Last())) {
                tbResultado.Text = tbResultado.Text.Remove(tbResultado.Text.Length - 1) +
                 "sin(" + tbResultado.Text.ElementAt(tbResultado.Text.Length - 1) + ")";
            }
        }

        private void btCos_Click(object sender, EventArgs e) {
            if (Char.IsNumber(tbResultado.Text.Last())) {
                tbResultado.Text = tbResultado.Text.Remove(tbResultado.Text.Length - 1) +
                "cos(" + tbResultado.Text.ElementAt(tbResultado.Text.Length - 1) + ")";
            }
        }
        #endregion


        #region Others_Buttons_Click
        private void btVirgula_Click(object sender, EventArgs e) {
            if (Char.IsNumber(tbResultado.Text.Last())) {
                tbResultado.Text += ".";
            }
        }

        private void btBackspace_Click(object sender, EventArgs e) {
            tbResultado.Text = tbResultado.Text.Remove(tbResultado.Text.Length - 1);
            //tbResultado.Text += tbResultado.Text.Length;
        }

        private void btC_Click(object sender, EventArgs e) {
            tbResultado.Text = "";
        }

        private void btLeft_Click(object sender, EventArgs e) {
            try {
                if (Char.IsNumber(tbResultado.Text.Last())) {
                    tbResultado.Text += "*" + btLeft.Text;
                } else {
                    tbResultado.Text += btLeft.Text;
                }
            } catch {
                tbResultado.Text += btLeft.Text;
            }
        }

        private void btRight_Click(object sender, EventArgs e) {
            try {
                if (Char.IsNumber(tbResultado.Text.Last()) || tbResultado.Text.Last().Equals("(")) {
                    tbResultado.Text += btRight.Text;
                }
            } catch {

            }
        }
        #endregion




        private void btResult_Click(object sender, EventArgs e) {
            String temResult = tbResultado.Text;

            tbResultado.Text = tbResultado.Text.Replace("÷", "/");
            tbResultado.Text = tbResultado.Text.Replace("pow(", "Math.pow(");
            tbResultado.Text = tbResultado.Text.Replace("√(", "Math.sqrt(");
            tbResultado.Text = tbResultado.Text.Replace("sin(", "Math.sin(");
            tbResultado.Text = tbResultado.Text.Replace("cos(", "Math.cos(");


            try {

                tbResultado.Text = JScriptEval(tbResultado.Text).ToString();
                //tbResultado.Text = JScriptEval("Math.exp").ToString();
                lbError.Text = "";
            } catch {
                if (tbResultado.Text.Equals("")) {
                    lbError.Text = "";

                } else {
                    lbError.Text = "Erro: Equação incoreta";
                    tbResultado.Text = temResult;
                }
            }
        }

        
        public static VsaEngine _engine = VsaEngine.CreateEngine();

        public static string JScriptEval(string expr) {
            return Eval.JScriptEvaluate(expr, _engine).ToString();
        }
    }
}
