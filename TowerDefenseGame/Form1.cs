using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerDefenseGame
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			KeyPreview = true;//Thuộc tính này phải được kích hoạt nếu muốn Form1 nhận KeyDown

			FieldManager.panelField = panelField;
			FieldManager.Instance.DrawNodes();
            FieldManager.Instance.DesignPath();
			
			lblWaveLevel.Text = "Wave Level : " + WaveSpawner.level.ToString();
		}

		private void btnSpawnWave_Click(object sender, EventArgs e)
		{
			lblWaveLevel.Text = "Wave Level : " + WaveSpawner.level.ToString();
			WaveSpawner.Instance.SpawnWave();
		}

		private void tmrUpdateUI_Tick(object sender, EventArgs e)
		{

			if (PlayerStats.money < Constant.CHARMANDER_COST)
			{
				pnlCharmander.BackColor = Color.LightGray;
				btnChamander.Enabled = false;
			}
			else
			{
				pnlCharmander.BackColor = Color.Transparent;
				btnChamander.Enabled = true;
			}

			if (PlayerStats.money < Constant.KOFFING_COST)
			{
				pnlKoffing.BackColor = Color.LightGray;
				btnKoffing.Enabled = false;
			}
			else
			{
				pnlKoffing.BackColor = Color.Transparent;
				btnKoffing.Enabled = true;
			}

			lblMoney.Text = "Money : $" + PlayerStats.money;

			lblLives.Text = "Lives : " + PlayerStats.lives.ToString();


			if (BuildManager.Instance.turretToBuild == "none")
			{
				lblMessage.Text = "Select an item...";
				picSelecting.BackgroundImage = null;
			}
			if (BuildManager.Instance.turretToBuild == "Charmander")
			{
				lblMessage.Text = "Press R to Rotate.\nClick on an empty node to build.\nCost : $" + Constant.CHARMANDER_COST;
				picSelecting.BackgroundImage = Properties.Resources.Charmander_Icon;
			}
			if (BuildManager.Instance.turretToBuild == "Koffing")
			{
				lblMessage.Text = "Click on an empty node to build.\nCost : $" + Constant.KOFFING_COST;
				picSelecting.BackgroundImage = Properties.Resources.Koffing_Icon;
			}
			if (BuildManager.Instance.turretToBuild == "Evolution")
			{
				lblMessage.Text = Turret.messageText;
				picSelecting.BackgroundImage = Properties.Resources.Megaevo;
			}
		}
		
		private void btnChamander_Click(object sender, EventArgs e)
		{
			BuildManager.Instance.turretToBuild = "Charmander";
			BuildManager.Instance.turretToBuildDirection = "Left";
			Cursor = Cursors.PanWest;
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.R)
			{
				if (BuildManager.Instance.turretToBuild != "Charmander")
					return;
				if (BuildManager.Instance.turretToBuildDirection == "Left")
				{
					BuildManager.Instance.turretToBuildDirection = "Up";
					Cursor = Cursors.PanNorth;
				}
				else if (BuildManager.Instance.turretToBuildDirection == "Up")
				{
					BuildManager.Instance.turretToBuildDirection = "Right";
					Cursor = Cursors.PanEast;
				}
				else if (BuildManager.Instance.turretToBuildDirection == "Right")
				{
					BuildManager.Instance.turretToBuildDirection = "Down";
					Cursor = Cursors.PanSouth;
				}
				else if (BuildManager.Instance.turretToBuildDirection == "Down")
				{
					BuildManager.Instance.turretToBuildDirection = "Left";
					Cursor = Cursors.PanWest;
				}
			}
		}

		private void btnKoffing_Click(object sender, EventArgs e)
		{
			BuildManager.Instance.turretToBuild = "Koffing";
			Cursor = Cursors.Hand;
		}

		private void btnEvolution_Click(object sender, EventArgs e)
		{
			BuildManager.Instance.turretToBuild = "Evolution";
			Cursor = Cursors.Default;
			Turret.messageText = "Hover to a pokemon to see information...";
		}


		#region Convert from HSL to RGB
		//Nguồn : GeekyMonkey.com
		//Vì ko rành về màu sắc (RGB, HSL) lắm nên xin được lấy code converter có sẵn
		public struct ColorRGB
		{
			public byte R;
			public byte G;
			public byte B;
			public ColorRGB(Color value)
			{
				this.R = value.R;
				this.G = value.G;
				this.B = value.B;
			}

			public static implicit operator Color(ColorRGB rgb)
			{
				Color c = Color.FromArgb(rgb.R, rgb.G, rgb.B);
				return c;
			}
			public static explicit operator ColorRGB(Color c)
			{
				return new ColorRGB(c);
			}
		}
		public static ColorRGB HSL2RGB(double h, double sl, double l)
		// Given H,S,L in range of 0-1
		// Returns a Color (RGB struct) in range of 0-255
		{
			double v;
			double r, g, b;
			r = l;   // default to gray
			g = l;
			b = l;
			v = (l <= 0.5) ? (l * (1.0 + sl)) : (l + sl - l * sl);
			if (v > 0)
			{
				double m;
				double sv;
				int sextant;
				double fract, vsf, mid1, mid2;
				m = l + l - v;
				sv = (v - m) / v;
				h *= 6.0;
				sextant = (int)h;
				fract = h - sextant;
				vsf = v * sv * fract;
				mid1 = m + vsf;
				mid2 = v - vsf;
				switch (sextant)
				{
					case 0:
						r = v;
						g = mid1;
						b = m;
						break;
					case 1:
						r = mid2;
						g = v;
						b = m;
						break;
					case 2:
						r = m;
						g = v;
						b = mid1;
						break;
					case 3:
						r = m;
						g = mid2;
						b = v;
						break;
					case 4:
						r = mid1;
						g = m;
						b = v;
						break;
					case 5:
						r = v;
						g = m;
						b = mid2;
						break;
				}
			}
			ColorRGB rgb;
			rgb.R = Convert.ToByte(r * 255.0f);
			rgb.G = Convert.ToByte(g * 255.0f);
			rgb.B = Convert.ToByte(b * 255.0f);
			return rgb;
		}
		#endregion

		double rainbowIndex = 0;
		private void tmrEvolutionRainbow_Tick(object sender, EventArgs e)
			//Màu chữ cầu vồng cho Evolution
		{
			if (rainbowIndex >= 1)
			{
				rainbowIndex = 0;
				return;
			}
			ColorRGB c = HSL2RGB(rainbowIndex, 0.5, 0.5);
			lblEvolutionTitle.ForeColor = c;
			rainbowIndex += 0.1;
		}

	}
}