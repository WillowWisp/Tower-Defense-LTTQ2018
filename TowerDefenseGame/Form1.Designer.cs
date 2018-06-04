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
			this.label2 = new System.Windows.Forms.Label();
			this.lblEvolutionTitle = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.picChamanderShop = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.picKoffingShop = new System.Windows.Forms.PictureBox();
			this.tmrEvolutionRainbow = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picChamanderShop)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picKoffingShop)).BeginInit();
			this.SuspendLayout();
			// 
			// lblWaveLevel
			// 
			this.lblWaveLevel.AutoSize = true;
			this.lblWaveLevel.BackColor = System.Drawing.Color.Transparent;
			this.lblWaveLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWaveLevel.Location = new System.Drawing.Point(7, 652);
			this.lblWaveLevel.Name = "lblWaveLevel";
			this.lblWaveLevel.Size = new System.Drawing.Size(172, 29);
			this.lblWaveLevel.TabIndex = 6;
			this.lblWaveLevel.Text = "Wave  Level  X";
			// 
			// btnSpawnWave
			// 
			this.btnSpawnWave.BackColor = System.Drawing.SystemColors.Control;
			this.btnSpawnWave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSpawnWave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSpawnWave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSpawnWave.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnSpawnWave.Location = new System.Drawing.Point(12, 575);
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
			this.lblMoney.BackColor = System.Drawing.Color.Transparent;
			this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMoney.Location = new System.Drawing.Point(146, 423);
			this.lblMoney.Name = "lblMoney";
			this.lblMoney.Size = new System.Drawing.Size(155, 29);
			this.lblMoney.TabIndex = 9;
			this.lblMoney.Text = "Money   $100";
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
			this.lblLives.Location = new System.Drawing.Point(248, 721);
			this.lblLives.Name = "lblLives";
			this.lblLives.Size = new System.Drawing.Size(53, 13);
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
			this.panel1.Controls.Add(this.label2);
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
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(117, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(167, 56);
			this.label2.TabIndex = 2;
			this.label2.Text = "Upgrade your pokemon to a whole new level. Cost and strength depend on pokemon ev" +
    "olved";
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
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.picChamanderShop);
			this.panel2.Controls.Add(this.btnChamander);
			this.panel2.Location = new System.Drawing.Point(12, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(289, 122);
			this.panel2.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(117, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(167, 56);
			this.label3.TabIndex = 2;
			this.label3.Text = "- Shoot in a line\r\n- Attack speed : 0.8/s\r\n- Damage : 20\r\n- Cost : $50";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(112, 4);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(123, 25);
			this.label4.TabIndex = 1;
			this.label4.Text = "Chamander";
			// 
			// picChamanderShop
			// 
			this.picChamanderShop.BackColor = System.Drawing.Color.Transparent;
			this.picChamanderShop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picChamanderShop.BackgroundImage")));
			this.picChamanderShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.picChamanderShop.Location = new System.Drawing.Point(3, 3);
			this.picChamanderShop.Name = "picChamanderShop";
			this.picChamanderShop.Size = new System.Drawing.Size(102, 98);
			this.picChamanderShop.TabIndex = 0;
			this.picChamanderShop.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Transparent;
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.picKoffingShop);
			this.panel3.Controls.Add(this.btnKoffing);
			this.panel3.Location = new System.Drawing.Point(12, 140);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(289, 122);
			this.panel3.TabIndex = 15;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(117, 33);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(167, 56);
			this.label5.TabIndex = 2;
			this.label5.Text = "- Seek target around\r\n- Attack speed : 0.4/s\r\n- Damage : 5\r\n- Cost : $150";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Purple;
			this.label6.Location = new System.Drawing.Point(112, 4);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(79, 25);
			this.label6.TabIndex = 1;
			this.label6.Text = "Koffing";
			// 
			// picKoffingShop
			// 
			this.picKoffingShop.BackColor = System.Drawing.Color.Transparent;
			this.picKoffingShop.BackgroundImage = global::TowerDefenseGame.Properties.Resources.KoffingButton;
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = global::TowerDefenseGame.Properties.Resources.lMMX2resized;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1227, 743);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
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
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picChamanderShop)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picKoffingShop)).EndInit();
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
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnEvolution;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox picChamanderShop;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox picKoffingShop;
		private System.Windows.Forms.Timer tmrEvolutionRainbow;
	}
}

