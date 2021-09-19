using System;

namespace FigureLibrary.Creators
{
	public class EllipseCreator : Creator
	{
		public override Figure Create()
		{
			Ellipse ellipse = new Ellipse();
			ellipse.Resize(100, 120);
			return ellipse;
		}
	}
}
