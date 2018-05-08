using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerDefenseGame
{
	class Enemy
	{
		public PictureBox pbEnemy;
		int height = Constant.ENEMY_HEIGHT;
		int width = Constant.ENEMY_WIDTH;
		public Enemy()
		{
			pbEnemy = new PictureBox()
			{
				Height = height,
				Width = width,
				BackColor = Color.Red
			};
		}
	}
}
