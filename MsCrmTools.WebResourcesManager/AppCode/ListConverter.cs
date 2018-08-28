using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;

namespace MscrmTools.WebresourcesManager.AppCode
{
    public class ListConverter: TypeConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType) {
            if (destinationType != typeof(string))
            {
                return base.ConvertTo(context, culture, value, destinationType);
            }

            var col = (ICollection) value;
            var count = col.Count;
            string text;
            switch (count)
            {
                case 0:
                    text = "(None)";
                    break;
                case 1:
                    var first = ((IEnumerable) value).Cast<object>().First().ToString();
                    text = first.Length > 20
                        ? $"({first.Substring(0, Math.Min(first.Length, 15))}...)"
                        : $"({first})";
                    break;
                default:
                    text = "Count: " + count;
                    break;
            }

            return text;
        }
    }
}
