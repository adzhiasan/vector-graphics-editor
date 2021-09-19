using System;
using System.Drawing;

namespace FigureLibrary
{
	public abstract class Figure
	{
		private float x;
		private float y;
		private float width;
		private float height;

		public float X { get => x; }
		public float Y { get => y; }
		public float Width { get => width; }
		public float Height { get => height; }

		public virtual void Move(float targetX, float targetY)
		{
			if (targetX >= 0 || targetY >= 0)
			{
				x = targetX;
				y = targetY;
			}
			else
				throw new Exception("Сoordinates are less than zero!");
		}

		public virtual void Resize(float targetWidth, float targetHeight)
		{
			if (targetWidth > 0 || targetHeight > 0) 
			{
				width = targetWidth;
				width = targetHeight;
			}
			else
				throw new Exception("Dimensions are less than zero!");
		}

		public abstract void Draw(Graphics graphics);

		public virtual bool Touch(float dx, float dy)
			=> dx >= x && dy >= y && dx <= x + width && dy <= y + height;

		public virtual Figure Clone()
		{
			return null;
		}
	}
}
