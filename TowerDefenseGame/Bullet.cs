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

		public Bullet()
		{
			picBullet = new PictureBox()
			{
				Height = 12,
				Width = 12,
				BackColor = Color.Black
			};
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
				picBullet.Dispose();
				tmrFlyLeft.Stop();
			}
		}
	}
}