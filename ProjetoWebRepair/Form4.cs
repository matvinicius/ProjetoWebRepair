using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProjetoWebRepair
{
    public partial class Form4 : Form
    {
        Thread nt;

        public Form4()
        {
            InitializeComponent();

            txt_Pesquisanome.Enabled = false;
            txt_nome.Enabled = false;
            msk_tel.Enabled = false;
            msk_cel.Enabled = false;
            txt_email.Enabled = false;
            txt_endereco.Enabled = false;
            txt_num.Enabled = false;
            txt_bairro.Enabled = false;
            msk_rg.Enabled = false;
            msk_cpf.Enabled = false;
        }

        SqlConnection sqlCon = null;
        private string strCon = "Data Source=MICROSOFT;Initial Catalog=CLIENTE_DB;Integrated Security=True;Pooling=False";
        private string strSql = string.Empty;

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txt_nome.Enabled = true;
            msk_tel.Enabled = true;
            msk_cel.Enabled = true;
            txt_email.Enabled = true;
            txt_endereco.Enabled = true;
            txt_num.Enabled = true;
            txt_bairro.Enabled = true;
            msk_rg.Enabled = true;
            msk_cpf.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            strSql = "select *from CLIENTE where NOME = @pesquisa";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@pesquisa", SqlDbType.VarChar).Value = txt_Pesquisanome.Text;

            try
            {
                if (txt_Pesquisanome.Text == string.Empty)
                {
                    MessageBox.Show("Você não digitou um nome !");
                }

                sqlCon.Open();

                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == false)
                {
                    throw new Exception("Este nome não está cadastrado !");
                }

                dr.Read();

                txt_nome.Text = Convert.ToString(dr["NOME"]);
                msk_tel.Text = Convert.ToString(dr["TELEFONE"]);
                msk_cel.Text = Convert.ToString(dr["CELULAR"]);
                txt_email.Text = Convert.ToString(dr["EMAIL"]);
                txt_endereco.Text = Convert.ToString(dr["ENDERECO"]);
                txt_num.Text = Convert.ToString(dr["NUMERO"]);
                txt_bairro.Text = Convert.ToString(dr["BAIRRO"]);
                msk_rg.Text = Convert.ToString(dr["RG"]);
                msk_cpf.Text = Convert.ToString(dr["CPF"]);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlCon.Close();
            }

            txt_Pesquisanome.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            strSql = "update CLIENTE set NOME=@NOME, TELEFONE=@TELEFONE, CELULAR=@CELULAR, EMAIL=@EMAIL, ENDERECO=@ENDERECO, NUMERO=@NUMERO, BAIRRO=@BAIRRO, RG=@RG, CPF=@CPF";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@NOME", SqlDbType.VarChar).Value = txt_nome.Text;
            comando.Parameters.Add("@TELEFONE", SqlDbType.VarChar).Value = msk_tel.Text;
            comando.Parameters.Add("@CELULAR", SqlDbType.VarChar).Value = msk_cel.Text;
            comando.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = txt_email.Text;
            comando.Parameters.Add("@ENDERECO", SqlDbType.VarChar).Value = txt_endereco.Text;
            comando.Parameters.Add("@NUMERO", SqlDbType.VarChar).Value = txt_num.Text;
            comando.Parameters.Add("@BAIRRO", SqlDbType.VarChar).Value = txt_bairro.Text;
            comando.Parameters.Add("@RG", SqlDbType.VarChar).Value = msk_rg.Text;
            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = msk_cpf.Text;

            try
            {
                sqlCon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro alterado com sucesso !");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlCon.Close();
            }

            txt_nome.Clear();
            msk_tel.Clear();
            msk_cpf.Clear();
            txt_email.Clear();
            txt_endereco.Clear();
            txt_num.Clear();
            txt_bairro.Clear();
            msk_rg.Clear();
            msk_cel.Clear();
            txt_Pesquisanome.Clear();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            strSql = "delete from CLIENTE where NOME=@NOME";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@NOME", SqlDbType.VarChar).Value = txt_nome.Text;

            try
            {
                sqlCon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Exclusão de cadastro feita com sucesso! ");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlCon.Close();

                txt_nome.Clear();
                msk_tel.Clear();
                msk_cpf.Clear();
                txt_email.Clear();
                txt_endereco.Clear();
                txt_num.Clear();
                txt_bairro.Clear();
                msk_rg.Clear();
                msk_cel.Clear();
                txt_Pesquisanome.Clear();
            }
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            strSql = "insert into CLIENTE (NOME,TELEFONE,CELULAR,EMAIL,ENDERECO,NUMERO,BAIRRO,RG,CPF) values (@NOME,@TELEFONE,@CELULAR,@EMAIL,@ENDERECO,@NUMERO,@BAIRRO,@RG,@CPF)";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@NOME", SqlDbType.VarChar).Value = txt_nome.Text;
            comando.Parameters.Add("@TELEFONE", SqlDbType.VarChar).Value = msk_tel.Text;
            comando.Parameters.Add("@CELULAR", SqlDbType.VarChar).Value = msk_cel.Text;
            comando.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = txt_email.Text;
            comando.Parameters.Add("@ENDERECO", SqlDbType.VarChar).Value = txt_endereco.Text;
            comando.Parameters.Add("@NUMERO", SqlDbType.VarChar).Value = txt_num.Text;
            comando.Parameters.Add("@BAIRRO", SqlDbType.VarChar).Value = txt_bairro.Text;
            comando.Parameters.Add("@RG", SqlDbType.VarChar).Value = msk_rg.Text;
            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = msk_cpf.Text;

            try
            {
                sqlCon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro efetuado com sucesso");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlCon.Close();
            }

            txt_Pesquisanome.Enabled = true;

            txt_nome.Clear();
            msk_tel.Clear();
            msk_cpf.Clear();
            txt_email.Clear();
            txt_endereco.Clear();
            txt_num.Clear();
            txt_bairro.Clear();
            msk_rg.Clear();
            msk_cel.Clear();
            txt_Pesquisanome.Clear();
        }
    }
}
