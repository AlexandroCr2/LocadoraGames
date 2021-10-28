
namespace LocadoraGames
{
    partial class Form2
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
            this.panelButton = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTopo = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonCadastroGames = new System.Windows.Forms.Button();
            this.buttonListaGames = new System.Windows.Forms.Button();
            this.buttonCadastroPlayer = new System.Windows.Forms.Button();
            this.buttonPlayers = new System.Windows.Forms.Button();
            this.buttonAluguel = new System.Windows.Forms.Button();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(86)))));
            this.panelButton.Controls.Add(this.buttonLogout);
            this.panelButton.Controls.Add(this.buttonCadastroGames);
            this.panelButton.Controls.Add(this.buttonListaGames);
            this.panelButton.Controls.Add(this.buttonCadastroPlayer);
            this.panelButton.Controls.Add(this.buttonPlayers);
            this.panelButton.Controls.Add(this.buttonAluguel);
            this.panelButton.Controls.Add(this.panelLogo);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButton.Location = new System.Drawing.Point(0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(220, 582);
            this.panelButton.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 1;
            // 
            // panelTopo
            // 
            this.panelTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopo.Location = new System.Drawing.Point(220, 0);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(751, 80);
            this.panelTopo.TabIndex = 0;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLogout.Image = global::LocadoraGames.Properties.Resources.PowerWhite_30x30;
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(0, 380);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonLogout.Size = new System.Drawing.Size(220, 60);
            this.buttonLogout.TabIndex = 7;
            this.buttonLogout.Text = "      Logout";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.button6_Click);
            this.buttonLogout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonLogout_MouseMove);
            // 
            // buttonCadastroGames
            // 
            this.buttonCadastroGames.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCadastroGames.FlatAppearance.BorderSize = 0;
            this.buttonCadastroGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastroGames.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastroGames.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCadastroGames.Image = global::LocadoraGames.Properties.Resources.FolderNewGameWhite_35x351;
            this.buttonCadastroGames.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCadastroGames.Location = new System.Drawing.Point(0, 320);
            this.buttonCadastroGames.Name = "buttonCadastroGames";
            this.buttonCadastroGames.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonCadastroGames.Size = new System.Drawing.Size(220, 60);
            this.buttonCadastroGames.TabIndex = 5;
            this.buttonCadastroGames.Text = "    Cadastro de Games";
            this.buttonCadastroGames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCadastroGames.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCadastroGames.UseVisualStyleBackColor = true;
            this.buttonCadastroGames.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonCadastroGames_MouseMove);
            // 
            // buttonListaGames
            // 
            this.buttonListaGames.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonListaGames.FlatAppearance.BorderSize = 0;
            this.buttonListaGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListaGames.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListaGames.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonListaGames.Image = global::LocadoraGames.Properties.Resources.FolderGamesWhite_35x35;
            this.buttonListaGames.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonListaGames.Location = new System.Drawing.Point(0, 260);
            this.buttonListaGames.Name = "buttonListaGames";
            this.buttonListaGames.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonListaGames.Size = new System.Drawing.Size(220, 60);
            this.buttonListaGames.TabIndex = 4;
            this.buttonListaGames.Text = "    Lista de Games";
            this.buttonListaGames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonListaGames.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonListaGames.UseVisualStyleBackColor = true;
            this.buttonListaGames.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonListaGames_MouseMove);
            // 
            // buttonCadastroPlayer
            // 
            this.buttonCadastroPlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCadastroPlayer.FlatAppearance.BorderSize = 0;
            this.buttonCadastroPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastroPlayer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastroPlayer.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCadastroPlayer.Image = global::LocadoraGames.Properties.Resources.NewUserWhite_32x32;
            this.buttonCadastroPlayer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCadastroPlayer.Location = new System.Drawing.Point(0, 200);
            this.buttonCadastroPlayer.Name = "buttonCadastroPlayer";
            this.buttonCadastroPlayer.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonCadastroPlayer.Size = new System.Drawing.Size(220, 60);
            this.buttonCadastroPlayer.TabIndex = 3;
            this.buttonCadastroPlayer.Text = "     Cadastro de Player";
            this.buttonCadastroPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCadastroPlayer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCadastroPlayer.UseVisualStyleBackColor = true;
            this.buttonCadastroPlayer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonCadastroPlayer_MouseMove);
            // 
            // buttonPlayers
            // 
            this.buttonPlayers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPlayers.FlatAppearance.BorderSize = 0;
            this.buttonPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayers.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayers.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPlayers.Image = global::LocadoraGames.Properties.Resources.PlayerControllerWhite_35x35;
            this.buttonPlayers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPlayers.Location = new System.Drawing.Point(0, 140);
            this.buttonPlayers.Name = "buttonPlayers";
            this.buttonPlayers.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonPlayers.Size = new System.Drawing.Size(220, 60);
            this.buttonPlayers.TabIndex = 2;
            this.buttonPlayers.Text = "    Players";
            this.buttonPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPlayers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPlayers.UseVisualStyleBackColor = true;
            this.buttonPlayers.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonPlayers_MouseMove);
            // 
            // buttonAluguel
            // 
            this.buttonAluguel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAluguel.FlatAppearance.BorderSize = 0;
            this.buttonAluguel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAluguel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAluguel.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAluguel.Image = global::LocadoraGames.Properties.Resources.HandControllerWhite_40x40;
            this.buttonAluguel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAluguel.Location = new System.Drawing.Point(0, 80);
            this.buttonAluguel.Name = "buttonAluguel";
            this.buttonAluguel.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonAluguel.Size = new System.Drawing.Size(220, 60);
            this.buttonAluguel.TabIndex = 1;
            this.buttonAluguel.Text = "  Aluguel";
            this.buttonAluguel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAluguel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAluguel.UseVisualStyleBackColor = true;
            this.buttonAluguel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonAluguel_MouseMove);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(971, 582);
            this.Controls.Add(this.panelTopo);
            this.Controls.Add(this.panelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button buttonAluguel;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonCadastroPlayer;
        private System.Windows.Forms.Button buttonPlayers;
        private System.Windows.Forms.Button buttonListaGames;
        private System.Windows.Forms.Panel panelTopo;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonCadastroGames;
    }
}