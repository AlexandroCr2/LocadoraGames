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
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout realizado com sucesso!");
            this.Close();
            novaTela = new Thread(novoForm);
            novaTela.SetApartmentState(ApartmentState.STA);
            novaTela.Start();
        }
        private void novoForm()
        {
            //chama a inicialização do form2
            Application.Run(new Form1());
        }

        private void buttonAluguel_MouseMove(object sender, MouseEventArgs e)
        {
            buttonAluguel.BackColor = Color.FromArgb(0, 150, 136);
            int novaFonte = 11;
            buttonAluguel.Font = new Font(buttonAluguel.Font.FontFamily, novaFonte);

            int velhaFonte = 9;

            buttonPlayers.BackColor = Color.FromArgb(51, 51, 86);
            buttonPlayers.Font = new Font(buttonCadastroPlayer.Font.FontFamily, velhaFonte);

            buttonCadastroPlayer.BackColor = Color.FromArgb(51, 51, 86);
            buttonCadastroPlayer.Font = new Font(buttonCadastroPlayer.Font.FontFamily, velhaFonte); 

            buttonListaGames.BackColor = Color.FromArgb(51, 51, 86);
            buttonListaGames.Font = new Font(buttonListaGames.Font.FontFamily, velhaFonte);
            
            buttonCadastroGames.BackColor = Color.FromArgb(51, 51, 86);
            buttonCadastroGames.Font = new Font(buttonCadastroGames.Font.FontFamily, velhaFonte);

            buttonLogout.BackColor = Color.FromArgb(51, 51, 86);
            buttonLogout.Font = new Font(buttonLogout.Font.FontFamily, velhaFonte);
        }

        private void buttonPlayers_MouseMove(object sender, MouseEventArgs e)
        {
            buttonPlayers.BackColor = Color.FromArgb(0, 150, 136);
            int novaFonte = 11;
            buttonPlayers.Font = new Font(buttonPlayers.Font.FontFamily, novaFonte);

            int velhaFonte = 9;

            buttonAluguel.BackColor = Color.FromArgb(51, 51, 86);
            buttonAluguel.Font = new Font(buttonAluguel.Font.FontFamily, velhaFonte);

            buttonCadastroPlayer.BackColor = Color.FromArgb(51, 51, 86);
            buttonCadastroPlayer.Font = new Font(buttonCadastroPlayer.Font.FontFamily, velhaFonte);

            buttonListaGames.BackColor = Color.FromArgb(51, 51, 86);
            buttonListaGames.Font = new Font(buttonListaGames.Font.FontFamily, velhaFonte);

            buttonCadastroGames.BackColor = Color.FromArgb(51, 51, 86);
            buttonCadastroGames.Font = new Font(buttonCadastroGames.Font.FontFamily, velhaFonte);

            buttonLogout.BackColor = Color.FromArgb(51, 51, 86);
            buttonLogout.Font = new Font(buttonLogout.Font.FontFamily, velhaFonte);
        }

        private void buttonCadastroPlayer_MouseMove(object sender, MouseEventArgs e)
        {
            buttonCadastroPlayer.BackColor = Color.FromArgb(0, 150, 136);
            int novaFonte = 11;
            buttonCadastroPlayer.Font = new Font(buttonCadastroPlayer.Font.FontFamily, novaFonte);

            int velhaFonte = 9;

            buttonAluguel.BackColor = Color.FromArgb(51, 51, 86);
            buttonAluguel.Font = new Font(buttonAluguel.Font.FontFamily, velhaFonte);

            buttonPlayers.BackColor = Color.FromArgb(51, 51, 86);
            buttonPlayers.Font = new Font(buttonPlayers.Font.FontFamily, velhaFonte);

            buttonListaGames.BackColor = Color.FromArgb(51, 51, 86);
            buttonListaGames.Font = new Font(buttonListaGames.Font.FontFamily, velhaFonte);

            buttonCadastroGames.BackColor = Color.FromArgb(51, 51, 86);
            buttonCadastroGames.Font = new Font(buttonCadastroGames.Font.FontFamily, velhaFonte);

            buttonLogout.BackColor = Color.FromArgb(51, 51, 86);
            buttonLogout.Font = new Font(buttonLogout.Font.FontFamily, velhaFonte);
        }

        private void buttonListaGames_MouseMove(object sender, MouseEventArgs e)
        {
            buttonListaGames.BackColor = Color.FromArgb(0, 150, 136);
            int novaFonte = 11;
            buttonListaGames.Font = new Font(buttonListaGames.Font.FontFamily, novaFonte);

            int velhaFonte =  9;

            buttonAluguel.BackColor = Color.FromArgb(51, 51, 86);
            buttonAluguel.Font = new Font(buttonAluguel.Font.FontFamily, velhaFonte);

            buttonPlayers.BackColor = Color.FromArgb(51, 51, 86);
            buttonPlayers.Font = new Font(buttonPlayers.Font.FontFamily, velhaFonte);

            buttonCadastroPlayer.BackColor = Color.FromArgb(51, 51, 86);
            buttonCadastroPlayer.Font = new Font(buttonCadastroPlayer.Font.FontFamily, velhaFonte);

            buttonCadastroGames.BackColor = Color.FromArgb(51, 51, 86);
            buttonCadastroGames.Font = new Font(buttonCadastroGames.Font.FontFamily, velhaFonte);

            buttonLogout.BackColor = Color.FromArgb(51, 51, 86);
            buttonLogout.Font = new Font(buttonLogout.Font.FontFamily, velhaFonte);
        }

        private void buttonCadastroGames_MouseMove(object sender, MouseEventArgs e)
        {
            buttonCadastroGames.BackColor = Color.FromArgb(0, 150, 136);
            int novaFonte = 11;
            buttonCadastroGames.Font = new Font(buttonCadastroGames.Font.FontFamily, novaFonte);

            int velhaFonte = 9;

            buttonAluguel.BackColor = Color.FromArgb(51, 51, 86);
            buttonAluguel.Font = new Font(buttonAluguel.Font.FontFamily, velhaFonte);

            buttonPlayers.BackColor = Color.FromArgb(51, 51, 86);
            buttonPlayers.Font = new Font(buttonPlayers.Font.FontFamily, velhaFonte);

            buttonCadastroPlayer.BackColor = Color.FromArgb(51, 51, 86);
            buttonCadastroPlayer.Font = new Font(buttonCadastroPlayer.Font.FontFamily, velhaFonte);

            buttonListaGames.BackColor = Color.FromArgb(51, 51, 86);
            buttonListaGames.Font = new Font(buttonListaGames.Font.FontFamily, velhaFonte);

            buttonLogout.BackColor = Color.FromArgb(51, 51, 86);
            buttonLogout.Font = new Font(buttonLogout.Font.FontFamily, velhaFonte);
        }

        private void buttonLogout_MouseMove(object sender, MouseEventArgs e)
        {
            buttonLogout.BackColor = Color.FromArgb(0, 150, 136);
            int novaFonte = 11;
            buttonLogout.Font = new Font(buttonLogout.Font.FontFamily, novaFonte);

            int velhaFonte = 9;

            buttonAluguel.BackColor = Color.FromArgb(51, 51, 86);
            buttonAluguel.Font = new Font(buttonAluguel.Font.FontFamily, velhaFonte);

            buttonPlayers.BackColor = Color.FromArgb(51, 51, 86);
            buttonPlayers.Font = new Font(buttonPlayers.Font.FontFamily, velhaFonte);

            buttonCadastroPlayer.BackColor = Color.FromArgb(51, 51, 86);
            buttonCadastroPlayer.Font = new Font(buttonCadastroPlayer.Font.FontFamily, velhaFonte);

            buttonListaGames.BackColor = Color.FromArgb(51, 51, 86);
            buttonListaGames.Font = new Font(buttonListaGames.Font.FontFamily, velhaFonte);

            buttonCadastroGames.BackColor = Color.FromArgb(51, 51, 86);
            buttonCadastroGames.Font = new Font(buttonCadastroGames.Font.FontFamily, velhaFonte);
        }
    }
}
