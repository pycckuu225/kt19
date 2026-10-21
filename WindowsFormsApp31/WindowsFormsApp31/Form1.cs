using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
			Pen p = new Pen(Color.Black, 3f);
			Point[] points = new Point[1000];
			for(int i =0; i<points.Length;i++)
			{
				points[i] = new Point(i, (int)(Math.Sin((double)i / 10) * 100 + 150));
			}
			g.DrawLines(p, points);
		}
	}
}
