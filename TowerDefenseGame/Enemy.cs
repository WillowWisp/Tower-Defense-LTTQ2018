using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TowerDefenseGame.Properties;

namespace TowerDefenseGame
{
	public class Enemy
	{
		public PictureBox picEnemy;
		int height = Constant.ENEMY_HEIGHT;
		int width = Constant.ENEMY_WIDTH;
		int moneyDrop = 25;
		int moveSpeed = 2;

		Timer tmrMoveRight;
		Timer tmrMoveLeft;
		Timer tmrMoveDown;
		Timer tmrMoveUp;
		Timer tmrCheckWaypoint;
		
		public bool isAlive = true;

		public int waypointIndex = 0;

		public Point target;//Vị trí waypoint đang đi tới

		public Enemy()
		{			
			picEnemy = new PictureBox()
			{
				Height = height,
				Width = width,
				BackColor = Color.Transparent,
				SizeMode = PictureBoxSizeMode.Zoom,
			};
		}
			
		public void SpawnEnemy(Path path)
		{
			FieldManager.panelField.Controls.Add(picEnemy);
			picEnemy.Location = path.GetCenterPoint();
			picEnemy.BringToFront();
		}

		public void MoveThroughWaypoints(List<Point> waypointList)
		{
			target = FieldManager.Instance.waypointList[0];
			HeadToTarget();

			tmrCheckWaypoint = new Timer();
			tmrCheckWaypoint.Interval = 1;
			tmrCheckWaypoint.Start();
			tmrCheckWaypoint.Tick += CheckWaypoint_Tick;
		}
		void CheckWaypoint_Tick(object sender, EventArgs e)
		{
			if (picEnemy.Location == target)
			{
				ClearMovement();
				waypointIndex++;


				if (waypointIndex >= FieldManager.Instance.waypointList.Count)
				{
					if (isAlive)
					{
						DamageDoor();
					}
					tmrCheckWaypoint.Stop();
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
			picEnemy.Left += moveSpeed;
			if ((string)picEnemy.Tag != "FaceRight")
			{
				picEnemy.Image = Properties.Resources.Pik_Right;
				picEnemy.Tag = "FaceRight";
			}
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
			picEnemy.Left -= moveSpeed;
			if ((string)picEnemy.Tag != "FaceLeft")
			{
				picEnemy.Image = Properties.Resources.Pik_Left;
				picEnemy.Tag = "FaceLeft";
			}
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
			picEnemy.Top += moveSpeed;
			if ((string)picEnemy.Tag != "FaceDown")
			{
				picEnemy.Image = Properties.Resources.Pik_Down;
				picEnemy.Tag = "FaceDown";
			}
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
			picEnemy.Top -= moveSpeed;
			if ((string)picEnemy.Tag != "FaceUp")
			{
				picEnemy.Image = Properties.Resources.Pik_Up;
				picEnemy.Tag = "FaceUp";
			}
		}


		string GetDirectionToTarget()
		{
			if (target.Y == picEnemy.Location.Y)
			{
				if (target.X >= picEnemy.Location.X)
					return "E";
				else return "W";
			}
			else if (target.X == picEnemy.Location.X)
			{
				if (target.Y <= picEnemy.Location.Y)
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
			picEnemy.Dispose();
			isAlive = false;
			ObjectManager.Instance.enemyList.Remove(this);
			PlayerStats.lives -= 1;
		}

		public void Die() //Chỉ dùng khi enemy bị trụ giết
		{
			picEnemy.Dispose();
			isAlive = false;
			PlayerStats.money += moneyDrop;
		}
	}
}
//Transparent, Destroy enemy, Speedup enemy