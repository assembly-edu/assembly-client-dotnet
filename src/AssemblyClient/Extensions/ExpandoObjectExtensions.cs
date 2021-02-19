/**
 * Assembly Developer API .NET Client
 * SDK Version 2.2.471
 * API Version 1.1.0
 *
 * Support
 * Email: help@assembly.education
 * URL:   http://developers.assembly.education
 *
 * Terms of Service: http://assembly.education/terms/
 * License:          MIT, https://spdx.org/licenses/MIT.html
 */


using System;
using System.Linq;
using System.Dynamic;
using System.Collections.Generic;

namespace AssemblyClient
{
  public static class ExpandoObjectExtensions
  {
    public static string ToParams(this ExpandoObject me)
    {
      var x = (IDictionary<string, object>)me;
      var valueArgs = x.Where(v => v.Value != null);
      var args = valueArgs.Select(AsQueryParam).ToArray();
      var result = string.Join("&", args);
      return result;
    }

    private static string AsQueryParam(KeyValuePair<string, object> kvp)
    {
      if (kvp.Value is bool?)
      {
        var boolValue = kvp.Value as bool?;
        return boolValue.HasValue && boolValue.Value ? $"{kvp.Key.ToSnakeCase()}=1" : $"{kvp.Key}=0";
      }
      else if (kvp.Value is List<int?>)
      {
        var ids = string.Join("+", ((List<int?>) kvp.Value).Where(x => x != null).Select(i => i.ToString()).ToArray());
        return $"{kvp.Key}={ids}";
      }
      else if (kvp.Value is List<int>)
      {
        var ids = string.Join("+", ((List<int>) kvp.Value).Select(i => i.ToString()).ToArray());
        return $"{kvp.Key}={ids}";
      }
      else if (kvp.Value is DateTime)
      {
        var dateValue = (DateTime)kvp.Value;
        return $"{kvp.Key}={dateValue.ToString("yyyy-MM-dd")}";
      }
      else if (kvp.Value is DateTime?)
      {
        var dateValue = kvp.Value as DateTime?;
        return dateValue.HasValue ? $"{kvp.Key.ToSnakeCase()}={dateValue.Value.ToString("yyyy-MM-dd")}" : string.Empty;
      }

      var stringValue = kvp.Value.ToString().Trim();
      return !string.IsNullOrEmpty(stringValue) ? $"{kvp.Key.ToSnakeCase()}={stringValue}" : string.Empty;
    }

    public static object V(this ExpandoObject me, string propertyName)
    {
      return ((IDictionary<string, object>)me)[propertyName];
    }

    public static T V<T>(this ExpandoObject me, string propertyName)
    {
      return (T)((IDictionary<string, object>)me)[propertyName];
    }

    public static bool HasKey(this ExpandoObject me, string propertyName)
    {
      return ((IDictionary<string, object>)me).ContainsKey(propertyName);
    }
  }
}
