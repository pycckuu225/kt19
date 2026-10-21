using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp31
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Graphics g = pictureBox1.CreateGraphics();
			g.Clear(Color.White);

			int w = pictureBox1.Width;
			int h = pictureBox1.Height;
			int center = h / 2;

			// sin — зелёный
			if (checkBoxSin.Checked)
			{
				Point[] points = new Point[w];
				for (int x = 0; x < w; x++)
					points[x] = new Point(x, center - (int)(Math.Sin(2 * Math.PI * 3 * x / w) * h * 0.35));
				g.DrawLines(new Pen(Color.Green, 2), points);
			}

			// cos — красный
			if (checkBoxCos.Checked)
			{
				Point[] points = new Point[w];
				for (int x = 0; x < w; x++)
					points[x] = new Point(x, center - (int)(Math.Cos(2 * Math.PI * 3 * x / w) * h * 0.35));
				g.DrawLines(new Pen(Color.Red, 2), points);
			}

			// эллипс — синий
			if (checkBoxEllipse.Checked)
			{
				Point[] points = new Point[200];
				for (int i = 0; i < 200; i++)
					points[i] = new Point(
						(int)(w / 2 + Math.Cos(2 * Math.PI * i / 199) * w * 0.4),
						(int)(center + Math.Sin(2 * Math.PI * i / 199) * h * 0.4));
				g.DrawLines(new Pen(Color.Blue, 2), points);
			}
		}
	}
}
