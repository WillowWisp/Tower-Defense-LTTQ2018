namespace TowerDefenseGame
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.lblWaveLevel = new System.Windows.Forms.Label();
			this.btnSpawnWave = new System.Windows.Forms.Button();
			this.lblMoney = new System.Windows.Forms.Label();
			this.tmrUpdateUI = new System.Windows.Forms.Timer(this.components);
			this.lblLives = new System.Windows.Forms.Label();
			this.btnKoffing = new System.Windows.Forms.Button();
			this.btnChamander = new System.Windows.Forms.Button();
			this.panelField = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnEvolution = new System.Windows.Forms.Button();
			this.lblEvolutionDesc = new System.Windows.Forms.Label();
			this.lblEvolutionTitle = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pnlCharmander = new System.Windows.Forms.Panel();
			this.lblCharDesc = new System.Windows.Forms.Label();
			this.lblCharTitle = new System.Windows.Forms.Label();
			this.picChamanderShop = new System.Windows.Forms.PictureBox();
			this.pnlKoffing = new System.Windows.Forms.Panel();
			this.lblKofDesc = new System.Windows.Forms.Label();
			this.lblKoffTitle = new System.Windows.Forms.Label();
			this.picKoffingShop = new System.Windows.Forms.PictureBox();
			this.tmrEvolutionRainbow = new System.Windows.Forms.Timer(this.components);
			this.panel4 = new System.Windows.Forms.Panel();
			this.lblMessage = new System.Windows.Forms.Label();
			this.picSelecting = new System.Windows.Forms.PictureBox();
			this.wmpTheme = new AxWMPLib.AxWindowsMediaPlayer();
			this.wmpHitSound = new AxWMPLib.AxWindowsMediaPlayer();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.pnlCharmander.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picChamanderShop)).BeginInit();
			this.pnlKoffing.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picKoffingShop)).BeginInit();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picSelecting)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.wmpTheme)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.wmpHitSound)).BeginInit();
			this.SuspendLayout();
			// 
			// lblWaveLevel
			// 
			this.lblWaveLevel.AutoSize = true;
			this.lblWaveLevel.BackColor = System.Drawing.Color.Transparent;
			this.lblWaveLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWaveLevel.Location = new System.Drawing.Point(12, 664);
			this.lblWaveLevel.Name = "lblWaveLevel";
			this.lblWaveLevel.Size = new System.Drawing.Size(186, 29);
			this.lblWaveLevel.TabIndex = 6;
			this.lblWaveLevel.Text = "Wave Level : X";
			// 
			// btnSpawnWave
			// 
			this.btnSpawnWave.BackColor = System.Drawing.SystemColors.Control;
			this.btnSpawnWave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSpawnWave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSpawnWave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSpawnWave.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnSpawnWave.Location = new System.Drawing.Point(13, 696);
			this.btnSpawnWave.Name = "btnSpawnWave";
			this.btnSpawnWave.Size = new System.Drawing.Size(197, 35);
			this.btnSpawnWave.TabIndex = 7;
			this.btnSpawnWave.Text = "Next Wave";
			this.btnSpawnWave.UseVisualStyleBackColor = false;
			this.btnSpawnWave.Click += new System.EventHandler(this.btnSpawnWave_Click);
			// 
			// lblMoney
			// 
			this.lblMoney.AutoSize = true;
			this.lblMoney.BackColor = System.Drawing.Color.Transparent;
			this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMoney.Location = new System.Drawing.Point(11, 414);
			this.lblMoney.Name = "lblMoney";
			this.lblMoney.Size = new System.Drawing.Size(167, 29);
			this.lblMoney.TabIndex = 9;
			this.lblMoney.Text = "Money : $100";
			// 
			// tmrUpdateUI
			// 
			this.tmrUpdateUI.Enabled = true;
			this.tmrUpdateUI.Interval = 10;
			this.tmrUpdateUI.Tick += new System.EventHandler(this.tmrUpdateUI_Tick);
			// 
			// lblLives
			// 
			this.lblLives.AutoSize = true;
			this.lblLives.BackColor = System.Drawing.Color.Transparent;
			this.lblLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLives.Location = new System.Drawing.Point(359, 699);
			this.lblLives.Name = "lblLives";
			this.lblLives.Size = new System.Drawing.Size(115, 25);
			this.lblLives.TabIndex = 14;
			this.lblLives.Text = "Lives : 10";
			// 
			// btnKoffing
			// 
			this.btnKoffing.BackColor = System.Drawing.Color.Transparent;
			this.btnKoffing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnKoffing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKoffing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnKoffing.Location = new System.Drawing.Point(209, 94);
			this.btnKoffing.Name = "btnKoffing";
			this.btnKoffing.Size = new System.Drawing.Size(75, 23);
			this.btnKoffing.TabIndex = 13;
			this.btnKoffing.Tag = "150";
			this.btnKoffing.Text = "Select";
			this.btnKoffing.UseVisualStyleBackColor = false;
			this.btnKoffing.Click += new System.EventHandler(this.btnKoffing_Click);
			// 
			// btnChamander
			// 
			this.btnChamander.BackColor = System.Drawing.Color.Transparent;
			this.btnChamander.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnChamander.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChamander.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChamander.Location = new System.Drawing.Point(209, 94);
			this.btnChamander.Name = "btnChamander";
			this.btnChamander.Size = new System.Drawing.Size(75, 23);
			this.btnChamander.TabIndex = 13;
			this.btnChamander.Tag = "50";
			this.btnChamander.Text = "Select";
			this.btnChamander.UseVisualStyleBackColor = false;
			this.btnChamander.Click += new System.EventHandler(this.btnChamander_Click);
			// 
			// panelField
			// 
			this.panelField.BackColor = System.Drawing.SystemColors.Control;
			this.panelField.BackgroundImage = global::TowerDefenseGame.Properties.Resources.panelField_background;
			this.panelField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panelField.Location = new System.Drawing.Point(489, 12);
			this.panelField.Name = "panelField";
			this.panelField.Size = new System.Drawing.Size(720, 720);
			this.panelField.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnEvolution);
			this.panel1.Controls.Add(this.lblEvolutionDesc);
			this.panel1.Controls.Add(this.lblEvolutionTitle);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(12, 289);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(289, 122);
			this.panel1.TabIndex = 15;
			// 
			// btnEvolution
			// 
			this.btnEvolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEvolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEvolution.Location = new System.Drawing.Point(209, 94);
			this.btnEvolution.Name = "btnEvolution";
			this.btnEvolution.Size = new System.Drawing.Size(75, 23);
			this.btnEvolution.TabIndex = 3;
			this.btnEvolution.Text = "Select";
			this.btnEvolution.UseVisualStyleBackColor = true;
			this.btnEvolution.Click += new System.EventHandler(this.btnEvolution_Click);
			// 
			// lblEvolutionDesc
			// 
			this.lblEvolutionDesc.Location = new System.Drawing.Point(117, 33);
			this.lblEvolutionDesc.Name = "lblEvolutionDesc";
			this.lblEvolutionDesc.Size = new System.Drawing.Size(167, 56);
			this.lblEvolutionDesc.TabIndex = 2;
			this.lblEvolutionDesc.Text = "Evolve your pokemon. Gain new strength with a cost of money. Cost and strength de" +
    "pend on pokemon evolved";
			// 
			// lblEvolutionTitle
			// 
			this.lblEvolutionTitle.AutoSize = true;
			this.lblEvolutionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEvolutionTitle.Location = new System.Drawing.Point(112, 4);
			this.lblEvolutionTitle.Name = "lblEvolutionTitle";
			this.lblEvolutionTitle.Size = new System.Drawing.Size(163, 25);
			this.lblEvolutionTitle.TabIndex = 1;
			this.lblEvolutionTitle.Text = "Evolution Stone";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = global::TowerDefenseGame.Properties.Resources.Megaevo;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(102, 98);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pnlCharmander
			// 
			this.pnlCharmander.BackColor = System.Drawing.Color.Transparent;
			this.pnlCharmander.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlCharmander.Controls.Add(this.lblCharDesc);
			this.pnlCharmander.Controls.Add(this.lblCharTitle);
			this.pnlCharmander.Controls.Add(this.picChamanderShop);
			this.pnlCharmander.Controls.Add(this.btnChamander);
			this.pnlCharmander.Location = new System.Drawing.Point(12, 12);
			this.pnlCharmander.Name = "pnlCharmander";
			this.pnlCharmander.Size = new System.Drawing.Size(289, 122);
			this.pnlCharmander.TabIndex = 15;
			// 
			// lblCharDesc
			// 
			this.lblCharDesc.Location = new System.Drawing.Point(117, 33);
			this.lblCharDesc.Name = "lblCharDesc";
			this.lblCharDesc.Size = new System.Drawing.Size(167, 56);
			this.lblCharDesc.TabIndex = 2;
			this.lblCharDesc.Text = "- Shoot in a line\r\n- Attack speed : Normal\r\n- Damage : 20\r\n- Cost : $50";
			// 
			// lblCharTitle
			// 
			this.lblCharTitle.AutoSize = true;
			this.lblCharTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCharTitle.ForeColor = System.Drawing.Color.Red;
			this.lblCharTitle.Location = new System.Drawing.Point(112, 4);
			this.lblCharTitle.Name = "lblCharTitle";
			this.lblCharTitle.Size = new System.Drawing.Size(123, 25);
			this.lblCharTitle.TabIndex = 1;
			this.lblCharTitle.Text = "Chamander";
			// 
			// picChamanderShop
			// 
			this.picChamanderShop.BackColor = System.Drawing.Color.Transparent;
			this.picChamanderShop.BackgroundImage = global::TowerDefenseGame.Properties.Resources.Charmander_Icon;
			this.picChamanderShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.picChamanderShop.Location = new System.Drawing.Point(3, 3);
			this.picChamanderShop.Name = "picChamanderShop";
			this.picChamanderShop.Size = new System.Drawing.Size(102, 98);
			this.picChamanderShop.TabIndex = 0;
			this.picChamanderShop.TabStop = false;
			// 
			// pnlKoffing
			// 
			this.pnlKoffing.BackColor = System.Drawing.Color.Transparent;
			this.pnlKoffing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlKoffing.Controls.Add(this.lblKofDesc);
			this.pnlKoffing.Controls.Add(this.lblKoffTitle);
			this.pnlKoffing.Controls.Add(this.picKoffingShop);
			this.pnlKoffing.Controls.Add(this.btnKoffing);
			this.pnlKoffing.Location = new System.Drawing.Point(12, 140);
			this.pnlKoffing.Name = "pnlKoffing";
			this.pnlKoffing.Size = new System.Drawing.Size(289, 122);
			this.pnlKoffing.TabIndex = 15;
			// 
			// lblKofDesc
			// 
			this.lblKofDesc.Location = new System.Drawing.Point(117, 33);
			this.lblKofDesc.Name = "lblKofDesc";
			this.lblKofDesc.Size = new System.Drawing.Size(167, 56);
			this.lblKofDesc.TabIndex = 2;
			this.lblKofDesc.Text = "- Seek target around\r\n- Attack speed : Fast\r\n- Damage : 5\r\n- Cost : $75";
			// 
			// lblKoffTitle
			// 
			this.lblKoffTitle.AutoSize = true;
			this.lblKoffTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblKoffTitle.ForeColor = System.Drawing.Color.Purple;
			this.lblKoffTitle.Location = new System.Drawing.Point(112, 4);
			this.lblKoffTitle.Name = "lblKoffTitle";
			this.lblKoffTitle.Size = new System.Drawing.Size(79, 25);
			this.lblKoffTitle.TabIndex = 1;
			this.lblKoffTitle.Text = "Koffing";
			// 
			// picKoffingShop
			// 
			this.picKoffingShop.BackColor = System.Drawing.Color.Transparent;
			this.picKoffingShop.BackgroundImage = global::TowerDefenseGame.Properties.Resources.Koffing_Icon;
			this.picKoffingShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.picKoffingShop.Location = new System.Drawing.Point(3, 3);
			this.picKoffingShop.Name = "picKoffingShop";
			this.picKoffingShop.Size = new System.Drawing.Size(102, 98);
			this.picKoffingShop.TabIndex = 0;
			this.picKoffingShop.TabStop = false;
			// 
			// tmrEvolutionRainbow
			// 
			this.tmrEvolutionRainbow.Enabled = true;
			this.tmrEvolutionRainbow.Interval = 50;
			this.tmrEvolutionRainbow.Tick += new System.EventHandler(this.tmrEvolutionRainbow_Tick);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Transparent;
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.lblMessage);
			this.panel4.Location = new System.Drawing.Point(12, 502);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(202, 125);
			this.panel4.TabIndex = 16;
			// 
			// lblMessage
			// 
			this.lblMessage.BackColor = System.Drawing.Color.Transparent;
			this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMessage.ForeColor = System.Drawing.Color.Black;
			this.lblMessage.Location = new System.Drawing.Point(3, 9);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(194, 105);
			this.lblMessage.TabIndex = 1;
			this.lblMessage.Text = "Select an item...";
			// 
			// picSelecting
			// 
			this.picSelecting.BackColor = System.Drawing.Color.Transparent;
			this.picSelecting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.picSelecting.Location = new System.Drawing.Point(269, 502);
			this.picSelecting.Name = "picSelecting";
			this.picSelecting.Size = new System.Drawing.Size(128, 128);
			this.picSelecting.TabIndex = 0;
			this.picSelecting.TabStop = false;
			// 
			// wmpTheme
			// 
			this.wmpTheme.Enabled = true;
			this.wmpTheme.Location = new System.Drawing.Point(226, 701);
			this.wmpTheme.Name = "wmpTheme";
			this.wmpTheme.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpTheme.OcxState")));
			this.wmpTheme.Size = new System.Drawing.Size(75, 23);
			this.wmpTheme.TabIndex = 17;
			this.wmpTheme.Visible = false;
			// 
			// wmpHitSound
			// 
			this.wmpHitSound.Enabled = true;
			this.wmpHitSound.Location = new System.Drawing.Point(364, 12);
			this.wmpHitSound.Name = "wmpHitSound";
			this.wmpHitSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpHitSound.OcxState")));
			this.wmpHitSound.Size = new System.Drawing.Size(75, 23);
			this.wmpHitSound.TabIndex = 17;
			this.wmpHitSound.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = global::TowerDefenseGame.Properties.Resources.lMMX2resized;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1227, 743);
			this.Controls.Add(this.wmpHitSound);
			this.Controls.Add(this.wmpTheme);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.pnlKoffing);
			this.Controls.Add(this.pnlCharmander);
			this.Controls.Add(this.picSelecting);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblLives);
			this.Controls.Add(this.lblMoney);
			this.Controls.Add(this.btnSpawnWave);
			this.Controls.Add(this.lblWaveLevel);
			this.Controls.Add(this.panelField);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tower Defense Game";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.pnlCharmander.ResumeLayout(false);
			this.pnlCharmander.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picChamanderShop)).EndInit();
			this.pnlKoffing.ResumeLayout(false);
			this.pnlKoffing.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picKoffingShop)).EndInit();
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picSelecting)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.wmpTheme)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.wmpHitSound)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelField;
		private System.Windows.Forms.Label lblWaveLevel;
		private System.Windows.Forms.Button btnSpawnWave;
		private System.Windows.Forms.Label lblMoney;
		private System.Windows.Forms.Timer tmrUpdateUI;
		private System.Windows.Forms.Button btnChamander;
		private System.Windows.Forms.Label lblLives;
		private System.Windows.Forms.Button btnKoffing;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblEvolutionTitle;
		private System.Windows.Forms.Label lblEvolutionDesc;
		private System.Windows.Forms.Button btnEvolution;
		private System.Windows.Forms.Panel pnlCharmander;
		private System.Windows.Forms.Label lblCharDesc;
		private System.Windows.Forms.Label lblCharTitle;
		private System.Windows.Forms.PictureBox picChamanderShop;
		private System.Windows.Forms.Panel pnlKoffing;
		private System.Windows.Forms.Label lblKofDesc;
		private System.Windows.Forms.Label lblKoffTitle;
		private System.Windows.Forms.PictureBox picKoffingShop;
		private System.Windows.Forms.Timer tmrEvolutionRainbow;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.PictureBox picSelecting;
		private AxWMPLib.AxWindowsMediaPlayer wmpTheme;
		private AxWMPLib.AxWindowsMediaPlayer wmpHitSound;
	}
}

