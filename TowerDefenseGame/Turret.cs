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

		Timer tmrShooting;

		public Turret()
		{
			picTurret = new PictureBox()
			{
				Height = Constant.NODE_HEIGHT,
				Width = Constant.NODE_WIDTH,
				BackColor = Color.Transparent,
				Image = Image.FromFile(Application.StartupPath + "\\Resources\\start1.png")
			};

			tmrShooting = new Timer();
			tmrShooting.Interval = 1000;
			tmrShooting.Start();
			tmrShooting.Tick += TmrShooting_Tick;
		}

		private void TmrShooting_Tick(object sender, EventArgs e)
		{
			Bullet bullet = new Bullet();
			bullet.SpawnBulletAt(LeftCannonPoint());
			bullet.FlyLeft();
		}

		Point LeftCannonPoint()
		{
			return new Point(picTurret.Location.X + 12, picTurret.Location.Y + 18);
		}
	}
}