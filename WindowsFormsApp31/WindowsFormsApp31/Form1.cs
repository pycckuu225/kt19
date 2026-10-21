using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp31
{
	public partial class Form1 : Form
	{
		// Сколько периодов sin/cos укладывается по ширине графика
		private const int Periods = 3;

		// Количество отрезков, которыми обходится эллипс
		private const int EllipseSteps = 240;

		// Толщина линий графиков
		private const float PenWidth = 2.5f;

		// Амплитуда волн в долях высоты картинки
		private const float Amplitude = 0.35f;

		private static readonly Color SinColor = Color.FromArgb(0, 160, 0);      // зелёный
		private static readonly Color CosColor = Color.FromArgb(200, 0, 0);      // красный
		private static readonly Color EllipseColor = Color.FromArgb(0, 90, 200); // синий

		public Form1()
		{
			InitializeComponent();

			// Минимальный размер окна — как при открытии, дальше можно только увеличивать
			MinimumSize = Size;

			// При изменении размера картинки график перерисовывается под новый размер
			pictureBox1.SizeChanged += (s, e) => RenderGraph();

			RenderGraph();
		}

		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			base.OnFormClosed(e);

			// Картинка графика больше не нужна
			if (pictureBox1.Image != null)
			{
				pictureBox1.Image.Dispose();
				pictureBox1.Image = null;
			}
		}

		// Полная перерисовка графика в буфер, чтобы не было мерцания
		private void RenderGraph()
		{
			int width = pictureBox1.ClientSize.Width;
			int height = pictureBox1.ClientSize.Height;

			if (width <= 0 || height <= 0)
				return;

			Bitmap bitmap = new Bitmap(width, height);

			using (Graphics g = Graphics.FromImage(bitmap))
			{
				g.SmoothingMode = SmoothingMode.AntiAlias;
				g.Clear(Color.White);

				DrawAxes(g, width, height);

				if (checkBoxSin.Checked)
					DrawWave(g, width, height, false, SinColor);

				if (checkBoxCos.Checked)
					DrawWave(g, width, height, true, CosColor);

				if (checkBoxEllipse.Checked)
					DrawEllipse(g, width, height, EllipseColor);
			}

			Image previous = pictureBox1.Image;
			pictureBox1.Image = bitmap;

			if (previous != null)
				previous.Dispose();
		}

		// Оси координат — чтобы было видно, где центр
		private static void DrawAxes(Graphics g, int width, int height)
		{
			using (Pen axisPen = new Pen(Color.FromArgb(215, 215, 215), 1f))
			{
				g.DrawLine(axisPen, 0, height / 2f, width, height / 2f);
				g.DrawLine(axisPen, width / 2f, 0, width / 2f, height);
			}
		}

		// График sin(x) или cos(x): x пробегает всю ширину, Periods периодов на картинку
		private static void DrawWave(Graphics g, int width, int height, bool isCos, Color color)
		{
			float centerY = height / 2f;
			float amplitude = height * Amplitude;

			PointF[] points = new PointF[width];

			for (int x = 0; x < width; x++)
			{
				double phase = 2.0 * Math.PI * Periods * x / width;
				double value = isCos ? Math.Cos(phase) : Math.Sin(phase);

				points[x] = new PointF(x, (float)(centerY - value * amplitude));
			}

			using (Pen pen = new Pen(color, PenWidth))
			{
				pen.LineJoin = LineJoin.Round;
				g.DrawLines(pen, points);
			}
		}

		// Эллипс: x = cx + a*cos(t), y = cy + b*sin(t), t от 0 до 2*pi
		private static void DrawEllipse(Graphics g, int width, int height, Color color)
		{
			float centerX = width / 2f;
			float centerY = height / 2f;
			float radiusX = width * 0.42f;
			float radiusY = height * 0.42f;

			PointF[] points = new PointF[EllipseSteps + 1];

			for (int i = 0; i <= EllipseSteps; i++)
			{
				double angle = 2.0 * Math.PI * i / EllipseSteps;

				points[i] = new PointF(
					(float)(centerX + radiusX * Math.Cos(angle)),
					(float)(centerY + radiusY * Math.Sin(angle)));
			}

			using (Pen pen = new Pen(color, PenWidth))
			{
				pen.LineJoin = LineJoin.Round;
				g.DrawLines(pen, points);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			RenderGraph();
		}

		// Общий обработчик для всех трёх галочек
		private void checkBox_CheckedChanged(object sender, EventArgs e)
		{
			RenderGraph();
		}
	}
}
