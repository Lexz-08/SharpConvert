using System.ComponentModel;
using System.Drawing;

namespace SharpConvert
{
	public static class Extension
    {
		public static T ConvertTo<T>(this object obj)
		{
			TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
			return (T)converter.ConvertFrom(obj);
		}
		public static T FromString<T>(this T obj, string str)
		{
			TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
			return (T)converter.ConvertFromString(str);
		}
	}

	public class Converter
	{
		public static Size PointToSize(Point pt)
		{
			return new Size(pt.X, pt.Y);
		}
		public static Point SizeToPoint(Size sz)
		{
			return new Point(sz.Width, sz.Height);
		}

		public static SizeF PointFToSizeF(PointF pt)
		{
			return new SizeF(pt.X, pt.Y);
		}
		public static PointF SizeFToPointF(SizeF sz)
		{
			return new PointF(sz.Width, sz.Height);
		}

		public static SizeF PointToSizeF(Point pt)
		{
			return new SizeF(pt.X, pt.Y);
		}
		public static PointF SizeToPointF(Size sz)
		{
			return new PointF(sz.Width, sz.Height);
		}

		public static T EnumFromString<T>(T enumeration, string str)
		{
			TypeConverter enumConverter = TypeDescriptor.GetConverter(typeof(T));
			return (T)enumConverter.ConvertFromString(str);
		}
	}
}
