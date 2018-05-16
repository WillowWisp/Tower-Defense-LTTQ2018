using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerDefenseGame
{
	public class ObjectManager
	{
		#region Singleton
		private static ObjectManager instance;
		public static ObjectManager Instance
		{
			get
			{
				if (instance == null)
					instance = new ObjectManager();
				return instance;
			}
		}
		#endregion

		public ObjectManager()
		{
			enemyList = new List<Enemy>();
		}
		
		public List<Enemy> enemyList;
	}
}