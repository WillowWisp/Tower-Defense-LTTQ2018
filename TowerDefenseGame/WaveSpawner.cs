using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerDefenseGame
{
	public class WaveSpawner
	{
		#region Singleton
		//private static WaveSpawner instance;
		//public static WaveSpawner Instance
		//{
		//	get
		//	{
		//		return instance;
		//	}
		//}
		#endregion
		
		public static int level = 1;
		public static int enemyLeft;
		Panel panelField;

		Timer tmrSpawnEnemy;

		public WaveSpawner(Panel _panelField)
		{
			panelField = _panelField;
		}

		public void SpawnWave()
		{
			enemyLeft = level * 2;
			tmrSpawnEnemy = new Timer();
			tmrSpawnEnemy.Interval = 1000;
			tmrSpawnEnemy.Start();
			tmrSpawnEnemy.Tick += SpawnEnemy_Tick;

			level++;
		}

		void SpawnEnemy_Tick(object sender, EventArgs e)
		{
			if (enemyLeft <= 0)
			{
				tmrSpawnEnemy.Stop();
				return;
			}
			Enemy enemy = new Enemy();
			enemy.SpawnEnemy(panelField, FieldManager.Instance.pathList[0]);
			enemy.MoveThroughWaypoints(FieldManager.Instance.waypointList);
			enemyLeft--;
		}
	}
}
