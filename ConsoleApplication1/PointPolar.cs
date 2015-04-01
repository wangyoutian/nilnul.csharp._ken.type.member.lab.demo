using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	public class PointPolar : PointA
	{
		private double _radius;
		private double _angle;

	
		public double radius
		{
			get { return _radius; }
			set {

				var oldX = x;
				var oldY = y;
				_radius = value;

				

				if (changed != null)
				{
					changed(oldX, oldY, x, y);
				}


			}
		}

		public double angle
		{
			get { return _angle; }
			set {

				var oldX = x;
				var oldY = y;
				_angle = value;

				

				if (changed != null)
				{
					changed(oldX, oldY, x, y);
				}


			}
		}


		public override CoordSys CoordSys
		{
			get
			{
				return CoordSys.Polar;
				throw new NotImplementedException();
			}

		
		}

		public override double x
		{
			get
			{
				return _radius * Math.Cos(_angle);

				throw new NotImplementedException();
			}

			
		}



		public override double y
		{
			get
			{
				return _radius * Math.Sin(_angle);
				throw new NotImplementedException();
			}

			
		}

		
		~PointPolar() {
			//release unmanaged resources
		}
		public override event PointChanged changed;
	}
}