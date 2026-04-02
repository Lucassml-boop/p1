namespace P1
{
    partial class Form1
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
            this.btEmpregados = new System.Windows.Forms.Button();
            this.btgravar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodSetor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSetor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cód Setor:";
            // 
            // txtCodSetor
            // 
            this.txtCodSetor.Location = new System.Drawing.Point(120, 27);
            this.txtCodSetor.Name = "txtCodSetor";
            this.txtCodSetor.Size = new System.Drawing.Size(100, 20);
            this.txtCodSetor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Setor:";
            // 
            // txtSetor
            // 
            this.txtSetor.Location = new System.Drawing.Point(120, 67);
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.Size = new System.Drawing.Size(200, 20);
            this.txtSetor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(120, 107);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(200, 60);
            this.txtDescricao.TabIndex = 6;
            // 
            // btgravar
            // 
            this.btgravar.Location = new System.Drawing.Point(120, 190);
            this.btgravar.Name = "btgravar";
            this.btgravar.Size = new System.Drawing.Size(75, 40);
            this.btgravar.TabIndex = 7;
            this.btgravar.Text = "Gravar";
            this.btgravar.UseVisualStyleBackColor = true;
            this.btgravar.Click += new System.EventHandler(this.Btgravar_Click);
            // 
            // btEmpregados
            // 
            this.btEmpregados.Location = new System.Drawing.Point(210, 190);
            this.btEmpregados.Name = "btEmpregados";
            this.btEmpregados.Size = new System.Drawing.Size(110, 40);
            this.btEmpregados.TabIndex = 0;
            this.btEmpregados.Text = "Ir para Empregados";
            this.btEmpregados.UseVisualStyleBackColor = true;
            this.btEmpregados.Click += new System.EventHandler(this.BtEmpregados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 260);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSetor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodSetor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btgravar);
            this.Controls.Add(this.btEmpregados);
            this.Name = "Form1";
            this.Text = "Cadastro de Setores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btEmpregados;
        private System.Windows.Forms.Button btgravar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodSetor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSetor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
    }
}

