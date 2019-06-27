using System;
using System.Collections.Generic;

namespace BlazorKit.Util
{
  [System.AttributeUsage(System.AttributeTargets.Field)]
  public class EnumValueAttribute : System.Attribute
  {
    public string Value { get; set; }
    public EnumValueAttribute(string value)
    {
      this.Value = value;
    }
  }

  public static class EnumExtensions
  {
    public static string GetValue<T>(this T val)
    {
      return val.GetValue<T>(null);
    }

    public static string GetValue<T>(this T val, string prefix)
    {
      EnumValueAttribute[] attributes = (EnumValueAttribute[])val.GetType()
        .GetField(val.ToString()).GetCustomAttributes(typeof(EnumValueAttribute), false);
      return attributes.Length > 0 ? (prefix != null ? prefix : "") + attributes[0].Value : null;
    }
    public static string GetValues<T>(this T val, string separator)
    {
      return val.GetValues<T>(separator, null);
    }

    public static string GetValues<T>(this T val, string separator, string prefix)
    {
      EnumValueAttribute[] attributes = (EnumValueAttribute[])val.GetType()
        .GetField(val.ToString()).GetCustomAttributes(typeof(EnumValueAttribute), false);

      List<string> atts = new List<string>();
      foreach (var a in attributes)
      {
        atts.Add((prefix != null ? prefix : "") + a.Value);
      }
      return string.Join(separator, atts);
    }
  }
}
