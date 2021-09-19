using System;

namespace FigureLibrary.Creators
{
	public class RectangleCreator : Creator
	{
		public override Figure Create()
		{
			Rect rectangle = new Rect();
			rectangle.Resize(100, 120);
			return rectangle;
		}
	}
}
