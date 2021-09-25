using System;

namespace FigureLibrary
{
	public class RectangleCreator : Creator
	{
		public override Figure Create()
		{
			Rect rectangle = new();
			rectangle.Resize(100, 120);
			return rectangle;
		}
	}
}
