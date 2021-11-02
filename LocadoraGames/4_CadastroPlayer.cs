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

    public partial class FormCadastroPlayer : Form
    {

        public FormCadastroPlayer()
        {
            InitializeComponent();
        }

        private void CadastroPlayer_Load(object sender, EventArgs e) //ao iniciar o form é atualizado o grid com todas as informações sobre players do banco de dados
        {
            atualizarGrid();
            dataGridCadastro.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 10);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        { //botão salvar chama o método para confirmar se já existe player cadastrado com o mesmo nome
            confirmacaoPlayer();
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        { //botão remover chama o método para para alterar o status do player selecionado de ativo para inativo
            remover();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        { //botão alterar chama o método para alterar alguma informação do player selecionado
            alterar();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        { //botão buscar chama o método para buscar o player informado no textox
            buscarPlayer();
        }

        private void labelClose_Click(object sender, EventArgs e)
        { //label fecha o forma atual
            this.Close();
        }

        private void dataGridCadastro_CellClick(object sender, DataGridViewCellEventArgs e)
        { //metoto para clonar os dados da linha clicada do datagrid para as textbox
            if (dataGridCadastro.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) //se a celula clicada não tiver uma valor nulo a linha é armazenada em uma variável
            {
                limparCampos(); //limpa os campos dos textbox para receber os novos valores
                dataGridCadastro.CurrentRow.Selected = true;
                //preenche os textbox com as células da linha selecionada
                textBoxNome.Text = dataGridCadastro.Rows[e.RowIndex].Cells["columnNome"].FormattedValue.ToString();
                textBoxTelefone.Text = dataGridCadastro.Rows[e.RowIndex].Cells["columnTelefone"].FormattedValue.ToString();
                textBoxEndereco.Text = dataGridCadastro.Rows[e.RowIndex].Cells["columnEndereco"].FormattedValue.ToString();
                id = dataGridCadastro.Rows[e.RowIndex].Cells["columnID"].FormattedValue.ToString();
            }
        }

        private void textBoxNome_Click(object sender, EventArgs e) //metodo para limpar a textbox selecionada e alterar suas cores
        {
            corTB();
            textBoxNome.Clear();
            panelNome.BackColor = cor;
            textBoxNome.ForeColor = cor;
        }

        private void textBoxTelefone_Click(object sender, EventArgs e) //metodo para limpar a textbox selecionada e alterar suas cores
        {
            corTB();
            textBoxTelefone.Clear();
            panelTelefone.BackColor = cor;
            textBoxTelefone.ForeColor = cor;
        }

        private void textBoxEndereco_Click(object sender, EventArgs e) //metodo para limpar a textbox selecionada e alterar suas cores
        {
            corTB();
            textBoxEndereco.Clear();
            panelEndereco.BackColor = cor;
            textBoxEndereco.ForeColor = cor;
        }

        public string id { get; set; } // string publica para armazenar o id de um usuário
        public Color cor = Color.FromArgb(150, 110, 190); // cor publica para posterios chamada

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

        private void atualizarGrid() //metodo para atualizar o datagrid com as informações do banco de dados
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco(); //chama o metodo para abrir conexão com o banco de dados
            MySqlConnection realizarConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizarConexaoBD.Open(); //abre conexão com o banco de dados

                MySqlCommand comandoMySql = realizarConexaoBD.CreateCommand(); //cria comando para o bancco de dados
                comandoMySql.CommandText = "SELECT * FROM player WHERE ativoPlayer = 1";
                MySqlDataReader reader = comandoMySql.ExecuteReader(); //executa leitura dos dados capturados do banco de dados e armazena em uma variavel

                dataGridCadastro.Rows.Clear(); //limpa o datagrid

                while (reader.Read()) //envia para o datagrid os dados armazenados na variavel que recebeu os dados do banco de dados
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridCadastro.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//TELEFONE
                    row.Cells[3].Value = reader.GetString(3);//ENDEREÇO
                    dataGridCadastro.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizarConexaoBD.Close(); //fecha conxao com o banco de dados
            }
            catch (Exception ex) //caso não seja possível conectar ao banco de dados a mensagem de excessão abaixo é exibida
            {
                MessageBox.Show("Não foi possível realizar a conexão com o banco de dados!");
                Console.WriteLine(ex.Message);
            }
        }

        private void limparGrid() //metodo para limpar o datagrid
        {
            dataGridCadastro.Rows.Clear();
        }

        private void limparCampos() //método para limpar os textbox
        {
            textBoxNome.Text = "Nome do Usuário";
            textBoxTelefone.Text = "Telefone";
            textBoxEndereco.Text = "Endereço";
        }

        private void corTB() //metodo para setar as cores dos textbox e paineis como padrão
        {
            panelEndereco.BackColor = Color.LightGray;
            textBoxEndereco.ForeColor = Color.LightGray;

            panelNome.BackColor = Color.LightGray;
            textBoxNome.ForeColor = Color.LightGray;

            panelTelefone.BackColor = Color.LightGray;
            textBoxTelefone.ForeColor = Color.LightGray;
        }

        private void confirmacaoPlayer() //metodo para confirmar se o player já tem cadastro impedindo de cadastras novamente
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco(); //chama método para abrir conexão com o banco dde dados
            MySqlConnection realizarConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizarConexaoBD.Open(); //abre conexão com o banco de dados

                MySqlCommand comandoMySql = realizarConexaoBD.CreateCommand(); //envia comando ao banco de dados
                comandoMySql.CommandText = "SELECT * FROM `player` WHERE nomePlayer = ('" + textBoxNome.Text + "')";
                MySqlDataReader reader = comandoMySql.ExecuteReader(); //armazena os dados recebidos em uma variavel

                if (reader.Read()) //se a variável retornou valores a mensagem de erro é exibida, impedndo cadastros duplicados
                {
                    MessageBox.Show("Não é possível dois usuários com o mesmo nome!");
                }
                else //caso a variável não retorne valores o método para adicionar novo cadastro é chamado
                {
                    novoPlayer();
                }
                realizarConexaoBD.Close(); //fecha conexão com o banco de dados
            }
            catch (Exception ex) //caso não seja possível conectar ao banco de dados a mensagem de erexcessão abaixo é exibida
            {
                MessageBox.Show("Não foi possível realizar a conexão com o banco de dados!");
                Console.WriteLine(ex.Message);
            }
        }

        private void novoPlayer() //método para adicionar novo cadastro ao banco de dados
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco(); //chama metodo para abrir conexao com o banco de dados
            MySqlConnection realizarConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizarConexaoBD.Open(); //abr conexao com o banco de dados

                MySqlCommand comandoMySql = realizarConexaoBD.CreateCommand(); //cria comando para o banco de dados
                comandoMySql.CommandText = "INSERT INTO player (nomePlayer,telefonePlayer,enderecoPlayer) " +
                    "VALUES('" + textBoxNome.Text + "', '" + textBoxTelefone.Text + "','" + textBoxEndereco.Text + "')";
                comandoMySql.ExecuteNonQuery(); //executa comando no banco de dados

                realizarConexaoBD.Close(); //fecha conexão com o banco de dados
                MessageBox.Show("Salvo com sucesso!");
                atualizarGrid(); //metodo para atualizar o grid
                limparCampos(); //metodo para limpar os campos dos textbox
            }
            catch (Exception ex) //caso não seja possível conectar ao banco de dados a mensagem de excessão é exibida
            {
                MessageBox.Show("Não foi possível realizar a conexão com o banco de dados!");
                Console.WriteLine(ex.Message);
            }
        }

        private void remover() //metodo para remover visualização do player alterando seu status de ativo para inativo
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco(); //chama metodo para abrir conexao com o banco de dados
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "UPDATE `player` SET `ativoPlayer`= 0 WHERE nomePlayer = '" + textBoxNome.Text + "';";

                comandoMySql.ExecuteNonQuery(); //executa comando no banco dde dados

                realizaConexaoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Removido com sucesso!"); //Exibo mensagem de aviso
                atualizarGrid(); //método para atualizar o gridd
                limparCampos(); //limpa os dados dos textbox
            }
            catch (Exception ex) //caso não seja possível conectar ao banco dde dados uma mensagem de erro é gerada
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void alterar() //metodo para alterar um cadastro já realizado
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco(); //chama método para conectar ao banco de dados
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "UPDATE `player` SET `nomePlayer`='" + textBoxNome.Text + "'," +
                    "`telefonePlayer`='" + textBoxTelefone.Text + "',`enderecoPlayer`='" + textBoxEndereco.Text + "' " +
                    "WHERE `idPlayer`='" + id + "'";

                comandoMySql.ExecuteNonQuery(); //executa comando no banco de dados

                realizaConexaoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Atualizado com sucesso!"); //Exibo mensagem de aviso
                atualizarGrid(); //limpa o datagrid
                limparCampos(); //limpa os campos dos textbox
            }
            catch (Exception ex) //caso não seja possível conectar ao banco de dados uma mensagem de excessão é exibida
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void buscarPlayer() //metodo para buscar uma cadastro 
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco(); //chama o metodo para conectar ao bando de dados
            MySqlConnection realizarConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizarConexaoBD.Open(); //abre conexaão com o banco de dados

                MySqlCommand comandoMySql = realizarConexaoBD.CreateCommand(); //cria comando para o bando de dados
                comandoMySql.CommandText = "SELECT * FROM `player` WHERE nomePlayer LIKE ('%" + textBoxNome.Text + "%')";
                MySqlDataReader reader = comandoMySql.ExecuteReader(); //executa comando e armazena os dados recebidos em uma variável

                if (reader.HasRows) //verifica se a pesquisa retornou alguma linha
                {
                    limparGrid();
                    while(reader.Read()) //caso a variavel retorne algum valor ele é exibido no datagrid
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridCadastro.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                        row.Cells[0].Value = reader.GetInt32(0);//ID
                        row.Cells[1].Value = reader.GetString(1);//NOME
                        row.Cells[2].Value = reader.GetString(2);//TELEFONE
                        row.Cells[3].Value = reader.GetString(3);//ENDEREÇO
                        dataGridCadastro.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                    }
                }
                else //caso a variavel não retorne nenhum valor a mensagem abaixo é exibida
                {
                    MessageBox.Show("Não há players relacionados a busca!");
                }

                realizarConexaoBD.Close(); //fecha conexão com o bano de dados
            }
            catch (Exception ex) //caso não seja possível conectar ao banco de dados uma mensagem de excessão é exibida
            {
                MessageBox.Show("Não foi possível realizar a conexão com o banco de dados!");
                Console.WriteLine(ex.Message);
            }
        }

    }
}
