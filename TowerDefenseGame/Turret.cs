using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerDefenseGame
{
	public class Turret
	{
		public PictureBox picTurret;
		string turretType = "none";
		string direction;

		public int cost;
		int delayPerShot;
		

		Timer tmrChamanderShoot;

		public Turret(string _turretType, string _direction = null)
		{
			turretType = _turretType;
			direction = _direction;

			picTurret = new PictureBox()
			{
				Height = Constant.NODE_HEIGHT,
				Width = Constant.NODE_WIDTH
			};

			//Chamander
			if (turretType == "Charmander")
			{
				cost = 50;
				delayPerShot = 800;

				if (direction == "Left")
				{
					picTurret.Image = Properties.Resources.CharmanderLeft;
				}
				if (direction == "Right")
				{
					picTurret.Image = Properties.Resources.CharmanderRight;
				}
				if (direction == "Up")
				{
					picTurret.Image = Properties.Resources.CharmanderUp;
				}
				if (direction == "Down")
				{
					picTurret.Image = Properties.Resources.CharmanderDown;
				}

				tmrChamanderShoot = new Timer();
				tmrChamanderShoot.Interval = delayPerShot;
				tmrChamanderShoot.Start();
				tmrChamanderShoot.Tick += TmrChamanderShoot_Tick;
			}
		}

		private void TmrChamanderShoot_Tick(object sender, EventArgs e)
		{
			Bullet bullet = new Bullet(turretType, direction);
			bullet.SpawnBulletAt(ChamanderCenterPoint());
		}

		Point ChamanderCenterPoint()
		{
			return new Point(picTurret.Location.X + 21, picTurret.Location.Y + 21);
		}
	}
}