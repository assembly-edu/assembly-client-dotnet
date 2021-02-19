/**
 * Assembly Developer API .NET Client
 * SDK Version 2.2.474
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
using System.Reflection;

namespace AssemblyClient
{
  public class ApiException : Exception
  {
    public Uri baseAddress { get; protected set; }
    public string resourceWithQuery { get; protected set; }

    private static string DecoratedMessage(Uri baseAddress, string resourceWithQuery, string message)
    {
      if (string.IsNullOrEmpty(message))
      {
        message = "An unexpected error occurred";
      }

      var uri = new Uri(baseAddress, resourceWithQuery);

      AssemblyName name = Assembly.GetExecutingAssembly().GetName();
      message = $"{message} [{name.Name}, {name.Version}][{uri.AbsoluteUri}]";
      return message;
    }

    public ApiException(Uri baseAddress, string resourceWithQuery, string message) : this(baseAddress, resourceWithQuery, message, null)
    {
    }

    public ApiException(Uri baseAddress, string resourceWithQuery, Exception inner) : this(baseAddress, resourceWithQuery, null, inner)
    {
    }

    public ApiException(Uri baseAddress, string resourceWithQuery, string message, Exception inner) : base(DecoratedMessage(baseAddress, resourceWithQuery, message), inner)
    {
      this.baseAddress = baseAddress;
      this.resourceWithQuery = resourceWithQuery;
    }
  }
}
