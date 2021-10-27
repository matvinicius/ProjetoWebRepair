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
using System.Data.SqlClient;

namespace ProjetoWebRepair
{
    public partial class Form5 : Form
    {
        Thread nt;

        public Form5()
        {
            InitializeComponent();

            txtPesquisar.Enabled = false;
            txtCodPeca.Enabled = false;
            txtDescricao.Enabled = false;
            txtQtd.Enabled = false;
            txtEstoque.Enabled = false;
            txtValor.Enabled = false;
            txtAplicacao.Enabled = false;
        }
        SqlConnection sqlCon = null;

        private string strCon = @"Data Source=MICROSOFT;Initial Catalog=CLIENTE_DB;Integrated Security=True;Pooling=False";

        private string strSql = string.Empty;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtPesquisar.Enabled = true;
            txtCodPeca.Enabled = true;
            txtDescricao.Enabled = true;
            txtQtd.Enabled = true;
            txtEstoque.Enabled = true;
            txtValor.Enabled = true;
            txtAplicacao.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            strSql = "insert into PECAS (CODIGO,DESCRICAO,QUANTIDADE,ESTOQUE,VALOR,APLICACAO) " +
                "values (@CODIGO,@DESCRICAO,@QUANTIDADE,@ESTOQUE,@VALOR,@APLICACAO)";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = txtCodPeca.Text;
            comando.Parameters.Add("@DESCRICAO", SqlDbType.VarChar).Value = txtDescricao.Text;
            comando.Parameters.Add("@QUANTIDADE", SqlDbType.VarChar).Value = txtQtd.Text;
            comando.Parameters.Add("@ESTOQUE", SqlDbType.VarChar).Value = txtEstoque.Text;
            comando.Parameters.Add("@VALOR", SqlDbType.VarChar).Value = txtValor.Text;
            comando.Parameters.Add("@APLICACAO", SqlDbType.VarChar).Value = txtAplicacao.Text;

            try
            {
                sqlCon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Peça cadastrada com sucesso!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlCon.Close();
            }

            txtPesquisar.Enabled = true;

            txtCodPeca.Clear();
            txtDescricao.Clear();
            txtQtd.Clear();
            txtEstoque.Clear();
            txtValor.Clear();
            txtAplicacao.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            strSql = "select *from PECAS where CODIGO = @pesquisa";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@pesquisa", SqlDbType.VarChar).Value = txtPesquisar.Text;

            try
            {
                if (txtPesquisar.Text == string.Empty)
                {
                    MessageBox.Show("Você não digitou um codigo!");
                }

                sqlCon.Open();

                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == false)
                {
                    throw new Exception("Esta peça não está cadastrada!");
                }

                dr.Read();

                txtCodPeca.Text = Convert.ToString(dr["CODIGO"]);
                txtDescricao.Text = Convert.ToString(dr["DESCRICAO"]);
                txtQtd.Text = Convert.ToString(dr["QUANTIDADE"]);
                txtEstoque.Text = Convert.ToString(dr["ESTOQUE"]);
                txtValor.Text = Convert.ToString(dr["VALOR"]);
                txtAplicacao.Text = Convert.ToString(dr["APLICACAO"]);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlCon.Close();
            }

            txtPesquisar.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            strSql = "update PECAS set CODIGO=@CODIGO, DESCRICAO=@DESCRICAO, QUANTIDADE=@QUANTIDADE," +
                " ESTOQUE=@ESTOQUE, VALOR=@VALOR, APLICACAO=@APLICACAO";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = txtCodPeca.Text;
            comando.Parameters.Add("@DESCRICAO", SqlDbType.VarChar).Value = txtDescricao.Text;
            comando.Parameters.Add("@QUANTIDADE", SqlDbType.VarChar).Value = txtQtd.Text;
            comando.Parameters.Add("@ESTOQUE", SqlDbType.VarChar).Value = txtEstoque.Text;
            comando.Parameters.Add("@VALOR", SqlDbType.VarChar).Value = txtValor.Text;
            comando.Parameters.Add("@APLICACAO", SqlDbType.VarChar).Value = txtAplicacao.Text;

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

            txtCodPeca.Clear();
            txtDescricao.Clear();
            txtQtd.Clear();
            txtEstoque.Clear();
            txtValor.Clear();
            txtAplicacao.Clear();
        }

        private void btnApgar_Click(object sender, EventArgs e)
        {
            strSql = "delete from PECAS where CODIGO=@CODIGO";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = txtCodPeca.Text;

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

                txtCodPeca.Clear();
                txtDescricao.Clear();
                txtQtd.Clear();
                txtEstoque.Clear();
                txtValor.Clear();
                txtAplicacao.Clear();
            }
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
    }
}
