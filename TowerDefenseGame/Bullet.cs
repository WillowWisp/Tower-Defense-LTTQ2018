using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerDefenseGame
{
	public class Bullet
	{
		public PictureBox picBullet;
		int flyRange = 50;

		Timer tmrFlyLeft;

		Timer tmrCheckCollision;

		bool isDisposed = false;

		public Bullet()
		{
			picBullet = new PictureBox()
			{
				Height = 12,
				Width = 12,
				BackColor = Color.Black
			};

			tmrCheckCollision = new Timer();
			tmrCheckCollision.Interval = 30;
			tmrCheckCollision.Start();
			tmrCheckCollision.Tick += TmrCheckCollision_Tick;
		}

		private void TmrCheckCollision_Tick(object sender, EventArgs e)
		{
			if (ObjectManager.Instance.enemyList.Count == 0)
			{
				tmrCheckCollision.Enabled = false;
				return;
			}
			OnCollisionEnter(ObjectManager.Instance.enemyList);
		}
		void OnCollisionEnter(List<Enemy> enemyList)
		{
			List<Enemy> enemiesToRemove = new List<Enemy>();

			foreach (Enemy enemy in enemyList)
			{
				if (picBullet.Bounds.IntersectsWith(enemy.picEnemy.Bounds) && !isDisposed && enemy.isAlive)
				//isDisposed và isAlive để fix lỗi khi Dispose, control ko mất hoàn toàn			
				{
					this.picBullet.Dispose();
					this.isDisposed = true;
					enemy.Die();
					enemiesToRemove.Add(enemy);
					//Vì ta không xóa trực tiếp enemyList.Remove(enemy) trong foreach được nên phải xài List trung gian
				}
			}

			foreach (Enemy enemyToRemove in enemiesToRemove)
			{
				enemyList.Remove(enemyToRemove);
			}
		}

		public void SpawnBulletAt(Point location)
		{
			FieldManager.panelField.Controls.Add(picBullet);
			picBullet.Location = location;
			picBullet.BringToFront();
		}

		public void FlyLeft()
		{
			tmrFlyLeft = new Timer();
			tmrFlyLeft.Interval = 10;
			tmrFlyLeft.Start();
			tmrFlyLeft.Tick += TmrFlyLeft_Tick;
		}
		private void TmrFlyLeft_Tick(object sender, EventArgs e)
		{
			picBullet.Left -= 3;
			flyRange--;
			if (flyRange <= 0)
			{
				tmrFlyLeft.Stop();
				picBullet.Dispose();
				isDisposed = true;
			}
		}
	}
}