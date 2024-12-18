using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Prototype2
{
	internal interface IShape
	{
		void Draw();
		IShape Duplicate();
	}
}
