using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

/// <summary>
/// Extensions for String, instances, and so on
/// </summary>
public static class Extensions
{
    public static int? ToNullableInt(this string s)
    {
        int i;
        return int.TryParse(s, out i) ? (int?) i : (int?) null;
    }

    public static string ToXML<T>(this T instance)
    {
        var stringWriter = new System.IO.StringWriter();
        var xmlSerializer = new XmlSerializer(instance.GetType());
        xmlSerializer.Serialize(stringWriter, instance);
        return stringWriter.ToString();
    }
}