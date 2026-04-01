namespace P1
{
    partial class PaginaInicial
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btSetores = new System.Windows.Forms.Button();
            this.btEmpregados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(80, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(232, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "RH Soluções";
            // 
            // btSetores
            // 
            this.btSetores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSetores.Location = new System.Drawing.Point(50, 120);
            this.btSetores.Name = "btSetores";
            this.btSetores.Size = new System.Drawing.Size(130, 60);
            this.btSetores.TabIndex = 1;
            this.btSetores.Text = "Cadastro de Setores";
            this.btSetores.UseVisualStyleBackColor = true;
            this.btSetores.Click += new System.EventHandler(this.btSetores_Click);
            // 
            // btEmpregados
            // 
            this.btEmpregados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmpregados.Location = new System.Drawing.Point(210, 120);
            this.btEmpregados.Name = "btEmpregados";
            this.btEmpregados.Size = new System.Drawing.Size(130, 60);
            this.btEmpregados.TabIndex = 2;
            this.btEmpregados.Text = "Cadastro de Empregados";
            this.btEmpregados.UseVisualStyleBackColor = true;
            this.btEmpregados.Click += new System.EventHandler(this.btEmpregados_Click);
            // 
            // PaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.btEmpregados);
            this.Controls.Add(this.btSetores);
            this.Controls.Add(this.lblTitulo);
            this.Name = "PaginaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Página Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btSetores;
        private System.Windows.Forms.Button btEmpregados;
    }
}