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
    public partial class FormPlayers : Form
    {

        public FormPlayers()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            limparGrid(); //metodo para limpar o datagrid
            buscarPlayer();            
            nomePlayer = "";
        }

        public string nomePlayer { get; set; }

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
            dataGridPlayer.Rows.Clear();
            dataGridAlugueis.Rows.Clear();
        }

        private void buscarPlayer() //metodo para buscar um cadastro 
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco(); //chama o metodo para abrir conexão com o banco de dados
            MySqlConnection realizarConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizarConexaoBD.Open(); //abre conexão com o banco de dados

                MySqlCommand comandoMySql = realizarConexaoBD.CreateCommand(); //cria comando para o bancco de dados
                comandoMySql.CommandText = "SELECT * FROM `player` WHERE nomePlayer LIKE ('%" + textBoxNome.Text + "%');";
                MySqlDataReader reader = comandoMySql.ExecuteReader(); //executa leitura dos dados capturados do banco de dados e armazena em uma variavel

                if (reader.HasRows)
                {
                    dataGridPlayer.Rows.Clear(); //limpa o datagrid
                    while (reader.Read()) //envia para o datagrid os dados armazenados na variavel que recebeu os dados do banco de dados
                    {
                        
                        DataGridViewRow row = (DataGridViewRow)dataGridPlayer.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                        row.Cells[0].Value = reader.GetInt32(0);//ID
                        row.Cells[1].Value = reader.GetString(1);//NOME
                        row.Cells[2].Value = reader.GetString(2);//GAME
                        row.Cells[3].Value = reader.GetString(3);//PLATAFORMA                    
                        dataGridPlayer.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                    }
                }
                else //caso a variavel não retorne nenhum valor a mensagem abaixo é exibida
                {
                    MessageBox.Show("Não há players relacionados a busca!");
                }

                realizarConexaoBD.Close(); //fecha conxao com o banco de dados
            }
            catch (Exception ex) //caso não seja possível conectar ao banco de dados a mensagem de excessão abaixo é exibida
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
                comandoMySql.CommandText = "SELECT * FROM `aluguel` WHERE playerAluguel = '" + nomePlayer + "';";
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

        private void textBoxNome_Click(object sender, EventArgs e)
        {
            textBoxNome.Clear();
        }

        private void dataGridPlayer_CellClick(object sender, DataGridViewCellEventArgs e)
        { //metoto para clonar os dados da linha clicada do datagrid para as textbox
            if (dataGridPlayer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) //se a celula clicada não tiver uma valor nulo a linha é armazenada em uma variável
            {
                textBoxNome.Clear(); //limpa os campos dos textbox para receber os novos valores
                dataGridPlayer.CurrentRow.Selected = true;
                //preenche os textbox com as células da linha selecionada
                textBoxNome.Text = dataGridPlayer.Rows[e.RowIndex].Cells["columnNome"].FormattedValue.ToString();
                nomePlayer = dataGridPlayer.Rows[e.RowIndex].Cells["columnNome"].FormattedValue.ToString();
                buscarPlayer();
                buscarAlugueis();
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        { //fecha o form atual
            this.Close();
        }

        private void FormPlayers_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void atualizarGrid()
        { //método para atualizar o datagrid com as informações do banco de dados
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco(); //chama metodo para abrir conexão com o banco de dados
            MySqlConnection realizarConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizarConexaoBD.Open(); //abre conexão com o banco de dados

                MySqlCommand comandoMySql = realizarConexaoBD.CreateCommand(); //cria comando para o banco de dados
                comandoMySql.CommandText = "SELECT * FROM player WHERE ativoPlayer = 1";
                MySqlDataReader reader = comandoMySql.ExecuteReader(); //executa comanddo no banco de  e ermazena os dados recebidos em uma variavel

                dataGridPlayer.Rows.Clear(); //limpa as linhas do datagrid

                while (reader.Read()) //executa leitura dos dados armazenados na vaiavel e atualiza o datagrid com os valores
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridPlayer.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//TELEFONE
                    row.Cells[3].Value = reader.GetString(3);//ENDEREÇO             
                    dataGridPlayer.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizarConexaoBD.Close(); //fecha conexao com o banco de dados
            }
            catch (Exception ex) //caso não seja possível realizar a conexão com o banco de dados a mensagem de excessão abaixo é exibida
            {
                MessageBox.Show("Não foi possível realizar a conexão com o banco de dados!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
