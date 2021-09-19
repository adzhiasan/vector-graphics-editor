using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using FigureLibrary;
using FigureLibrary.Creators;

namespace VgeWinForms
{
	public partial class Form1 : Form
	{
		Tool tool;
		Model model = new Model();
		Creator currentCreator = null;
		Dictionary<string, Creator> creators = new Dictionary<string, Creator>();
		public Form1()
		{
			InitializeComponent();
			creators["Rectangle"] = new RectangleCreator();
			creators["Ellipse"] = new EllipseCreator();
			creators["Select"] = null;
		}

		private void mainPanel_MouseDown(object sender, MouseEventArgs e)
		{
			Graphics graphics = mainPanel.CreateGraphics();

			Figure figure = currentCreator.Create();
			figure.Move(e.X, e.Y);
			model.Add(figure);

			Refresh();
			
		}

		private void ToolStripButton_Click(object sender, EventArgs e)
		{
			string key = (sender as ToolStripButton).Text;
			if (creators.ContainsKey(key))
				currentCreator = creators[key];
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
