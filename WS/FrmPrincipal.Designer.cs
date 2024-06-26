namespace WS
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnContinuar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbAdmi = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.rbMudanca = new System.Windows.Forms.RadioButton();
            this.rbDemi = new System.Windows.Forms.RadioButton();
            this.rbPerio = new System.Windows.Forms.RadioButton();
            this.rbRetorno = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFunc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(551, 288);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(159, 38);
            this.btnContinuar.TabIndex = 0;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Passo 1";
            // 
            // rbAdmi
            // 
            this.rbAdmi.AutoSize = true;
            this.rbAdmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdmi.Location = new System.Drawing.Point(52, 90);
            this.rbAdmi.Name = "rbAdmi";
            this.rbAdmi.Size = new System.Drawing.Size(91, 17);
            this.rbAdmi.TabIndex = 2;
            this.rbAdmi.TabStop = true;
            this.rbAdmi.Text = "Admissional";
            this.rbAdmi.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(44, 173);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(153, 20);
            this.txtNome.TabIndex = 3;
            // 
            // rbMudanca
            // 
            this.rbMudanca.AutoSize = true;
            this.rbMudanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMudanca.Location = new System.Drawing.Point(161, 90);
            this.rbMudanca.Name = "rbMudanca";
            this.rbMudanca.Size = new System.Drawing.Size(141, 17);
            this.rbMudanca.TabIndex = 4;
            this.rbMudanca.TabStop = true;
            this.rbMudanca.Text = "Mudança de Função";
            this.rbMudanca.UseVisualStyleBackColor = true;
            // 
            // rbDemi
            // 
            this.rbDemi.AutoSize = true;
            this.rbDemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDemi.Location = new System.Drawing.Point(338, 90);
            this.rbDemi.Name = "rbDemi";
            this.rbDemi.Size = new System.Drawing.Size(92, 17);
            this.rbDemi.TabIndex = 5;
            this.rbDemi.TabStop = true;
            this.rbDemi.Text = "Demissional";
            this.rbDemi.UseVisualStyleBackColor = true;
            // 
            // rbPerio
            // 
            this.rbPerio.AutoSize = true;
            this.rbPerio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPerio.Location = new System.Drawing.Point(480, 90);
            this.rbPerio.Name = "rbPerio";
            this.rbPerio.Size = new System.Drawing.Size(78, 17);
            this.rbPerio.TabIndex = 6;
            this.rbPerio.TabStop = true;
            this.rbPerio.Text = "Periódico";
            this.rbPerio.UseVisualStyleBackColor = true;
            // 
            // rbRetorno
            // 
            this.rbRetorno.AutoSize = true;
            this.rbRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRetorno.Location = new System.Drawing.Point(597, 90);
            this.rbRetorno.Name = "rbRetorno";
            this.rbRetorno.Size = new System.Drawing.Size(142, 17);
            this.rbRetorno.TabIndex = 7;
            this.rbRetorno.TabStop = true;
            this.rbRetorno.Text = "Retorno ao Trabalho";
            this.rbRetorno.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Idade :";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(44, 227);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(153, 20);
            this.txtIdade.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "RG :";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(44, 279);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(153, 20);
            this.txtRG.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Função :";
            // 
            // txtFunc
            // 
            this.txtFunc.Location = new System.Drawing.Point(44, 340);
            this.txtFunc.Name = "txtFunc";
            this.txtFunc.Size = new System.Drawing.Size(153, 20);
            this.txtFunc.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Empresa :";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(44, 397);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(153, 20);
            this.txtEmpresa.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ocupação :";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFunc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbRetorno);
            this.Controls.Add(this.rbPerio);
            this.Controls.Add(this.rbDemi);
            this.Controls.Add(this.rbMudanca);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.rbAdmi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnContinuar);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exame Clínico Ocupacional";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAdmi;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton rbMudanca;
        private System.Windows.Forms.RadioButton rbDemi;
        private System.Windows.Forms.RadioButton rbPerio;
        private System.Windows.Forms.RadioButton rbRetorno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFunc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label7;
    }
}

