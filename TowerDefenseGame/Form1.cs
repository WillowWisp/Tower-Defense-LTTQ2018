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

		private void button1_Click(object sender, EventArgs e)
		{
			lblWaveLevel.Text = "Wave   Level   " + WaveSpawner.level.ToString();
			WaveSpawner.Instance.SpawnWave();
		}
	}
}