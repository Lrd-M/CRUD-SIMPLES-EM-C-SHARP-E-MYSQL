using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD___UNIP
{
    public partial class Home : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=clientes_unip;Uid=root;Pwd=MySQL00");

                strSQL = "INSERT INTO pessoas (nome, cpf, telefone, numero, logradouro, cep, bairro, cidade, estado) VALUES (@nome, @cpf, @telefone, @numero, @logradouro, @cep, @bairro, @cidade, @estado)";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@nome", txb_Nome.Text);
                comando.Parameters.AddWithValue("@cpf", txb_cpf.Text);
                comando.Parameters.AddWithValue("@telefone", txb_telefone.Text);
                comando.Parameters.AddWithValue("@numero", txb_numero.Text);
                comando.Parameters.AddWithValue("@logradouro", txb_logradouro.Text);
                comando.Parameters.AddWithValue("@cep", txb_cep.Text);
                comando.Parameters.AddWithValue("@bairro", txb_bairro.Text);
                comando.Parameters.AddWithValue("@cidade", txb_cidade.Text);
                comando.Parameters.AddWithValue("@estado", txb_estado.Text);

                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao=null;
                comando=null;
            }
            
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=clientes_unip;Uid=root;Pwd=MySQL00");

                strSQL = "UPDATE pessoas SET nome = @nome, cpf = @cpf, telefone = @telefone, numero = @numero, logradouro = @logradouro, cep = @cep, bairro = @bairro, cidade = @cidade, estado = @estado WHERE id = @id";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@id", txb_editar.Text);
                comando.Parameters.AddWithValue("@nome", txb_Nome.Text);
                comando.Parameters.AddWithValue("@cpf", txb_cpf.Text);
                comando.Parameters.AddWithValue("@telefone", txb_telefone.Text);
                comando.Parameters.AddWithValue("@numero", txb_numero.Text);
                comando.Parameters.AddWithValue("@logradouro", txb_logradouro.Text);
                comando.Parameters.AddWithValue("@cep", txb_cep.Text);
                comando.Parameters.AddWithValue("@bairro", txb_bairro.Text);
                comando.Parameters.AddWithValue("@cidade", txb_cidade.Text);
                comando.Parameters.AddWithValue("@estado", txb_estado.Text);

                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=clientes_unip;Uid=root;Pwd=MySQL00");

                strSQL ="DELETE FROM pessoas WHERE id = @id";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@id", txb_editar.Text);
    
                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=clientes_unip;Uid=root;Pwd=MySQL00");

                strSQL = "SELECT * FROM pessoas WHERE id = @id";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@id", txb_pesquisa.Text);

                conexao.Open();

                dr = comando.ExecuteReader();

                while(dr.Read())
                {
                    txb_Nome.Text = Convert.ToString(dr["nome"]);
                    txb_cpf.Text = Convert.ToString(dr["cpf"]);
                    txb_telefone.Text = Convert.ToString(dr["telefone"]);
                    txb_numero.Text = Convert.ToString(dr["numero"]);
                    txb_logradouro.Text = Convert.ToString(dr["logradouro"]);
                    txb_cep.Text = Convert.ToString(dr["cep"]);
                    txb_bairro.Text = Convert.ToString(dr["bairro"]);
                    txb_cidade.Text = Convert.ToString(dr["cidade"]);
                    txb_estado.Text = Convert.ToString(dr["estado"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }
    }
}
