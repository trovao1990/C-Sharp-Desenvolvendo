namespace DesenvolvendoCaixaEletronico
{
    partial class Form1
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
            this.btnBuscarInfos = new System.Windows.Forms.Button();
            this.txtBoxNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxSaldo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxCpf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBuscarInfos
            // 
            this.btnBuscarInfos.Location = new System.Drawing.Point(95, 191);
            this.btnBuscarInfos.Name = "btnBuscarInfos";
            this.btnBuscarInfos.Size = new System.Drawing.Size(85, 32);
            this.btnBuscarInfos.TabIndex = 0;
            this.btnBuscarInfos.Text = "Buscar Dados";
            this.btnBuscarInfos.UseVisualStyleBackColor = true;
            this.btnBuscarInfos.Click += new System.EventHandler(this.btnBuscarInfos_Click);
            // 
            // txtBoxNumero
            // 
            this.txtBoxNumero.Location = new System.Drawing.Point(111, 12);
            this.txtBoxNumero.Name = "txtBoxNumero";
            this.txtBoxNumero.Size = new System.Drawing.Size(137, 20);
            this.txtBoxNumero.TabIndex = 1;
            this.txtBoxNumero.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número da Conta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome do Cliente:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(111, 39);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(137, 20);
            this.txtNomeCliente.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saldo:";
            // 
            // txtBoxSaldo
            // 
            this.txtBoxSaldo.Location = new System.Drawing.Point(111, 97);
            this.txtBoxSaldo.Name = "txtBoxSaldo";
            this.txtBoxSaldo.Size = new System.Drawing.Size(137, 20);
            this.txtBoxSaldo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CPF";
            // 
            // txtBoxCpf
            // 
            this.txtBoxCpf.Location = new System.Drawing.Point(111, 67);
            this.txtBoxCpf.Name = "txtBoxCpf";
            this.txtBoxCpf.Size = new System.Drawing.Size(137, 20);
            this.txtBoxCpf.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtBoxCpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxSaldo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxNumero);
            this.Controls.Add(this.btnBuscarInfos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarInfos;
        private System.Windows.Forms.TextBox txtBoxNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxSaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxCpf;
    }
}

