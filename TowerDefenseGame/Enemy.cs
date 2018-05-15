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
		Timer tmrMoveLeft;
		Timer tmrMoveDown;
		Timer tmrMoveUp;
		Timer tmrCheckWaypoint;

		public int waypointIndex = 0;

		public Point target;//Vị trí waypoint đang đi tới

		public Enemy()
		{
			pbEnemy = new PictureBox()
			{
				Height = height,
				Width = width,
				BackColor = Color.Red
			};
		}

		public void SpawnEnemy(Path path)
		{
			FieldManager.panelField.Controls.Add(pbEnemy);
			pbEnemy.Location = path.GetCenterPoint();
			pbEnemy.BringToFront();
		}

		public void MoveThroughWaypoints(List<Point> waypointList)
		{
			target = FieldManager.Instance.waypointList[0];
			HeadToTarget();

			tmrCheckWaypoint = new Timer();
			tmrCheckWaypoint.Interval = 10;
			tmrCheckWaypoint.Start();
			tmrCheckWaypoint.Tick += CheckWaypoint_Tick;
		}
		void CheckWaypoint_Tick(object sender, EventArgs e)
		{
			if (pbEnemy.Location == target)
			{
				ClearMovement();
				waypointIndex++;


				if (waypointIndex >= FieldManager.Instance.waypointList.Count)
				{
					DamageDoor();
					return;
				}
				else
				{
					target = FieldManager.Instance.waypointList[waypointIndex];
					
					HeadToTarget();
				}
			}
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

		void MoveLeft()
		{
			tmrMoveLeft = new Timer();
			tmrMoveLeft.Interval = 10;
			tmrMoveLeft.Start();
			tmrMoveLeft.Tick += MoveLeft_Tick;
		}
		void MoveLeft_Tick(object sender, EventArgs e)
		{
			pbEnemy.Left -= 1;
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

		void MoveUp()
		{
			tmrMoveUp = new Timer();
			tmrMoveUp.Interval = 1;
			tmrMoveUp.Start();
			tmrMoveUp.Tick += MoveUp_Tick;
		}
		void MoveUp_Tick(object sender, EventArgs e)
		{
			pbEnemy.Top -= 1;
		}


		string GetDirectionToTarget()
		{
			if (target.Y == pbEnemy.Location.Y)
			{
				if (target.X >= pbEnemy.Location.X)
					return "E";
				else return "W";
			}
			else if (target.X == pbEnemy.Location.X)
			{
				if (target.Y <= pbEnemy.Location.Y)
					return "N";
				else return "S";
			}
			else return "0";
		}
		void HeadToTarget()
		{
			if (GetDirectionToTarget() == "E")
				MoveRight();
			if (GetDirectionToTarget() == "W")
				MoveLeft();
			if (GetDirectionToTarget() == "S")
				MoveDown();
			if (GetDirectionToTarget() == "N")
				MoveUp();
		}

		void ClearMovement()
		{
			if (tmrMoveRight != null)
				tmrMoveRight.Enabled = false;
			if (tmrMoveLeft != null)
				tmrMoveLeft.Enabled = false;
			if (tmrMoveDown != null)
				tmrMoveDown.Enabled = false;
			if (tmrMoveUp != null)
				tmrMoveUp.Enabled = false;
		}

		void DamageDoor()
		{
			pbEnemy.Dispose();
		}
	}
}
//Transparent, Destroy enemy, Speedup enemy