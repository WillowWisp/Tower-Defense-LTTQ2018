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
		
		//Chamander
		Timer tmrChamanderShoot;


		//Koffing
		Timer tmrSeekAndShoot;
		Enemy target;
		public Rectangle rangeRectangle = new Rectangle();

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

			//Koffing
			if (turretType == "Koffing")
			{
				cost = 100;
				delayPerShot = 400;

				picTurret.Image = Properties.Resources.KoffingIdle;

				tmrSeekAndShoot = new Timer();
				tmrSeekAndShoot.Interval = delayPerShot;
				tmrSeekAndShoot.Tick += TmrSeekAndShoot_Tick;
				tmrSeekAndShoot.Start();
			}
		}

		

		#region Chamander
		private void TmrChamanderShoot_Tick(object sender, EventArgs e)
		{
			Bullet bullet = new Bullet(turretType, direction);
			bullet.SpawnBulletAt(ChamanderCenterPoint());
		}

		Point ChamanderCenterPoint()
		{
			return new Point(picTurret.Location.X + 21, picTurret.Location.Y + 21);
		}
		#endregion

		#region Koffing
		private void TmrSeekAndShoot_Tick(object sender, EventArgs e)
		{
			if (ObjectManager.Instance.enemyList.Count <= 0)
			//Xử lý 1 số trường hợp lag game khiến Koffing ko idle
			{
				picTurret.Image = Properties.Resources.KoffingIdle;
				return;
			}

			for (int i = 0; i < ObjectManager.Instance.enemyList.Count; i++)
			{
				target = ObjectManager.Instance.enemyList[i];

				if (!target.isAlive)
				{
					ObjectManager.Instance.enemyList.RemoveAt(i);
					i--;
					continue;
				}

				if (rangeRectangle.Contains(target.picEnemy.Bounds))
				{
					if (picTurret.Image != Properties.Resources.KoffingAttack)
						picTurret.Image = Properties.Resources.KoffingAttack;
					Shoot(target);
					break;
				}
				else picTurret.Image = Properties.Resources.KoffingIdle;
			}
		}
		void Shoot(Enemy _target)
		{
			Bullet bullet = new Bullet("Koffing");
			bullet.SeekTarget(target);
			bullet.SpawnBulletAt(ChamanderCenterPoint());
		}
		#endregion
	}
}