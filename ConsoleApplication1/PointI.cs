using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	public interface PointI
	{
		event PointChanged changed;

		double x { get; }
		double y { get; }
		CoordSys CoordSys { get; }

		double shift();
	}
}