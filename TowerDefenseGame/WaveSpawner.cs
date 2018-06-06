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
		private static WaveSpawner instance;

		public static WaveSpawner Instance
		{
			get
			{
				if (instance == null)
					instance = new WaveSpawner();
				return instance;
			}
		}
		#endregion

		public static int level = 0;
		public static int enemyLeft;
		bool isBossWave = false;

		Timer tmrSpawnEnemy;

		public void SpawnWave()
		{
			level++;

			if (level >= 5)
			{
				isBossWave = true;
				enemyLeft = 1;
			}
			else
			{
				enemyLeft = level * 3;
				Constant.PIKACHU_HP += (level * 40);
			}
			tmrSpawnEnemy = new Timer();
			tmrSpawnEnemy.Interval = 500;
			tmrSpawnEnemy.Start();
			tmrSpawnEnemy.Tick += SpawnEnemy_Tick;
		}

		void SpawnEnemy_Tick(object sender, EventArgs e)
		{
			if (enemyLeft <= 0)
			{
				tmrSpawnEnemy.Stop();
				return;
			}
			Enemy enemy = new Enemy(isBossWave);
			enemy.SpawnEnemy(FieldManager.Instance.pathList[0]);
			ObjectManager.Instance.enemyList.Add(enemy);
			enemy.MoveThroughWaypoints(FieldManager.Instance.waypointList);
			enemyLeft--;
		}
	}
}