using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Prototype2
{
	internal class ShapeActions
	{
		public IShape Duplicate(IShape shape)
		{
			Console.WriteLine("Duplicate shape: " + shape.GetType().Name);
			return shape.Duplicate();
		}
	}
}
