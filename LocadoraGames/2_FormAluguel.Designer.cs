
namespace LocadoraGames
{
    partial class FormAluguel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.panelNome = new System.Windows.Forms.Panel();
            this.dataGridPlayer = new System.Windows.Forms.DataGridView();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelClose = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridGame = new System.Windows.Forms.DataGridView();
            this.ColumnGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlataforma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDisponivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxGame = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.textBoxGameAlugar = new System.Windows.Forms.TextBox();
            this.textBoxValorAluguel = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBoxPlataforma = new System.Windows.Forms.TextBox();
            this.textBoxEnderecoAlugar = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxTelefoneAlugar = new System.Windows.Forms.TextBox();
            this.textBoxTempoAluguel = new System.Windows.Forms.TextBox();
            this.textBoxUsuarioAlugar = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlayer)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGame)).BeginInit();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.AcceptsTab = true;
            this.textBoxNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.textBoxNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxNome.HideSelection = false;
            this.textBoxNome.Location = new System.Drawing.Point(43, 90);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNome.Multiline = true;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(271, 18);
            this.textBoxNome.TabIndex = 13;
            this.textBoxNome.TabStop = false;
            this.textBoxNome.Text = "Nome do Player";
            this.textBoxNome.Click += new System.EventHandler(this.textBoxNome_Click);
            // 
            // panelNome
            // 
            this.panelNome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelNome.Location = new System.Drawing.Point(14, 116);
            this.panelNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelNome.Name = "panelNome";
            this.panelNome.Size = new System.Drawing.Size(300, 1);
            this.panelNome.TabIndex = 11;
            // 
            // dataGridPlayer
            // 
            this.dataGridPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPlayer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNome,
            this.ColumnTelefone,
            this.ColumnEndereco});
            this.dataGridPlayer.Location = new System.Drawing.Point(14, 169);
            this.dataGridPlayer.Name = "dataGridPlayer";
            this.dataGridPlayer.Size = new System.Drawing.Size(349, 109);
            this.dataGridPlayer.TabIndex = 29;
            this.dataGridPlayer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPlayer_CellClick);
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.Width = 150;
            // 
            // ColumnTelefone
            // 
            this.ColumnTelefone.HeaderText = "Telefone";
            this.ColumnTelefone.Name = "ColumnTelefone";
            this.ColumnTelefone.Width = 80;
            // 
            // ColumnEndereco
            // 
            this.ColumnEndereco.HeaderText = "Endereço";
            this.ColumnEndereco.Name = "ColumnEndereco";
            this.ColumnEndereco.Width = 390;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.labelClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelClose.Location = new System.Drawing.Point(731, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(18, 18);
            this.labelClose.TabIndex = 27;
            this.labelClose.Text = "X";
            this.labelClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 1);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.labelClose);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.dataGridGame);
            this.panel2.Controls.Add(this.textBoxGame);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.dataGridPlayer);
            this.panel2.Controls.Add(this.buttonConfirmar);
            this.panel2.Controls.Add(this.textBoxNome);
            this.panel2.Controls.Add(this.panelNome);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(751, 502);
            this.panel2.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.button2.Location = new System.Drawing.Point(81, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 30);
            this.button2.TabIndex = 46;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridGame
            // 
            this.dataGridGame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGame.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnGame,
            this.ColumnPlataforma,
            this.ColumnDisponivel});
            this.dataGridGame.Location = new System.Drawing.Point(14, 377);
            this.dataGridGame.Name = "dataGridGame";
            this.dataGridGame.Size = new System.Drawing.Size(349, 109);
            this.dataGridGame.TabIndex = 45;
            this.dataGridGame.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridGame_CellClick);
            // 
            // ColumnGame
            // 
            this.ColumnGame.HeaderText = "Game";
            this.ColumnGame.Name = "ColumnGame";
            this.ColumnGame.Width = 170;
            // 
            // ColumnPlataforma
            // 
            this.ColumnPlataforma.HeaderText = "Plataforma";
            this.ColumnPlataforma.Name = "ColumnPlataforma";
            // 
            // ColumnDisponivel
            // 
            this.ColumnDisponivel.HeaderText = "Dispo.";
            this.ColumnDisponivel.Name = "ColumnDisponivel";
            this.ColumnDisponivel.Width = 40;
            // 
            // textBoxGame
            // 
            this.textBoxGame.AcceptsTab = true;
            this.textBoxGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.textBoxGame.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGame.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGame.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxGame.HideSelection = false;
            this.textBoxGame.Location = new System.Drawing.Point(43, 298);
            this.textBoxGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGame.Multiline = true;
            this.textBoxGame.Name = "textBoxGame";
            this.textBoxGame.Size = new System.Drawing.Size(271, 18);
            this.textBoxGame.TabIndex = 44;
            this.textBoxGame.TabStop = false;
            this.textBoxGame.Text = "Game";
            this.textBoxGame.Click += new System.EventHandler(this.textBoxGame_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel9.Location = new System.Drawing.Point(14, 324);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(300, 1);
            this.panel9.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.button1.Location = new System.Drawing.Point(81, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 30);
            this.button1.TabIndex = 36;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Location = new System.Drawing.Point(413, 195);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 1);
            this.panel3.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Location = new System.Drawing.Point(413, 151);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 1);
            this.panel4.TabIndex = 32;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Location = new System.Drawing.Point(413, 107);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 1);
            this.panel5.TabIndex = 30;
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.buttonConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.buttonConfirmar.Location = new System.Drawing.Point(480, 396);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(233, 30);
            this.buttonConfirmar.TabIndex = 28;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = false;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.textBoxGameAlugar);
            this.panel11.Controls.Add(this.label1);
            this.panel11.Controls.Add(this.textBoxValorAluguel);
            this.panel11.Controls.Add(this.panel8);
            this.panel11.Controls.Add(this.panel10);
            this.panel11.Controls.Add(this.panel7);
            this.panel11.Controls.Add(this.textBoxPlataforma);
            this.panel11.Controls.Add(this.textBoxEnderecoAlugar);
            this.panel11.Controls.Add(this.panel6);
            this.panel11.Controls.Add(this.textBoxTelefoneAlugar);
            this.panel11.Controls.Add(this.textBoxTempoAluguel);
            this.panel11.Controls.Add(this.textBoxUsuarioAlugar);
            this.panel11.Location = new System.Drawing.Point(390, 20);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(347, 466);
            this.panel11.TabIndex = 49;
            // 
            // textBoxGameAlugar
            // 
            this.textBoxGameAlugar.AcceptsTab = true;
            this.textBoxGameAlugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.textBoxGameAlugar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGameAlugar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGameAlugar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.textBoxGameAlugar.HideSelection = false;
            this.textBoxGameAlugar.Location = new System.Drawing.Point(21, 189);
            this.textBoxGameAlugar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGameAlugar.Multiline = true;
            this.textBoxGameAlugar.Name = "textBoxGameAlugar";
            this.textBoxGameAlugar.Size = new System.Drawing.Size(271, 18);
            this.textBoxGameAlugar.TabIndex = 38;
            this.textBoxGameAlugar.TabStop = false;
            this.textBoxGameAlugar.Text = "Game";
            // 
            // textBoxValorAluguel
            // 
            this.textBoxValorAluguel.AcceptsTab = true;
            this.textBoxValorAluguel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.textBoxValorAluguel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxValorAluguel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValorAluguel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.textBoxValorAluguel.HideSelection = false;
            this.textBoxValorAluguel.Location = new System.Drawing.Point(21, 325);
            this.textBoxValorAluguel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxValorAluguel.Multiline = true;
            this.textBoxValorAluguel.Name = "textBoxValorAluguel";
            this.textBoxValorAluguel.Size = new System.Drawing.Size(271, 18);
            this.textBoxValorAluguel.TabIndex = 48;
            this.textBoxValorAluguel.TabStop = false;
            this.textBoxValorAluguel.Text = "Valor do Aluguel";
            this.textBoxValorAluguel.WordWrap = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel8.Location = new System.Drawing.Point(21, 217);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(300, 1);
            this.panel8.TabIndex = 37;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel10.Location = new System.Drawing.Point(21, 353);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(300, 1);
            this.panel10.TabIndex = 47;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel7.Location = new System.Drawing.Point(21, 261);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(300, 1);
            this.panel7.TabIndex = 39;
            // 
            // textBoxPlataforma
            // 
            this.textBoxPlataforma.AcceptsTab = true;
            this.textBoxPlataforma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.textBoxPlataforma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPlataforma.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlataforma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.textBoxPlataforma.HideSelection = false;
            this.textBoxPlataforma.Location = new System.Drawing.Point(21, 233);
            this.textBoxPlataforma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPlataforma.Multiline = true;
            this.textBoxPlataforma.Name = "textBoxPlataforma";
            this.textBoxPlataforma.Size = new System.Drawing.Size(271, 18);
            this.textBoxPlataforma.TabIndex = 40;
            this.textBoxPlataforma.TabStop = false;
            this.textBoxPlataforma.Text = "Plataforma";
            // 
            // textBoxEnderecoAlugar
            // 
            this.textBoxEnderecoAlugar.AcceptsTab = true;
            this.textBoxEnderecoAlugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.textBoxEnderecoAlugar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEnderecoAlugar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnderecoAlugar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.textBoxEnderecoAlugar.HideSelection = false;
            this.textBoxEnderecoAlugar.Location = new System.Drawing.Point(21, 147);
            this.textBoxEnderecoAlugar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEnderecoAlugar.Multiline = true;
            this.textBoxEnderecoAlugar.Name = "textBoxEnderecoAlugar";
            this.textBoxEnderecoAlugar.Size = new System.Drawing.Size(271, 18);
            this.textBoxEnderecoAlugar.TabIndex = 35;
            this.textBoxEnderecoAlugar.TabStop = false;
            this.textBoxEnderecoAlugar.Text = "Endereço";
            this.textBoxEnderecoAlugar.WordWrap = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.Location = new System.Drawing.Point(21, 305);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 1);
            this.panel6.TabIndex = 41;
            // 
            // textBoxTelefoneAlugar
            // 
            this.textBoxTelefoneAlugar.AcceptsTab = true;
            this.textBoxTelefoneAlugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.textBoxTelefoneAlugar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTelefoneAlugar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefoneAlugar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.textBoxTelefoneAlugar.HideSelection = false;
            this.textBoxTelefoneAlugar.Location = new System.Drawing.Point(21, 103);
            this.textBoxTelefoneAlugar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTelefoneAlugar.Multiline = true;
            this.textBoxTelefoneAlugar.Name = "textBoxTelefoneAlugar";
            this.textBoxTelefoneAlugar.Size = new System.Drawing.Size(271, 18);
            this.textBoxTelefoneAlugar.TabIndex = 33;
            this.textBoxTelefoneAlugar.TabStop = false;
            this.textBoxTelefoneAlugar.Text = "Telefone";
            // 
            // textBoxTempoAluguel
            // 
            this.textBoxTempoAluguel.AcceptsTab = true;
            this.textBoxTempoAluguel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.textBoxTempoAluguel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTempoAluguel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTempoAluguel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.textBoxTempoAluguel.HideSelection = false;
            this.textBoxTempoAluguel.Location = new System.Drawing.Point(21, 277);
            this.textBoxTempoAluguel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTempoAluguel.Multiline = true;
            this.textBoxTempoAluguel.Name = "textBoxTempoAluguel";
            this.textBoxTempoAluguel.Size = new System.Drawing.Size(271, 18);
            this.textBoxTempoAluguel.TabIndex = 42;
            this.textBoxTempoAluguel.TabStop = false;
            this.textBoxTempoAluguel.Text = "Dias de Aluguel";
            this.textBoxTempoAluguel.WordWrap = false;
            this.textBoxTempoAluguel.Click += new System.EventHandler(this.textBoxTempoAluguel_Click);
            this.textBoxTempoAluguel.TextChanged += new System.EventHandler(this.textBoxTempoAluguel_TextChanged);
            // 
            // textBoxUsuarioAlugar
            // 
            this.textBoxUsuarioAlugar.AcceptsTab = true;
            this.textBoxUsuarioAlugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.textBoxUsuarioAlugar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsuarioAlugar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuarioAlugar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.textBoxUsuarioAlugar.HideSelection = false;
            this.textBoxUsuarioAlugar.Location = new System.Drawing.Point(21, 59);
            this.textBoxUsuarioAlugar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUsuarioAlugar.Multiline = true;
            this.textBoxUsuarioAlugar.Name = "textBoxUsuarioAlugar";
            this.textBoxUsuarioAlugar.Size = new System.Drawing.Size(271, 18);
            this.textBoxUsuarioAlugar.TabIndex = 31;
            this.textBoxUsuarioAlugar.TabStop = false;
            this.textBoxUsuarioAlugar.Text = "Nome do Player";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.labelTitulo.Location = new System.Drawing.Point(12, 22);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(178, 22);
            this.labelTitulo.TabIndex = 29;
            this.labelTitulo.Text = "Aluguel de Games";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel12.Location = new System.Drawing.Point(3, 29);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(233, 1);
            this.panel12.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Confirmação Aluguel";
            // 
            // FormAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(751, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAluguel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlayer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGame)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Panel panelNome;
        private System.Windows.Forms.DataGridView dataGridPlayer;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridGame;
        private System.Windows.Forms.TextBox textBoxGame;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox textBoxGameAlugar;
        private System.Windows.Forms.TextBox textBoxValorAluguel;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBoxPlataforma;
        private System.Windows.Forms.TextBox textBoxEnderecoAlugar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBoxTelefoneAlugar;
        private System.Windows.Forms.TextBox textBoxTempoAluguel;
        private System.Windows.Forms.TextBox textBoxUsuarioAlugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlataforma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDisponivel;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label1;
    }
}