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

namespace LocadoraGames
{

    public partial class CadastroPlayer : Form
    {
        public CadastroPlayer()
        {
            InitializeComponent();
        }

        private void CadastroPlayer_Load(object sender, EventArgs e)
        {
            atualizarGrid();
            dataGridCadastro.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 10);
        }

        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "locadoragames";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }

        private void atualizarGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizarConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizarConexaoBD.Open();

                MySqlCommand comandoMySql = realizarConexaoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM player WHERE ativoPlayer = 1";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dataGridCadastro.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridCadastro.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//TELEFONE
                    row.Cells[3].Value = reader.GetString(3);//ENDEREÇO
                    dataGridCadastro.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizarConexaoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar a conexão com o banco de dados!");
                Console.WriteLine(ex.Message);
            }
        }

        private void limparCampos()
        {
            textBoxNome.Text = "Nome do Usuário";
            textBoxTelefone.Text = "Telefone";
            textBoxEndereco.Text = "Endereço";
        }

        /*private void nomeRepetido()
         {
             MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
             MySqlConnection realizarConexaoBD = new MySqlConnection(conexaoBD.ToString());
             try
             {
                 realizarConexaoBD.Open();

                 MySqlCommand comandoMySql = realizarConexaoBD.CreateCommand();
                 comandoMySql.CommandText = "SELECT * FROM `player` WHERE nomePlayer = ('" + textBoxNome.Text + "')";
                 MySqlDataReader reader = comandoMySql.ExecuteReader();

                bool repetido;

                while (reader.Read())
                 {
                    MessageBox.Show("não é possível dois usuários com o mesmo nome!");

                    repetido = true;
                 }

                 realizarConexaoBD.Close();
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Não foi possível realizar a conexão com o banco de dados!");
                 Console.WriteLine(ex.Message);
             }
         }*/

        private void textBoxNome_Click(object sender, EventArgs e)
        {
            textBoxNome.Clear();
            panelNome.BackColor = Color.FromArgb(150, 110, 190);
            textBoxNome.ForeColor = Color.FromArgb(150, 110, 190);

            panelTelefone.BackColor = Color.LightGray;
            textBoxTelefone.ForeColor = Color.LightGray;

            panelEndereco.BackColor = Color.LightGray;
            textBoxEndereco.ForeColor = Color.LightGray;
        }

        private void textBoxTelefone_Click(object sender, EventArgs e)
        {
            textBoxTelefone.Clear();
            panelTelefone.BackColor = Color.FromArgb(150, 110, 190);
            textBoxTelefone.ForeColor = Color.FromArgb(150, 110, 190);

            panelNome.BackColor = Color.LightGray;
            textBoxNome.ForeColor = Color.LightGray;

            panelEndereco.BackColor = Color.LightGray;
            textBoxEndereco.ForeColor = Color.LightGray;
        }

        private void textBoxEndereco_Click(object sender, EventArgs e)
        {
            textBoxEndereco.Clear();
            panelEndereco.BackColor = Color.FromArgb(150,110, 190);
            textBoxEndereco.ForeColor = Color.FromArgb(150, 110, 190);

            panelNome.BackColor = Color.LightGray;
            textBoxNome.ForeColor = Color.LightGray;

            panelTelefone.BackColor = Color.LightGray;
            textBoxTelefone.ForeColor = Color.LightGray;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizarConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {

                realizarConexaoBD.Open();

                MySqlCommand comandoMySql = realizarConexaoBD.CreateCommand();
                comandoMySql.CommandText = "INSERT INTO player (nomePlayer,telefonePlayer,enderecoPlayer) " +
                    "VALUES('" + textBoxNome.Text + "', '" + textBoxTelefone.Text + "','" + textBoxEndereco.Text + "')";
                comandoMySql.ExecuteNonQuery();

                realizarConexaoBD.Close();
                MessageBox.Show("Salvo com sucesso");
                atualizarGrid();
                limparCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar a conexão com o banco de dados!");
                Console.WriteLine(ex.Message);
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
