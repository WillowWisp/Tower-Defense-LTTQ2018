using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerDefenseGame
{
	public class FieldManager
	{
		//Singleton
		private static FieldManager instance;

		public static FieldManager Instance
		{
			get
			{
				if (instance == null)
					instance = new FieldManager();
				return instance;
			}
		}

		//Variables
		public static Panel panelField;

		List<List<Node>> nodeList;
		public List<Path> pathList;

		public List<Point> waypointList;


		//Methods
		public void DrawNodes()
		{
			nodeList = new List<List<Node>>();

			PictureBox prePic = new PictureBox()
			{
				Width = 0,
				Location = new Point(0, Constant.NODE_Y_OFFSET)
			};


			for (int i = 0; i < 15; i++)
			{
				nodeList.Add(new List<Node>());
				for (int j = 0; j < 15; j++)
				{
					Node node = new Node();
					node.picNode.Location = new Point(prePic.Location.X + prePic.Width + Constant.NODE_X_OFFSET, prePic.Location.Y);
					node.horIndex = i;

					panelField.Controls.Add(node.picNode);
					nodeList[i].Add(node);

					prePic.Location = new Point(node.picNode.Location.X, prePic.Location.Y);
					prePic.Size = node.picNode.Size;
				}

				prePic.Location = new Point(0, prePic.Location.Y + prePic.Width + Constant.NODE_Y_OFFSET);//Gán lại prePicBox = vị trí đầu tiên của hàng dưới
				prePic.Width = 0;
			}
			
		}

		Point GetNodePoint(Node node)
		{
			int yPoint = node.horIndex;
			int xPoint = nodeList[yPoint].IndexOf(node);
			Point point = new Point(xPoint, yPoint);
			return point;
		}

        
		public void DesignPath()
		{
            pathList = new List<Path>();
            int pathIndex = 0;

			waypointList = new List<Point>();

			DrawPathHorizontal(new Point(1, 1), new Point(6, 1), ref pathIndex);
			DrawPathVertical(new Point(6, 2), new Point(6, 4), ref pathIndex);
			DrawPathHorizontal(new Point(5, 4), new Point(3, 4), ref pathIndex);
			DrawPathVertical(new Point(3, 5), new Point(3, 6), ref pathIndex);
			DrawPathHorizontal(new Point(4, 6), new Point(8, 6), ref pathIndex);
			DrawPathVertical(new Point(8, 5), new Point(8, 2), ref pathIndex);
			DrawPathHorizontal(new Point(9, 2), new Point(11, 2), ref pathIndex);
			DrawPathVertical(new Point(11, 3), new Point(11, 9), ref pathIndex);
			DrawPathHorizontal(new Point(10, 9), new Point(4, 9), ref pathIndex);
			DrawPathVertical(new Point(4, 10), new Point(4, 13), ref pathIndex);
			DrawPathHorizontal(new Point(5, 13), new Point(7, 13), ref pathIndex);
			DrawOnlyOnePath(new Point(7, 12), ref pathIndex);//Xử lý trường hợp gấp khúc nhỏ
			DrawPathHorizontal(new Point(8, 12), new Point(13, 12), ref pathIndex);
			SetStartEnd();
			ClearAllPath();
		}

		void ClearAllPath()
		{
			foreach (Path path in pathList)
			{
				path.picPath.Dispose();
			}
		}

		void ReplaceNodeWithPath(Node node, Path path)
		{
			Point pathLocation = node.picNode.Location;
			panelField.Controls.Remove(node.picNode);
			path.picPath.Location = pathLocation;
			panelField.Controls.Add(path.picPath);
		}
		void DrawPathHorizontal(Point startPoint, Point endPoint, ref int pathIndex)
		{
			if (endPoint.X >= startPoint.X)
			{
				//Vẽ từ trái sang phải
				for (int j = startPoint.X; j <= endPoint.X; j++)
				{
					Path path = new Path();
					ReplaceNodeWithPath(nodeList[startPoint.Y][j], path);
					pathList.Add(path);
					path.index = pathIndex;
					pathIndex++;
				}
			}
			else
			{
				//Vẽ từ phải sang trái
				for (int j = startPoint.X; j >= endPoint.X; j--)
				{
					Path path = new Path();
					ReplaceNodeWithPath(nodeList[startPoint.Y][j], path);
					pathList.Add(path);
					path.index = pathIndex;
					pathIndex++;
				}
			}
			waypointList.Add(pathList[pathIndex - 1].GetCenterPoint());//Gán waypoint bằng ô path cuối để tạo điểm đến cho enemy
		}
		void DrawPathVertical(Point startPoint, Point endPoint, ref int pathIndex)
		{
			if (endPoint.Y >= startPoint.Y)
			{
				//Vẽ từ trên xuống
				for (int i = startPoint.Y; i <= endPoint.Y; i++)
				{
					Path path = new Path();
					ReplaceNodeWithPath(nodeList[i][startPoint.X], path);
					pathList.Add(path);
					path.index = pathIndex;
					pathIndex++;
				}
			}
			else
			{
				//Vẽ từ dưới lên
				for (int i = startPoint.Y; i >= endPoint.Y; i--)
				{
					Path path = new Path();
					ReplaceNodeWithPath(nodeList[i][startPoint.X], path);
					pathList.Add(path);
					path.index = pathIndex;
					pathIndex++;
				}
			}
			waypointList.Add(pathList[pathIndex - 1].GetCenterPoint());
		}
		void DrawOnlyOnePath(Point point, ref int pathIndex)
		{
			Path path = new Path();
			ReplaceNodeWithPath(nodeList[point.Y][point.X], path);
			pathList.Add(path);
			path.index = pathIndex;
			pathIndex++;
			waypointList.Add(pathList[pathIndex - 1].GetCenterPoint());
		}

		void SetStartEnd()
		{
			pathList[0].picPath.Image = Image.FromFile(Application.StartupPath + "\\Resources\\start1.png");
			pathList[0].picPath.Tag = "Start";
			pathList[pathList.Count - 1].picPath.Image = Image.FromFile(Application.StartupPath + "\\Resources\\end1.png");
			pathList[pathList.Count - 1].picPath.Tag = "End";
		}
		
		void AddWaypoint(ref List<Point> waypointList, Path path)
		{
			waypointList.Add(path.GetCenterPoint());
		}
	}
}