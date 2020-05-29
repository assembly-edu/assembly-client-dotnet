/**
 * Assembly Developer API .NET Client
 * SDK Version 2.2.464
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
using System.Net;

namespace AssemblyClient
{
  public class HttpResponseDetailedException : Exception
  {
    public HttpStatusCode StatusCode { get; private set; }

    public HttpResponseDetailedException(HttpStatusCode statusCode, string content)
      : base(content)
    {
      StatusCode = statusCode;
    }
  }
}
