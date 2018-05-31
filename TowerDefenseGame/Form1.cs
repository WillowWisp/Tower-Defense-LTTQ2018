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
			label31.Text = ObjectManager.Instance.enemyList.Count.ToString();

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
		}

		private void button1_Click(object sender, EventArgs e)
		{
			BuildManager.Instance.turretToBuild = "Chamander";
			BuildManager.Instance.turretToBuildDirection = "Right";
		}
	}
}