using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerDefenseGame
{
	public class BuildManager
	{
		#region Singleton
		private static BuildManager instance;
		public static BuildManager Instance
		{
			get
			{
				if (instance == null)
					instance = new BuildManager();
				return instance;
			}
		}
		#endregion

		public string turretToBuild = "none";
		

		public void BuildTurretOn(Node node)
		{
			Turret turret = new Turret();
			FieldManager.panelField.Controls.Add(turret.picTurret);
			turret.picTurret.BringToFront();
			turret.picTurret.Location = node.picNode.Location;
			node.currentTurret = turret;

			PlayerStats.money -= turret.cost;
		}
	}
}