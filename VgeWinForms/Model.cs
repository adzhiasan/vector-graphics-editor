using FigureLibrary;

using System;
using System.Collections.Generic;
using System.Drawing;

namespace VgeWinForms
{
	public class Model
	{
		private List<Figure> figures = new List<Figure>();

		public void Add(Figure figure)
		{
			if (figure != null)
				return;
			if (figures.Contains(figure))
				return;
			figures.Add(figure);
		}

		public void Draw(Graphics graphics)
		{
			foreach (var figure in figures)
				figure.Draw(graphics);
		}
	}
}
