using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

        public Node()
        {
            picNode = new PictureBox()
            {
                Height = height,
                Width = width,
                BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\cactus_top.png"),
                BackgroundImageLayout = ImageLayout.Stretch
            };
        }
	}
}