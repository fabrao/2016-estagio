namespace Calculadora
{
    partial class CalculadoraForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt1 = new System.Windows.Forms.Button();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btPow3 = new System.Windows.Forms.Button();
            this.btCos = new System.Windows.Forms.Button();
            this.brSqrt2 = new System.Windows.Forms.Button();
            this.btSen = new System.Windows.Forms.Button();
            this.brPow2 = new System.Windows.Forms.Button();
            this.btLeft = new System.Windows.Forms.Button();
            this.btRight = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btBackspace = new System.Windows.Forms.Button();
            this.btResult = new System.Windows.Forms.Button();
            this.btMultiplicacao = new System.Windows.Forms.Button();
            this.btDivisao = new System.Windows.Forms.Button();
            this.btVirgula = new System.Windows.Forms.Button();
            this.btSubtracao = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.btSoma = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.bt1.Location = new System.Drawing.Point(62, 18);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(50, 50);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // tbResultado
            // 
            this.tbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResultado.Location = new System.Drawing.Point(13, 13);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(287, 38);
            this.tbResultado.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btPow3);
            this.groupBox1.Controls.Add(this.btCos);
            this.groupBox1.Controls.Add(this.brSqrt2);
            this.groupBox1.Controls.Add(this.btSen);
            this.groupBox1.Controls.Add(this.brPow2);
            this.groupBox1.Controls.Add(this.btLeft);
            this.groupBox1.Controls.Add(this.btRight);
            this.groupBox1.Controls.Add(this.bt0);
            this.groupBox1.Controls.Add(this.btBackspace);
            this.groupBox1.Controls.Add(this.btResult);
            this.groupBox1.Controls.Add(this.btMultiplicacao);
            this.groupBox1.Controls.Add(this.btDivisao);
            this.groupBox1.Controls.Add(this.btVirgula);
            this.groupBox1.Controls.Add(this.btSubtracao);
            this.groupBox1.Controls.Add(this.bt9);
            this.groupBox1.Controls.Add(this.bt8);
            this.groupBox1.Controls.Add(this.bt7);
            this.groupBox1.Controls.Add(this.btSoma);
            this.groupBox1.Controls.Add(this.bt6);
            this.groupBox1.Controls.Add(this.bt5);
            this.groupBox1.Controls.Add(this.bt4);
            this.groupBox1.Controls.Add(this.btC);
            this.groupBox1.Controls.Add(this.bt3);
            this.groupBox1.Controls.Add(this.bt2);
            this.groupBox1.Controls.Add(this.bt1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 302);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btPow3
            // 
            this.btPow3.Location = new System.Drawing.Point(62, 244);
            this.btPow3.Name = "btPow3";
            this.btPow3.Size = new System.Drawing.Size(50, 50);
            this.btPow3.TabIndex = 24;
            this.btPow3.Text = "x³";
            this.btPow3.UseVisualStyleBackColor = true;
            this.btPow3.Click += new System.EventHandler(this.btPow3_Click);
            // 
            // btCos
            // 
            this.btCos.Location = new System.Drawing.Point(174, 244);
            this.btCos.Name = "btCos";
            this.btCos.Size = new System.Drawing.Size(50, 50);
            this.btCos.TabIndex = 23;
            this.btCos.Text = "cos";
            this.btCos.UseVisualStyleBackColor = true;
            this.btCos.Click += new System.EventHandler(this.btCos_Click);
            // 
            // brSqrt2
            // 
            this.brSqrt2.Location = new System.Drawing.Point(4, 132);
            this.brSqrt2.Name = "brSqrt2";
            this.brSqrt2.Size = new System.Drawing.Size(50, 50);
            this.brSqrt2.TabIndex = 22;
            this.brSqrt2.Text = "²√";
            this.brSqrt2.UseVisualStyleBackColor = true;
            this.brSqrt2.Click += new System.EventHandler(this.brSqrt2_Click);
            // 
            // btSen
            // 
            this.btSen.Location = new System.Drawing.Point(118, 244);
            this.btSen.Name = "btSen";
            this.btSen.Size = new System.Drawing.Size(50, 50);
            this.btSen.TabIndex = 21;
            this.btSen.Text = "sin";
            this.btSen.UseVisualStyleBackColor = true;
            this.btSen.Click += new System.EventHandler(this.btSen_Click);
            // 
            // brPow2
            // 
            this.brPow2.Location = new System.Drawing.Point(6, 244);
            this.brPow2.Name = "brPow2";
            this.brPow2.Size = new System.Drawing.Size(50, 50);
            this.brPow2.TabIndex = 20;
            this.brPow2.Text = "x²";
            this.brPow2.UseVisualStyleBackColor = true;
            this.brPow2.Click += new System.EventHandler(this.brPow2_Click);
            // 
            // btLeft
            // 
            this.btLeft.Location = new System.Drawing.Point(6, 188);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(50, 50);
            this.btLeft.TabIndex = 19;
            this.btLeft.Text = "(";
            this.btLeft.UseVisualStyleBackColor = true;
            this.btLeft.Click += new System.EventHandler(this.btLeft_Click);
            // 
            // btRight
            // 
            this.btRight.Location = new System.Drawing.Point(62, 188);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(50, 50);
            this.btRight.TabIndex = 18;
            this.btRight.Text = ")";
            this.btRight.UseVisualStyleBackColor = true;
            this.btRight.Click += new System.EventHandler(this.btRight_Click);
            // 
            // bt0
            // 
            this.bt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.bt0.Location = new System.Drawing.Point(118, 188);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(50, 50);
            this.bt0.TabIndex = 17;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // btBackspace
            // 
            this.btBackspace.Location = new System.Drawing.Point(6, 74);
            this.btBackspace.Name = "btBackspace";
            this.btBackspace.Size = new System.Drawing.Size(50, 50);
            this.btBackspace.TabIndex = 16;
            this.btBackspace.Text = "←";
            this.btBackspace.UseVisualStyleBackColor = true;
            this.btBackspace.Click += new System.EventHandler(this.btBackspace_Click);
            // 
            // btResult
            // 
            this.btResult.Location = new System.Drawing.Point(230, 244);
            this.btResult.Name = "btResult";
            this.btResult.Size = new System.Drawing.Size(50, 50);
            this.btResult.TabIndex = 15;
            this.btResult.Text = "=";
            this.btResult.UseVisualStyleBackColor = true;
            this.btResult.Click += new System.EventHandler(this.btResult_Click);
            // 
            // btMultiplicacao
            // 
            this.btMultiplicacao.Location = new System.Drawing.Point(230, 74);
            this.btMultiplicacao.Name = "btMultiplicacao";
            this.btMultiplicacao.Size = new System.Drawing.Size(50, 50);
            this.btMultiplicacao.TabIndex = 14;
            this.btMultiplicacao.Text = "*";
            this.btMultiplicacao.UseVisualStyleBackColor = true;
            this.btMultiplicacao.Click += new System.EventHandler(this.btMultiplicacao_Click);
            // 
            // btDivisao
            // 
            this.btDivisao.Location = new System.Drawing.Point(230, 18);
            this.btDivisao.Name = "btDivisao";
            this.btDivisao.Size = new System.Drawing.Size(50, 50);
            this.btDivisao.TabIndex = 13;
            this.btDivisao.Text = "÷";
            this.btDivisao.UseVisualStyleBackColor = true;
            this.btDivisao.Click += new System.EventHandler(this.btDivisao_Click);
            // 
            // btVirgula
            // 
            this.btVirgula.Location = new System.Drawing.Point(174, 188);
            this.btVirgula.Name = "btVirgula";
            this.btVirgula.Size = new System.Drawing.Size(50, 50);
            this.btVirgula.TabIndex = 12;
            this.btVirgula.Text = ",";
            this.btVirgula.UseVisualStyleBackColor = true;
            this.btVirgula.Click += new System.EventHandler(this.btVirgula_Click);
            // 
            // btSubtracao
            // 
            this.btSubtracao.Location = new System.Drawing.Point(230, 130);
            this.btSubtracao.Name = "btSubtracao";
            this.btSubtracao.Size = new System.Drawing.Size(50, 50);
            this.btSubtracao.TabIndex = 11;
            this.btSubtracao.Text = "-";
            this.btSubtracao.UseVisualStyleBackColor = true;
            this.btSubtracao.Click += new System.EventHandler(this.btSubtracao_Click);
            // 
            // bt9
            // 
            this.bt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.bt9.Location = new System.Drawing.Point(174, 130);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(50, 50);
            this.bt9.TabIndex = 10;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // bt8
            // 
            this.bt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.bt8.Location = new System.Drawing.Point(118, 130);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(50, 50);
            this.bt8.TabIndex = 9;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt7
            // 
            this.bt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.bt7.Location = new System.Drawing.Point(62, 130);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(50, 50);
            this.bt7.TabIndex = 8;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // btSoma
            // 
            this.btSoma.Location = new System.Drawing.Point(230, 188);
            this.btSoma.Name = "btSoma";
            this.btSoma.Size = new System.Drawing.Size(50, 50);
            this.btSoma.TabIndex = 7;
            this.btSoma.Text = "+";
            this.btSoma.UseVisualStyleBackColor = true;
            this.btSoma.Click += new System.EventHandler(this.btSoma_Click);
            // 
            // bt6
            // 
            this.bt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.bt6.Location = new System.Drawing.Point(174, 74);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(50, 50);
            this.bt6.TabIndex = 6;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt5
            // 
            this.bt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.bt5.Location = new System.Drawing.Point(118, 74);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(50, 50);
            this.bt5.TabIndex = 5;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt4
            // 
            this.bt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.bt4.Location = new System.Drawing.Point(62, 74);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(50, 50);
            this.bt4.TabIndex = 4;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // btC
            // 
            this.btC.Location = new System.Drawing.Point(6, 18);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(50, 50);
            this.btC.TabIndex = 3;
            this.btC.Text = "C";
            this.btC.UseVisualStyleBackColor = true;
            this.btC.Click += new System.EventHandler(this.btC_Click);
            // 
            // bt3
            // 
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.bt3.Location = new System.Drawing.Point(174, 18);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(50, 50);
            this.bt3.TabIndex = 2;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.bt2.Location = new System.Drawing.Point(118, 18);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(50, 50);
            this.bt2.TabIndex = 1;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(12, 63);
            this.lbError.Name = "lbError";
            this.lbError.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbError.Size = new System.Drawing.Size(0, 13);
            this.lbError.TabIndex = 5;
            // 
            // CalculadoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 386);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbResultado);
            this.Name = "CalculadoraForm";
            this.Text = "Calculadora";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btResult;
        private System.Windows.Forms.Button btMultiplicacao;
        private System.Windows.Forms.Button btDivisao;
        private System.Windows.Forms.Button btVirgula;
        private System.Windows.Forms.Button btSubtracao;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button btSoma;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.Button btRight;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btBackspace;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Button btPow3;
        private System.Windows.Forms.Button btCos;
        private System.Windows.Forms.Button brSqrt2;
        private System.Windows.Forms.Button btSen;
        private System.Windows.Forms.Button brPow2;
    }
}

