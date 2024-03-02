
namespace ProjetoLojaABC
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(24, 28);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(211, 220);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Location = new System.Drawing.Point(24, 267);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(211, 220);
            this.btnFuncionarios.TabIndex = 1;
            this.btnFuncionarios.Text = "Fucionários";
            this.btnFuncionarios.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(283, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 220);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnProdutos
            // 
            this.btnProdutos.Location = new System.Drawing.Point(283, 28);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(211, 220);
            this.btnProdutos.TabIndex = 2;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(543, 267);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(211, 220);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.Location = new System.Drawing.Point(543, 28);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(211, 220);
            this.btnFornecedores.TabIndex = 4;
            this.btnFornecedores.Text = "Fornecedores";
            this.btnFornecedores.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(543, 495);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(215, 52);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnFornecedores);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnFuncionarios);
            this.Controls.Add(this.btnClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LojaABC - Menu principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnFornecedores;
        private System.Windows.Forms.Button button7;
    }
}