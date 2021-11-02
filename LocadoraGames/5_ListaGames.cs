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
    public partial class FormListaGames : Form
    {
        public FormListaGames()
        {
            InitializeComponent();
        }

        public string nomeGame { get; set; }
        public string plataformaGame { get; set; }

        private MySqlConnectionStringBuilder conexaoBanco() //metodo para conectar ao banco de dados
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "locadoragames";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }

        private void limparGrid() //metodo para limpar o datagrid
        {
            dataGridGames.Rows.Clear();
            dataGridAlugueis.Rows.Clear();
        }

        private void labelClose_Click(object sender, EventArgs e)
        { //fecha o form atual
            this.Close();
        }

        private void buttonBuscar_Click_1(object sender, EventArgs e)
        {
            limparGrid();
            buscarGame(); // chama o metodo para buscar o no banc de dado o player inserido no textbox
        }

        private void buscarGame() // busca o player
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco(); // chama o metodo conexaoBanco para conectar ao banco de dados
            MySqlConnection realizarConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizarConexaoBD.Open(); // abre a conexao com o banco de dados

                MySqlCommand comandoMySql = realizarConexaoBD.CreateCommand(); // abre canal para incluir comando no banco de dados
                comandoMySql.CommandText = "SELECT * FROM `games` WHERE nomeGame LIKE ('%" + textBoxGame.Text + "%') AND plataformaGame LIKE ('%" + textBoxPlataforma.Text + "%') AND ativoGame = 1;"; // comando para o banco de dados (busca no banco os caracteres incluidos no textbox
                MySqlDataReader reader = comandoMySql.ExecuteReader(); // executa a leitura dos dados

                dataGridGames.Rows.Clear(); // chama o metodo limparGrid para limpar o grid do game

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridGames.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                        row.Cells[0].Value = reader.GetInt32(0);//ID
                        row.Cells[1].Value = reader.GetString(1);//NOME
                        row.Cells[2].Value = reader.GetString(2);//ANO
                        row.Cells[3].Value = reader.GetString(3);//PLATAFORMA
                        row.Cells[4].Value = reader.GetString(4);//DESCRIÇÃO
                        row.Cells[5].Value = reader.GetString(5);//DISPONÍVEL
                        dataGridGames.Rows.Add(row);//ADICIONO A LINHA NA TABELA 
                    }
                }
                else
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


        private void textBoxGame_Click(object sender, EventArgs e)
        {
            textBoxGame.Clear();
        }

        private void dataGridGames_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridGames.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) // se a linha clicada não for nula
            {
                //limparCamposGameAluguel(); // chama o metodo para limpar os txtbox do game no campo confirmar aluguel
                dataGridGames.CurrentRow.Selected = true;
                //preenche os textbox com as células da linha selecionada
                textBoxGame.Text = dataGridGames.Rows[e.RowIndex].Cells["ColumnNomeGame"].FormattedValue.ToString();
                textBoxPlataforma.Text = dataGridGames.Rows[e.RowIndex].Cells["ColumnPlataformaGame"].FormattedValue.ToString();
                plataformaGame = dataGridGames.Rows[e.RowIndex].Cells["ColumnPlataformaGame"].FormattedValue.ToString();
                buscarGame();
                buscarAlugueis();
            }
        }

        private void textBoxPlataforma_Click(object sender, EventArgs e)
        {
            textBoxPlataforma.Clear();
        }

        private void buttonDispGame_Click(object sender, EventArgs e)
        { //chama o método para alterar o game selecionado a partir do datagrid
            alterar();
        }

        private void alterar()
        { //método para alterar os dados de uma game no banco de dados 
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco(); //chama método para conectar ao banco de dados
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "UPDATE `games` SET `disponivelGame`='SIM' WHERE nomeGame = '" + textBoxGame.Text + "' AND plataformaGame = '" + textBoxPlataforma.Text + "';";
                comandoMySql.ExecuteNonQuery(); //executa comando no banco de dados

                realizaConexaoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Atualizado com sucesso!"); //Exibo mensagem de aviso
                atualizarGrid(); //atualiza o datagrid com os dados alterados
                limparCampos(); //limpa os textbox
            }
            catch (Exception ex) //caso não seja possível se conectar ao banco de dados a mensagem de excessão é exibida
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void limparCampos() //método para limpar os campos dos textbox
        {
            textBoxGame.Text = "Nome do Game";
            textBoxPlataforma.Text = "Plataforma";
        }

        private void atualizarGrid()
        { //método para atualizar o datagrid com as informações do banco de dados
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco(); //chama metodo para abrir conexão com o banco de dados
            MySqlConnection realizarConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizarConexaoBD.Open(); //abre conexão com o banco de dados

                MySqlCommand comandoMySql = realizarConexaoBD.CreateCommand(); //cria comando para o banco de dados
                comandoMySql.CommandText = "SELECT * FROM games WHERE ativoGame = 1";
                MySqlDataReader reader = comandoMySql.ExecuteReader(); //executa comanddo no banco de  e ermazena os dados recebidos em uma variavel

                dataGridGames.Rows.Clear(); //limpa as linhas do datagrid

                while (reader.Read()) //executa leitura dos dados armazenados na vaiavel e atualiza o datagrid com os valores
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridGames.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//ANO
                    row.Cells[3].Value = reader.GetString(3);//PLATAFORMA
                    row.Cells[4].Value = reader.GetString(4);//DESCRIÇÃO
                    row.Cells[5].Value = reader.GetString(5);//DISPONÍVEL
                    dataGridGames.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizarConexaoBD.Close(); //fecha conexao com o banco de dados
            }
            catch (Exception ex) //caso não seja possível realizar a conexão com o banco de dados a mensagem de excessão abaixo é exibida
            {
                MessageBox.Show("Não foi possível realizar a conexão com o banco de dados!");
                Console.WriteLine(ex.Message);
            }
        }

        private void buscarAlugueis() //metodo para atualizar o datagrid com as informações do banco de dados
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco(); //chama o metodo para abrir conexão com o banco de dados
            MySqlConnection realizarConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizarConexaoBD.Open(); //abre conexão com o banco de dados

                MySqlCommand comandoMySql = realizarConexaoBD.CreateCommand(); //cria comando para o bancco de dados
                comandoMySql.CommandText = "SELECT * FROM `aluguel` WHERE gameAluguel = '" + textBoxGame.Text + "' AND plataformaAluguel = '" + textBoxPlataforma.Text + "';"; // comando para o banco de dados (busca no banco os caracteres incluidos no textbox;
                MySqlDataReader reader = comandoMySql.ExecuteReader(); //executa leitura dos dados capturados do banco de dados e armazena em uma variavel

                dataGridAlugueis.Rows.Clear(); //limpa o datagrid

                while (reader.Read()) //envia para o datagrid os dados armazenados na variavel que recebeu os dados do banco de dados
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridAlugueis.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(4);//GAME
                    row.Cells[3].Value = reader.GetString(5);//PLATAFORMA
                    row.Cells[4].Value = reader.GetInt32(6);//DIAS
                    row.Cells[5].Value = reader.GetString(7);//VALOR
                    dataGridAlugueis.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizarConexaoBD.Close(); //fecha conxao com o banco de dados
            }
            catch (Exception ex) //caso não seja possível conectar ao banco de dados a mensagem de excessão abaixo é exibida
            {
                MessageBox.Show("Não foi possível realizar a conexão com o banco de dados!");
                Console.WriteLine(ex.Message);
            }
        }

        private void FormListaGames_Load(object sender, EventArgs e)
        {
            atualizarGrid(); 
        }
    }

}
