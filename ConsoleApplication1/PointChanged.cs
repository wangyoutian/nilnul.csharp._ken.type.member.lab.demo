using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	/// <summary>
	/// if point changed, do some action
	/// </summary>
	public delegate void PointChanged(double oldX, double oldY, double newX, double newY);
}