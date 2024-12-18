using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Prototype2
{
	internal class Circle:IShape
	{
		public int Radius { get; set; } = 5;
		public void Draw()
		{
			Console.WriteLine("I'm drawing circle with radious " + Radius);
		}

		public IShape Duplicate()
		{
			var newCircle = new Circle();
			newCircle.Radius = Radius;
			return newCircle;
		}
	}
}
