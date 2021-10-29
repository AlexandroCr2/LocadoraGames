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

        public string id { get; set; }
        public Color cor = Color.FromArgb(150, 110, 190);

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

        private void limparGrid()
        {
            dataGridCadastro.Rows.Clear();
        }

        private void limparCampos()
        {
            textBoxNome.Text = "Nome do Usuário";
            textBoxTelefone.Text = "Telefone";
            textBoxEndereco.Text = "Endereço";
        }

        private void corTB()
        {
            panelEndereco.BackColor = Color.LightGray;
            textBoxEndereco.ForeColor = Color.LightGray;

            panelNome.BackColor = Color.LightGray;
            textBoxNome.ForeColor = Color.LightGray;

            panelTelefone.BackColor = Color.LightGray;
            textBoxTelefone.ForeColor = Color.LightGray;

        }

        private void confirmacaoPlayer()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizarConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizarConexaoBD.Open();

                MySqlCommand comandoMySql = realizarConexaoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM `player` WHERE nomePlayer = ('" + textBoxNome.Text + "')";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Não é possível dois usuários com o mesmo nome!");
                }
                else
                {
                    novoPlayer();
                }
                realizarConexaoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar a conexão com o banco de dados!");
                Console.WriteLine(ex.Message);
            }
        }

        private void novoPlayer()
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

        private void remover()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand(); //Crio um comando SQL
                // "DELETE FROM filme WHERE idFilme = "+ textBoxId.Text +""
                //comandoMySql.CommandText = "DELETE FROM filme WHERE idFilme = " + tbID.Text + "";
                comandoMySql.CommandText = "UPDATE `player` SET `ativoPlayer`= 0 WHERE nomePlayer = '" + textBoxNome.Text + "';";

                comandoMySql.ExecuteNonQuery();

                realizaConexaoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Removido com sucesso!"); //Exibo mensagem de aviso
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void alterar()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "UPDATE `player` SET `nomePlayer`='" + textBoxNome.Text + "'," +
                    "`telefonePlayer`='" + textBoxTelefone.Text + "',`enderecoPlayer`='" + textBoxEndereco.Text + "' " +
                    "WHERE `idPlayer`='" + id + "'";

                comandoMySql.ExecuteNonQuery();

                realizaConexaoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Atualizado com sucesso!"); //Exibo mensagem de aviso
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void buscarPlayer()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizarConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizarConexaoBD.Open();

                MySqlCommand comandoMySql = realizarConexaoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM `player` WHERE nomePlayer LIKE ('%" + textBoxNome.Text + "%')";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                if (reader.Read())
                {
                    limparGrid();
                    DataGridViewRow row = (DataGridViewRow)dataGridCadastro.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//TELEFONE
                    row.Cells[3].Value = reader.GetString(3);//ENDEREÇO
                    dataGridCadastro.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }
                else
                {
                    MessageBox.Show("Não há players relacionados a busca!");
                }
                realizarConexaoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar a conexão com o banco de dados!");
                Console.WriteLine(ex.Message);
            }
        }


        private void dataGridCadastro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridCadastro.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                limparCampos();
                dataGridCadastro.CurrentRow.Selected = true;
                //preenche os textbox com as células da linha selecionada
                textBoxNome.Text = dataGridCadastro.Rows[e.RowIndex].Cells["columnNome"].FormattedValue.ToString();
                textBoxTelefone.Text = dataGridCadastro.Rows[e.RowIndex].Cells["columnTelefone"].FormattedValue.ToString();
                textBoxEndereco.Text = dataGridCadastro.Rows[e.RowIndex].Cells["columnEndereco"].FormattedValue.ToString();
                id = dataGridCadastro.Rows[e.RowIndex].Cells["columnID"].FormattedValue.ToString();
            }
        }

        private void textBoxNome_Click(object sender, EventArgs e)
        {
            corTB();
            textBoxNome.Clear();
            panelNome.BackColor = cor;
            textBoxNome.ForeColor = cor;
        }

        private void textBoxTelefone_Click(object sender, EventArgs e)
        {
            corTB();
            textBoxTelefone.Clear();
            panelTelefone.BackColor = cor;
            textBoxTelefone.ForeColor = cor;
        }

        private void textBoxEndereco_Click(object sender, EventArgs e)
        {
            corTB();
            textBoxEndereco.Clear();
            panelEndereco.BackColor = cor;
            textBoxEndereco.ForeColor = cor;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            confirmacaoPlayer();
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            remover();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            alterar();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            buscarPlayer();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
