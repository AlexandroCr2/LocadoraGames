
namespace LocadoraGames
{
    partial class FormTelaSelecao
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
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonCadastroGames = new System.Windows.Forms.Button();
            this.buttonListaGames = new System.Windows.Forms.Button();
            this.buttonCadastroPlayer = new System.Windows.Forms.Button();
            this.buttonPlayers = new System.Windows.Forms.Button();
            this.buttonAluguel = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTopo = new System.Windows.Forms.Panel();
            this.labelHome = new System.Windows.Forms.Label();
            this.pictureBoxCentral = new System.Windows.Forms.PictureBox();
            this.panelButton.SuspendLayout();
            this.panelTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCentral)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
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
            this.panelButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelButton_MouseMove);
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
            this.buttonLogout.Text = "    Logout";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
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
            this.buttonCadastroGames.Text = "  Cadastro de Games";
            this.buttonCadastroGames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCadastroGames.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCadastroGames.UseVisualStyleBackColor = true;
            this.buttonCadastroGames.Click += new System.EventHandler(this.buttonCadastroGames_Click);
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
            this.buttonListaGames.Text = "  Lista de Games";
            this.buttonListaGames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonListaGames.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonListaGames.UseVisualStyleBackColor = true;
            this.buttonListaGames.Click += new System.EventHandler(this.buttonListaGames_Click);
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
            this.buttonCadastroPlayer.Text = "   Cadastro de Player";
            this.buttonCadastroPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCadastroPlayer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCadastroPlayer.UseVisualStyleBackColor = true;
            this.buttonCadastroPlayer.Click += new System.EventHandler(this.buttonCadastroPlayer_Click);
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
            this.buttonPlayers.Text = "  Players";
            this.buttonPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPlayers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPlayers.UseVisualStyleBackColor = true;
            this.buttonPlayers.Click += new System.EventHandler(this.buttonPlayers_Click);
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
            this.buttonAluguel.Text = " Aluguel";
            this.buttonAluguel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAluguel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAluguel.UseVisualStyleBackColor = true;
            this.buttonAluguel.Click += new System.EventHandler(this.buttonAluguel_Click);
            this.buttonAluguel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonAluguel_MouseMove);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panelLogo.BackgroundImage = global::LocadoraGames.Properties.Resources.BMOGamesIcon_220x801;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 1;
            // 
            // panelTopo
            // 
            this.panelTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.panelTopo.Controls.Add(this.labelHome);
            this.panelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopo.Location = new System.Drawing.Point(220, 0);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(751, 80);
            this.panelTopo.TabIndex = 0;
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelHome.Location = new System.Drawing.Point(356, 33);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(71, 24);
            this.labelHome.TabIndex = 0;
            this.labelHome.Text = "HOME";
            // 
            // pictureBoxCentral
            // 
            this.pictureBoxCentral.BackColor = System.Drawing.Color.Black;
            this.pictureBoxCentral.Image = global::LocadoraGames.Properties.Resources.night_neon_yellow_technology_vintage_8_bit_Nintendo_GameBoy_DMG_01_darkness_graphics_1920x1200_px_computer_wallpaper_780035;
            this.pictureBoxCentral.Location = new System.Drawing.Point(220, 80);
            this.pictureBoxCentral.Name = "pictureBoxCentral";
            this.pictureBoxCentral.Size = new System.Drawing.Size(751, 502);
            this.pictureBoxCentral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCentral.TabIndex = 1;
            this.pictureBoxCentral.TabStop = false;
            this.pictureBoxCentral.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // FormTelaSelecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(971, 582);
            this.Controls.Add(this.pictureBoxCentral);
            this.Controls.Add(this.panelTopo);
            this.Controls.Add(this.panelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTelaSelecao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelButton.ResumeLayout(false);
            this.panelTopo.ResumeLayout(false);
            this.panelTopo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCentral)).EndInit();
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
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.PictureBox pictureBoxCentral;
    }
}