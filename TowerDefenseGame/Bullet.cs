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
		int bulletRange;
		int bulletSpeed;

		//Khởi tạo trước để ta có thể dừng timer ở bất cứ đâu
		Timer tmrFlyLeft = new Timer();
		Timer tmrFlyRight = new Timer();
		Timer tmrFlyUp = new Timer();
		Timer tmrFlyDown = new Timer();

		Timer tmrCheckCollision;

		bool isDisposed = false;

		public Bullet(string turretType, string direction = null)
		{
			if (turretType == "Charmander")
			{
				picBullet = new PictureBox()
				{
					Height = 3,
					Width = 6,
					BackColor = Color.White
				};
				bulletRange = 30;
				bulletSpeed = 4;
			}

			if (direction == "Left")
				FlyLeft();
			if (direction == "Right")
				FlyRight();
			if (direction == "Up")
			{
				picBullet.Height = 6;
				picBullet.Width = 3;
				FlyUp();
			}
			if (direction == "Down")
			{
				picBullet.Height = 6;
				picBullet.Width = 3;
				FlyDown();
			}

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
					this.Destroy();
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

		void Destroy()
		{
			this.picBullet.Dispose();
			this.isDisposed = true;
			tmrCheckCollision.Stop();
			tmrFlyLeft.Stop();
			tmrFlyRight.Stop();
			tmrFlyUp.Stop();
			tmrFlyDown.Stop();
		}

		void FlyLeft()
		{
			tmrFlyLeft.Interval = 10;
			tmrFlyLeft.Start();
			tmrFlyLeft.Tick += TmrFlyLeft_Tick;
		}
		private void TmrFlyLeft_Tick(object sender, EventArgs e)
		{
			picBullet.Left -= bulletSpeed;
			bulletRange--;
			if (bulletRange <= 0)
			{
				Destroy();
			}
		}

		void FlyRight()
		{
			tmrFlyRight.Interval = 10;
			tmrFlyRight.Start();
			tmrFlyRight.Tick += TmrFlyRight_Tick;
		}
		private void TmrFlyRight_Tick(object sender, EventArgs e)
		{
			picBullet.Left += bulletSpeed;
			bulletRange--;
			if (bulletRange <= 0)
			{
				Destroy();
			}
		}

		void FlyUp()
		{
			tmrFlyUp.Interval = 10;
			tmrFlyUp.Start();
			tmrFlyUp.Tick += TmrFlyUp_Tick;
		}
		private void TmrFlyUp_Tick(object sender, EventArgs e)
		{
			picBullet.Top -= bulletSpeed;
			bulletRange--;
			if (bulletRange <= 0)
			{
				Destroy();
			}
		}

		void FlyDown()
		{
			tmrFlyDown.Interval = 10;
			tmrFlyDown.Start();
			tmrFlyDown.Tick += TmrFlyDown_Tick;
		}
		private void TmrFlyDown_Tick(object sender, EventArgs e)
		{
			picBullet.Top += bulletSpeed;
			bulletRange--;
			if (bulletRange <= 0)
			{
				Destroy();
			}
		}
	}
}