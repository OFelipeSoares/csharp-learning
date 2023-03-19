namespace conta.cs
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
            this.button1 = new System.Windows.Forms.Button();
            this.saldoConta = new System.Windows.Forms.TextBox();
            this.titularConta = new System.Windows.Forms.TextBox();
            this.numeroConta = new System.Windows.Forms.TextBox();
            this.numero = new System.Windows.Forms.Label();
            this.saldo = new System.Windows.Forms.Label();
            this.titular = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 82);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Conta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saldoConta
            // 
            this.saldoConta.Location = new System.Drawing.Point(63, 243);
            this.saldoConta.Name = "saldoConta";
            this.saldoConta.Size = new System.Drawing.Size(180, 22);
            this.saldoConta.TabIndex = 1;
            this.saldoConta.Text = "0,0";
            this.saldoConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // titularConta
            // 
            this.titularConta.Location = new System.Drawing.Point(63, 165);
            this.titularConta.Name = "titularConta";
            this.titularConta.Size = new System.Drawing.Size(180, 22);
            this.titularConta.TabIndex = 2;
            this.titularConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numeroConta
            // 
            this.numeroConta.Location = new System.Drawing.Point(63, 92);
            this.numeroConta.Name = "numeroConta";
            this.numeroConta.Size = new System.Drawing.Size(180, 22);
            this.numeroConta.TabIndex = 3;
            this.numeroConta.Text = "0";
            this.numeroConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.Location = new System.Drawing.Point(133, 60);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(55, 16);
            this.numero.TabIndex = 4;
            this.numero.Text = "Numero";
            // 
            // saldo
            // 
            this.saldo.AutoSize = true;
            this.saldo.Location = new System.Drawing.Point(133, 217);
            this.saldo.Name = "saldo";
            this.saldo.Size = new System.Drawing.Size(43, 16);
            this.saldo.TabIndex = 5;
            this.saldo.Text = "Saldo";
            // 
            // titular
            // 
            this.titular.AutoSize = true;
            this.titular.Location = new System.Drawing.Point(133, 138);
            this.titular.Name = "titular";
            this.titular.Size = new System.Drawing.Size(44, 16);
            this.titular.TabIndex = 6;
            this.titular.Text = "Titular";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 82);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add Conta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(321, 532);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.titular);
            this.Controls.Add(this.saldo);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.numeroConta);
            this.Controls.Add(this.titularConta);
            this.Controls.Add(this.saldoConta);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox saldoConta;
        private System.Windows.Forms.TextBox titularConta;
        private System.Windows.Forms.TextBox numeroConta;
        private System.Windows.Forms.Label numero;
        private System.Windows.Forms.Label saldo;
        private System.Windows.Forms.Label titular;
        private System.Windows.Forms.Button button2;
    }
}

