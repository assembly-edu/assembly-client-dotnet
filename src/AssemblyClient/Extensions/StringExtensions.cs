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

namespace AssemblyClient
{
  public static class StringExtensions
  {
    public static byte[] GetBytes(this string me)
    {
      byte[] bytes = new byte[me.Length * sizeof(char)];
      System.Buffer.BlockCopy(me.ToCharArray(), 0, bytes, 0, bytes.Length);
      return bytes;
    }

    public static string ToProperty(this string me)
    {
      var result = me.Replace("_", " ").TitleCase().Replace(" ", string.Empty);
      return result;
    }

    public static string TitleCase(this string me)
    {
      if (me == null)
      {
        return me;
      }

      string[] words = me.Split(' ');

      for (int i = 0; i < words.Length; i++)
      {
        if (words[i].Length == 0)
        {
          continue;
        }

        char firstChar = char.ToUpper(words[i][0]);
        string rest = string.Empty;
        if (words[i].Length > 1)
        {
          rest = words[i].Substring(1).ToLower();
        }

        words[i] = firstChar + rest;
      }

      return string.Join(" ", words);
    }

    public static string ToSnakeCase(this string str)
    {
        return str == null
            ? null
            : string.Join("_", string.Concat(string.Join("_", str.Split(new char[] {},
                StringSplitOptions.RemoveEmptyEntries))
                .Select(c => char.IsUpper(c)
                    ? $"_{c}".ToLower()
                    : $"{c}"))
                .Split(new[] {'_'}, StringSplitOptions.RemoveEmptyEntries));
    }
  }
}
