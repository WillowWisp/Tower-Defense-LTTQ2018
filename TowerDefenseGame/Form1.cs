using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerDefenseGame
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			FieldManager.Instance.DrawNodes(panelField);
            FieldManager.Instance.DesignPath(panelField);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			label31.Text = Enemy.waypointIndex.ToString();
			label32.Text = FieldManager.Instance.waypointList.Count.ToString();
		}
	}
}