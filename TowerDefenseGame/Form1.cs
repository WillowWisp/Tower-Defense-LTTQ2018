using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

			lblWaveLevel.Text = "Wave   Level   " + WaveSpawner.level.ToString();
		}

		private void btnSpawnWave_Click(object sender, EventArgs e)
		{
			lblWaveLevel.Text = "Wave   Level   " + WaveSpawner.level.ToString();
			WaveSpawner.Instance.SpawnWave();
		}

		private void tmrUpdateUI_Tick(object sender, EventArgs e)
		{
			label31.Text = BuildManager.Instance.turretToBuildDirection;

			if (PlayerStats.money < int.Parse(btnChamander.Tag.ToString()))
				btnChamander.Enabled = false;
			else btnChamander.Enabled = true;

			lblMoney.Text = "Money   $" + PlayerStats.money;

			lblLives.Text = "Lives : " + PlayerStats.lives.ToString();
		}
		
		private void btnChamander_Click(object sender, EventArgs e)
		{
			BuildManager.Instance.turretToBuild = "Chamander";
			BuildManager.Instance.turretToBuildDirection = "Left";
			Cursor = Cursors.PanWest;
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.R)
			{
				if (BuildManager.Instance.turretToBuild == "none")
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
	}
}