using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraGames
{
    public partial class Form2 : Form
    {
        //nova thread chamar nova tela
        Thread novaTela;

        public Form2()
        {
            InitializeComponent(); 
            panelLogo.BackColor = Color.FromArgb(10, 10, 15);
            panelTopo.BackColor = Color.FromArgb(35, 35, 55);
        }

        private void fontePadrao()
        {
            //metodo onde o tamanho da fonte dos buttons fica setada em 9 e a backcolor é setada em RGB(51, 51, 86)
            int velhaFonte = 9;

            buttonAluguel.BackColor = Color.Transparent;
            buttonAluguel.Font = new Font(buttonAluguel.Font.FontFamily, velhaFonte);

            buttonPlayers.BackColor = Color.Transparent;
            buttonPlayers.Font = new Font(buttonCadastroPlayer.Font.FontFamily, velhaFonte);

            buttonCadastroPlayer.BackColor = Color.Transparent;
            buttonCadastroPlayer.Font = new Font(buttonCadastroPlayer.Font.FontFamily, velhaFonte);

            buttonListaGames.BackColor = Color.Transparent;
            buttonListaGames.Font = new Font(buttonListaGames.Font.FontFamily, velhaFonte);

            buttonCadastroGames.BackColor = Color.Transparent;
            buttonCadastroGames.Font = new Font(buttonCadastroGames.Font.FontFamily, velhaFonte);

            buttonLogout.BackColor = Color.Transparent;
            buttonLogout.Font = new Font(buttonLogout.Font.FontFamily, velhaFonte);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            //botão de logout que chama a tela de login novamente
            MessageBox.Show("Logout realizado com sucesso!");
            this.Close();
            novaTela = new Thread(novoForm);
            novaTela.SetApartmentState(ApartmentState.STA);
            novaTela.Start();
        }

        private void novoForm()
        {
            //chama a inicialização da tela de login
            Application.Run(new Form1());
        }

        private void buttonAluguel_MouseMove(object sender, MouseEventArgs e)
        {
            //altera o backcolor dos paineis e do buttom e a fonte do buttom ao passar o mouse sobre ele
            fontePadrao();
            labelHome.Text = buttonAluguel.Text;
            panelLogo.BackColor = Color.FromArgb(0, 50, 43);
            panelTopo.BackColor = Color.FromArgb(0, 150, 136);
            buttonAluguel.BackColor = Color.FromArgb(0, 150, 136);
            int novaFonte = 11;
            buttonAluguel.Font = new Font(buttonAluguel.Font.FontFamily, novaFonte);
        }

        private void buttonPlayers_MouseMove(object sender, MouseEventArgs e)
        {
            //altera o backcolor dos paineis e do buttom e a fonte do buttom ao passar o mouse sobre ele
            fontePadrao();
            labelHome.Text = buttonPlayers.Text;
            panelLogo.BackColor = Color.FromArgb(0, 0, 50);
            panelTopo.BackColor = Color.FromArgb(93, 152, 183);
            buttonPlayers.BackColor = Color.FromArgb(93, 152, 183);
            int novaFonte = 11;
            buttonPlayers.Font = new Font(buttonPlayers.Font.FontFamily, novaFonte);

        }

        private void buttonCadastroPlayer_MouseMove(object sender, MouseEventArgs e)
        {
            //altera o backcolor dos paineis e do buttom e a fonte do buttom ao passar o mouse sobre ele
            fontePadrao();
            labelHome.Text = buttonCadastroPlayer.Text;
            panelLogo.BackColor = Color.FromArgb(40, 0, 50);
            panelTopo.BackColor = Color.FromArgb(150, 110, 190);
            buttonCadastroPlayer.BackColor = Color.FromArgb(150, 110, 190);
            int novaFonte = 11;
            buttonCadastroPlayer.Font = new Font(buttonCadastroPlayer.Font.FontFamily, novaFonte);
        }

        private void buttonListaGames_MouseMove(object sender, MouseEventArgs e)
        {
            //altera o backcolor dos paineis e do buttom e a fonte do buttom ao passar o mouse sobre ele
            fontePadrao();
            labelHome.Text = buttonListaGames.Text;
            panelLogo.BackColor = Color.FromArgb(60, 16, 14);
            panelTopo.BackColor = Color.FromArgb(169, 53, 53);
            buttonListaGames.BackColor = Color.FromArgb(169, 53, 53);
            int novaFonte = 11;
            buttonListaGames.Font = new Font(buttonListaGames.Font.FontFamily, novaFonte);
        }

        private void buttonCadastroGames_MouseMove(object sender, MouseEventArgs e)
        {
            //altera o backcolor dos paineis e do buttom e a fonte do buttom ao passar o mouse sobre ele
            fontePadrao();
            labelHome.Text = buttonCadastroGames.Text;
            panelLogo.BackColor = Color.FromArgb(77, 42, 27);
            panelTopo.BackColor = Color.FromArgb(188, 110, 65);
            buttonCadastroGames.BackColor = Color.FromArgb(188, 110, 65);
            int novaFonte = 11;
            buttonCadastroGames.Font = new Font(buttonCadastroGames.Font.FontFamily, novaFonte);
        }

        private void buttonLogout_MouseMove(object sender, MouseEventArgs e)
        {
            //altera o backcolor dos paineis e do buttom e a fonte do buttom ao passar o mouse sobre ele
            fontePadrao();
            labelHome.Text = buttonLogout.Text;
            panelLogo.BackColor = Color.FromArgb(54, 54, 54);
            panelTopo.BackColor = Color.FromArgb(100, 100, 100);
            buttonLogout.BackColor = Color.FromArgb(100, 100, 100);
            int novaFonte = 11;
            buttonLogout.Font = new Font(buttonLogout.Font.FontFamily, novaFonte);
        }

        private void buttonAluguel_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonCadastroPlayer_Click(object sender, EventArgs e)
        {
            FormCadastroPlayer janelaCadastroPlayer = new FormCadastroPlayer();
            janelaCadastroPlayer.TopLevel = false;
            janelaCadastroPlayer.Visible = true;
            pictureBox1.Controls.Clear();
            pictureBox1.Controls.Add(janelaCadastroPlayer);
        }

        private void buttonCadastroGames_Click(object sender, EventArgs e)
        {
            FormCadastroGames janela = new FormCadastroGames();
            janela.TopLevel = false;
            janela.Visible = true;
            pictureBox1.Controls.Clear();
            pictureBox1.Controls.Add(janela);
        }
    }
}
