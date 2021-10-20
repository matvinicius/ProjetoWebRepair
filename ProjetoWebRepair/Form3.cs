using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProjetoWebRepair
{
    public partial class Form3 : Form
    {
        Thread nt;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double vlProduto, vlServico, total;

            vlProduto = Double.Parse(txtProdutos.Text);
            vlServico = Double.Parse(txtServicos.Text);

            total = vlProduto + vlServico;
            txtTotal.Text = "R$ " + total.ToString("F2");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoForm()
        {
            Application.Run(new Form2());
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ordem de serviço cadastrada com sucesso !");
            this.Close();
            nt = new Thread(novoForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
    }
}
