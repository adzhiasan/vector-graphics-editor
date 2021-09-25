using System;
using System.Collections.Generic;
using System.Windows.Forms;

using FigureLibrary;

namespace VgeWinForms
{
	public partial class Form1 : Form
	{
		Model model = new Model();
		Creator currentCreator = null;
		Dictionary<string, Creator> creators = new Dictionary<string, Creator>();
		Figure selected;
		public Form1()
		{
			InitializeComponent();
			creators["Rectangle"] = new RectangleCreator();
			creators["Ellipse"] = new EllipseCreator();
			creators["Select"] = null;
		}

		private void mainPanel_MouseDown(object sender, MouseEventArgs e)
		{
			Figure figure;
			if (currentCreator != null)
			{
				figure = currentCreator.Create();
				figure.Move(e.X, e.Y);
				model.Add(figure);
			}

			else
			{
				selected = model.Select(e.X, e.Y);
				figureDetectRadioButton.Checked = selected != null;
			}

			Refresh();
		}

		private void ToolStripButton_Click(object sender, EventArgs e)
		{
			string key = (sender as ToolStripButton).Text;
			if (creators.ContainsKey(key))
				currentCreator = creators[key];
		}

		private void ModifyToolStripButton_Click(object sender, EventArgs e)
		{
			if(selected != null)
				selected.Resize(selected.Width / 2, selected.Height * 2);
			Refresh();
		}

		private void AddFigureToBarToolStripButton_Click(object sender, EventArgs e)
		{
			ToolStripButton button = new();
			button.DisplayStyle = ToolStripItemDisplayStyle.Text;
			button.Text = "New Figure";
			toolStrip.Items.Add(button);
			ProtoCreator protoCreator = new() { Proto = selected.Clone() };
			creators["New Figure"] = protoCreator;
			button.Click += ToolStripButton_Click;



		}

		private void mainPanel_Paint(object sender, PaintEventArgs e)
		{
			model.Draw(e.Graphics);
		}
	}
}
