using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerDefenseGame.Resources
{
	public partial class Start : Form
	{
		string[] list = { "Play", "Help", "Exit" };
		int index = 0;
		Timer timer = new Timer();
		int r = 0;
		int i = 1;
		public Start()
		{
			InitializeComponent();
			if (index == 0)
			{
				pcbUp.Visible = false;
			}
			timer.Interval = 30;
			timer.Tick += Timer_Tick;
			timer.Start();
			
			pcbStart.Controls.Add(picPokemonLogo);
			pcbStart.Controls.Add(pcbUp);
			pcbStart.Controls.Add(lbOption);
			pcbStart.Controls.Add(pcbDown);
		}

		private void Timer_Tick(object sender, EventArgs e)
		{

			if (r > 240)
			{
				i = -10;
			}
			else if (r < 10)
			{
				i = 10;
			}
			r += i;
			lbOption.ForeColor = Color.FromArgb(r, r, r);
		}			

		private void pcbDown_Click_1(object sender, EventArgs e)
		{
			lbOption.Text = list[++index];
			pcbUp.Visible = true;
			if (index >= 2)
			{
				pcbDown.Visible = false;
			}
			SoundPlayer selectSound = new SoundPlayer(Properties.Resources.select_sound);
			selectSound.Play();
		}

		private void lbOption_Click_1(object sender, EventArgs e)
		{
			SoundPlayer selectSound = new SoundPlayer(Properties.Resources.select_sound);
			selectSound.Play();
			if (lbOption.Text == "Play")
			{
				this.Hide();
				new Form1().ShowDialog();
				this.Close();
			}
			else if (lbOption.Text == "Help")
			{
				string help = "Bạn cần xây trụ để chống lại các đợt lính địch"
					+ "\n"
					+ "	Quy Tắc:"
					+ "\n - Bắt đầu với $100, số tiền sẽ tăng dần dựa vào số địch bạn tiêu diệt được."
					+ "\n - Số lượng địch sau mỗi đợt sẽ tăng dần về máu lẫn số lượng."
					+ "\n - Bạn chỉ có '2 mạng' đồng nghĩa với 2 kẻ địch có thể tấn công vào thành, sau đó bạn sẽ thua.";
				MessageBox.Show(help, "Trợ Giúp");
			}
			else if (lbOption.Text == "Exit")
			{
				DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Hỏi Thoát?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
					this.Close();
			}
		}
		private void pcbUp_Click_1(object sender, EventArgs e)
		{
			lbOption.Text = list[--index];
			pcbDown.Visible = true;
			if (index <= 0)
			{
				pcbUp.Visible = false;
			}
			SoundPlayer selectSound = new SoundPlayer(Properties.Resources.select_sound);
			selectSound.Play();
		}
	}
}

