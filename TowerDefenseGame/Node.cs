﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerDefenseGame
{
    public class Node
    {
        public PictureBox picNode;
        public int horIndex;//Số thứ tự cột của node

        int height = Constant.NODE_HEIGHT;
        int width = Constant.NODE_WIDTH;

		public Turret currentTurret;

        public Node()
        {
            picNode = new PictureBox()
            {
                Height = height,
                Width = width,
                BackgroundImage = Properties.Resources.cactus_top,
                BackgroundImageLayout = ImageLayout.Stretch
            };

			picNode.MouseClick += PicNode_MouseClick;
		}

		private void PicNode_MouseClick(object sender, MouseEventArgs e)
		{
			if (currentTurret != null)
			{
				return;
			}
			if (BuildManager.Instance.turretToBuild == "none" || BuildManager.Instance.turretToBuild == "Evolution")
				return;
			BuildManager.Instance.BuildTurretOn(this);
			BuildManager.Instance.turretToBuild = "none";
			BuildManager.Instance.turretToBuildDirection = null;

			SoundPlayer buildSound = new SoundPlayer(Properties.Resources.build_sound);
			buildSound.Play();

			Form1.ActiveForm.Cursor = Cursors.Default;
		}
	}
}