
namespace LocadoraGames
{
    partial class FormPlayers
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
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelClose = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.dataGridAlugueis = new System.Windows.Forms.DataGridView();
            this.ColumnIdGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlataforma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.panelQuadroAlugueis = new System.Windows.Forms.Panel();
            this.labelAlugueis = new System.Windows.Forms.Label();
            this.panelAlugueis = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlayer)).BeginInit();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlugueis)).BeginInit();
            this.panelQuadroAlugueis.SuspendLayout();
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
            this.textBoxNome.Location = new System.Drawing.Point(84, 81);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNome.Multiline = true;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(271, 18);
            this.textBoxNome.TabIndex = 13;
            this.textBoxNome.TabStop = false;
            this.textBoxNome.Text = "Nome do Usuário";
            this.textBoxNome.Click += new System.EventHandler(this.textBoxNome_Click);
            // 
            // panelNome
            // 
            this.panelNome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelNome.Location = new System.Drawing.Point(55, 107);
            this.panelNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelNome.Name = "panelNome";
            this.panelNome.Size = new System.Drawing.Size(300, 1);
            this.panelNome.TabIndex = 11;
            // 
            // dataGridPlayer
            // 
            this.dataGridPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPlayer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNome,
            this.ColumnTelefone,
            this.ColumnEndereco});
            this.dataGridPlayer.Location = new System.Drawing.Point(10, 129);
            this.dataGridPlayer.Name = "dataGridPlayer";
            this.dataGridPlayer.Size = new System.Drawing.Size(727, 151);
            this.dataGridPlayer.TabIndex = 29;
            this.dataGridPlayer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPlayer_CellClick);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Width = 30;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.Width = 170;
            // 
            // ColumnTelefone
            // 
            this.ColumnTelefone.HeaderText = "Telefone";
            this.ColumnTelefone.Name = "ColumnTelefone";
            // 
            // ColumnEndereco
            // 
            this.ColumnEndereco.HeaderText = "Endereço";
            this.ColumnEndereco.Name = "ColumnEndereco";
            this.ColumnEndereco.Width = 380;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(152)))), ((int)(((byte)(183)))));
            this.labelClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelClose.Location = new System.Drawing.Point(731, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(18, 18);
            this.labelClose.TabIndex = 27;
            this.labelClose.Text = "X";
            this.labelClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelTitulo.Location = new System.Drawing.Point(12, 48);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(233, 1);
            this.panelTitulo.TabIndex = 30;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.Transparent;
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelForm.Controls.Add(this.dataGridAlugueis);
            this.panelForm.Controls.Add(this.dataGridPlayer);
            this.panelForm.Controls.Add(this.buttonBuscar);
            this.panelForm.Controls.Add(this.textBoxNome);
            this.panelForm.Controls.Add(this.panelNome);
            this.panelForm.Controls.Add(this.labelClose);
            this.panelForm.Controls.Add(this.panelQuadroAlugueis);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(751, 502);
            this.panelForm.TabIndex = 31;
            // 
            // dataGridAlugueis
            // 
            this.dataGridAlugueis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlugueis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdGame,
            this.ColumnNomeGame,
            this.ColumnGame,
            this.ColumnPlataforma,
            this.ColumnDias,
            this.ColumnValor});
            this.dataGridAlugueis.Location = new System.Drawing.Point(16, 331);
            this.dataGridAlugueis.Name = "dataGridAlugueis";
            this.dataGridAlugueis.Size = new System.Drawing.Size(716, 152);
            this.dataGridAlugueis.TabIndex = 34;
            // 
            // ColumnIdGame
            // 
            this.ColumnIdGame.HeaderText = "ID";
            this.ColumnIdGame.Name = "ColumnIdGame";
            this.ColumnIdGame.Width = 30;
            // 
            // ColumnNomeGame
            // 
            this.ColumnNomeGame.HeaderText = "Nome";
            this.ColumnNomeGame.Name = "ColumnNomeGame";
            this.ColumnNomeGame.Width = 190;
            // 
            // ColumnGame
            // 
            this.ColumnGame.HeaderText = "Game";
            this.ColumnGame.Name = "ColumnGame";
            this.ColumnGame.Width = 160;
            // 
            // ColumnPlataforma
            // 
            this.ColumnPlataforma.HeaderText = "Plataforma";
            this.ColumnPlataforma.Name = "ColumnPlataforma";
            this.ColumnPlataforma.Width = 120;
            // 
            // ColumnDias
            // 
            this.ColumnDias.HeaderText = "Dias";
            this.ColumnDias.Name = "ColumnDias";
            this.ColumnDias.Width = 80;
            // 
            // ColumnValor
            // 
            this.ColumnValor.HeaderText = "Valor";
            this.ColumnValor.Name = "ColumnValor";
            this.ColumnValor.Width = 80;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(152)))), ((int)(((byte)(183)))));
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.buttonBuscar.Location = new System.Drawing.Point(442, 81);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(233, 30);
            this.buttonBuscar.TabIndex = 24;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // panelQuadroAlugueis
            // 
            this.panelQuadroAlugueis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelQuadroAlugueis.Controls.Add(this.labelAlugueis);
            this.panelQuadroAlugueis.Controls.Add(this.panelAlugueis);
            this.panelQuadroAlugueis.Location = new System.Drawing.Point(10, 286);
            this.panelQuadroAlugueis.Name = "panelQuadroAlugueis";
            this.panelQuadroAlugueis.Size = new System.Drawing.Size(727, 202);
            this.panelQuadroAlugueis.TabIndex = 37;
            // 
            // labelAlugueis
            // 
            this.labelAlugueis.AutoSize = true;
            this.labelAlugueis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlugueis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(152)))), ((int)(((byte)(183)))));
            this.labelAlugueis.Location = new System.Drawing.Point(281, 10);
            this.labelAlugueis.Name = "labelAlugueis";
            this.labelAlugueis.Size = new System.Drawing.Size(137, 19);
            this.labelAlugueis.TabIndex = 35;
            this.labelAlugueis.Text = "Últimos Aluguéis";
            // 
            // panelAlugueis
            // 
            this.panelAlugueis.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelAlugueis.Location = new System.Drawing.Point(275, 33);
            this.panelAlugueis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelAlugueis.Name = "panelAlugueis";
            this.panelAlugueis.Size = new System.Drawing.Size(150, 1);
            this.panelAlugueis.TabIndex = 36;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(152)))), ((int)(((byte)(183)))));
            this.labelTitulo.Location = new System.Drawing.Point(12, 22);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(80, 22);
            this.labelTitulo.TabIndex = 29;
            this.labelTitulo.Text = "Players";
            // 
            // FormPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(751, 502);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.panelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPlayers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlayer)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlugueis)).EndInit();
            this.panelQuadroAlugueis.ResumeLayout(false);
            this.panelQuadroAlugueis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Panel panelNome;
        private System.Windows.Forms.DataGridView dataGridPlayer;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridView dataGridAlugueis;
        private System.Windows.Forms.Panel panelAlugueis;
        private System.Windows.Forms.Label labelAlugueis;
        private System.Windows.Forms.Panel panelQuadroAlugueis;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlataforma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEndereco;
    }
}