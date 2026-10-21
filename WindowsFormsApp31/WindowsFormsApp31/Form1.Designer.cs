
namespace WindowsFormsApp31
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBoxSin = new System.Windows.Forms.CheckBox();
			this.checkBoxCos = new System.Windows.Forms.CheckBox();
			this.checkBoxEllipse = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(14, 52);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(758, 380);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.Location = new System.Drawing.Point(14, 448);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(150, 46);
			this.button1.TabIndex = 1;
			this.button1.Text = "Перерисовать";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.checkBoxEllipse);
			this.groupBox1.Controls.Add(this.checkBoxCos);
			this.groupBox1.Controls.Add(this.checkBoxSin);
			this.groupBox1.Location = new System.Drawing.Point(790, 52);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(196, 148);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Графики";
			// 
			// checkBoxSin
			// 
			this.checkBoxSin.AutoSize = true;
			this.checkBoxSin.Checked = true;
			this.checkBoxSin.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxSin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
			this.checkBoxSin.Location = new System.Drawing.Point(18, 32);
			this.checkBoxSin.Name = "checkBoxSin";
			this.checkBoxSin.Size = new System.Drawing.Size(45, 17);
			this.checkBoxSin.TabIndex = 0;
			this.checkBoxSin.Text = "sin(x)";
			this.checkBoxSin.UseVisualStyleBackColor = true;
			this.checkBoxSin.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
			// 
			// checkBoxCos
			// 
			this.checkBoxCos.AutoSize = true;
			this.checkBoxCos.Checked = true;
			this.checkBoxCos.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxCos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.checkBoxCos.Location = new System.Drawing.Point(18, 64);
			this.checkBoxCos.Name = "checkBoxCos";
			this.checkBoxCos.Size = new System.Drawing.Size(48, 17);
			this.checkBoxCos.TabIndex = 1;
			this.checkBoxCos.Text = "cos(x)";
			this.checkBoxCos.UseVisualStyleBackColor = true;
			this.checkBoxCos.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
			// 
			// checkBoxEllipse
			// 
			this.checkBoxEllipse.AutoSize = true;
			this.checkBoxEllipse.Checked = true;
			this.checkBoxEllipse.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxEllipse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(200)))));
			this.checkBoxEllipse.Location = new System.Drawing.Point(18, 96);
			this.checkBoxEllipse.Name = "checkBoxEllipse";
			this.checkBoxEllipse.Size = new System.Drawing.Size(59, 17);
			this.checkBoxEllipse.TabIndex = 2;
			this.checkBoxEllipse.Text = "ellipse";
			this.checkBoxEllipse.UseVisualStyleBackColor = true;
			this.checkBoxEllipse.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.ForeColor = System.Drawing.Color.DimGray;
			this.label1.Location = new System.Drawing.Point(790, 214);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(190, 32);
			this.label1.TabIndex = 3;
			this.label1.Text = "Галочка включает\r\nи выключает кривую";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1000, 520);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Графики: sin, cos, эллипс";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox checkBoxSin;
		private System.Windows.Forms.CheckBox checkBoxCos;
		private System.Windows.Forms.CheckBox checkBoxEllipse;
		private System.Windows.Forms.Label label1;
	}
}
