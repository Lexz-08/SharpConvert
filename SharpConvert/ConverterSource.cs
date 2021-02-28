using System.ComponentModel;

namespace SharpConvert
{
	public static class Extension
    {
		public static T ConvertTo<T>(this object obj)
		{
			TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
			return (T)converter.ConvertFrom(obj);
		}
	}
}
