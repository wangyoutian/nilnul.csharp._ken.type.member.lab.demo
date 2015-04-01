using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	public abstract class PointA : PointI
	{
		public abstract double x { get;  }
		public abstract double y { get;  }

		public abstract CoordSys CoordSys
		{ get;  }
		

		public abstract event PointChanged changed;

		public double shift() {
			return Shift(this.x,y);
		}

		static public double Shift(double x, double y)
		{
			return Math.Sqrt( x * x + y * y);

			throw new System.NotImplementedException();
		}

		static public double Shift(PointI point)	//this is a static method. Note Shift is different from shift in that one is capitalized.
		{
			return Shift(point.x,point.y);

			throw new System.NotImplementedException();
		}

	}
}