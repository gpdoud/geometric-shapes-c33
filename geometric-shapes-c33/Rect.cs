using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometric_shapes_c33
{
	class Rect
	{
		public int Side1 { get; set; }
		public int Side2 { get; set; }

		public int Area()
		{
			return Side1 * Side2;
		}
		public int Perimeter()
		{
			return 2 * (Side1 + Side2);
		}
	}
}
