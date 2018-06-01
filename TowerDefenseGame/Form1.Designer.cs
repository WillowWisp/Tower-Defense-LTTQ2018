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
			this.lblWaveLevel = new System.Windows.Forms.Label();
			this.btnSpawnWave = new System.Windows.Forms.Button();
			this.lblMoney = new System.Windows.Forms.Label();
			this.tmrUpdateUI = new System.Windows.Forms.Timer(this.components);
			this.label31 = new System.Windows.Forms.Label();
			this.lblLives = new System.Windows.Forms.Label();
			this.btnChamander = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panelField = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// lblWaveLevel
			// 
			this.lblWaveLevel.AutoSize = true;
			this.lblWaveLevel.Font = new System.Drawing.Font("ArcadeClassic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWaveLevel.Location = new System.Drawing.Point(-1, 729);
			this.lblWaveLevel.Name = "lblWaveLevel";
			this.lblWaveLevel.Size = new System.Drawing.Size(152, 23);
			this.lblWaveLevel.TabIndex = 6;
			this.lblWaveLevel.Text = "Wave  Level  X";
			// 
			// btnSpawnWave
			// 
			this.btnSpawnWave.BackColor = System.Drawing.SystemColors.Control;
			this.btnSpawnWave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSpawnWave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSpawnWave.Font = new System.Drawing.Font("ArcadeClassic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSpawnWave.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnSpawnWave.Location = new System.Drawing.Point(282, 726);
			this.btnSpawnWave.Name = "btnSpawnWave";
			this.btnSpawnWave.Size = new System.Drawing.Size(197, 31);
			this.btnSpawnWave.TabIndex = 7;
			this.btnSpawnWave.Text = "Next Wave";
			this.btnSpawnWave.UseVisualStyleBackColor = false;
			this.btnSpawnWave.Click += new System.EventHandler(this.btnSpawnWave_Click);
			// 
			// lblMoney
			// 
			this.lblMoney.AutoSize = true;
			this.lblMoney.Font = new System.Drawing.Font("ArcadeClassic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMoney.Location = new System.Drawing.Point(590, 729);
			this.lblMoney.Name = "lblMoney";
			this.lblMoney.Size = new System.Drawing.Size(133, 23);
			this.lblMoney.TabIndex = 9;
			this.lblMoney.Text = "Money   $100";
			// 
			// tmrUpdateUI
			// 
			this.tmrUpdateUI.Enabled = true;
			this.tmrUpdateUI.Interval = 10;
			this.tmrUpdateUI.Tick += new System.EventHandler(this.tmrUpdateUI_Tick);
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Location = new System.Drawing.Point(729, 130);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(41, 13);
			this.label31.TabIndex = 12;
			this.label31.Text = "label31";
			// 
			// lblLives
			// 
			this.lblLives.AutoSize = true;
			this.lblLives.BackColor = System.Drawing.Color.Transparent;
			this.lblLives.Location = new System.Drawing.Point(729, 440);
			this.lblLives.Name = "lblLives";
			this.lblLives.Size = new System.Drawing.Size(53, 13);
			this.lblLives.TabIndex = 14;
			this.lblLives.Text = "Lives : 10";
			// 
			// btnChamander
			// 
			this.btnChamander.BackgroundImage = global::TowerDefenseGame.Properties.Resources.chamander;
			this.btnChamander.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnChamander.Location = new System.Drawing.Point(729, 3);
			this.btnChamander.Name = "btnChamander";
			this.btnChamander.Size = new System.Drawing.Size(64, 64);
			this.btnChamander.TabIndex = 13;
			this.btnChamander.Tag = "50";
			this.btnChamander.Text = "Trái";
			this.btnChamander.UseVisualStyleBackColor = true;
			this.btnChamander.Click += new System.EventHandler(this.btnChamander_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.BackgroundImage = global::TowerDefenseGame.Properties.Resources.arcade_stick_by_gfball84887_d9i3x9t;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox2.Location = new System.Drawing.Point(729, 512);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(218, 211);
			this.pictureBox2.TabIndex = 10;
			this.pictureBox2.TabStop = false;
			// 
			// panelField
			// 
			this.panelField.BackColor = System.Drawing.SystemColors.Control;
			this.panelField.BackgroundImage = global::TowerDefenseGame.Properties.Resources.panelField_background;
			this.panelField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panelField.Location = new System.Drawing.Point(3, 3);
			this.panelField.Name = "panelField";
			this.panelField.Size = new System.Drawing.Size(720, 720);
			this.panelField.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(950, 760);
			this.Controls.Add(this.lblLives);
			this.Controls.Add(this.btnChamander);
			this.Controls.Add(this.label31);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.lblMoney);
			this.Controls.Add(this.btnSpawnWave);
			this.Controls.Add(this.lblWaveLevel);
			this.Controls.Add(this.panelField);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tower Defense Game";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelField;
		private System.Windows.Forms.Label lblWaveLevel;
		private System.Windows.Forms.Button btnSpawnWave;
		private System.Windows.Forms.Label lblMoney;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Timer tmrUpdateUI;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Button btnChamander;
		private System.Windows.Forms.Label lblLives;
	}
}

