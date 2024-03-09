using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMLab1
{
	public partial class Form1 : Form
	{
		const decimal g = 9.81M;
		const decimal C = 0.15M;
		const decimal rho = 1.29M;
		decimal dt = 0.1M;
		decimal t, x, y, v0, cosa, sina, S, m, k, vx, vy, y0, MaxH=0;

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void nWeight_ValueChanged(object sender, EventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
				t += dt;
				decimal v = (decimal)Math.Sqrt((double)(vx * vx + vy * vy));
				vx = vx - k * vx * v * dt;
				vy = vy - (g + k * vy * v) * dt;
				x = x + vx * dt;
				y = y + vy * dt;
			if (chart1.ChartAreas[0].AxisX.Maximum<(double)x)
			{
				chart1.ChartAreas[0].AxisX.Maximum= (double)x+0.5;
				MaxH = x;

			}
			if (chart1.ChartAreas[0].AxisY.Maximum < (double)y)
			{
				chart1.ChartAreas[0].AxisY.Maximum = (double)y+0.5;
			}
			chart1.Series[0].Points.AddXY(x, y);
			if (y <= 0)
			{
				timer1.Stop();
				dataGridView1.Rows.Add(dt, x, MaxH, v);

			}
		}

		public Form1()
		{
			InitializeComponent();

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button_Click(object sender, EventArgs e)
		{

			
				if (!timer1.Enabled)
				{
					chart1.Series[0].Points.Clear();
					y0 = nHeight.Value;
					double a = (double)nAngle.Value * Math.PI / 180;
					cosa = (decimal)Math.Cos(a);
					sina = (decimal)Math.Sin(a);
					v0 = nSpeed.Value;
					S = nSize.Value;
					m = nWeight.Value;
					dt = ndt.Value;

					k = 0.5M * C * rho * S / m;
					vx = v0 * cosa;
					vy = v0 * sina;
					y = y0;
					x = 0;
					t = 0;
					chart1.ChartAreas[0].AxisX.Maximum = 5;
					chart1.ChartAreas[0].AxisY.Maximum = (double)y0 + 0.5;
					chart1.Series[0].Points.AddXY(x, y);
					//timer1.Interval = dt;
					timer1.Start();
					
				}
			
		}





	}
}

