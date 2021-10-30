
namespace LocadoraGames
{
    partial class FormCadastroPlayer
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
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.panelTelefone = new System.Windows.Forms.Panel();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.panelNome = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.panelEndereco = new System.Windows.Forms.Panel();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridCadastro = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelClose = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(110)))), ((int)(((byte)(190)))));
            this.labelTitulo.Location = new System.Drawing.Point(12, 22);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(200, 22);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Cadastro de Usuário";
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.AcceptsTab = true;
            this.textBoxTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.textBoxTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTelefone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefone.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxTelefone.HideSelection = false;
            this.textBoxTelefone.Location = new System.Drawing.Point(84, 125);
            this.textBoxTelefone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTelefone.Multiline = true;
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(271, 18);
            this.textBoxTelefone.TabIndex = 16;
            this.textBoxTelefone.TabStop = false;
            this.textBoxTelefone.Text = "Telefone";
            this.textBoxTelefone.Click += new System.EventHandler(this.textBoxTelefone_Click);
            // 
            // panelTelefone
            // 
            this.panelTelefone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelTelefone.Location = new System.Drawing.Point(55, 151);
            this.panelTelefone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTelefone.Name = "panelTelefone";
            this.panelTelefone.Size = new System.Drawing.Size(300, 1);
            this.panelTelefone.TabIndex = 14;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 1);
            this.panel1.TabIndex = 12;
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.AcceptsTab = true;
            this.textBoxEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.textBoxEndereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEndereco.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEndereco.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxEndereco.HideSelection = false;
            this.textBoxEndereco.Location = new System.Drawing.Point(84, 169);
            this.textBoxEndereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEndereco.Multiline = true;
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(271, 18);
            this.textBoxEndereco.TabIndex = 19;
            this.textBoxEndereco.TabStop = false;
            this.textBoxEndereco.Text = "Endereço";
            this.textBoxEndereco.WordWrap = false;
            this.textBoxEndereco.Click += new System.EventHandler(this.textBoxEndereco_Click);
            // 
            // panelEndereco
            // 
            this.panelEndereco.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelEndereco.Location = new System.Drawing.Point(55, 195);
            this.panelEndereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelEndereco.Name = "panelEndereco";
            this.panelEndereco.Size = new System.Drawing.Size(300, 1);
            this.panelEndereco.TabIndex = 17;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(110)))), ((int)(((byte)(190)))));
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.buttonSalvar.Location = new System.Drawing.Point(442, 81);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(233, 30);
            this.buttonSalvar.TabIndex = 20;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(110)))), ((int)(((byte)(190)))));
            this.buttonAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.buttonAlterar.Location = new System.Drawing.Point(442, 125);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(233, 30);
            this.buttonAlterar.TabIndex = 24;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = false;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(110)))), ((int)(((byte)(190)))));
            this.buttonRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemover.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.buttonRemover.Location = new System.Drawing.Point(442, 169);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(233, 30);
            this.buttonRemover.TabIndex = 26;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = false;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dataGridCadastro);
            this.panel2.Controls.Add(this.textBoxEndereco);
            this.panel2.Controls.Add(this.buttonBuscar);
            this.panel2.Controls.Add(this.panelEndereco);
            this.panel2.Controls.Add(this.buttonAlterar);
            this.panel2.Controls.Add(this.textBoxTelefone);
            this.panel2.Controls.Add(this.buttonSalvar);
            this.panel2.Controls.Add(this.panelTelefone);
            this.panel2.Controls.Add(this.buttonRemover);
            this.panel2.Controls.Add(this.textBoxNome);
            this.panel2.Controls.Add(this.panelNome);
            this.panel2.Controls.Add(this.labelClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(751, 502);
            this.panel2.TabIndex = 28;
            // 
            // dataGridCadastro
            // 
            this.dataGridCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCadastro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNome,
            this.ColumnTelefone,
            this.ColumnEndereco});
            this.dataGridCadastro.Location = new System.Drawing.Point(10, 235);
            this.dataGridCadastro.Name = "dataGridCadastro";
            this.dataGridCadastro.Size = new System.Drawing.Size(727, 253);
            this.dataGridCadastro.TabIndex = 29;
            this.dataGridCadastro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCadastro_CellClick);
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
            this.ColumnEndereco.Width = 390;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(110)))), ((int)(((byte)(190)))));
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.buttonBuscar.Location = new System.Drawing.Point(442, 37);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(233, 30);
            this.buttonBuscar.TabIndex = 28;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(110)))), ((int)(((byte)(190)))));
            this.labelClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelClose.Location = new System.Drawing.Point(731, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(18, 18);
            this.labelClose.TabIndex = 27;
            this.labelClose.Text = "X";
            this.labelClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // FormCadastroPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(751, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastroPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CadastroPlayer_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.Panel panelTelefone;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Panel panelNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Panel panelEndereco;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridView dataGridCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEndereco;
    }
}