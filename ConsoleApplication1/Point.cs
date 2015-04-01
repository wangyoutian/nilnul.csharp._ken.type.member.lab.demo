using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	public struct Point : PointI	//note: struct can only inherit ValueType, so it can not inherit PointA
	{
		private double _x;
		private double _y;

		public event PointChanged changed;

		public double x
		{
			get
			{
				return _x;
				throw new System.NotImplementedException();
			}

			set
			{
				var oldX = x;
				var oldY = y;
				_x = value;

				if (changed != null)
				{
					changed(oldX, oldY, x, y);
				}

			}
		}

		public double y
		{
			get
			{
				throw new System.NotImplementedException();
			}

			set
			{
				var oldX = x;
				var oldY = y;
				_x = value;

				if (changed != null)
				{
					changed(oldX, oldY, x, y);
				}
			}
		}

		public CoordSys CoordSys
		{
			get
			{
				return CoordSys.Straight;
			}

			
		}

		public double shift()
		{
			return PointA.Shift(this);
			throw new NotImplementedException();
		}

		public Point()
			: this(0, 0)
		{


		}
		public Point(double x, double y)
		{
			_x = x;
			_y = y;
			changed = null;

		}


	}
}