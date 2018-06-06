namespace TowerDefenseGame.Resources
{
	partial class Start
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
			this.lbOption = new System.Windows.Forms.Label();
			this.picPokemonLogo = new System.Windows.Forms.PictureBox();
			this.pcbDown = new System.Windows.Forms.PictureBox();
			this.pcbUp = new System.Windows.Forms.PictureBox();
			this.pcbStart = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picPokemonLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbUp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbStart)).BeginInit();
			this.SuspendLayout();
			// 
			// lbOption
			// 
			this.lbOption.AutoEllipsis = true;
			this.lbOption.BackColor = System.Drawing.Color.Transparent;
			this.lbOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbOption.Location = new System.Drawing.Point(298, 427);
			this.lbOption.Name = "lbOption";
			this.lbOption.Size = new System.Drawing.Size(200, 70);
			this.lbOption.TabIndex = 7;
			this.lbOption.Text = "Play";
			this.lbOption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbOption.Click += new System.EventHandler(this.lbOption_Click_1);
			// 
			// picPokemonLogo
			// 
			this.picPokemonLogo.BackColor = System.Drawing.Color.Transparent;
			this.picPokemonLogo.BackgroundImage = global::TowerDefenseGame.Properties.Resources.Pokemon_Logo;
			this.picPokemonLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.picPokemonLogo.Location = new System.Drawing.Point(132, 12);
			this.picPokemonLogo.Name = "picPokemonLogo";
			this.picPokemonLogo.Size = new System.Drawing.Size(530, 183);
			this.picPokemonLogo.TabIndex = 9;
			this.picPokemonLogo.TabStop = false;
			// 
			// pcbDown
			// 
			this.pcbDown.BackColor = System.Drawing.Color.Transparent;
			this.pcbDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pcbDown.Image = global::TowerDefenseGame.Properties.Resources.down;
			this.pcbDown.Location = new System.Drawing.Point(366, 497);
			this.pcbDown.Name = "pcbDown";
			this.pcbDown.Size = new System.Drawing.Size(64, 64);
			this.pcbDown.TabIndex = 6;
			this.pcbDown.TabStop = false;
			this.pcbDown.Click += new System.EventHandler(this.pcbDown_Click_1);
			// 
			// pcbUp
			// 
			this.pcbUp.BackColor = System.Drawing.Color.Transparent;
			this.pcbUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pcbUp.Image = global::TowerDefenseGame.Properties.Resources.up;
			this.pcbUp.Location = new System.Drawing.Point(366, 363);
			this.pcbUp.Name = "pcbUp";
			this.pcbUp.Size = new System.Drawing.Size(64, 64);
			this.pcbUp.TabIndex = 4;
			this.pcbUp.TabStop = false;
			this.pcbUp.Click += new System.EventHandler(this.pcbUp_Click_1);
			// 
			// pcbStart
			// 
			this.pcbStart.BackColor = System.Drawing.Color.Transparent;
			this.pcbStart.Image = global::TowerDefenseGame.Properties.Resources.pokeball;
			this.pcbStart.Location = new System.Drawing.Point(0, -4);
			this.pcbStart.Name = "pcbStart";
			this.pcbStart.Size = new System.Drawing.Size(793, 596);
			this.pcbStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pcbStart.TabIndex = 8;
			this.pcbStart.TabStop = false;
			// 
			// Start
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.picPokemonLogo);
			this.Controls.Add(this.lbOption);
			this.Controls.Add(this.pcbDown);
			this.Controls.Add(this.pcbUp);
			this.Controls.Add(this.pcbStart);
			this.Name = "Start";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Start";
			((System.ComponentModel.ISupportInitialize)(this.picPokemonLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbUp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbStart)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label lbOption;
		private System.Windows.Forms.PictureBox pcbDown;
		private System.Windows.Forms.PictureBox pcbUp;
		private System.Windows.Forms.PictureBox pcbStart;
		private System.Windows.Forms.PictureBox picPokemonLogo;
	}
}