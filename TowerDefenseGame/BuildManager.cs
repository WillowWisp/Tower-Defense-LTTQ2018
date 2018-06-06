using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Media;

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
		public string turretToBuildDirection;


		public void BuildTurretOn(Node node)
		{
			Turret turret = new Turret(turretToBuild, turretToBuildDirection);
			FieldManager.panelField.Controls.Add(turret.picTurret);
			turret.picTurret.BringToFront();
			turret.picTurret.Location = node.picNode.Location;
			turret.rangeRectangle = new Rectangle((turret.picTurret.Location.X + 24) - 150, (turret.picTurret.Location.Y + 24) - 150, 300, 300);//Set tầm bắn cho turret = hình vuông cạnh 300
			node.currentTurret = turret;

			SoundPlayer buildSound = new SoundPlayer(Properties.Resources.build_sound);
			buildSound.Play();

			PlayerStats.money -= turret.cost;
		}
	}
}