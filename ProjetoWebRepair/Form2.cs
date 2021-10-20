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
    public partial class Form2 : Form
    {
        Thread nt;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoForm()
        {
            Application.Run(new Form3());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(NovoForm1);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void NovoForm1()
        {
            Application.Run(new Form1());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(NovoForm2);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void NovoForm2()
        {
            Application.Run(new Form4());
        }

        private void btnPecas_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(NovoForm3);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void NovoForm3()
        {
            Application.Run(new Form5());
        }
    }
}
    

