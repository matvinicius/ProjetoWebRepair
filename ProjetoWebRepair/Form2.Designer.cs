
namespace ProjetoWebRepair
{
    partial class Form2
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnPecas = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gold;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::ProjetoWebRepair.Properties.Resources.Close_icon;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(301, 297);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(242, 134);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Encerrar sessão";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.Gold;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Image = global::ProjetoWebRepair.Properties.Resources._10278_man_mechanic_icon;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(23, 297);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(242, 134);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Cadastro de clientes";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnPecas
            // 
            this.btnPecas.BackColor = System.Drawing.Color.Gold;
            this.btnPecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPecas.Image = global::ProjetoWebRepair.Properties.Resources.Tools_icon;
            this.btnPecas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPecas.Location = new System.Drawing.Point(301, 113);
            this.btnPecas.Name = "btnPecas";
            this.btnPecas.Size = new System.Drawing.Size(242, 134);
            this.btnPecas.TabIndex = 1;
            this.btnPecas.Text = "Cadastro de peças";
            this.btnPecas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPecas.UseVisualStyleBackColor = false;
            this.btnPecas.Click += new System.EventHandler(this.btnPecas_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.Gold;
            this.btnCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastro.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Image = global::ProjetoWebRepair.Properties.Resources.Car_Repair_icon;
            this.btnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.Location = new System.Drawing.Point(23, 113);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(242, 134);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.Text = "Cadastro de serviço";
            this.btnCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(564, 542);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnPecas);
            this.Controls.Add(this.btnCadastro);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnPecas;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnExit;
    }
}