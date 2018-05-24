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
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbOption = new System.Windows.Forms.Label();
			this.pcbDown = new System.Windows.Forms.PictureBox();
			this.pcbUp = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbUp)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lbOption);
			this.panel1.Controls.Add(this.pcbDown);
			this.panel1.Controls.Add(this.pcbUp);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(776, 426);
			this.panel1.TabIndex = 1;
			// 
			// lbOption
			// 
			this.lbOption.AutoEllipsis = true;
			this.lbOption.AutoSize = true;
			this.lbOption.BackColor = System.Drawing.Color.Transparent;
			this.lbOption.Font = new System.Drawing.Font("Action Jackson", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbOption.Location = new System.Drawing.Point(296, 211);
			this.lbOption.Name = "lbOption";
			this.lbOption.Size = new System.Drawing.Size(195, 65);
			this.lbOption.TabIndex = 7;
			this.lbOption.Text = "Play";
			this.lbOption.Click += new System.EventHandler(this.lbOption_Click_1);
			// 
			// pcbDown
			// 
			this.pcbDown.BackColor = System.Drawing.Color.Transparent;
			this.pcbDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pcbDown.Image = global::TowerDefenseGame.Properties.Resources.down;
			this.pcbDown.Location = new System.Drawing.Point(356, 279);
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
			this.pcbUp.Location = new System.Drawing.Point(356, 144);
			this.pcbUp.Name = "pcbUp";
			this.pcbUp.Size = new System.Drawing.Size(64, 64);
			this.pcbUp.TabIndex = 4;
			this.pcbUp.TabStop = false;
			this.pcbUp.Click += new System.EventHandler(this.pcbUp_Click_1);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("KV-CooperBlack", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(137, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(524, 86);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tower Defense";
			// 
			// Start
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Name = "Start";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Start";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbUp)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbOption;
		private System.Windows.Forms.PictureBox pcbDown;
		private System.Windows.Forms.PictureBox pcbUp;
		private System.Windows.Forms.Label label1;
	}
}