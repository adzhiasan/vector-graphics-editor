using System;
using System.Drawing;
using System.Windows.Forms;

using FigureLibrary;

namespace VgeWinForms
{
	public partial class Form1 : Form
	{
		Tool tool;
		Model model;
		public Form1()
		{
			InitializeComponent();
		}

		private void mainPanel_MouseDown(object sender, MouseEventArgs e)
		{
			Graphics graphics = mainPanel.CreateGraphics();

			
		}

		private void EllipseButton_Click(object sender, EventArgs e)
		{
			tool = Tool.Ellipse;
		}

		private void RectangleButton_Click(object sender, EventArgs e)
		{
			tool = Tool.Rectangle;
		}

		private void SelectButton_Click(object sender, EventArgs e)
		{
			tool = Tool.Select;
		}

		private void mainPanel_Paint(object sender, PaintEventArgs e)
		{
			model.Draw(e.Graphics);
		}
	}

	enum Tool
	{
		Select,
		Rectangle,
		Ellipse
	}
}
