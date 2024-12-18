using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Prototype2
{
	internal class Rectangle:IShape
	{
		public int Width { get; set; } = 5;
		public int Height { get; set; } = 10;
		public void Draw()
		{
			Console.WriteLine("I'm drawing a rectangle " + Width + " " + Height);
		}

		public IShape Duplicate()
		{
			Rectangle newRectangle = new Rectangle();
			newRectangle.Width = Width;
			newRectangle.Height = Height;
			return newRectangle;
		}
	}
}
