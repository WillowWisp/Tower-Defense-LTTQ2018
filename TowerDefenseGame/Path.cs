﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerDefenseGame
{
    public class Path
    {
        public PictureBox pbNode;
        public int index;
        int height = Constant.NODE_HEIGHT;
        int width = Constant.NODE_WIDTH;
        public Path()
        {
            pbNode = new PictureBox()
            {
                Height = height,
                Width = width,
                BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\brick_grey.png"),
                BackgroundImageLayout = ImageLayout.Stretch
            };
        }
    }
}
