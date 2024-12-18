using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Prototype2
{
	internal class ShapeActionsBAD
	{
		public void Duplicate(IShapeBAD shape)
		{
			//shape actions depends of all concrete type of shapes
			if(shape is CircleBAD)
			{
				var copiedShape = (CircleBAD)shape;
				var newShape = new CircleBAD();
				newShape.Radius = copiedShape.Radius;
				newShape.Draw();
			}
			else if(shape is RectangleBAD)
			{
				//shape actions need to know how every single shape class is composed
				//is better to move the logic of duplicate inside a proper shape class
				//DECOUPLE the shape actions from their concrete shape
				var copiedShape = (RectangleBAD)shape;
				var newShape = new RectangleBAD();
				newShape.Width = copiedShape.Width;
				newShape.Height = copiedShape.Height;
				newShape.Draw();
			}
			else
			{
				throw new ArgumentException("I need the shape type");
			}
		}
	}
}
