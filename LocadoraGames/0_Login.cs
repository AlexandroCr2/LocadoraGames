using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LocadoraGames
{
    public partial class FormLogin : Form
    {
        //nova thread chamar nova tela
        Thread novaTela;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void labelClose_Click(object sender, EventArgs e) // ao clicar sobre a label o form é fechado
        {
            this.Close();
        }

        private void textBoxUser_Click(object sender, EventArgs e) // limpa o textBox e altera a cor da fonte, da picturebox e do panel
        {
            textBoxUser.Clear();
            pictureBoxUser.Image = Properties.Resources.UserIconAzul11;
            panelUser.BackColor = Color.Teal;
            textBoxUser.ForeColor = Color.Teal;

            pictureBoxPswd.Image = Properties.Resources.CadeadoBrancoIcone;
            panelPswd.BackColor = Color.WhiteSmoke;
            textBoxPswd.ForeColor = Color.WhiteSmoke;
        }

        private void textBoxPswd_Click(object sender, EventArgs e) // limpa o textBox e altera a cor da fonte, da picturebox e do panel
        {
            textBoxPswd.Clear();
            textBoxPswd.PasswordChar = '*';
            pictureBoxPswd.Image = Properties.Resources.CadeadoAzulIcone1;
            panelPswd.BackColor = Color.Teal;
            textBoxPswd.ForeColor = Color.Teal;

            pictureBoxUser.Image = Properties.Resources.UserIconBranco1;
            panelUser.BackColor = Color.WhiteSmoke;
            textBoxUser.ForeColor = Color.WhiteSmoke;
        }

        private void button1_Click(object sender, EventArgs e) // confere se a senha e o usuário estão corretos
        {
            if (textBoxUser.Text == "Funcionario_1" && textBoxPswd.Text == "12345") // se estiverem corretos exib a msg abaixo, fecha o formLogin e chama a o metodo novoForm
            {
                MessageBox.Show("Login realizado com sucesso!");
                this.Close();
                novaTela = new Thread(novoForm);
                novaTela.SetApartmentState(ApartmentState.STA);
                novaTela.Start();
            }
            else // se o usuario ou a senha estiverem incorretos apresenta a mensagem de erro abaixo
            {
                MessageBox.Show("Usuáro e/ou senha Incorretos!");
            }
        }
        private void novoForm() //chama a inicialização do FormTelaSelecao
        {
            Application.Run(new FormTelaSelecao());
        }

    }
}
