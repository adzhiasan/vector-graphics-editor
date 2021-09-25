using System;

namespace FigureLibrary
{
	public class EllipseCreator : Creator
	{
		public override Figure Create()
		{
			Ellipse ellipse = new();
			ellipse.Resize(100, 120);
			return ellipse;
		}
	}
}
