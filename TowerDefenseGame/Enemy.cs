using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerDefenseGame
{
	public class Enemy
	{
		public PictureBox pbEnemy;
		int height = Constant.ENEMY_HEIGHT;
		int width = Constant.ENEMY_WIDTH;

		Timer tmrMoveRight;
		Timer tmrMoveDown;
		Timer tmrCheckWaypoint;

		public static int waypointIndex = 0;

		public static Point target;//Vị trí waypoint đang đi tới

		public Enemy()
		{
			pbEnemy = new PictureBox()
			{
				Height = height,
				Width = width,
				BackColor = Color.Red
			};
		}

		public void SpawnEnemy(Panel panelField, Path path)
		{
			panelField.Controls.Add(pbEnemy);
			pbEnemy.Location = path.GetCenterPoint();
			pbEnemy.BringToFront();
		}

		public void MoveThroughWaypoints(List<Point> waypointList)
		{
			target = FieldManager.Instance.waypointList[0];
			MoveRight();

			tmrCheckWaypoint = new Timer();
			tmrCheckWaypoint.Interval = 10;
			tmrCheckWaypoint.Start();
			tmrCheckWaypoint.Tick += CheckWaypoint_Tick;
		}

		void MoveRight()
		{
			tmrMoveRight = new Timer();
			tmrMoveRight.Interval = 10;
			tmrMoveRight.Start();
			tmrMoveRight.Tick += MoveRight_Tick;
		}
		void MoveRight_Tick(object sender, EventArgs e)
		{
			pbEnemy.Left += 1;
		}

		void MoveDown()
		{
			tmrMoveDown = new Timer();
			tmrMoveDown.Interval = 1;
			tmrMoveDown.Start();
			tmrMoveDown.Tick += MoveDown_Tick;
		}
		void MoveDown_Tick(object sender, EventArgs e)
		{
			pbEnemy.Top += 1;
		}

		void CheckWaypoint_Tick(object sender, EventArgs e)
		{
			if (pbEnemy.Location == target)
			{
				ClearMovement();
				waypointIndex++;
				

				if (waypointIndex >= FieldManager.Instance.waypointList.Count)
				{
					ClearMovement();
				}
				else
				{
					MoveDown();
					target = FieldManager.Instance.waypointList[waypointIndex];
				}
			}
		}

		void ClearMovement()
		{
			tmrMoveRight.Enabled = false;
			if (tmrMoveDown != null)
				tmrMoveDown.Enabled = false;
		}
	}
}
