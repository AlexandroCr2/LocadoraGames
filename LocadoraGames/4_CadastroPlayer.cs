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

    public partial class CadastroPlayer : Form
    {
        public CadastroPlayer()
        {
            InitializeComponent();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxNome_Click(object sender, EventArgs e)
        {
            textBoxNome.Clear();
            panelNome.BackColor = Color.FromArgb(150, 110, 190);
            textBoxNome.ForeColor = Color.FromArgb(150, 110, 190);

            panelTelefone.BackColor = Color.LightGray;
            textBoxTelefone.ForeColor = Color.LightGray;

            panelEndereco.BackColor = Color.LightGray;
            textBoxEndereco.ForeColor = Color.LightGray;
        }

        private void textBoxTelefone_Click(object sender, EventArgs e)
        {
            textBoxTelefone.Clear();
            panelTelefone.BackColor = Color.FromArgb(150, 110, 190);
            textBoxTelefone.ForeColor = Color.FromArgb(150, 110, 190);

            panelNome.BackColor = Color.LightGray;
            textBoxNome.ForeColor = Color.LightGray;

            panelEndereco.BackColor = Color.LightGray;
            textBoxEndereco.ForeColor = Color.LightGray;
        }

        private void textBoxEndereco_Click(object sender, EventArgs e)
        {
            textBoxEndereco.Clear();
            panelEndereco.BackColor = Color.FromArgb(150,110, 190);
            textBoxEndereco.ForeColor = Color.FromArgb(150, 110, 190);

            panelNome.BackColor = Color.LightGray;
            textBoxNome.ForeColor = Color.LightGray;

            panelTelefone.BackColor = Color.LightGray;
            textBoxTelefone.ForeColor = Color.LightGray;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string nome;
            string telefone;
            string endereco;

            nome = textBoxNome.Text;
            telefone = textBoxTelefone.Text;
            endereco = textBoxEndereco.Text;

            this.dataGridView1.Rows.Add("", nome, telefone, endereco);
        }

    }
}
