
namespace LocadoraGames
{
    partial class FormListaGames
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.labelClose = new System.Windows.Forms.Label();
            this.dataGridGames = new System.Windows.Forms.DataGridView();
            this.buttonDispGame = new System.Windows.Forms.Button();
            this.panelGame = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.textBoxGame = new System.Windows.Forms.TextBox();
            this.panelAlugueis = new System.Windows.Forms.Panel();
            this.labelAlugueis = new System.Windows.Forms.Label();
            this.panelQuadroAlugueis = new System.Windows.Forms.Panel();
            this.dataGridAlugueis = new System.Windows.Forms.DataGridView();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.ColumnIdAluguel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeAluguel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGameAluguel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlataformaAluguel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiasAluguel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValorAluguel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAnoGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlataformaGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescricaoGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDisponivelGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxPlataforma = new System.Windows.Forms.TextBox();
            this.panelPlataforma = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGames)).BeginInit();
            this.panelForm.SuspendLayout();
            this.panelQuadroAlugueis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlugueis)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.labelTitulo.Location = new System.Drawing.Point(12, 22);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(75, 22);
            this.labelTitulo.TabIndex = 32;
            this.labelTitulo.Text = "Games";
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelTitulo.Location = new System.Drawing.Point(12, 48);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(233, 1);
            this.panelTitulo.TabIndex = 33;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.labelClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelClose.Location = new System.Drawing.Point(731, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(18, 18);
            this.labelClose.TabIndex = 27;
            this.labelClose.Text = "X";
            this.labelClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridGames
            // 
            this.dataGridGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdGame,
            this.ColumnNomeGame,
            this.ColumnAnoGame,
            this.ColumnPlataformaGame,
            this.ColumnDescricaoGame,
            this.ColumnDisponivelGame});
            this.dataGridGames.Location = new System.Drawing.Point(10, 129);
            this.dataGridGames.Name = "dataGridGames";
            this.dataGridGames.Size = new System.Drawing.Size(727, 151);
            this.dataGridGames.TabIndex = 29;
            this.dataGridGames.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridGames_CellClick);
            // 
            // buttonDispGame
            // 
            this.buttonDispGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.buttonDispGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDispGame.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDispGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.buttonDispGame.Location = new System.Drawing.Point(442, 81);
            this.buttonDispGame.Name = "buttonDispGame";
            this.buttonDispGame.Size = new System.Drawing.Size(233, 30);
            this.buttonDispGame.TabIndex = 24;
            this.buttonDispGame.Text = "Disponibilizar game";
            this.buttonDispGame.UseVisualStyleBackColor = false;
            this.buttonDispGame.Click += new System.EventHandler(this.buttonDispGame_Click);
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelGame.Location = new System.Drawing.Point(55, 107);
            this.panelGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(200, 1);
            this.panelGame.TabIndex = 11;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.Transparent;
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelForm.Controls.Add(this.textBoxPlataforma);
            this.panelForm.Controls.Add(this.panelPlataforma);
            this.panelForm.Controls.Add(this.buttonBuscar);
            this.panelForm.Controls.Add(this.dataGridAlugueis);
            this.panelForm.Controls.Add(this.dataGridGames);
            this.panelForm.Controls.Add(this.buttonDispGame);
            this.panelForm.Controls.Add(this.textBoxGame);
            this.panelForm.Controls.Add(this.panelGame);
            this.panelForm.Controls.Add(this.labelClose);
            this.panelForm.Controls.Add(this.panelQuadroAlugueis);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(751, 502);
            this.panelForm.TabIndex = 34;
            // 
            // textBoxGame
            // 
            this.textBoxGame.AcceptsTab = true;
            this.textBoxGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.textBoxGame.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGame.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGame.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxGame.HideSelection = false;
            this.textBoxGame.Location = new System.Drawing.Point(55, 81);
            this.textBoxGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGame.Multiline = true;
            this.textBoxGame.Name = "textBoxGame";
            this.textBoxGame.Size = new System.Drawing.Size(171, 18);
            this.textBoxGame.TabIndex = 13;
            this.textBoxGame.TabStop = false;
            this.textBoxGame.Text = "Nome do Game";
            this.textBoxGame.Click += new System.EventHandler(this.textBoxGame_Click);
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
            // labelAlugueis
            // 
            this.labelAlugueis.AutoSize = true;
            this.labelAlugueis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlugueis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.labelAlugueis.Location = new System.Drawing.Point(281, 10);
            this.labelAlugueis.Name = "labelAlugueis";
            this.labelAlugueis.Size = new System.Drawing.Size(137, 19);
            this.labelAlugueis.TabIndex = 35;
            this.labelAlugueis.Text = "Últimos Aluguéis";
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
            // dataGridAlugueis
            // 
            this.dataGridAlugueis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlugueis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdAluguel,
            this.ColumnNomeAluguel,
            this.ColumnGameAluguel,
            this.ColumnPlataformaAluguel,
            this.ColumnDiasAluguel,
            this.ColumnValorAluguel});
            this.dataGridAlugueis.Location = new System.Drawing.Point(16, 331);
            this.dataGridAlugueis.Name = "dataGridAlugueis";
            this.dataGridAlugueis.Size = new System.Drawing.Size(716, 152);
            this.dataGridAlugueis.TabIndex = 34;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.buttonBuscar.Location = new System.Drawing.Point(442, 36);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(233, 30);
            this.buttonBuscar.TabIndex = 38;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click_1);
            // 
            // ColumnIdAluguel
            // 
            this.ColumnIdAluguel.HeaderText = "ID";
            this.ColumnIdAluguel.Name = "ColumnIdAluguel";
            this.ColumnIdAluguel.Width = 30;
            // 
            // ColumnNomeAluguel
            // 
            this.ColumnNomeAluguel.HeaderText = "Nome";
            this.ColumnNomeAluguel.Name = "ColumnNomeAluguel";
            this.ColumnNomeAluguel.Width = 190;
            // 
            // ColumnGameAluguel
            // 
            this.ColumnGameAluguel.HeaderText = "Game";
            this.ColumnGameAluguel.Name = "ColumnGameAluguel";
            this.ColumnGameAluguel.Width = 160;
            // 
            // ColumnPlataformaAluguel
            // 
            this.ColumnPlataformaAluguel.HeaderText = "Plataforma";
            this.ColumnPlataformaAluguel.Name = "ColumnPlataformaAluguel";
            this.ColumnPlataformaAluguel.Width = 120;
            // 
            // ColumnDiasAluguel
            // 
            this.ColumnDiasAluguel.HeaderText = "Dias";
            this.ColumnDiasAluguel.Name = "ColumnDiasAluguel";
            this.ColumnDiasAluguel.Width = 80;
            // 
            // ColumnValorAluguel
            // 
            this.ColumnValorAluguel.HeaderText = "Valor";
            this.ColumnValorAluguel.Name = "ColumnValorAluguel";
            this.ColumnValorAluguel.Width = 80;
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
            this.ColumnNomeGame.Width = 140;
            // 
            // ColumnAnoGame
            // 
            this.ColumnAnoGame.HeaderText = "Ano";
            this.ColumnAnoGame.Name = "ColumnAnoGame";
            this.ColumnAnoGame.Width = 50;
            // 
            // ColumnPlataformaGame
            // 
            this.ColumnPlataformaGame.HeaderText = "Plataforma";
            this.ColumnPlataformaGame.Name = "ColumnPlataformaGame";
            this.ColumnPlataformaGame.Width = 90;
            // 
            // ColumnDescricaoGame
            // 
            this.ColumnDescricaoGame.HeaderText = "Descrição";
            this.ColumnDescricaoGame.Name = "ColumnDescricaoGame";
            this.ColumnDescricaoGame.Width = 300;
            // 
            // ColumnDisponivelGame
            // 
            this.ColumnDisponivelGame.HeaderText = "Disponível";
            this.ColumnDisponivelGame.Name = "ColumnDisponivelGame";
            this.ColumnDisponivelGame.Width = 65;
            // 
            // textBoxPlataforma
            // 
            this.textBoxPlataforma.AcceptsTab = true;
            this.textBoxPlataforma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.textBoxPlataforma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPlataforma.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlataforma.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxPlataforma.HideSelection = false;
            this.textBoxPlataforma.Location = new System.Drawing.Point(274, 81);
            this.textBoxPlataforma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPlataforma.Multiline = true;
            this.textBoxPlataforma.Name = "textBoxPlataforma";
            this.textBoxPlataforma.Size = new System.Drawing.Size(143, 18);
            this.textBoxPlataforma.TabIndex = 40;
            this.textBoxPlataforma.TabStop = false;
            this.textBoxPlataforma.Text = "Plataforma";
            this.textBoxPlataforma.Click += new System.EventHandler(this.textBoxPlataforma_Click);
            // 
            // panelPlataforma
            // 
            this.panelPlataforma.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelPlataforma.Location = new System.Drawing.Point(274, 107);
            this.panelPlataforma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelPlataforma.Name = "panelPlataforma";
            this.panelPlataforma.Size = new System.Drawing.Size(150, 1);
            this.panelPlataforma.TabIndex = 39;
            // 
            // FormListaGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(751, 502);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListaGames";
            this.Load += new System.EventHandler(this.FormListaGames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGames)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panelQuadroAlugueis.ResumeLayout(false);
            this.panelQuadroAlugueis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlugueis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.DataGridView dataGridGames;
        private System.Windows.Forms.Button buttonDispGame;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.TextBox textBoxGame;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridView dataGridAlugueis;
        private System.Windows.Forms.Panel panelQuadroAlugueis;
        private System.Windows.Forms.Label labelAlugueis;
        private System.Windows.Forms.Panel panelAlugueis;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAnoGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlataformaGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescricaoGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDisponivelGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdAluguel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeAluguel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGameAluguel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlataformaAluguel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiasAluguel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValorAluguel;
        private System.Windows.Forms.TextBox textBoxPlataforma;
        private System.Windows.Forms.Panel panelPlataforma;
    }
}