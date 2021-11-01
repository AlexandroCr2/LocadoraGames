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

namespace LocadoraGames
{
    public partial class FormAluguel : Form
    {
        public FormAluguel()
        {
            InitializeComponent();
        }

        private MySqlConnectionStringBuilder conexaoBanco() // realiza conexão com o  banco de dados
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "locadoragames";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }

        private void restaurarCampos() // restaura todos os campos
        {
            limparGridGame();
            limparGridPlayer();
            textBoxNome.Text = "Nome do Player";
            textBoxGame.Text = "Game";
            textBoxUsuarioAlugar.Text = "Nome do Player";
            textBoxGameAlugar.Text = "Game";
            textBoxTelefoneAlugar.Text = "Telefone";
            textBoxEnderecoAlugar.Text = "Endereço";
            textBoxGame.Text = "Game";
            textBoxPlataforma.Text = "Plataforma";
            textBoxTempoAluguel.Text = "Dias de Aluguel";
            textBoxValorAluguel.Text = "Valor do Aluguel";
            
        }

        private void limparGridPlayer() // limpa o gridPlayer
        {
            dataGridPlayer.Rows.Clear();
        }

        private void limparGridGame() // limpa o gridGame
        {
            dataGridGame.Rows.Clear();
        }

        private void buscarPlayer() // busca o player 
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco(); // chama o metodo conexaoBanco para conectar ao banco de dados
            MySqlConnection realizarConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizarConexaoBD.Open(); // abre a conexao com o banco de dados

                MySqlCommand comandoMySql = realizarConexaoBD.CreateCommand(); // abre canal para incluir comando no banco de dados
                comandoMySql.CommandText = "SELECT * FROM `player` WHERE nomePlayer LIKE ('%" + textBoxNome.Text + "%')"; // comando para o banco de dados (busca no banco os caracteres incluidos no textbox
                MySqlDataReader reader = comandoMySql.ExecuteReader(); // executa o comando no banco de dados

                if (reader.Read()) // se retornar um valor, esse valor é atribuido ao datagrid
                {
                    limparGridPlayer(); // chamama o metodo para limpar o datagrid
                    DataGridViewRow row = (DataGridViewRow)dataGridPlayer.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetString(1);//NOME
                    row.Cells[1].Value = reader.GetString(2);//TELEFONE
                    row.Cells[2].Value = reader.GetString(3);//ENDEREÇO

                    dataGridPlayer.Rows.Add(row);//ADICIONA LINHA NA TABELA
                }
                else // se não retornar valor exibe a mensagem abaixo
                {
                    MessageBox.Show("Não há players relacionados a busca!");
                }
                realizarConexaoBD.Close(); // fecha a conexao com o banco de dados
            }
            catch (Exception ex) // se não for possível abrir o banco de dados a mensagem abaixo é exibida
            {
                MessageBox.Show("Não foi possível realizar a conexão com o banco de dados!");
                Console.WriteLine(ex.Message);
            }
        }

        private void buscarGame() // busca o player
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco(); // chama o metodo conexaoBanco para conectar ao banco de dados
            MySqlConnection realizarConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizarConexaoBD.Open(); // abre a conexao com o banco de dados

                MySqlCommand comandoMySql = realizarConexaoBD.CreateCommand(); // abre canal para incluir comando no banco de dados
                comandoMySql.CommandText = "SELECT * FROM `games` WHERE nomeGame LIKE ('%" + textBoxGame.Text + "%') AND ativoGame = 1";  // comando para o banco de dados (busca no banco os caracteres incluidos no textbox
                MySqlDataReader reader = comandoMySql.ExecuteReader(); // executa o comando no banco de dados

                if (reader.Read()) // se retornar um valor, esse valor é atribuido ao datagrid
                {
                    limparGridGame(); // chamama o metodo para limpar o datagrid
                    DataGridViewRow row = (DataGridViewRow)dataGridGame.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetString(1);//NOME
                    row.Cells[1].Value = reader.GetString(3);//PLATAFORMA
                    row.Cells[2].Value = reader.GetString(5);//DISPONIBILIDADE
                    dataGridGame.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }
                else // se não retornar valor exibe a mensagem abaixo
                {
                    MessageBox.Show("Não há games relacionados a busca!");
                }
                realizarConexaoBD.Close(); // fecha a conexao com o banco de dados
            }
            catch (Exception ex) // se não for possível abrir o banco de dados a mensagem abaixo é exibida
            {
                MessageBox.Show("Não foi possível realizar a conexão com o banco de dados!");
                Console.WriteLine(ex.Message);
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close(); // fecha o form atual
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limparGridPlayer(); // chama o metodo limparGrid para limar o grid do player
            buscarPlayer(); // chama o metodo para buscar o no banc de dado o player inserido no textbox 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limparGridGame(); // chama o metodo limparGrid para limar o grid do player
            buscarGame(); // chama o metodo para buscar o no banc de dado o player inserido no textbox 
        }

        private void dataGridPlayer_CellClick(object sender, DataGridViewCellEventArgs e) // metodo para incluir nos txtbox os caracteres da linha clicada no datagrid 
        {
            if (dataGridPlayer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) // se a linha clicada não for nula
            {
                //limparCamposPlayerAluguel(); // chama o metodo para limpar os txtbox do player no campo confirmar aluguel
                dataGridPlayer.CurrentRow.Selected = true;
                //preenche os textbox com as células da linha selecionada
                textBoxUsuarioAlugar.Text = dataGridPlayer.Rows[e.RowIndex].Cells["columnNome"].FormattedValue.ToString();
                textBoxTelefoneAlugar.Text = dataGridPlayer.Rows[e.RowIndex].Cells["columnTelefone"].FormattedValue.ToString();
                textBoxEnderecoAlugar.Text = dataGridPlayer.Rows[e.RowIndex].Cells["columnEndereco"].FormattedValue.ToString();
            }
        }

        private void dataGridGame_CellClick(object sender, DataGridViewCellEventArgs e) // metodo para incluir nos txtbox os caracteres da linha clicada no datagrid
        {
            if (dataGridGame.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) // se a linha clicada não for nula
            {
                //limparCamposGameAluguel(); // chama o metodo para limpar os txtbox do game no campo confirmar aluguel
                dataGridGame.CurrentRow.Selected = true;
                //preenche os textbox com as células da linha selecionada
                textBoxGameAlugar.Text = dataGridGame.Rows[e.RowIndex].Cells["ColumnGame"].FormattedValue.ToString();
                textBoxPlataforma.Text = dataGridGame.Rows[e.RowIndex].Cells["ColumnPlataforma"].FormattedValue.ToString();
            }
        }

        public double valortotal { get;set; } // variavel utilizada em dois metodos

        private void textBoxTempoAluguel_TextChanged(object sender, EventArgs e) // ao inserir um valor no textboxdias, esse valor é multiplicado por 5 e retona o valor no txtboxValor
        {
            string dias = textBoxTempoAluguel.Text; // salva em uma string o valor da textbox
            try
            {
                double diasNum = double.Parse(dias); // trsnforma a string dias em double e salva na variavel diasNum
                double total = diasNum * 5.49; // multiplica os dias pelo valor do aluguel e salva na vriavel total
                valortotal = total; // salva o valor do aluguel na variavel publica valortotal  
                textBoxValorAluguel.Text = "R$" + total.ToString(); // transmite o valor do aluguel para a textbox
            }
            catch (FormatException) { }
        }

        private void textBoxTempoAluguel_Click(object sender, EventArgs e)
        {
            textBoxTempoAluguel.Clear(); // limpa o txtBox
        }

        private void buttonConfirmar_Click(object sender, EventArgs e) // confirma o aluguel e chama os metodos
        {
            disponivelGame(); // chama o metodo para mudar a disponibilidade do game em especifico para NÃO
            confirmarAluguel(); // chama o metodo para salvar o aluguel no banco de dados
            restaurarCampos(); // chama o metodo para restaurar os campos 
        }

        private void disponivelGame()//metodo para alterar o status do game de disponivel SIM para Não quando o game é alugado
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco(); // chama o metodo conexaoBanco para conectar ao banco de dados
            MySqlConnection realizarConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizarConexaoBD.Open(); // abre a conexao com o banco de dados
                MySqlCommand comandoMySql = realizarConexaoBD.CreateCommand(); // abre canal para incluir comando no banco de dados
                comandoMySql.CommandText = "UPDATE `games` SET `disponivelGame`= 'NÃO' WHERE nomeGame =" +
                    " '" + textBoxGameAlugar.Text +"' AND plataformaGame = '"+ textBoxPlataforma.Text +"';";
                comandoMySql.ExecuteNonQuery(); // envia o comando ao banco de dados
                realizarConexaoBD.Close(); // feccha conexao com o banco de dados
            }
            catch (Exception ex) { Console.WriteLine(ex.Message);} // mensagem de excessao caso nao seja possivel conectar ao banco de dados
        }

        private void confirmarAluguel() // metodo para confirmar o aluguel e salvar no banco d dados
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco(); // chama o metodo conexaoBanco para conectar ao banco de dados
            MySqlConnection realizarConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizarConexaoBD.Open(); // abre a conexao com o banco de dados
                MySqlCommand comandoMySql = realizarConexaoBD.CreateCommand(); // abre canal para incluir comando no banco de dados
                comandoMySql.CommandText = "INSERT INTO aluguel (playerAluguel,telefoneAluguel,enderecoAluguel," +
                    "gameAluguel,plataformaAluguel,diasAluguel,valorAluguel) " +
                    "VALUES('" + textBoxUsuarioAlugar.Text + "', '" + textBoxTelefoneAlugar.Text + "'," +
                    "'" + textBoxEnderecoAlugar.Text + "','" + textBoxGameAlugar.Text + "'," +
                    " '" + textBoxPlataforma.Text + "','" + Convert.ToInt32(textBoxTempoAluguel.Text) + "'," +
                    "'" + valortotal + "')";
                comandoMySql.ExecuteNonQuery(); // envia o comando ao banco de dados
                realizarConexaoBD.Close(); // feccha conexao com o banco de dados

                MessageBox.Show("Salvo com sucesso!");
            }
            catch (Exception ex) // mensagem de excessao caso nao seja possivel conectar ao banco de dados
            {
                MessageBox.Show("Não foi possível realizar a conexão com o banco de dados!");
                Console.WriteLine(ex.Message);
            }
        }

        private void textBoxNome_Click(object sender, EventArgs e)
        {
            textBoxNome.Clear();// chama o metodo para lipar a textbox
        }

        private void textBoxGame_Click(object sender, EventArgs e)
        {
            textBoxGame.Clear();// chama o metodo para lipar a textbox
        }
    }
}
