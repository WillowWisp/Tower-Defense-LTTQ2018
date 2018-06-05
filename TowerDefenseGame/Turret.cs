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
		int evolveStage = 1;
		string direction;

		public int cost;
		int delayPerShot;
		
		//Chamander
		Timer tmrChamanderShoot;
		
		//Koffing
		Timer tmrSeekAndShoot;
		Enemy target;
		public Rectangle rangeRectangle = new Rectangle();

		//Evolution
		public static string messageText;



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
				cost = Constant.CHARMANDER_COST;
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
				cost = Constant.KOFFING_COST;
				delayPerShot = 800;

				picTurret.Image = KoffingIdleByStage();

				tmrSeekAndShoot = new Timer();
				tmrSeekAndShoot.Interval = delayPerShot;
				tmrSeekAndShoot.Tick += TmrSeekAndShoot_Tick;
				tmrSeekAndShoot.Start();
			}

			//Evolution
			picTurret.MouseClick += PicTurret_MouseClick;
			picTurret.MouseEnter += PicTurret_MouseEnter;
			picTurret.MouseLeave += PicTurret_MouseLeave;
		}





		#region Chamander
		private void TmrChamanderShoot_Tick(object sender, EventArgs e)
		{
			Bullet bullet = new Bullet(turretType, evolveStage, direction);
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
				if (picTurret.Tag.ToString() != "Idle")
					picTurret.Image = KoffingIdleByStage();
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
					if (picTurret.Tag.ToString() != "Attack")//Tương đương Image != KoffingAttackByStage() - nhưng ko so 2 ảnh trực tiếp được
						picTurret.Image = KoffingAttackByStage();
					Shoot(target);
					break;
				}
				else picTurret.Image = KoffingIdleByStage();
			}
		}
		void Shoot(Enemy _target)
		{
			Bullet bullet = new Bullet("Koffing", evolveStage);
			bullet.SeekTarget(target);
			bullet.SpawnBulletAt(ChamanderCenterPoint());
		}
		
		//Trả về giá trị Image tương ứng với evolveStage
		Image KoffingIdleByStage()
		{
			if (turretType != "Koffing")
				return null;
			picTurret.Tag = "Idle";
			if (evolveStage == 1)
			{
				return Properties.Resources.KoffingIdle;
			}
			else if (evolveStage == 2)
				return Properties.Resources.WeezingIdle;
			return null;
		}
		Image KoffingAttackByStage()
		{
			if (turretType != "Koffing")
				return null;
			picTurret.Tag = "Attack";
			if (evolveStage == 1)
				return Properties.Resources.KoffingAttack;
			else if (evolveStage == 2)
				return Properties.Resources.WeezingAtk;
			return null;
		}
		#endregion

		#region Evolution
		private void PicTurret_MouseClick(object sender, MouseEventArgs e)
		{
			if (BuildManager.Instance.turretToBuild != "Evolution")
				return;
			EvolveTurret();
			BuildManager.Instance.turretToBuild = "none";
			Form1.ActiveForm.Cursor = Cursors.Default;
		}

		void EvolveTurret()
		{
			#region Charizard
			if (turretType == "Charmander" && evolveStage == 1)
			{
				if (PlayerStats.money < Constant.CHARIZARD_COST)
					return;
				PlayerStats.money -= Constant.CHARIZARD_COST;
				if (direction == "Left")
				{
					picTurret.Image = Properties.Resources.CharizardLeft;
				}
				if (direction == "Right")
				{
					picTurret.Image = Properties.Resources.CharizardRight;
				}
				if (direction == "Up")
				{
					picTurret.Image = Properties.Resources.CharizardUp;
				}
				if (direction == "Down")
				{
					picTurret.Image = Properties.Resources.CharizardDown;
				}
				delayPerShot = 700;
				tmrChamanderShoot.Interval = delayPerShot;
				evolveStage = 2;
			}
			#endregion
			#region Weezing
			if (turretType == "Koffing" && evolveStage == 1)
			{
				if (PlayerStats.money < Constant.WEEZING_COST)
					return;
				PlayerStats.money -= Constant.WEEZING_COST;
				picTurret.Image = Properties.Resources.WeezingIdle;
				delayPerShot = 400;
				tmrSeekAndShoot.Interval = delayPerShot;
				evolveStage = 2;
			}
			#endregion
		}

		//Hiển thị giao diện (đưa giá trị lblMessageText ra)
		private void PicTurret_MouseLeave(object sender, EventArgs e)
		{
			if (BuildManager.Instance.turretToBuild != "Evolution")
				return;

			messageText = "Hover to a pokemon to see information...";
			Form1.ActiveForm.Cursor = Cursors.Default;
		}
		private void PicTurret_MouseEnter(object sender, EventArgs e)
		{
			if (BuildManager.Instance.turretToBuild != "Evolution")
				return;

			if (turretType == "Charmander")
			{
				if (evolveStage == 1)
					messageText = "Evolve to Charizard :\n - Attack speed+\n - Range++\n - Damage++\n - Cost : $" + Constant.CHARIZARD_COST;
				else if (evolveStage == 2)
					messageText = "Already at maximum lvl.";
			}
			if (turretType == "Koffing")
			{
				if (evolveStage == 1)
					messageText = "Evolve to Weezing :\n - Attack speed++\n - Damage+\n - Cost : $" + Constant.WEEZING_COST;
				else if (evolveStage == 2)
					messageText = "Already at maximum lvl.";
			}
			Form1.ActiveForm.Cursor = Cursors.Hand;
		}
		#endregion
	}
}