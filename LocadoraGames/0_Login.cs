using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LocadoraGames
{
    public partial class Form1 : Form
    {
        //nova thread chamar nova tela
        Thread novaTela;

        public Form1()
        {
            InitializeComponent();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxUser_Click(object sender, EventArgs e)
        {
            textBoxUser.Clear();
            pictureBoxUser.Image = Properties.Resources.UserIconAzul11;
            panelUser.BackColor = Color.Teal;
            textBoxUser.ForeColor = Color.Teal;

            pictureBoxPswd.Image = Properties.Resources.CadeadoBrancoIcone;
            panelPswd.BackColor = Color.WhiteSmoke;
            textBoxPswd.ForeColor = Color.WhiteSmoke;
        }

        private void textBoxPswd_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "" && textBoxPswd.Text == "")
            {
                MessageBox.Show("Login realizado com sucesso!");
                this.Close();
                novaTela = new Thread(novoForm);
                novaTela.SetApartmentState(ApartmentState.STA);
                novaTela.Start();
            }
            else
            {
                MessageBox.Show("Usuáro ou senha não encontrados");
                textBoxUser.Clear();
                textBoxPswd.Clear();
            }
        }
        private void novoForm()
        {
            //chama a inicialização do form2
            Application.Run(new Form2());
        }

    }
}
