using System;
using System.Drawing;

namespace FigureLibrary
{
	public class Rect : Figure
	{
		public override void Draw(Graphics graphics)
			=> graphics.DrawRectangle(Pens.Black, X, Y, Width, Height);

		public override Figure Clone()
		{
			Rect rectangle =  new();
			rectangle.Resize(X, Y);
			rectangle.Move(Width, Height);
			return rectangle;
		}
	}
}
