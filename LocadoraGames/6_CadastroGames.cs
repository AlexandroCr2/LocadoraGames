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
    public partial class FormCadastroGames : Form
    {
        public FormCadastroGames()
        {
            InitializeComponent();
        }

        private void FormCadastroGames_Load(object sender, EventArgs e)
        {
            atualizarGrid(); //chama o método para atualizar o dtagrid com as informações carregadas do banco de dados
            dataGridCadastro.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 10);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        { //chama o método para buscar o game informado no textbox e exibir no datagrid
            buscarGame();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        { //chama o método para confirmar se o game já existe no banco de dados evitando duplicatas
            confirmacaoGame();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        { //chama o método para alterar o game selecionado a partir do datagrid
            alterar();
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        { //chama o metodo para alterar o sttus do game selecionado de ativo para inativo
            remover();
        }

        private void labelClose_Click(object sender, EventArgs e)
        { //fecha o forma atual
            this.Close();
        }

        private void textBoxNome_Click(object sender, EventArgs e)
        { //metodo para alterar as cores do textbox e painel e limpar o textbox selecionado
            corTB();
            textBoxNome.Clear();
            panelNome.BackColor = cor;
            textBoxNome.ForeColor = cor;
        }

        private void textBoxAno_Click(object sender, EventArgs e)
        { //metodo para alterar as cores do textbox e painel e limpar o textbox selecionado
            corTB();
            textBoxAno.Clear();
            panelAno.BackColor = cor;
            textBoxAno.ForeColor = cor;
        }

        private void textBoxPlataforma_Click(object sender, EventArgs e)
        { //metodo para alterar as cores do textbox e painel e limpar o textbox selecionado
            corTB();
            textBoxPlataforma.Clear();
            panelPlataforma.BackColor = cor;
            textBoxPlataforma.ForeColor = cor;
        }

        private void textBoxDescricao_Click(object sender, EventArgs e)
        { //metodo para alterar as cores do textbox e painel e limpar o textbox selecionado
            corTB();
            textBoxDescricao.Clear();
            panelDescricao.BackColor = cor;
            textBoxDescricao.ForeColor = cor;
        }

        private void dataGridCadastro_CellClick(object sender, DataGridViewCellEventArgs e)
        { //metodo captura os dados da linha do datagrid selecionada e os insere nas textbox
            if (dataGridCadastro.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                limparCampos(); //metodo pra limpar os campos dos textbox
                dataGridCadastro.CurrentRow.Selected = true;
                //preenche os textbox com as células da linha selecionada
                textBoxNome.Text = dataGridCadastro.Rows[e.RowIndex].Cells["columnNome"].FormattedValue.ToString();
                textBoxAno.Text = dataGridCadastro.Rows[e.RowIndex].Cells["columnAno"].FormattedValue.ToString();
                textBoxPlataforma.Text = dataGridCadastro.Rows[e.RowIndex].Cells["columnPlataforma"].FormattedValue.ToString();
                textBoxDescricao.Text = dataGridCadastro.Rows[e.RowIndex].Cells["columnDescricao"].FormattedValue.ToString();
                id = dataGridCadastro.Rows[e.RowIndex].Cells["columnID"].FormattedValue.ToString();
            }
        }

        public string id { get; set; } //string publica para armazenar o id do game selecionado para posterior uso
        public Color cor = Color.FromArgb(188, 110, 65); //cor padrao para ser utilizada em métodos

        private void corTB() //método para setar as cores dos textbox e paineis como padrão
        {
            panelNome.BackColor = Color.LightGray;
            panelNome.ForeColor = Color.LightGray;

            panelAno.BackColor = Color.LightGray;
            textBoxAno.ForeColor = Color.LightGray;

            panelPlataforma.BackColor = Color.LightGray;
            textBoxPlataforma.ForeColor = Color.LightGray;

            panelDescricao.BackColor = Color.LightGray;
            textBoxDescricao.ForeColor = Color.LightGray;
        }

        private MySqlConnectionStringBuilder conexaoBanco()
        { //método para abrir conexão com o banco de dados
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "locadoragames";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
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

                dataGridCadastro.Rows.Clear(); //limpa as linhas do datagrid

                while (reader.Read()) //executa leitura dos dados armazenados na vaiavel e atualiza o datagrid com os valores
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridCadastro.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//ANO
                    row.Cells[3].Value = reader.GetString(3);//PLATAFORMA
                    row.Cells[4].Value = reader.GetString(4);//DESCRIÇÃO
                    row.Cells[5].Value = reader.GetString(5);//DISPONÍVEL
                    dataGridCadastro.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizarConexaoBD.Close(); //fecha conexao com o banco de dados
            }
            catch (Exception ex) //caso não seja possível realizar a conexão com o banco de dados a mensagem de excessão abaixo é exibida
            {
                MessageBox.Show("Não foi possível realizar a conexão com o banco de dados!");
                Console.WriteLine(ex.Message);
            }
        }

        private void limparGrid() //método para limpar os dados do datagrid
        {
            dataGridCadastro.Rows.Clear();
        }

        private void limparCampos() //método para limpar os campos dos textbox
        {
            textBoxNome.Text = "Nome do Game";
            textBoxAno.Text = "Ano";
            textBoxPlataforma.Text = "Plataforma";
            textBoxDescricao.Text = "Descrição";
        }

        private void buscarGame()
        { //método para buscar uum game informado no textbox
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco(); //chama método para conectar com o banco de dados
            MySqlConnection realizarConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizarConexaoBD.Open(); //abre conexão com o banco de dados 

                MySqlCommand comandoMySql = realizarConexaoBD.CreateCommand(); //cria comando para o banco de dados
                comandoMySql.CommandText = "SELECT * FROM `games` WHERE nomeGame LIKE ('%" + textBoxNome.Text + "%')";
                MySqlDataReader reader = comandoMySql.ExecuteReader(); //executa o comanddo e armazena os dados recebidos em uma variável

                if (reader.HasRows) //se a variável retonar dados, os mesmos são inseridos no datagrid
                {
                    limparGrid();
                    while (reader.Read())
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridCadastro.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                        row.Cells[0].Value = reader.GetInt32(0);//ID
                        row.Cells[1].Value = reader.GetString(1);//NOME
                        row.Cells[2].Value = reader.GetString(2);//ANO
                        row.Cells[3].Value = reader.GetString(3);//PLATAFORMA
                        row.Cells[4].Value = reader.GetString(4);//DESCRIÇÃO
                        row.Cells[5].Value = reader.GetString(5);//DISPONÍVEL
                        dataGridCadastro.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                    }                                     
                }
                else //se a variável não retornar dados a mensagem de erro é exibida
                {
                    MessageBox.Show("Não há players relacionados a busca!");
                }

                realizarConexaoBD.Close(); //fecha conexão com o banco de dados
            }
            catch (Exception ex) //caso não seja possível se conectar ao banco de dados a mensaem de excessão abaixo é exibida
            {
                MessageBox.Show("Não foi possível realizar a conexão com o banco de dados!");
                Console.WriteLine(ex.Message);
            }
        }

        private void confirmacaoGame()
        { //método para confirmar se já existe um game salvo no banco e dados com os mesmo nome e plataforma, impedindo duplicatas
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco(); //chama metodo para conectar ao banco de dados
            MySqlConnection realizarConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizarConexaoBD.Open(); //abre conexão com o banco de dados

                MySqlCommand comandoMySql = realizarConexaoBD.CreateCommand(); //cria comando para o banco de dados
                comandoMySql.CommandText = "SELECT * FROM `games` WHERE nomeGame = ('" + textBoxNome.Text + "') " +
                    "AND plataformaGame = ('" + textBoxPlataforma.Text + "')";
                MySqlDataReader reader = comandoMySql.ExecuteReader(); //executa comando e armazena os dados recebidos em uma váriável

                if (reader.Read()) //se a variável retornar valores a mensagem de erro abaixo é exibida
                {
                    MessageBox.Show("Não é possível dois games com o mesmo nome para a mesma plataforma!");
                }
                else //caso a variável não retorne nenhum valor o metodo para salvar o game é chamado
                {
                    novoGame();
                }

                realizarConexaoBD.Close(); //fecha a conexão com o banco de dados
            }
            catch (Exception ex) //caso não seja possível se conectar ao banco de dados a menagem de excessão abaixo é exibida
            {
                MessageBox.Show("Não foi possível realizar a conexão com o banco de dados!");
                Console.WriteLine(ex.Message);
            }
        }

        private void novoGame()
        { //método para incluir novo cadastro de game no banco de dados
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco(); //chama método para abris conexão com o banco e dados
            MySqlConnection realizarConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizarConexaoBD.Open(); //abre conexão com o banco de dados

                MySqlCommand comandoMySql = realizarConexaoBD.CreateCommand(); //cria comando para o bancco de dados
                comandoMySql.CommandText = "INSERT INTO games (nomeGame,anoGame,plataformaGame,descricaoGame,disponivelGame) " +
                    "VALUES('" + textBoxNome.Text + "', '" + textBoxAno.Text + "','" + textBoxPlataforma.Text + "', '" + textBoxDescricao.Text + "', 'SIM')";
                comandoMySql.ExecuteNonQuery(); //executa comando 

                realizarConexaoBD.Close(); //fecha conexão com o banco de dados
                MessageBox.Show("Salvo com sucesso!");
                atualizarGrid(); //atualiza o datagrid incluindo os novos dados
                limparCampos(); //limpa os textbox
            }
            catch (Exception ex) //caso não sej possível se conectar ao banco de dados a mensagem de excessão aabaixo é exibida
            {
                MessageBox.Show("Não foi possível realizar a conexão com o banco de dados!");
                Console.WriteLine(ex.Message);
            }
        }

        private void alterar()
        { //método para alterar os dados de uma game no banco de dados 
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco(); //chama método para conectar ao banco de dados
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "UPDATE `games` SET `nomeGame`='" + textBoxNome.Text + "'," +
                    "`anoGame`='" + textBoxAno.Text + "',`plataformaGame`='" + textBoxPlataforma.Text + "'," +
                    "`descricaoGame`='" + textBoxDescricao.Text + "' WHERE `idGame`= '" + id + "'";
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

        private void remover()
        { //método para alterar o status de um game de ativo para inativo
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco(); //chama método para abrir a conexão com o banco de dados 
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand(); //Crio um comando SQL
                // "DELETE FROM filme WHERE idFilme = "+ textBoxId.Text +""
                //comandoMySql.CommandText = "DELETE FROM filme WHERE idFilme = " + tbID.Text + "";
                comandoMySql.CommandText = "UPDATE `games` SET `ativoGame`= 0 WHERE " +
                    "nomeGame = '" + textBoxNome.Text + "' AND plataformaGame = '" + textBoxPlataforma.Text + "';";
                comandoMySql.ExecuteNonQuery(); //executa o comando no banco de dados

                realizaConexaoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Removido com sucesso!"); //Exibo mensagem de aviso
                atualizarGrid(); //atualiza o datagrid com os dados alterados
                limparCampos(); //limpa os textbox
            }
            catch (Exception ex) //caso não sej possível se conectar ao banco de dados a mensagem de excessão aabaixo é exibida
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
