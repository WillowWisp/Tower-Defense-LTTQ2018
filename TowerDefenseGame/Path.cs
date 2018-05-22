using System;
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
        public PictureBox pbPath;
        public int index;
        int height = Constant.NODE_HEIGHT;
        int width = Constant.NODE_WIDTH;
        public Path()
        {
            pbPath = new PictureBox()
            {
                Height = height,
                Width = width,
                BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\brick_grey.png"),
                BackgroundImageLayout = ImageLayout.Stretch
            };
        }

		public Point GetCenterPoint()
		{
			return new Point(pbPath.Location.X + 6, pbPath.Location.Y + 6);//12 là offset để căn enemy ra giữa, dựa vào size của enemy
		}
	}
}
