using System;

namespace FigureLibrary
{
	public class ProtoCreator : Creator
	{
		public Figure Proto { get; set; }
		public override Figure Create() => Proto?.Clone();
	}
}
