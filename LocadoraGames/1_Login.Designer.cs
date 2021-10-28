
namespace LocadoraGames
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelUser = new System.Windows.Forms.Panel();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelClose = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxPswd = new System.Windows.Forms.TextBox();
            this.panelPswd = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxPswd = new System.Windows.Forms.PictureBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPswd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelUser.Location = new System.Drawing.Point(478, 185);
            this.panelUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(233, 1);
            this.panelUser.TabIndex = 2;
            // 
            // textBoxUser
            // 
            this.textBoxUser.AcceptsTab = true;
            this.textBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUser.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxUser.HideSelection = false;
            this.textBoxUser.Location = new System.Drawing.Point(507, 159);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUser.Multiline = true;
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(206, 18);
            this.textBoxUser.TabIndex = 4;
            this.textBoxUser.TabStop = false;
            this.textBoxUser.Text = "Digite o Usuário";
            this.textBoxUser.Click += new System.EventHandler(this.textBoxUser_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Teal;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.buttonLogin.Location = new System.Drawing.Point(478, 272);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(233, 40);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Play";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.Color.Teal;
            this.labelClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelClose.Location = new System.Drawing.Point(717, 3);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(18, 18);
            this.labelClose.TabIndex = 7;
            this.labelClose.Text = "X";
            this.labelClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.labelClose, "Fechar");
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // textBoxPswd
            // 
            this.textBoxPswd.AcceptsTab = true;
            this.textBoxPswd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.textBoxPswd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPswd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPswd.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxPswd.HideSelection = false;
            this.textBoxPswd.Location = new System.Drawing.Point(507, 203);
            this.textBoxPswd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPswd.Multiline = true;
            this.textBoxPswd.Name = "textBoxPswd";
            this.textBoxPswd.Size = new System.Drawing.Size(206, 18);
            this.textBoxPswd.TabIndex = 10;
            this.textBoxPswd.TabStop = false;
            this.textBoxPswd.Text = "Digite a Senha";
            this.textBoxPswd.Click += new System.EventHandler(this.textBoxPswd_Click);
            // 
            // panelPswd
            // 
            this.panelPswd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelPswd.Location = new System.Drawing.Point(478, 229);
            this.panelPswd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelPswd.Name = "panelPswd";
            this.panelPswd.Size = new System.Drawing.Size(233, 1);
            this.panelPswd.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LocadoraGames.Properties.Resources.gameboy1;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 363);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::LocadoraGames.Properties.Resources.BMOicon;
            this.pictureBoxLogo.Location = new System.Drawing.Point(539, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(116, 149);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 6;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxPswd
            // 
            this.pictureBoxPswd.Image = global::LocadoraGames.Properties.Resources.CadeadoBrancoIcone;
            this.pictureBoxPswd.Location = new System.Drawing.Point(478, 194);
            this.pictureBoxPswd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxPswd.Name = "pictureBoxPswd";
            this.pictureBoxPswd.Size = new System.Drawing.Size(23, 28);
            this.pictureBoxPswd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPswd.TabIndex = 9;
            this.pictureBoxPswd.TabStop = false;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = global::LocadoraGames.Properties.Resources.UserIconBranco1;
            this.pictureBoxUser.Location = new System.Drawing.Point(478, 150);
            this.pictureBoxUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(23, 28);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 3;
            this.pictureBoxUser.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(737, 350);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.textBoxPswd);
            this.Controls.Add(this.pictureBoxPswd);
            this.Controls.Add(this.panelPswd);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.panelUser);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPswd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBoxPswd;
        private System.Windows.Forms.PictureBox pictureBoxPswd;
        private System.Windows.Forms.Panel panelPswd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

