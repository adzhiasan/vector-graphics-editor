using System;
using System.Drawing;

namespace FigureLibrary
{
	public class Ellipse : Figure
	{
		public override void Draw(Graphics graphics)
			=> graphics.DrawEllipse(Pens.Green, X, Y, Width, Height);

		public override Figure Clone()
		{
			Ellipse ellipse = new Ellipse();
			ellipse.Resize(Width, Height);
			ellipse.Move(X, Y);
			return ellipse;
		}
	}
}
